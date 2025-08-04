using MyApiPEEDM;
using MyApiPEEDM.DTO;
using MyApiPEEDM.Modelos;
using MyApiPEEDM.Utilerias;
using System;
using System.Collections.Generic;
using System.Linq;


using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace MyApiPEREP
{
    /// <summary>
    /// Provides methods to manage and retrieve ticket information.
    /// </summary>
    /// <remarks>The <c>TicketREP</c> class offers functionality to obtain and set ticket data, converting
    /// between domain models and data transfer objects (DTOs) as needed.</remarks>
    public class TicketREP
    {
        public TicketREP()
        {
            Console.WriteLine("TicketREP constructor called.");
        }
        /// <summary>
        /// obtiene un listado fijo de 5 tickets, con productos y calculos de IVA
        /// </summary>
        /// <returns></returns>
        public List<TicketDTO> GetTickets()
        {

            List<TicketDTO> ticketsDTO = new List<TicketDTO>();
            try
            {
                var prods = new ProductoREP();

                /// obtener los productos del ticket
                //               var productosT1 = prods.GetProductos();
                //var productosT1 = prods.GetProductos().Select(p => new Producto
                //{
                //    SKU = p.SKU,
                //    Nombre = p.Nombre,
                //    Precio = p.Precio
                //}).ToList();
                //var productosT2 = prods.GetProductos().Select(p => new Producto
                //{
                //    SKU = p.SKU,
                //    Nombre = p.Nombre,
                //    Precio = p.Precio
                //}).ToList();
                //var productosT3 = prods.GetProductos().Select(p => new Producto
                //{
                //    SKU = p.SKU,
                //    Nombre = p.Nombre,
                //    Precio = p.Precio
                //}).ToList();
                //var productosT4 = prods.GetProductos().Select(p => new Producto
                //{
                //    SKU = p.SKU,
                //    Nombre = p.Nombre,
                //    Precio = p.Precio
                //}).ToList();
                //var productosT5 = prods.GetProductos().Select(p => new Producto
                //{
                //    SKU = p.SKU,
                //    Nombre = p.Nombre,
                //    Precio = p.Precio
                //}).ToList();

                /// calcular el Subtotal del ticket 
                //var subtotalT1 = productosT1.Sum(p => p.Precio);
                //var subtotalT2 = productosT2.Sum(p => p.Precio);
                //var subtotalT3 = productosT3.Sum(p => p.Precio);
                //var subtotalT4 = productosT4.Sum(p => p.Precio);
                //var subtotalT5 = productosT5.Sum(p => p.Precio);
                //            Console.WriteLine($"El Subtotal del ticket es: {subtotalT1}");

                /// calcular el IVA del ticket
                //var algo = new CalculaIVA();
                //var iva1 = CalculaIVA.Calcular(subtotalT1);
                //var iva2 = CalculaIVA.Calcular(subtotalT2);
                //var iva3 = CalculaIVA.Calcular(subtotalT3);
                //var iva4 = CalculaIVA.Calcular(subtotalT4);
                //var iva5 = CalculaIVA.Calcular(subtotalT5);
                //            Console.WriteLine($"El IVA del ticket es: {iva1}");

                ticketsDTO.Add(new TicketDTO { Pedido = 1, Factura = 101 });
                ticketsDTO.Add(new TicketDTO { Pedido = 2, Factura = 102 });
                ticketsDTO.Add(new TicketDTO { Pedido = 3, Factura = 103 });
                ticketsDTO.Add(new TicketDTO { Pedido = 4, Factura = 104 });
                ticketsDTO.Add(new TicketDTO { Pedido = 5, Factura = 105 });
                //tickets.Add(new Ticket { Pedido = 2, Factura = 102, Subtotal = subtotalT2, IVA = iva2, Total = subtotalT2 + iva2, Productos = productosT2 });
                //tickets.Add(new Ticket { Pedido = 3, Factura = 103, Subtotal = subtotalT3, IVA = iva3, Total = subtotalT3 + iva3, Productos = productosT3 });
                //tickets.Add(new Ticket { Pedido = 4, Factura = 104, Subtotal = subtotalT4, IVA = iva4, Total = subtotalT4 + iva4, Productos = productosT4 });
                //tickets.Add(new Ticket { Pedido = 5, Factura = 105, Subtotal = subtotalT5, IVA = iva5, Total = subtotalT5 + iva5, Productos = productosT5 });

                //// Convertimos los productos a DTOs para poder enviarlos a las demas capas
                //ticketsDTO = tickets.Select(p => new TicketDTO
                //{
                //    Pedido = p.Pedido,
                //    Factura = p.Factura,
                //    Subtotal = p.Subtotal,
                //    IVA = p.IVA,
                //    Total = p.Total,
                //    Productos = p.Productos
                //}).ToList();
                ////                return tickets;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener tickets: {ex.Message}");
            }
            return ticketsDTO;
        }

        /// <summary>
        /// obtiene un listado de cantidad variable de tickets, con productos variables, y calculos de IVA
        /// </summary>
        /// <returns></returns>
        public List<Ticket> SetTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            //            List<Producto> data = new ProductoREP().GetProductos();

            List<Producto> data = new ProductoREP().GetProductos()
                .Select(p => new Producto { SKU = p.SKU, Nombre = p.Nombre, Precio = p.Precio })
                .ToList();

            decimal iva = 0.16M; // Definimos el IVA como un valor fijo del 16%

            Random random2 = new Random();
            int cantidadTickets = random2.Next(0, 5);        // Definimos una cantidad de tickets a generar, maximo 5

            for (int i = 0; i < cantidadTickets + 1; i++)
            {
                Ticket ticket = new Ticket();
                ticket.Productos = new List<Producto>();

                int mandante = 1; // Asignamos el mandante al ticket

                ticket.Pedido = (mandante * 1000) + i + 101;
                ticket.Factura = (mandante * 1000) + i + 201;

                Random random = new Random();
                int producto = random.Next(0, data.Count);

                for (int j = 0; j < producto + 1; j++)
                {
                    ticket.Productos.Add(new Producto() { Nombre = data[j].Nombre, Precio = data[j].Precio, SKU = data[j].SKU });
                    ticket.Subtotal = data[j].Precio + ticket.Subtotal;
                    ticket.IVA = ticket.Subtotal * iva;
                }
                ticket.Total = ticket.Subtotal + ticket.IVA;
                tickets.Add(ticket);
            }
            return tickets;
        }
        // Implementación requerida por la interfaz ISetTicketBL
        public List<TicketDTO> SetTickets(List<TicketDTO> tickets)
        {
            // Implementación de ejemplo: simplemente retorna la lista recibida
            return tickets;
        }
    }
}
