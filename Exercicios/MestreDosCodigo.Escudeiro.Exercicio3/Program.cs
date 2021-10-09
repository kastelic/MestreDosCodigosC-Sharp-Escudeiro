using System;

namespace MestreDosCodigo.Escudeiro.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarExecucao = true;
            int i = 1;
            while(continuarExecucao)
            {
                if ((i % 3) == 0)
                {
                    Console.WriteLine($"O número {i} pode ser divido por 3");
                }
                i++;

                if(i >= 100)
                {
                    continuarExecucao = false;
                }
            }

           
        }
    }
}
