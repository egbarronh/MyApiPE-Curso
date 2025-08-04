using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiPEEDM
{
    /// <summary>
    /// clase que representa un producto STEREN
    /// </summary>
    /// <created>Enrique Barron</created>
    public class Producto
    {
        /// <summary>
        /// SKU del producto
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// nombre-descripcion
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// precio del producto
        /// </summary>
        public decimal Precio { get; set; }
    }
}
