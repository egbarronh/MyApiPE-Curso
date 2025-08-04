using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiPEEDM.DTO
{
    /// <summary>
    /// clase que representa un ticket
    /// </summary>
    /// <created>Enrique Barron</created>
    public class TicketDTO
    {
        /// <summary>
        /// Numero del pedido
        /// </summary>
        public int Pedido { get; set; }

        /// <summary>
        /// numero de factura
        /// </summary>
        public int Factura { get; set; }

        /// <summary>
        /// subtotal
        /// </summary>
        public decimal Subtotal { get; set; }

        /// <summary>
        /// iva
        /// </summary>
        public decimal IVA { get; set; }

        /// <summary>
        /// total
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// lista de productos del ticket
        /// </summary>
        public List<Producto> Productos { get; set; }

    }



}
