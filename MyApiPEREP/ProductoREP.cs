using MyApiPEEDM;
using MyApiPEEDM.DTO;
using MyApiPEEDM.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiPEREP
{
    /// <summary>
    /// Represents a repository for managing product data.
    /// </summary>
    /// <remarks>This class provides methods to retrieve product information, simulating a database
    /// interaction.</remarks>
    public class ProductoREP
    {
        public ProductoREP()
        {
            Console.WriteLine("ProductoREP constructor called.");
        }
        /// <summary>
        /// obtiene un listado, con cantidad aleatoria de productos
        /// </summary>
        /// <returns></returns>
        public List<ProductoDTO> GetProductos()
        {
            List<ProductoDTO> productosDTO = new List<ProductoDTO>();
            try
            {
                // Simulamos una base de datos con una lista de productos

                var productos = new List<Producto>();
                productosDTO.Add(new ProductoDTO { SKU = "MUL-100", Nombre = "Multimetro", Precio = 100.00M });
                productosDTO.Add(new ProductoDTO { SKU = "AUD-060", Nombre = "Audifono", Precio = 200.00M });
                productosDTO.Add(new ProductoDTO { SKU = "SHOME-100", Nombre = "Shome 100", Precio = 300.00M });
                productosDTO.Add(new ProductoDTO { SKU = "SHOME-200", Nombre = "Shome 200", Precio = 400.00M });
                productosDTO.Add(new ProductoDTO { SKU = "SHOME-300", Nombre = "Shome 300", Precio = 500.00M });

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener productos: {ex.Message}");
            }
            return productosDTO;
        }
    }
}
