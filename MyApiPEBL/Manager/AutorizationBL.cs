using Microsoft.Extensions.Configuration;
using MyApiPEEDM.DTO;
using MyApiPEREP;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace MyApiPEBL.Manager
    {
    public class AutorizationBL
    {

        private readonly IConfiguration _config;
    public AutorizationBL(IConfiguration config)
        {
           
                _config = config;
            }

        public async Task<string> ValidateUser(UserAppRequest data)
        {
            string validacion = string.Empty;
            var repository = new AutorizationREP();
            bool result = await repository.ValidateUser(data);
            if (result)
            {
                // Usuario Valido, generamos el Token para el consumo del Api
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, "usuario_demo"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var token = new JwtSecurityToken(
                    issuer: _config["Jwt:Issuer"],
                    audience: _config["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(1), // El token expira en 30 minutos
                    signingCredentials: credentials);

                validacion = new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
                validacion = "Usuario no autorizado";
            }

            return validacion;
        }
        
    }
}
