using IDCL.AVGUST.SIP.ManagerDto.Tacama.Articulo;
using System.ComponentModel.DataAnnotations.Schema;

namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Pedido
{
    public class GetPedidoDetalleTacamaDto
    {
        public int IdPedido { get; set; }
        public int IdEmpresa { get; set; }
        public int IdLocal { get; set; }
        public int IdItem { get; set; }
        public bool? IndArticuloNuevo { get; set; }
        public int IdArticulo { get; set; }
        public string? CodArticulo { get; set; }
        public string AlmacenText { get; set; }

        public string? NomArticulo { get; set; }
        public int? IdCalibre { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdTipoPrecio { get; set; }
        public bool? IndSinStock { get; set; }
        public decimal Cantidad { get; set; }
        public int? CantidadUnit { get; set; }
        public decimal? CantidadFinal { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? PrecioConImpuesto { get; set; }
        public decimal? Dscto1 { get; set; }
        public decimal? Dscto2 { get; set; }
        public decimal? Dscto3 { get; set; }
        public decimal? PorDscto1 { get; set; }
        public decimal? PorDscto2 { get; set; }
        public decimal? PorDscto3 { get; set; }
        public bool? FlgIgv { get; set; }
        public decimal? Isc { get; set; }
        public decimal? Igv { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Total { get; set; }
        public decimal? PorIsc { get; set; }
        public decimal? PorIgv { get; set; }
        public bool? FlgAfectacionIgv { get; set; }
        public string? TipoAfectacionIgv { get; set; }
        public int? IdPresentacion { get; set; }
        public int? IdMarca { get; set; }
        public int? IdTipoMedida { get; set; }
        public int? IdUmedida { get; set; }
        public int? IdTipoArticulo { get; set; }
        public int? IdAlmacen { get; set; }
        public decimal? Stock { get; set; }
        public string? Lote { get; set; }
        public string? NroOt { get; set; }
        public bool? IndCalculo { get; set; }
        public string? TipoImpSelectivo { get; set; }
        public decimal? Capacidad { get; set; }
        public decimal? Contenido { get; set; }
        public bool? IndDetraccion { get; set; }
        public string? TipDetraccion { get; set; }
        public decimal? TasaDetraccion { get; set; }
        public bool? IndPrecioUnit { get; set; }
        public decimal? PrecioUnitIni { get; set; }
        public string? TipArticulo { get; set; }
        public bool? IndDistribuirLote { get; set; }
        public bool IndRptaStock { get; set; }
        public bool? IndNoAtender { get; set; }
        public string? ObsNoAtender { get; set; }
        public decimal? CantidadNoAtendida { get; set; }
        public decimal? CantidadAtender { get; set; }
        public int? ItemPrecio { get; set; }
        public bool? VerImagen { get; set; }
        public bool? ChkPromo { get; set; }
        public bool? IndPrecioPromocional { get; set; }
        public decimal? PrecioUnitPromocional { get; set; }
        public bool? IndUmedida { get; set; }
        public decimal? ContenidoUmedida { get; set; }
        public decimal? CantidadUmedida { get; set; }
        public bool IndPack { get; set; }
        public int? IdArticuloPack { get; set; }
        public int? CantidadPack { get; set; }
        public GetArticuloTacamaDto IdArticuloNavegation { get; set; } = null!;
        public GetArticuloServicioPresentacionDto? IdPresentacionNavigation { get; set; }

    }
}
