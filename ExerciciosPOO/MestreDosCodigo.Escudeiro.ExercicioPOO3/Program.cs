using MestreDosCodigo.Escudeiro.Domain.Entities;
using System;

namespace MestreDosCodigo.Escudeiro.ExercicioPOO3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente();
        }

        private static void ContaCorrente()
        {
            try
            {
                int numeroDaConta = 8080;
                double taxaOperacao = 10.00;

                var contaCorrente = new ContaCorrente(taxaOperacao, numeroDaConta, 0);
                contaCorrente.Depositar(900.00); 
                contaCorrente.Sacar(100.00); 
                Console.WriteLine(contaCorrente.MostrarDados());

                contaCorrente.Sacar(780.00);
                Console.WriteLine(contaCorrente.MostrarDados());

                contaCorrente.Depositar(20.00);
                Console.WriteLine(contaCorrente.MostrarDados());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            
        }
    }
}
