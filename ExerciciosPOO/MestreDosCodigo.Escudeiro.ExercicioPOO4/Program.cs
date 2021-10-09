using MestreDosCodigo.Escudeiro.Domain.Entities;
using MestreDosCodigo.Escudeiro.Domain.Helpers;
using System;
using System.Linq;

namespace MestreDosCodigo.Escudeiro.ExercicioPOO4
{
    class Program
    {
        static void Main(string[] args)
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);

            Console.WriteLine("______________________________________");
            MostrarCanais(televisao);
            Console.WriteLine("______________________________________");
            bool tvLigada = true;
            while (tvLigada)
            {
                MostrarOpcoes();
                var opcaoSelecionada = Console.ReadLine();

                if (Validacoes.ValidarNumero(opcaoSelecionada))
                {
                    switch (Convert.ToInt32(opcaoSelecionada))
                    {
                        case 0:
                            Console.WriteLine($"Desligando TV... \r\n");
                            tvLigada = false;
                            break;
                        case 1:
                            Console.WriteLine($"{controleRemoto.AumentarCanal() } \r\n");
                            break;
                        case 2:
                            Console.WriteLine($"{controleRemoto.DiminuirCanal() } \r\n");
                            break;
                        case 3:
                            MostrarCanais(televisao);
                            Console.WriteLine("Digite o Canal:");
                            var canalDigitado = Console.ReadLine();
                            if (Validacoes.ValidarNumero(canalDigitado))
                            {
                                Console.WriteLine($"{controleRemoto.SelecionarCanal(Convert.ToInt32(canalDigitado)) } \r\n");
                            }
                            else
                            {
                                Console.WriteLine($"Opção Inválida  \r\n");
                            }
                            break;
                        case 4:
                            Console.WriteLine($"{controleRemoto.AumentarVolume() } \r\n");
                            break;
                        case 5:
                            Console.WriteLine($"{controleRemoto.DiminuirVolume() } \r\n");
                            break;
                        case 6:
                            Console.WriteLine($"{controleRemoto.MostrarConfiguracoes() } \r\n");
                            break;
                        default:
                            Console.WriteLine($"Opção Inválida  \r\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Opção Inválida  \r\n");
                }
            }
        }


        private static void MostrarCanais(Televisao televisao)
        {
            Console.WriteLine("");
            Console.WriteLine("CANAIS DISPONÍVEIS");
            Console.WriteLine("");
            televisao.Canais.ForEach(f =>
            {
                Console.WriteLine(f.NumeroCanal + "-" + f.NomeCanal);
            });
        }

        private static void MostrarOpcoes()
        {
            Console.WriteLine("OPÇÕES");
            Console.WriteLine("1 - Avançar Canal");
            Console.WriteLine("2 - Diminuir Canal");
            Console.WriteLine("3 - Selecionar Canal");
            Console.WriteLine("4 - Aumentar volume");
            Console.WriteLine("5 - Diminuir volume");
            Console.WriteLine("6 - Mostrar Configurações Atuais");
            Console.WriteLine("0 - Desligar");
            Console.WriteLine("Selecione um comando:");
            Console.WriteLine("");
        }


    }
}
