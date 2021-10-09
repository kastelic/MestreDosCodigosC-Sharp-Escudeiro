using System;

namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(double taxaDeOperacao, int numeroConta, double saldo) : base(numeroConta, saldo)
        {
            TaxaDeOperacao = taxaDeOperacao;
        }
        public double TaxaDeOperacao { get; private set; }

        public override void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new Exception("Não é permitido depositar um valor negativo!");
            }
            Saldo += valor - TaxaDeOperacao;
        }

        public override void Sacar(double valor)
        {
            if (Saldo - valor < 0)
            {
                throw new Exception("Você não possui saldo!");
            }

            Saldo -= (valor + TaxaDeOperacao);
        }

        public override string MostrarDados()
        {
            return $"Conta Corrente Nº: {NumeroConta}, possui um saldo atual de {Saldo.ToString("N2")} reais";
        }
    }
}
