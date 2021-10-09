using MestreDosCodigo.Escudeiro.Domain.Entities;
using MestreDosCodigo.Escudeiro.Domain.Helpers;
using System;

namespace MestreDosCodigo.Escudeiro.ExercicioPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciarExercicio();
        }

        private static void IniciarExercicio()
        {
            string nome = string.Empty;
            DateTime dataNascimento = DateTime.Now;
            double altura = 0;

            while (true)
            {
                Console.WriteLine("Digite o nome da Pessoa  \r\n ");
                nome = Console.ReadLine();
                Console.WriteLine();

                if (string.IsNullOrEmpty(nome) || nome.Length < 3)
                {
                    Console.WriteLine("Você digitou uma opção inválida \r\n");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Digite a data de nascimento da pessoa, ex. 01/01/2000 \r\n ");
                string data = Console.ReadLine();
                Console.WriteLine();

                if (!Validacoes.ValidarData(data))
                {
                    Console.WriteLine("Digite uma data válida. Tente novamente \r\n");
                    continue;
                }
                dataNascimento = Convert.ToDateTime(data);
                break;
            }

            while (true)
            {
                Console.WriteLine("Digite a altura da pessoa, ex.(1,84) \r\n ");
                string alt = Console.ReadLine();
                Console.WriteLine();

                if (!Validacoes.ValidarDouble(alt))
                {
                    Console.WriteLine("Digite uma altura válida, ex.(1,84). Tente novamente \r\n");
                    continue;
                }
                altura = Convert.ToDouble(alt);
                break;
            }

            var pessoa = new Pessoa(nome, dataNascimento, altura);
            Console.WriteLine(pessoa.RetornoDadosDaPessoa());
            Console.WriteLine();
            FazerNovamente();

        }

        private static void FazerNovamente()
        {
            while (true)
            {
                Console.WriteLine("Selecione uma opção? \r\n" +
                "Digite (1) fazer o exercicio novamente \r\n" +
                "Digite (0) para sair \r\n");

                var opcao = Console.ReadLine();
                Console.WriteLine("");

                if (opcao == "0")
                {
                    Environment.Exit(0);
                }
                else if (opcao == "1")
                {
                    Console.Clear();
                    IniciarExercicio();
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
