using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyApiPE.Servicios;

namespace MyApiPE.Controllers
{
    [Authorize] // Indica que este controlador requiere autorización para acceder a sus acciones
    [ApiController]  //Indica que esta clase es un controlador de API
    [Route("api/[controller]")] // Se usa para formar la URL:/, Define la ruta base para las acciones del controlador
    public class TiendaTicketController : ControllerBase // Indica que este controlador es un controlador de API y no de vistas
    {
        private readonly ILogger<TiendaTicketController> _logger; // Logger para registrar información de la aplicación
        public TiendaTicketController(ILogger<TiendaTicketController> logger) // Constructor que recibe un logger para registrar información
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetTiendasTickets")] // Define el método HTTP GET y asigna un nombre a la acción
        public async Task<IActionResult> Get() // Método que maneja las solicitudes GET a la ruta /api/producto
        {
            return Ok(await new TiendaTicketManager().GetTiendasTickets().ConfigureAwait(false));
            //Saber porque puso el ConfigureAwait(false) en False.
            // LA URL ES: https://localhost:7088/api/tiendaticket
        }
    }
}
