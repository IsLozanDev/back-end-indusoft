using IDCL.AVGUST.SIP.Contexto.IDCL.AVGUST.SIP.Entity.Avgust;
using IDCL.AVGUST.SIP.Manager.Tacama;
using IDCL.AVGUST.SIP.ManagerDto.Tacama;
using IDCL.Tacama.Core.Entity;
using IDLC.Tacama.Core.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MINEDU.IEST.Estudiante.Inf_Utils.Constants;
using MINEDU.IEST.Estudiante.Inf_Utils.Dtos;
using Org.BouncyCastle.Bcpg.Sig;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
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
            var response = await _tacamaManager.login(user.UserName, user.Password);

            if (response == null)
            {
                return NotFound(new { codigo = HttpStatusCode.NotFound, message = "Usuario y/o clave incorrecto." });
            }
            else
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.Secret));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5281",
                    audience: "http://localhost:5281",
                    claims: new List<Claim> {
                        new Claim(SecurityClaimType.PersonId ,user.UserName),
                        new Claim(SecurityClaimType.IdUsuario, response.IdPersona.ToString())
                    },
                    expires: DateTime.Now.AddMinutes(60),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                response.token = tokenString;
                return Ok(response);
            }
        }

        [HttpPost("loginExt")]
        [AllowAnonymous]
        public async Task<IActionResult> loginExt([FromBody] LoginModel user)
        {
            var response = new GetUsuarioTacamaDto();

            if (user is null)
            {
                return BadRequest(new { codigo = HttpStatusCode.BadRequest, message = "Solicitud del cliente invalido." });
            }

            if (user.UserName != _config.UserName || user.Password != _config.Password)
            {
                return NotFound(new { codigo = HttpStatusCode.NotFound, message = "Usuario y/o clave no existe" });
            }

            var query = await _tacamaManager.loginExt(user.Email);

            if (query <= 0)
            {
                return NotFound(new { codigo = HttpStatusCode.NotFound, message = "Email no valido." });
            }
            else
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.Secret));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5281",
                    audience: "http://localhost:5281",
                    claims: new List<Claim> {
                        new Claim(SecurityClaimType.PersonId ,user.UserName)
                    },
                    expires: DateTime.Now.AddHours(4),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                return Ok(new { token = tokenString, idUsuario = query });
            }
        }

    }
}
