namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public class Funcionario
    {
        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get; set; }
        public decimal Salario { get; set; }
    }
}
