using MyApiPEBL.Interfaces;
using MyApiPEEDM.DTO;
using MyApiPEREP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiPEBL.Manager
{
    public class ProductoBL : IProductoBL
    {
        public List<ProductoDTO> GetProductos()
        {
            var productoREP = new ProductoREP();
            try
            {
                return productoREP.GetProductos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener productos: {ex.Message}");
                return new List<ProductoDTO>();
            }
        }
    }
}
