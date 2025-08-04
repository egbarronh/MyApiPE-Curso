using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MyApiPEEDM.Modelos;

namespace MyApiPEEDM
{
    public class Tienda
    {
        /// <summary>
        /// numero de la tienda
        /// </summary>
        public int Mandante { get; set; }
        /// <summary>
        /// nombre de la tienda
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// lista de tickets emitidos en esta tienda
        /// </summary>
        public List<Ticket> Tickets { get; set; }

    }
}
