using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiPEEDM.Utilerias
{
    public class CalculaIVA
    {
        public static decimal Calcular(decimal monto)
        {
            int ivaPorcentaje = 16; // Porcentaje de IVA

            decimal montoiva = Math.Round(monto * ivaPorcentaje / 100, 2);
            //Console.WriteLine($"El monto para el IVA es: {monto}");
            //Console.WriteLine($"El IVA del monto es: {montoiva}");
            return montoiva;
        }
    }
}
