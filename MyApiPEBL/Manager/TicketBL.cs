using MyApiPEBL.Interfaces;
using MyApiPEEDM;
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
        public class TicketBL : ITicketBL
        {
            public List<TicketDTO> GetTickets()
            {
                var ticketREP = new TicketREP();
                try
                {
                    return ticketREP.GetTickets();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener tickets: {ex.Message}");
                    return new List<TicketDTO>();
                }
            }
        }
        public class SetTicketsBL : ISetTicketsBL
        {
            public List<TicketDTO> SetTickets()
            {
                var ticketREP = new TicketREP();
                try
                {
                    //                    return ticketREP.SetTickets();
                    // Convertir la lista de Ticket a TicketDTO
                    var tickets = ticketREP.SetTickets();
                    return tickets.Select(t => new TicketDTO
                    {
                        // Asignar aquí las propiedades necesarias
                        Pedido = t.Pedido,
                        Factura = t.Factura,
                        Subtotal = t.Subtotal,
                        IVA = t.IVA,    
                        Total = t.Total,    
                        // ... otras propiedades según corresponda
                    }).ToList();
            
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al establecer tickets: {ex.Message}");
                    return new List<TicketDTO>();
                }
            }

    }
}

