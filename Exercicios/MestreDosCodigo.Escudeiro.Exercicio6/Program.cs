using System;

namespace MestreDosCodigo.Escudeiro.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorReferencia = 0;
            MetodoReferencia(ref valorReferencia);

            int valorOut;
            MetodoOutput(out valorOut);
        }


        private static void MetodoReferencia(ref int valorReferencia)
        {
            int valorAnterior = valorReferencia;
            valorReferencia = 20;
            Console.WriteLine($"MetodoReferencia alterou o valor de : {valorAnterior} para {valorReferencia}");
        }

        private static void MetodoOutput(out int valorOutput)
        {
            //Só é possível utilizar a váriável "valorOutput" após setar algum valor a ela, diferente de quando usamos via ref.
            valorOutput = 100;
            Console.WriteLine($"MetodoOutput vai alterar o valor para {valorOutput}");
        }
    }
}
