using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApiPEEDM.DTO;
using MyApiPEEDM;
using MyApiPEEDM.Modelos;
using MyApiPEEDM.DTO;

namespace MyApiPEREP
{
    /// <summary>
    /// esta clase representa un repositorio para gestionar datos de tiendas, simulando el acceso a una BD.
    /// </summary>
    public class TiendaREP
    {
        
        public TiendaREP()
        {
            Console.WriteLine("TiendaREP constructor called.");
        }
        /// <summary>
        /// permite obtener un listado fijo de 5 tiendas, sin tickets.
        /// </summary>
        /// <returns></returns>
        public List<TiendaDTO> GetTiendas()
        {
            List<TiendaDTO> tiendasDTO = new List<TiendaDTO>();
            try
            {

                tiendasDTO.Add(new TiendaDTO
                {
                    Mandante = 1,
                    Nombre = "Tienda 0001",
                });

                tiendasDTO.Add(new TiendaDTO
                {
                    Mandante = 2,
                    Nombre = "Tienda 0002",
                });

                tiendasDTO.Add(new TiendaDTO
                {
                    Mandante = 3,
                    Nombre = "Tienda 0003",
                });

                tiendasDTO.Add(new TiendaDTO
                {
                    Mandante = 4,
                    Nombre = "Tienda 0004",
                });

                tiendasDTO.Add(new TiendaDTO
                {
                    Mandante = 5,
                    Nombre = "Tienda 0005",
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener tiendas: {ex.Message}");
            }
            return tiendasDTO;
        }
    }
}
