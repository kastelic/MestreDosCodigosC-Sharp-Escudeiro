using MestreDosCodigo.Escudeiro.Domain.Entities;
using MestreDosCodigo.Escudeiro.Domain.Helpers;
using System;
using System.Collections.Generic;

namespace MestreDosCodigo.Escudeiro.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAlunos = new List<Aluno>();
            IniciarExercicio(listaAlunos);
        }
        private static void IniciarExercicio(List<Aluno> listaAlunos)
        {
            string aluno = string.Empty;
            double mediaAluno = 0;

            aluno = CapturarAluno();
            mediaAluno = CapturarMediaDoAluno();
            listaAlunos.Add(new Aluno(aluno, mediaAluno));

            
            while (true)
            {
                Console.WriteLine("Deseja informar mais algum Aluno? \r\n" +
                "Digite (1) para SIM \r\n" +
                "Digite (0) para NÃO \r\n");

                var opcao = Console.ReadLine();
                Console.WriteLine("");

                if (opcao == "0")
                {
                    ListarMediaAlunos(listaAlunos, 7);
                }
                else if (opcao == "1")
                {
                    IniciarExercicio(listaAlunos);
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção inválida \r\n");
                    continue;
                }
            }
        }
        private static string CapturarAluno()
        {
            string aluno = string.Empty;
            while (true)
            {
                Console.WriteLine("Digite o nome do Aluno \r\n");
                aluno = Console.ReadLine();
                Console.WriteLine("");

                if (string.IsNullOrEmpty(aluno) || aluno.Length <= 3)
                {
                    Console.WriteLine("Digite um nome para o aluno, o nome deve conter mais de 3 caracteres \r\n");
                    continue;
                }
                else
                {
                    break;
                }
            }

            return aluno;
        }
        private static double CapturarMediaDoAluno()
        {
            double mediaAluno = 0;
            while (true)
            {
                Console.WriteLine("Digite a média do aluno \r\n");
                var media = Console.ReadLine();
                Console.WriteLine("");

                if (Validacoes.ValidarDouble(media) && ValidarMedia(Convert.ToDouble(media)))
                {
                    mediaAluno = Convert.ToDouble(media);
                    break;
                }
                else
                {
                    Console.WriteLine("A média deve ser de 0 a 10, você só pode digitar números e uma vírgula (ex. 7,5). Tente novamente \r\n");
                    continue;
                }
            }

            return mediaAluno;
        }
        private static void ListarMediaAlunos(List<Aluno> listaAlunos, double media)
        {
            Console.WriteLine($"Mostrando alunos com nota maior que {media}");
            int i = 0;
            foreach (var aluno in listaAlunos)
            {
                if (aluno.MediaAluno >= media)
                {
                    Console.WriteLine($"A média do aluno: {aluno.NomeAluno} é {aluno.MediaAluno}");
                    i++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"O Total de alunos com a media maior ou igual a {media} é de {i} entre {listaAlunos.Count} aluno(s)");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Deseja realizar a operação novamente? \r\n" +
                "Digite (1) para SIM \r\n" +
                "Digite (0) para NÃO \r\n");

                var opcao = Console.ReadLine();
                Console.WriteLine("");

                if (opcao == "0")
                {
                    break;
                }
                else if (opcao == "1")
                {
                    IniciarExercicio(listaAlunos);
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção inválida \r\n");
                }
            }

            Environment.Exit(0);
        }
        private static bool ValidarMedia(double media)
        {
            if (media >= 0 && media <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
