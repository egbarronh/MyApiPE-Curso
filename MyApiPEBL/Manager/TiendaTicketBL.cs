using MyApiPEBL.Interfaces;
using MyApiPEEDM.DTO;
using MyApiPEEDM.Modelos;
using MyApiPEREP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiPEBL.Manager
{
    public class TiendaTicketBL : ITiendaTicketBL
    {
        public List<TiendaDTO> GetTiendasTickets()
        {
            var ticketREP = new TicketREP();
            var tiendaREP = new TiendaREP();
            var tiendas = tiendaREP.GetTiendas();
            try
            {
                tiendas.ForEach(t =>
                    t.Tickets = ticketREP.SetTickets()); // Simula la adición de tickets a cada tienda

                return tiendas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener tiendas-tickets: {ex.Message}");
                return new List<TiendaDTO>();
            }
        }
    }
}
