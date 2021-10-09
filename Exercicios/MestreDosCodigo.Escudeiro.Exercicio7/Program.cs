using MestreDosCodigo.Escudeiro.Domain.Helpers;
using System;
using System.Collections.Generic;

namespace MestreDosCodigo.Escudeiro.Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciarExercicio();
        }


        private static void IniciarExercicio()
        {
            var listaNumeros = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                var inteiroLido = ObterNumero(i);
                listaNumeros.Add(inteiroLido);
            }

            Console.WriteLine($"O resultado da soma dos números que são pares é : {SomarNumerosPares(listaNumeros)}");

            while (true)
            {
              Console.WriteLine("Deseja realizar o exercicio 7 novamente? \r\n" +
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
                    IniciarExercicio();
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção inválida \r\n");
                    continue;
                }
            }
        }

        static int ObterNumero(int numero)
        {
            Console.WriteLine($"Digite o {numero + 1}° número");
            var valorDigitado = Console.ReadLine();
            Console.WriteLine("");

            if (!Validacoes.ValidarNumero(valorDigitado))
            {
                Console.WriteLine(" Você só pode digitar números. Tente novamente \r\n");
                return ObterNumero(numero);
            }

            return Convert.ToInt32(valorDigitado);
        }

        private static int SomarNumerosPares(List<int> listaNumeros)
        {
            int resultado = 0;
            listaNumeros.ForEach(f => { if (f % 2 == 0) { resultado += f; } });
            return resultado;
        }
    }
}
