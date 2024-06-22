using IDCL.AVGUST.SIP.PedidoApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MINEDU.IEST.Estudiante.Inf_Utils.Constants;
using MINEDU.IEST.Estudiante.Inf_Utils.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IDCL.AVGUST.SIP.PedidoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ConfigJwt _config;
        public AuthController(ConfigJwt config) => this._config = config;

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel user)
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
                return Ok(new AuthenticatedResponse { Token = tokenString });
            }
            return Unauthorized();
        }
    }
}
