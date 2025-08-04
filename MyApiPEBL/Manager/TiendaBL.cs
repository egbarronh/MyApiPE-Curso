using System;
using System.Collections.Generic;
using MyApiPEEDM.DTO;  
using MyApiPEBL.Interfaces; 
using MyApiPEREP; 


namespace MyApiPEBL.Manager
    {
        public class TiendaBL : ITiendaBL
        {
            public List<TiendaDTO> GetTiendas()
            {
                var tiendaREP = new TiendaREP();
                try
                {
                    return tiendaREP.GetTiendas();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener tiendas: {ex.Message}");
                    return new List<TiendaDTO>();
                }
            }
        }
    }

