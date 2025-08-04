using MyApiPEBL.Manager;
using MyApiPEEDM.DTO;

namespace MyApiPE.Servicios
{
    public class TiendaTicketManager
    {
        public async Task<List<TiendaDTO>> GetTiendasTickets()
        {
            var tiendaticketBL = new TiendaTicketBL();
            try
            {
                //Task.Delay(1000).Wait(); // Simula una operación asíncrona
                return tiendaticketBL.GetTiendasTickets();
            }
            catch (Exception ex)
            {
                //Task.Delay(1000).Wait(); // Simula una operación asíncrona
                Console.WriteLine($"Error al obtener tiendas-tickets: {ex.Message}");
                return new List<TiendaDTO>();
            }
        }
    }
}
