using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tarea09
{
    public static class ConversorMoneda
    {
        private const double COP_POR_USD = 4000;
        private const double COP_POR_EUR = 4300;

        public static double Convertir(double valor, string origen, string destino)
        {
            double enCop = origen switch
            {
                "COP" => valor,
                "USD" => valor * COP_POR_USD,
                "EUR" => valor * COP_POR_EUR,
                _ => throw new ArgumentException("Moneda de origen no válida.")
            };

            return destino switch
            {
                "COP" => enCop,
                "USD" => enCop / COP_POR_USD,
                "EUR" => enCop / COP_POR_EUR,
                _ => throw new ArgumentException("Moneda de destino no válida.")
            };
        }
    }
}