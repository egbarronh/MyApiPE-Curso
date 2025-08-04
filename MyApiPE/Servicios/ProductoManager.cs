using MyApiPEEDM.DTO;
using MyApiPEBL.Manager;

namespace MyApiPE.Servicios
{
    public class ProductoManager
    {
        public List<ProductoDTO> GetProductos()
        {
            var productoBL = new ProductoBL();
            try
            {
                return productoBL.GetProductos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener productos: {ex.Message}");
                return new List<ProductoDTO>();
            }
        }
    }
}
