using MestreDosCodigo.Escudeiro.Domain.Entities;
using MestreDosCodigo.Escudeiro.Domain.Helpers;
using System;


namespace MestreDosCodigo.Escudeiro.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciarExercicio();
        }

        private static void IniciarExercicio()
        {
            int primeiroNumero = ObterDadosParaCalculo("Digite o primeiro número \r\n");
            int segundoNumero = ObterDadosParaCalculo("Digite o Segundo número \r\n");
            bool _continuarExecucao = true;
            while (_continuarExecucao)
            {
                try
                {
                    _continuarExecucao = ListaDeOpcoes(primeiroNumero, segundoNumero);
                    continue;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Não é possível realizar uma divisão por 0 \r\n");
                }
            }
        }

        static int ObterDadosParaCalculo(string texto)
        {
            Console.WriteLine(texto);
            string valorDigitado = Console.ReadLine();

            if (Validacoes.ValidarNumero(valorDigitado))
            {
                return Convert.ToInt32(valorDigitado);
            }
            else
            {
                Console.WriteLine("Ops... Você só pode digitar números. Tente novamente \r\n");
                return ObterDadosParaCalculo(texto);
            }
        }

        static bool ListaDeOpcoes(int primeiroNumero, int segundoNumero)
        {
            Console.WriteLine("Escolha a opção que você deseja realizar. \r\n" +
             "Digite: (1) para SOMAR \r\n" +
             "Digite: (2) para SUBTRAIR  \r\n" +
             "Digite: (3) para MULTIPLICAR  \r\n" +
             "Digite: (4) para DIVIDIR \r\n" +
             "Digite: (5) para NOVO CALCULO  \r\n" +
             "Digite: (0) para ENCERRAR  \r\n");

            string opcaoSelecionada = Console.ReadLine();
            if (Validacoes.ValidarNumero(opcaoSelecionada) && Convert.ToInt32(opcaoSelecionada) <= 5)
            {
                int opcao = Convert.ToInt32(opcaoSelecionada);
                if (opcao == 0)
                {
                    return false;
                }

                if (opcao == 5)
                {
                    IniciarExercicio();
                }

                Calcular(primeiroNumero, segundoNumero, opcao);

                return true;
            }
            else
            {
                Console.WriteLine("Por favor informe um opção que conste na lista \r\n");
                return ListaDeOpcoes(primeiroNumero, segundoNumero);
            }
        }

        static bool Calcular(int primeiroNumero, int segundoNumero, int opcaoSelecionada)
        {
            bool retorno = false;
            var calculo = new Calculo(primeiroNumero, segundoNumero);

            switch (opcaoSelecionada)
            {
                case 1:
                    Console.WriteLine($"O Resultado da Soma é: { calculo.OperacaoSomar() } \r\n");
                    retorno = true;
                    break;
                case 2:
                    Console.WriteLine($"O Resultado da Subtração é: { calculo.OperacaoSubtrair() } \r\n");
                    retorno = true;
                    break;
                case 3:
                    Console.WriteLine($"O Resultado da Multiplicação é: { calculo.OperacaoMultiplicar() } \r\n");
                    retorno = true;
                    break;
                case 4:
                    Console.WriteLine($"O Resultado da Divisão é: { calculo.OperacaoDividir() } \r\n");
                    retorno = true;
                    break;
            }

            return retorno;
        }

        
    }
}
