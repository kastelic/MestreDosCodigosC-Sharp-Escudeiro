using MestreDosCodigo.Escudeiro.Domain.Interfaces;

namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public abstract class ContaBancaria : IImprimivel
    {
        protected ContaBancaria(int numeroConta, double saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public int NumeroConta { get; set; }
        public double Saldo { get; set; }

        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);

        public virtual string MostrarDados()
        {
            throw new System.NotImplementedException();
        }
    }
}
