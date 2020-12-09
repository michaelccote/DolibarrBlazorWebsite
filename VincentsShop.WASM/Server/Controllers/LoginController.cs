using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using VincentsShop.WASM.Shared.Models;
using VincentsShop.WASM.Shared.Controllers;

namespace VincentsShop.WASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly DolibarrService _dolibarrService;

        public LoginController(IConfiguration configuration,
                               DolibarrService dolibarrService)
        {
            _configuration = configuration;
            _dolibarrService = dolibarrService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] Usager usager)
        {
            LoginResponse result = await _dolibarrService.PostLoginAsync(usager);
            //result.Successful = result.success != null;
            if (result == null)
            {
                result = new LoginResponse() { ErrorMessage = "Usager ou mot de passe invalide.", Successful = false };
                return BadRequest(result);
            } 

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, usager.login)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );
            result.JwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(result);
        }

    }
}
