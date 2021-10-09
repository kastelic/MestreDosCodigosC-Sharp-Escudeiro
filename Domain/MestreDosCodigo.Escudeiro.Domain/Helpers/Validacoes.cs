using System;
using System.Text.RegularExpressions;

namespace MestreDosCodigo.Escudeiro.Domain.Helpers
{
    public static class Validacoes
    {
        public static bool ValidarNumero(string numero)
        {
            return Regex.IsMatch(numero, @"^[0-9]+$");
        }

        public static bool ValidarDouble(string numero)
        {
            return Double.TryParse(numero, out double valor);
        }

        public static bool ValidarDecimal(string numero)
        {
            return Decimal.TryParse(numero, out decimal valor);
        }

        public static bool ValidarData(string data)
        {
            return DateTime.TryParse(data, out DateTime valor);
        }
    }
}
