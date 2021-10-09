using System;

namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public class ContaEspecial : ContaBancaria
    {
        public ContaEspecial(double limite, int numeroConta, double saldo) : base(numeroConta, saldo)
        {
            Limite = limite;
        }
        public double Limite { get; private set; }

        public override void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new Exception("Não é permitido depositar um valor negativo!");
            }
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if(Saldo + Limite > valor)
            {
                throw new Exception($"Não é possivel realizar essa operação, Saldo insuficiente, limite de {Limite} já utilizado");
            }

            Saldo -= valor;
        }

        public override string MostrarDados()
        {
            return $"Conta Especial Nº: {NumeroConta}, possui um saldo atual de {Saldo.ToString("N2")} reais";
        } 
    }
}
