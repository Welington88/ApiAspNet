using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using apiVendas.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace apiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public TokenController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        // POST: api/Token
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken([FromBody] User request)
        {
            if (request.Nome == "root" && request.Senha == "1234")
            {
                //regras de claim
                var claims = new[] {
                    new Claim(ClaimTypes.Name, request.Nome)
                };

                //armazena a chave de token
                var key = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_configuration["SecurityKey"])
                    );

                //gera o token
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                        issuer: "api.vendas",
                        audience: "api.vendas",
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(5),
                        signingCredentials: creds
                    );
                return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token)
                    });
            }
            return BadRequest("Credenciais Inválidas....");
        }
    }
}
