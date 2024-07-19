using IDCL.AVGUST.SIP.Manager.Tacama;
using IDLC.Tacama.Core.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MINEDU.IEST.Estudiante.Inf_Utils.Constants;
using MINEDU.IEST.Estudiante.Inf_Utils.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IDLC.Tacama.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ILogger<SecurityController> _logger;
        private readonly ITacamaManager _tacamaManager;
        private readonly ConfigJwt _config;

        public SecurityController(ILogger<SecurityController> logger, ITacamaManager tacamaManager, ConfigJwt config)
        {
            _logger = logger;
            _tacamaManager = tacamaManager;
            _config = config;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> login([FromBody] LoginModel user)
        {

            if (user is null)
            {
                return BadRequest("Solicitud del cliente invalido.");
            }
            if (user.UserName == _config.UserName && user.Password == _config.Password)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.Secret));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5281",
                    audience: "http://localhost:5281",
                    claims: new List<Claim> {
                        new Claim(SecurityClaimType.PersonId ,user.UserName)
                    },
                    expires: DateTime.Now.AddMinutes(60),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }
            return Unauthorized();

            //var resp = new response();

            //try
            //{
            //    var response = await _tacamaManager.login(usuario, clave);
            //    if (response.EsError)
            //    {
            //        resp.status = "Error";
            //        resp.message = "Validaciones";

            //        ModelState.AddModelError("validacion", response.MensajeError);
            //        resp.data = ExtensionTools.Validaciones(ModelState);
            //        return UnprocessableEntity(resp);
            //    }
            //    resp.status = "OK";
            //    resp.message = "OK";
            //    resp.data = response;
            //    return Ok(resp);
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError("validacion", ex.Message);
            //    UnprocessableEntity(ExtensionTools.Validaciones(ModelState));
            //    _logger.LogError(ex.Message, ex);
            //    throw;
            //}
        }
    }
}
