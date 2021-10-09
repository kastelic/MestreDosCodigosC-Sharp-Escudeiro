using MestreDosCodigo.Escudeiro.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigo.Escudeiro.Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDecimal = new List<decimal>();
            IniciarExercicio(listaDecimal);
        }

        private static void IniciarExercicio(List<decimal> listaDecimal)
        {
            listaDecimal.Add(CapturarNumeroDigitado(listaDecimal));

            while (true)
            {
                Console.WriteLine("Deseja digitar mais números? \r\n" +
                "Digite (1) para SIM \r\n" +
                "Digite (0) para NÃO \r\n");

                var opcao = Console.ReadLine();
                Console.WriteLine("");

                if (opcao == "0")
                {
                    MostrarResultado(listaDecimal);
                }
                else if (opcao == "1")
                {
                    IniciarExercicio(listaDecimal);
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção inválida \r\n");
                    continue;
                }
            }
        }

        private static decimal CapturarNumeroDigitado(List<decimal> listaDecimal)
        {
            Console.WriteLine("Digite o numero, ex:(7,5): \r\n");
            var numeroDecimal = Console.ReadLine();

            if (!Validacoes.ValidarDecimal(numeroDecimal))
            {
                Console.WriteLine(" Você só pode digitar números e um virgula. Tente novamente \r\n");
                return CapturarNumeroDigitado(listaDecimal);
            }

            return Convert.ToDecimal(numeroDecimal);
        }

        private static void MostrarResultado(List<decimal> listaDecimal)
        {
            Console.WriteLine("ordem crescente :");
            listaDecimal = listaDecimal.OrderBy(o => o).ToList();
            listaDecimal.ForEach(f => Console.WriteLine(f.ToString()));
            Console.WriteLine("");
            Console.WriteLine("ordem decrescente :");
            listaDecimal = listaDecimal.OrderByDescending(o => o).ToList();
            listaDecimal.ForEach(f => Console.WriteLine(f.ToString()));
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("Deseja repetir o exercicio 8? \r\n" +
                "Digite (1) para SIM \r\n" +
                "Digite (0) para NÃO \r\n");

                var opcao = Console.ReadLine();
                Console.WriteLine("");

                if (opcao == "0")
                {
                    Environment.Exit(0);
                }
                else if (opcao == "1")
                {
                    var listaNova = new List<decimal>();
                    IniciarExercicio(listaNova);
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção inválida \r\n");
                    continue;
                }
            }
        }
    }
}
