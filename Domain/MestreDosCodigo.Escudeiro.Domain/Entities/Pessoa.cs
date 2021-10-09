using System;

namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public class Pessoa
    {
        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public double Altura { get; private set; }

        public string RetornoDadosDaPessoa()
        {
            return $"Dados Digitados: - Nome: {Nome}, Data de Nascimento: {DataNascimento.ToShortDateString()}, Idade: {RetornaIdadeDaPessoa()}";
        }

        public int RetornaIdadeDaPessoa()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;
            if(DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
    }
}
