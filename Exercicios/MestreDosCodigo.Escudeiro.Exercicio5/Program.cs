using MestreDosCodigo.Escudeiro.Domain.Helpers;
using System;

namespace MestreDosCodigo.Escudeiro.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementoA = ValidarValorDigitado("A");
            int elementoB = ValidarValorDigitado("B");
            int elementoC = ValidarValorDigitado("C");

            var valorDelta = Math.Pow(elementoB, 2) - 4 * elementoA * elementoC;
            var resultado1 = ((elementoB * -1) + Math.Sqrt(valorDelta)) / (2 * elementoA);
            var resultado2 = ((elementoB * -1) - Math.Sqrt(valorDelta)) / (2 * elementoA);

            Console.WriteLine("");
            Console.WriteLine($"R1: {resultado1}");
            Console.WriteLine($"R2: {resultado2}");
        }


        private static int ValidarValorDigitado(string NomeDoValor)
        {
            Console.Write($"\r\nDigite o valor do Elemento {NomeDoValor} \r\n");
            var valor = Console.ReadLine();
            if (!Validacoes.ValidarNumero(valor))
            {
                Console.Write($"O valor digitado no elemento {NomeDoValor} é inválido, digite um numero inteiro para continuar. \r\n");
                Console.Write("");
                ValidarValorDigitado(NomeDoValor);
            }

            return Convert.ToInt32(valor);
        }
    }
}
