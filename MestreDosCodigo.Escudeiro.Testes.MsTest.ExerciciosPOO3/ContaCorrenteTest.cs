using MestreDosCodigo.Escudeiro.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MestreDosCodigo.Escudeiro.Testes.MsTest.ExerciciosPOO3
{
    [TestClass]
    public class ContaCorrenteTest
    {
        private int numeroDaConta = 8080;
        double taxaOperacao = 10.00;

        [TestMethod]
        public void DeveCriarContaCorrente()
        {
            var contaCorrente = new ContaCorrente(taxaOperacao, numeroDaConta, 0);
            Assert.IsNotNull(contaCorrente);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Deve retornar exceção caso negativo")]
        public void SaquesEDepositosDevemGerarExcessaoCasoSejamNegativos()
        {
            var contaCorrente = new ContaCorrente(taxaOperacao, numeroDaConta, 0);
            contaCorrente.Depositar(-1);
            contaCorrente.Sacar(-1);
        }
    }
}
