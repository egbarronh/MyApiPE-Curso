using MyApiPEBL.Manager;
using MyApiPEEDM.DTO;

namespace MyApiPE.Servicios
{
    public class TicketManager
    {
        public async Task<List<TicketDTO>> GetTickets()
        {
            var ticketBL = new TicketBL();
            try
            {
                //Task.Delay(1000).Wait(); // Simula una operación asíncrona
                return ticketBL.GetTickets();
            }
            catch (Exception ex)
            {
                //Task.Delay(1000).Wait(); // Simula una operación asíncrona
                Console.WriteLine($"Error al obtener tickets: {ex.Message}");
                return new List<TicketDTO>();
            }
        }
    }
}
