using AutoMapper;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;
using Microsoft.AspNetCore.Http;
using MimeKit;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers.EmailSender;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers.FileManager;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public class EmailTacamaManager : IEmailTacamaManager
    {
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        private readonly IReporteTacamaManager _reporteTacamaManager;
        private readonly TacamaUnitOfWork _tacamaUnitOfWork;
        private readonly IStorageManager _storageManager;

        public EmailTacamaManager(IMapper mapper, IEmailSender emailSender, IReporteTacamaManager reporteTacamaManager,
            TacamaUnitOfWork tacamaUnitOfWork,
            IStorageManager storageManager)
        {
            _mapper = mapper;
            this._emailSender = emailSender;
            _reporteTacamaManager = reporteTacamaManager;
            this._tacamaUnitOfWork = tacamaUnitOfWork;
            this._storageManager = storageManager;
        }

        // ... other using directives

        public async Task<bool> SendEmailAsync(int idPedido)
        {
            try
            {
                var cotizacion = await _reporteTacamaManager.GetConstanciaAsync(10, 1, idPedido);

                var pedido = await _tacamaUnitOfWork._pedidoTacamaRepository.GetPedidoForEmailAsync(idPedido);

                var attachment = new List<Attachment> {
                    new()
                        {
                            FileName = "Cotizacion.pdf",
                            Content = _storageManager.GetArrayFromBase64(cotizacion.base64),
                            ContentType = "application/pdf"
                        }
                };

                var message = new Message(new string[] { "camoens1@outlook.com" }
                                , $"Cotizacion TACAMA S.A. Nro {pedido[0]} {pedido[1]}"
                                , new string[]
                                {
                                        pedido[0],
                                        pedido[1]
                                }
                                , attachment); // Fix: Pass the FormFileCollection instead of a single FormFile


                await _emailSender.SendEmailAsync(message);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
