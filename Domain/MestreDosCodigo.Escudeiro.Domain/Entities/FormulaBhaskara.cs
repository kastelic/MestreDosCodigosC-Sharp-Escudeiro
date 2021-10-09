using System;

namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public class FormulaBhaskara
    {
        
        public FormulaBhaskara(int elementoA, int elementoB, int elementoC)
        {
            this.ElementoA = elementoA;
            this.ElementoB = elementoB;
            this.ElementoC = elementoC;


            ValorDelta = Math.Pow(elementoB, 2) - 4 * elementoA * elementoC;
        }

        public int ElementoA { get; private set; }
        public int ElementoB { get; private set; }
        public int ElementoC { get; private set; }
        public double ValorDelta { get; private set; }

        public double CalcularPrimeiroResultado()
        {
            var resultado = ((ElementoB * -1) + Math.Sqrt(ValorDelta)) / (2 * ElementoA);
            return Math.Truncate(100 * resultado) / 100;
        }

        public double CalcularSegundoResultado()
        {
            var resultado = ((ElementoB * -1) - Math.Sqrt(ValorDelta)) / (2 * ElementoA);
            return Math.Truncate(100 * resultado) / 100;
        }

    }
}
