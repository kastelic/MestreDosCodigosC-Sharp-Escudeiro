using MestreDosCodigo.Escudeiro.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigo.Escudeiro.Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaNumeros = new List<int>();
            IniciarExercicio(listaNumeros);
        }

        private static void IniciarExercicio(List<int> listaNumeros)
        {
            while (true)
            {
                Console.WriteLine("Selecione uma opção? \r\n" +
                "Digite (1) para preencher os números automaticamente \r\n" +
                "Digite (0) para digitar manual \r\n");

                var opcao = Console.ReadLine();
                Console.WriteLine("");

                if (opcao == "0")
                {
                    CapturarNumeroManual(listaNumeros);
                }
                else if (opcao == "1")
                {
                    CapturarNumeroAutomatico(listaNumeros);
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção inválida \r\n");
                    continue;
                }
            }
        }

        private static void CapturarNumeroAutomatico(List<int> listaDecimal)
        {
            for (int i = 0; i < 20; i++)
            {
                listaDecimal.Add(new Random().Next(1, 5000));
            }

            ExecutarResultado(listaDecimal);
        }
        private static void CapturarNumeroManual(List<int> listaDecimal)
        {
            listaDecimal.Add(CapturarNumeroDigitado());

            while (true)
            {
                Console.WriteLine("Deseja digitar mais números? \r\n" +
                "Digite (1) para SIM \r\n" +
                "Digite (0) para NÃO \r\n");

                var opcao = Console.ReadLine();
                Console.WriteLine("");

                if (opcao == "0")
                {
                    ExecutarResultado(listaDecimal);
                }
                else if (opcao == "1")
                {
                    CapturarNumeroManual(listaDecimal);
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção inválida \r\n");
                    continue;
                }
            }
        }

        private static int CapturarNumeroDigitado()
        {
            Console.WriteLine("Digite o numero, ex:(7,5): \r\n");
            var numeroInteiro = Console.ReadLine();

            if (!Validacoes.ValidarNumero(numeroInteiro))
            {
                Console.WriteLine(" Você só pode digitar números e um virgula. Tente novamente \r\n");
                return CapturarNumeroDigitado();
            }

            return Convert.ToInt32(numeroInteiro);
        }

        private static void ExecutarResultado(List<int> listaDecimal)
        {
            Console.WriteLine("Todos os números da lista. \r\n");
            listaDecimal.ForEach(f => Console.Write($"{f}, "));
            Console.WriteLine("");

            Console.WriteLine("Números da lista em ordem crescente. \r\n");
            listaDecimal.OrderBy(o => o).ToList().ForEach(f => Console.Write($"{f}, "));
            Console.WriteLine("");

            Console.WriteLine("Números da lista em ordem descrescente. \r\n");
            listaDecimal.OrderByDescending(o => o).ToList().ForEach(f => Console.Write($"{f}, "));
            Console.WriteLine("");

            Console.Write("Mostra primeiro número da lista \r\n");
            Console.WriteLine(listaDecimal.First());
            Console.WriteLine("");

            Console.Write("Mostra último número da lista \r\n");
            Console.WriteLine(listaDecimal.Last());
            Console.WriteLine("");

            Console.WriteLine("Colocar um número no início da lista \r\n");
            listaDecimal.Insert(0, 99);
            listaDecimal.ForEach(f => Console.Write($"{f}, "));
            Console.WriteLine("");

            Console.WriteLine("Colocar número no final da lista \r\n");
            listaDecimal.Insert(listaDecimal.Count, 99);
            listaDecimal.ForEach(f => Console.Write($"{f}, "));
            Console.WriteLine("");

            Console.WriteLine("Remover o primeiro número \r\n");
            listaDecimal.RemoveAt(0);
            listaDecimal.ForEach(f => Console.Write($"{f}, "));
            Console.WriteLine("");

            Console.WriteLine("Remover o último número \r\n");
            listaDecimal.RemoveAt(listaDecimal.Count - 1);
            listaDecimal.ForEach(f => Console.Write($"{f}, "));
            Console.WriteLine("");

            Console.WriteLine("Apenas os números que são par \r\n");
            listaDecimal.Where(w => (w % 2) == 0).ToList().ForEach(f => Console.Write($"{f}, "));
            Console.WriteLine("");
        }
    }
}
