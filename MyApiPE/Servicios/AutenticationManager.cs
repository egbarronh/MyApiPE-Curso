
using MyApiPEBL.Manager;
using MyApiPEEDM.DTO;

namespace MyApiPE.Servicios
{
    public class AutenticationManager
    {
        private readonly IConfiguration _config;
        public AutenticationManager(IConfiguration config)
        {
            _config = config;
        }

        public async Task<string> ValidateCredentials(UserAppRequest data)
            {
                //// Simula una validación de usuario
                //await Task.Delay(1000); // Simula una operación asíncrona
                //return username == "admin" && password == "password"; // Validación simple
            return await new AutorizationBL(_config).ValidateUser(data).ConfigureAwait(false);
        }
    }
}
