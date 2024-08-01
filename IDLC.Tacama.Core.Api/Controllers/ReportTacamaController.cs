using IDCL.AVGUST.SIP.Manager.Tacama;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportTacamaController : ControllerBase
    {
        private readonly ILogger<ReportTacamaController> _logger;
        private readonly IReporteTacamaManager _reporteTacamaManager;

        public ReportTacamaController(ILogger<ReportTacamaController> logger, IReporteTacamaManager reporteTacamaManager)
        {
            _logger = logger;
            _reporteTacamaManager = reporteTacamaManager;
        }

        
        [HttpGet("GetConstanciaPdf/{idPedido}"), DisableRequestSizeLimit]
        public async Task<IActionResult> GetProductosFormuladosPdfAsync(int idPedido)
        {
            var idEmpresa = 10;
            var idLocal = 1;
            var query = await _reporteTacamaManager.GetConstanciaAsync(idEmpresa, idLocal, idPedido);

            //var toArray = query.base64;

            //var bytes = Convert.FromBase64String(toArray);

            //return File(bytes, "application/pdf", "GetProductosFormuladosPdfAsync.pdf");
            
            return Ok(query);

            //FileContentResult file = new FileContentResult(stream.ToArray(), "application/vnd")
            //{
            //    FileDownloadName = Path.GetFileName("yourfilename.pdf")
            //};

            //return file;

            //var stream = new MemoryStream(query);
            //stream.Position = 0;

            //return File(query, "application/pdf", "GetProductosFormuladosPdfAsync.pdf");

            //var fileStreamResult = new FileStreamResult(stream, "application/pdf");
            //return fileStreamResult;
        }
    }
}
