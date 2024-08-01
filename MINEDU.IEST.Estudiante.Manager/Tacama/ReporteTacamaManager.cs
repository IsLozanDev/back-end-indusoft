using AutoMapper;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Http;
using MINEDU.IEST.Estudiante.Inf_Utils.Dtos;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers;
using System.IO;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public class ReporteTacamaManager : IReporteTacamaManager
    {
        private readonly IMapper _mapper;
        private readonly TacamaUnitOfWork _tacamaUnitOfWork;
        private readonly ResourceDto _resourceDto;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ReporteTacamaManager(IMapper mapper,
            TacamaUnitOfWork tacamaUnitOfWork,
            ResourceDto resourceDto,
            IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _tacamaUnitOfWork = tacamaUnitOfWork;
            _resourceDto = resourceDto;
            _httpContextAccessor = httpContextAccessor;
        }

        //public async Task<GetPdfDto> GetConstanciaAsync(int idEmpresa, int idLocal, int idPedido)
        public async Task<GetPdfDto> GetConstanciaAsync(int idEmpresa, int idLocal, int idPedido)
        {
            var userName = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "UserName")?.Value;

            var model = await _tacamaUnitOfWork._pedidoTacamaRepository.GetSpPedidoCabNacional(idEmpresa, idLocal, idPedido);
            model.detalle = await _tacamaUnitOfWork._pedidoTacamaRepository.GetSpPedidoNacionalDet(idEmpresa, idLocal, idPedido);
            model.cuentas = await _tacamaUnitOfWork._pedidoTacamaRepository.GetSpListarCuentasParaDoc(idEmpresa);

            PdfFont fontSubTitle = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            PdfFont fontTitle = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            PdfFont fontHeaderTable = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            PdfFont fontTable = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            PdfFont fontTexto = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            PdfFont fontMR = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            PdfFont fontFirma = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            float setHeight = 13f;
            float setFontSize = 7f;
            float setMinHeight = 6f;

            PdfWriter writer = null;

            var cellColor = new DeviceRgb(224, 224, 224);


            MemoryStream baos = new MemoryStream();

            using (writer = new PdfWriter(baos))
            {
                PdfDocument pdf = new PdfDocument(writer);
                Document doc = new Document(pdf, PageSize.A4, false);

                #region LOGO

                var fileLogo = System.IO.Path.Combine(_resourceDto.Documents, "logo-cotizacion.jpg");

                iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(fileLogo));
                image.GetXObject().GetPdfObject().SetCompressionLevel(CompressionConstants.BEST_COMPRESSION);
                //image.ScaleAbsolute(200, 40);
                image.ScaleToFit(300, 70);
                image.SetFixedPosition(0, 780);

                //float offsetX = (200 - image.GetImageScaledWidth());
                //float offsetY = (523 - image.GetImageScaledHeight());
                //image.SetFixedPosition(9 + offsetX, 60 + offsetY);

                doc.Add(image);
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));

                #endregion


                #region Titulo de Pagina

                Table tableTitle = new Table(UnitValue.CreatePercentArray(new float[] { 9, 2 })).UseAllAvailableWidth().SetVerticalBorderSpacing(0).SetHorizontalBorderSpacing(0);

                tableTitle.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBold().SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE)
                    .Add(GetParagraph("COTIZACION").SetCharacterSpacing(2.5f).SetFont(fontTable).SetFontSize(setFontSize + 5)));


                tableTitle.AddCell(new Cell().SetBold().SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE)
                    .Add(GetParagraph($"N°{model.CodPedidoCad}").SetFont(fontTable).SetFontSize(setFontSize + 2)));


                doc.Add(tableTitle);

                doc.Add(new Paragraph(" "));

                #endregion


                #region Data

                Table tableBienesServicios = new Table(UnitValue.CreatePercentArray(new float[] { 2, 7, 3 })).UseAllAvailableWidth().SetVerticalBorderSpacing(3).SetHorizontalBorderSpacing(3);

                tableBienesServicios.AddCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).Add(GetParagraph("Razon Social").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableBienesServicios.AddCell(new Cell(1, 2).Add(GetParagraph(model.DesFacturar)).SetFont(fontTable).SetFontSize(setFontSize - 1));
                tableBienesServicios.AddCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).Add(GetParagraph("Atencion").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableBienesServicios.AddCell(new Cell().Add(GetParagraph("")).SetFont(fontTable).SetFontSize(setFontSize - 1));
                tableBienesServicios.AddCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).Add(GetParagraph($"Ruc: {model.RucCliente}").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableBienesServicios.AddCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).Add(GetParagraph("Direccion").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableBienesServicios.AddCell(new Cell(1, 2).Add(GetParagraph(model.DireccionCompleta)).SetFont(fontTable).SetFontSize(setFontSize - 1));
                tableBienesServicios.AddCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).Add(GetParagraph("Moneda").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableBienesServicios.AddCell(new Cell().Add(GetParagraph($"{(model.IdMoneda == "01" ? "Soles (S/.)" : "Dólares Americanos (US$)")}")).SetFont(fontTable).SetFontSize(setFontSize - 1));
                tableBienesServicios.AddCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).Add(GetParagraph($"Fecha: {model.Fecha.ToLongDateString()}").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                doc.Add(tableBienesServicios);

                #endregion

                #region condiciones

                Table tableCondiciones = new Table(UnitValue.CreatePercentArray(new float[] { 12 })).UseAllAvailableWidth().SetVerticalBorderSpacing(3).SetHorizontalBorderSpacing(3);

                var stringCondiciones = $"Condiciones: \r\t\t\t\t" +
                    $"Validez de la Cotizacion {model.DiasValidez} dias. \r\t\t\t\t" +
                    $"Pago {model.DesCondicion} \r\t\t\t\t" +
                    $"Direccion de entrega {model.PuntoLlegada} \r\t\t\t\t" +
                    $"Puestro en nuestro almacen \r\t\t\t\t" +
                    $"DESPACHO: Local: Sin costo a distritos aledaños anuestra oficina principal. \r\t\t\t\t" +
                    $"Provincia: Flete pago en destino. La mercaderia viaja por cuenta y riesgo del cliente. \r\t\t\t\t" +
                    $"{model.Observacion}";

                tableCondiciones.AddCell(new Cell().SetHorizontalAlignment(HorizontalAlignment.LEFT).Add(GetParagraph(stringCondiciones.ToString())).SetFont(fontTable).SetFontSize(setFontSize - 1));

                doc.Add(tableCondiciones);

                #endregion

                #region Detalles

                Table tableDetails = new Table(UnitValue.CreatePercentArray(new float[] { 0.5f, 1, 4, 0.5f, 0.2f, 1, 1, 1, 1.5f })).UseAllAvailableWidth().SetVerticalBorderSpacing(3).SetHorizontalBorderSpacing(3);

                tableDetails.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Item").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Cod Articulo").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Descripcion").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Cant.").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("UM").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Valor Venta").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Precio Venta").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Total Precio Venta").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Imagen").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));

                foreach (var item in model.detalle)
                {
                    tableDetails.AddCell(new Cell().Add(GetParagraph(item.IdItem.ToString("00")).SetTextAlignment(TextAlignment.CENTER).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableDetails.AddCell(new Cell().Add(GetParagraph(item.CodArticulo).SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                    var descripcionArticulo = string.Empty;

                    if (item.IndArticuloNuevo == "0")
                    {
                        if (item.IndCalculo == "0")
                        {
                            descripcionArticulo = item.DesArticuloCompuesto;
                        }
                        else
                        {
                            descripcionArticulo = item.DesArticuloCompuesto + " (BONIFICACION)";
                        }
                    }
                    else
                    {
                        descripcionArticulo = item.NomArticulo;
                    }

                    tableDetails.AddCell(new Cell().Add(GetParagraph(descripcionArticulo).SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableDetails.AddCell(new Cell().Add(GetParagraph(item.Cantidad.ToString("N0")).SetTextAlignment(TextAlignment.CENTER).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableDetails.AddCell(new Cell().Add(GetParagraph(item.DesUniPrese).SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableDetails.AddCell(new Cell().Add(GetParagraph(item.PrecioUnitario.ToString("N2")).SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableDetails.AddCell(new Cell().Add(GetParagraph(item.PrecioConImpuesto.ToString("N2")).SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableDetails.AddCell(new Cell().Add(GetParagraph(item.Total.ToString("N2")).SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableDetails.AddCell(new Cell().Add(GetParagraph("").SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                }

                doc.Add(tableDetails);

                //Totales
                tableDetails = new Table(UnitValue.CreatePercentArray(new float[] { 0.5f, 1, 4, 0.5f, 0.2f, 1, 1, 1, 1.5f })).UseAllAvailableWidth().SetVerticalBorderSpacing(3).SetHorizontalBorderSpacing(3);

                tableDetails.AddCell(new Cell(1, 6).Add(GetParagraph($"Son: {(NumeroLetras.enLetras(model.TotTotal.ToString()))}").SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddCell(new Cell().Add(GetParagraph("Sub Total").SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                tableDetails.AddCell(new Cell().Add(GetParagraph(model.TotTotal.ToString("N2")).SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                doc.Add(tableDetails);


                tableDetails = new Table(UnitValue.CreatePercentArray(new float[] { 0.5f, 1, 4, 0.5f, 0.2f, 1, 1, 1, 1.5f })).UseAllAvailableWidth().SetVerticalBorderSpacing(3).SetHorizontalBorderSpacing(3);

                tableDetails.AddCell(new Cell(1, 3).SetBorderLeft(Border.NO_BORDER).SetBorderBottom(Border.NO_BORDER)
                    .Add(GetParagraph().SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                tableDetails.AddCell(new Cell(1, 3).Add(GetParagraph("I.S.C").SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                decimal Isc = decimal.Round((from x in model.detalle where x.IndCalculo == "1" select x.Isc).Sum(), 2);

                tableDetails.AddCell(new Cell(1, 2).Add(GetParagraph(Isc.ToString("N2")).SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                tableDetails.AddCell(new Cell().SetBorderRight(Border.NO_BORDER).SetBorderBottom(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER)
                    .Add(GetParagraph("").SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                //
                tableDetails.AddCell(new Cell(1, 3).SetBorderLeft(Border.NO_BORDER).SetBorderBottom(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER)
                   .Add(GetParagraph().SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                tableDetails.AddCell(new Cell(1, 3).Add(GetParagraph($"I.G.V. 18%").SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));


                tableDetails.AddCell(new Cell(1, 2).Add(GetParagraph(model.TotIgv.ToString("N2")).SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                tableDetails.AddCell(new Cell().SetBorderRight(Border.NO_BORDER).SetBorderBottom(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER)
                    .Add(GetParagraph("").SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));


                //

                tableDetails.AddCell(new Cell(1, 3).SetBorderLeft(Border.NO_BORDER).SetBorderBottom(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER)
                   .Add(GetParagraph().SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                tableDetails.AddCell(new Cell(1, 3).Add(GetParagraph("Total").SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));


                tableDetails.AddCell(new Cell(1, 2).Add(GetParagraph(model.TotTotal.ToString("N2")).SetTextAlignment(TextAlignment.RIGHT).SetFont(fontTable).SetFontSize(setFontSize - 1)));

                tableDetails.AddCell(new Cell().SetBorderRight(Border.NO_BORDER).SetBorderBottom(Border.NO_BORDER).SetBorderTop(Border.NO_BORDER)
                    .Add(GetParagraph("").SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));


                doc.Add(tableDetails);

                #endregion


                #region Cuentas Bancarias

                // TODO: Agregar variables de configuración para empresa - TACAMA
                doc.Add(new Paragraph(" "));

                Paragraph paragraph1 = new Paragraph();
                paragraph1.Add("Remitir Orden de Compra/Servicio a nombre de VIÑA TACAMA S.A,  vía correo electrónico a: facturacion@tacama.com\r")
                    .Add("Hacer depósito bancario a nombre de: VIÑA TACAMA S.A. según:")
                    .SetFont(fontHeaderTable).SetFontSize(setFontSize - 1);


                doc.Add(paragraph1);

                doc.Add(new Paragraph(" "));

                Table tableCuentas = new Table(UnitValue.CreatePercentArray(new float[] { 3, 2, 2, 2 })).UseAllAvailableWidth().SetVerticalBorderSpacing(3).SetHorizontalBorderSpacing(3);

                tableCuentas.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Banco").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableCuentas.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Tipo de Cuenta").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableCuentas.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("N° de Cuenta").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));
                tableCuentas.AddHeaderCell(new Cell().SetBackgroundColor(cellColor).SetMinHeight(setMinHeight).SetTextAlignment(TextAlignment.CENTER).Add(GetParagraph("Código de Cta.Interbancaria").SetFont(fontHeaderTable).SetFontSize(setFontSize - 1)));

                foreach (var item in model.cuentas)
                {
                    tableCuentas.AddCell(new Cell().Add(GetParagraph(item.RazonSocial).SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableCuentas.AddCell(new Cell().Add(GetParagraph(item.DesTipCuenta).SetTextAlignment(TextAlignment.LEFT).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableCuentas.AddCell(new Cell().Add(GetParagraph(item.NumCuenta).SetTextAlignment(TextAlignment.CENTER).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                    tableCuentas.AddCell(new Cell().Add(GetParagraph(item.NumCuentaInter).SetTextAlignment(TextAlignment.CENTER).SetFont(fontTable).SetFontSize(setFontSize - 1)));
                }

                doc.Add(tableCuentas);

                doc.Add(new Paragraph(" "));


                paragraph1 = new Paragraph();
                paragraph1.Add("Posteriormente enviar voucher de depósito correspondiente a gvarela@tacama.com, haciendo referencia al N° de Orden Compra/Servicio.")
                    .SetFont(fontHeaderTable).SetFontSize(setFontSize - 1);
                doc.Add(paragraph1);

                paragraph1 = new Paragraph();
                paragraph1.Add("Sin otro particular quedamos de ustedes a la espera de sus gratas órdenes.")
                    .SetFont(fontHeaderTable).SetFontSize(setFontSize - 1);

                doc.Add(paragraph1);



                doc.Add(new Paragraph(" "));

                #endregion


                #region Firmas

                Table tableFirmas = new Table(UnitValue.CreatePercentArray(new float[] { 3 })).UseAllAvailableWidth().SetVerticalBorderSpacing(0).SetHorizontalBorderSpacing(0);

                tableFirmas.AddCell(new Cell().SetBorder(Border.NO_BORDER)
                    .SetBold().SetTextAlignment(TextAlignment.LEFT)
                    .Add(GetParagraph(userName.ToString()).SetFont(fontTable).SetFontSize(setFontSize + 2))
                    .Add(GetParagraph("VIÑA TACAMA S.A.").SetFontSize(setFontSize + 1))
                    .Add(GetParagraph("Ejecutivo Comercial").SetFontSize(setFontSize)));

                doc.Add(tableFirmas);

                #endregion



                #region Numeración de Página

                int numberOfPages = pdf.GetNumberOfPages();
                for (int i = 1; i <= numberOfPages; i++)
                {
                    doc.ShowTextAligned(new Paragraph($"Pag: {i} / {numberOfPages}"),
                        pdf.GetDefaultPageSize().GetWidth() - 20, pdf.GetDefaultPageSize().GetHeight() - 17, i, TextAlignment.RIGHT, VerticalAlignment.TOP, 0).SetFontSize(setFontSize - 2);

                    doc.ShowTextAligned(new Paragraph($"Fecha y Hora: {DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}"),
                       pdf.GetDefaultPageSize().GetWidth() - 55, pdf.GetDefaultPageSize().GetHeight() - 33, i, TextAlignment.RIGHT, VerticalAlignment.TOP, 0).SetFontSize(setFontSize - 2);


                    doc.ShowTextAligned(new Paragraph("NRO. S/N CAMINO REAL").SetTextAlignment(TextAlignment.RIGHT),
                       pdf.GetDefaultPageSize().GetWidth() - 45, pdf.GetDefaultPageSize().GetHeight() - 43, i, TextAlignment.RIGHT, VerticalAlignment.TOP, 0).SetFontSize(setFontSize - 1);

                    doc.ShowTextAligned(new Paragraph("00511-2183017").SetTextAlignment(TextAlignment.RIGHT),
                       pdf.GetDefaultPageSize().GetWidth() - 40, pdf.GetDefaultPageSize().GetHeight() - 53, i, TextAlignment.RIGHT, VerticalAlignment.TOP, 0).SetFontSize(setFontSize - 1);

                    doc.ShowTextAligned(new Paragraph("Correo-e: facturacion@tacama.com").SetTextAlignment(TextAlignment.RIGHT),
                       pdf.GetDefaultPageSize().GetWidth() - 40, pdf.GetDefaultPageSize().GetHeight() - 63, i, TextAlignment.RIGHT, VerticalAlignment.TOP, 0).SetFontSize(setFontSize - 1);

                    doc.ShowTextAligned(new Paragraph("RUC: 20216789611").SetTextAlignment(TextAlignment.RIGHT),
                       pdf.GetDefaultPageSize().GetWidth() - 40, pdf.GetDefaultPageSize().GetHeight() - 73, i, TextAlignment.RIGHT, VerticalAlignment.TOP, 0).SetFontSize(setFontSize - 1);

                }

                #endregion

                /*
                *   var pdf64 = Convert.ToBase64String(baos.ToArray());
                    var fileName = $"Cotizacion_{Guid.NewGuid().ToString()}.pdf";
                    var pathFileName = System.IO.Path.Combine(_resourceDto.storage, fileName);

                    _storageManager.SaveFile(pathFileName, pdf64, "application/pdf");
                 */

                // Ceramos el documento
                doc.Close();

            }


            var pdf64 = Convert.ToBase64String(baos.ToArray());
            GetPdfDto data = new GetPdfDto
            {
                base64 = pdf64
            };
            return data;




        }

        private Paragraph GetParagraph(string value = "")
        {
            return new Paragraph(value);
        }
    }
}
