namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public class Calculo
    {
        public Calculo(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public int OperacaoSomar()
        {
            return Valor1 + Valor2;
        }
        public int OperacaoSubtrair()
        {
            return Valor1 - Valor2;
        }
        public int OperacaoMultiplicar()
        {
            return Valor1 * Valor2;
        }
        public int OperacaoDividir()
        {
            return Valor1 / Valor2;
        }
    }
}
