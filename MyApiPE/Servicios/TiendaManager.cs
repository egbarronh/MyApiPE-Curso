using MyApiPEBL.Manager;
using MyApiPEEDM.DTO;

namespace MyApiPE.Servicios
{
    public class TiendaManager
    {
        public async Task<List<TiendaDTO>> GetTiendas()
        {
            var tiendaBL = new TiendaBL();
            try
            {
                //Task.Delay(1000).Wait(); // Simula una operación asíncrona
                return tiendaBL.GetTiendas();
            }
            catch (Exception ex)
            {
                //Task.Delay(1000).Wait(); // Simula una operación asíncrona
                Console.WriteLine($"Error al obtener tiendas: {ex.Message}");
                return new List<TiendaDTO>();
            }
        }
    }
}
