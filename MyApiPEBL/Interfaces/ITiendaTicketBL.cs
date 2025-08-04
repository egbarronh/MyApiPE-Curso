using MyApiPEEDM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiPEBL.Interfaces
{
    internal interface ITiendaTicketBL
    {
         List<TiendaDTO> GetTiendasTickets();
    }
}
