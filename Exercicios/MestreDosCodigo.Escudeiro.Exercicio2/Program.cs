using MestreDosCodigo.Escudeiro.Domain.Entities;
using MestreDosCodigo.Escudeiro.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigo.Escudeiro.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciarExercicio();
        }

        private static void IniciarExercicio()
        {
            var listaFuncionarios = new List<Funcionario>();

            while (true)
            {
                string funcionario = string.Empty;
                decimal salario = 0;

                var repeteNome = true;
                while (repeteNome)
                {
                    Console.WriteLine("Digite o nome do funcionário \r\n");
                    funcionario = Console.ReadLine();
                    Console.WriteLine("");


                    if (string.IsNullOrEmpty(funcionario) || funcionario.Length <= 3)
                    {
                        Console.WriteLine("Digite um nome para o funcionário, o nome deve conter mais de 3 caracteres \r\n");
                        continue;
                    }
                    else
                    {
                        repeteNome = false;
                    }
                }


                bool repeteSalario = true;
                while (repeteSalario)
                {
                    Console.WriteLine("Digite o salário do funcionário \r\n");
                    var salarioFuncionario = Console.ReadLine();
                    Console.WriteLine("");

                    repeteSalario = Validacoes.ValidarNumero(salarioFuncionario);

                    if (repeteSalario)
                    {
                        salario = Convert.ToDecimal(salarioFuncionario);
                        repeteSalario = false;
                    }
                    else
                    {
                        Console.WriteLine("Você só pode digitar números. Tente novamente \r\n");
                        repeteSalario = true;
                        continue;
                    }
                }

                listaFuncionarios.Add(new Funcionario(funcionario, salario));

                bool opcaoValida = true;
                while (opcaoValida)
                {
                    Console.WriteLine("Deseja informar mais algum funcionário? \r\n" +
                    "Digite (1) para SIM \r\n" +
                    "Digite (0) para NÃO \r\n");

                    var opcao = Console.ReadLine();
                    Console.WriteLine("");

                    if (opcao == "0")
                    {
                        opcaoValida = false;
                        MostrarSalarioMenorEMaior(listaFuncionarios);
                    }
                    else if (opcao == "1")
                    {
                        opcaoValida = false;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Você digitou uma opção inválida \r\n");
                    }

                }
            }
        }

        static void MostrarSalarioMenorEMaior(List<Funcionario> funcionarios)
        {
            
            if(funcionarios.Count > 1)
            {
                Funcionario funcionarioMaiorSalario = funcionarios.FirstOrDefault();
                Funcionario funcionarioMenorSalario = funcionarios.LastOrDefault();

                for (int i = 0; i < funcionarios.Count; i++)
                {
                    if (funcionarios[i].Salario > funcionarioMaiorSalario.Salario)
                    {
                        funcionarioMaiorSalario = funcionarios[i];
                    }

                    if (funcionarios[i].Salario < funcionarioMenorSalario.Salario)
                    {
                        funcionarioMenorSalario = funcionarios[i];
                    }
                }

                Console.WriteLine($"Maior salário - Funcionário : {funcionarioMaiorSalario.Nome} - Salário R$ {funcionarioMaiorSalario.Salario}");
                Console.WriteLine($"Menor salário - Funcionário: {funcionarioMenorSalario.Nome} - Salário R$ {funcionarioMenorSalario.Salario}");
            }
            else
            {
                Console.WriteLine($"Existe apenas um funcionário : {funcionarios[0].Nome} - Salário R$ {funcionarios[0].Salario}");
            }

            bool opcaoValida = true;
            while (opcaoValida)
            {
                Console.WriteLine("Deseja realizar um novo procedimento? \r\n" +
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
                    opcaoValida = false;
                    IniciarExercicio();
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção inválida \r\n");
                }

            }

        }
    }
}
