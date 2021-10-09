using MestreDosCodigo.Escudeiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MestreDosCodigo.Escudeiro.Testes.Exercicios5
{
    public class FormulaBhaskaraTests
    {
        [Theory]
        [InlineData(3, -15, 12, 4, 1)]
        [InlineData(9, -24, 16, 1.33, 1.33)]
        public void CalcularValorFormulaBhaskaraResultadoVerdadeiro(int ElementoA, int ElementoB, int ElementoC, double ResultadoEsperado1, double ResultadoEsperado2)
        {
            var bhaskara = new FormulaBhaskara(ElementoA, ElementoB, ElementoC);
            double resultado1 = bhaskara.CalcularPrimeiroResultado();
            double resultado2 = bhaskara.CalcularSegundoResultado();
            Assert.Equal(resultado1, ResultadoEsperado1);
            Assert.Equal(resultado2, ResultadoEsperado2);
        }
    }
}
