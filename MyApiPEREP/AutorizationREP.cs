using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApiPEEDM.DTO;

namespace MyApiPEREP
{
    public class AutorizationREP
    {
        public async Task<bool> ValidateUser(UserAppRequest data)
        {
            // vamos a simular que se extraen datos de la BD con los datos de los usuarios
            bool result = false;

            if (data.UserName == "admin" && data.Password == "123456")  // al usar un password se debe encriptar, no usar en blanco
            {
                result = true;
            }
            await Task.Delay(50); // Simula una espera de 1 segundo para simular una llamada a la BD 
            return result;
        }
    }
}
