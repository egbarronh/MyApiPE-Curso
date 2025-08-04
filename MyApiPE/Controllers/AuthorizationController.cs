using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyApiPE.Servicios;
using MyApiPEBL;
using MyApiPEEDM.DTO;

namespace MyApiPE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IConfiguration _config;
        public AuthorizationController(IConfiguration config)
        {
            _config = config;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserAppRequest user)
        {
            if (user.UserName.Length> 0 && user.Password.Length > 0)
            {
                // Aquí deberías validar las credenciales del usuario
                // Por simplicidad, asumimos que las credenciales son correctas
                return Ok(await new AutenticationManager(_config).ValidateCredentials(user).ConfigureAwait(false));
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
