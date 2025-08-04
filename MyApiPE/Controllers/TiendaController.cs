using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyApiPE.Servicios;

namespace MyApiPE.Controllers
{
    [Authorize] // Indica que este controlador requiere autenticación
    [ApiController]  //Indica que esta clase es un controlador de API
        [Route("api/[controller]")] // Se usa para formar la URL:/, Define la ruta base para las acciones del controlador
        public class TiendaController : ControllerBase // Indica que este controlador es un controlador de API y no de vistas
        {
            private readonly ILogger<TiendaController> _logger; // Logger para registrar información de la aplicación
            public TiendaController(ILogger<TiendaController> logger) // Constructor que recibe un logger para registrar información
            {
                _logger = logger;
            }
            [HttpGet(Name = "GetTiendas")] // Define el método HTTP GET y asigna un nombre a la acción
            public async Task<IActionResult> Get() // Método que maneja las solicitudes GET a la ruta /api/producto
            {
                return Ok(await new TiendaManager().GetTiendas().ConfigureAwait(false));
                //Saber porque puso el ConfigureAwait(false) en False.
                // LA URL ES: https://localhost:7088/api/tienda
            }
        }
}
