namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public class Aluno
    {
        public Aluno(string nomeAluno, double mediaAluno)
        {
            NomeAluno = nomeAluno;
            MediaAluno = mediaAluno;
        }

        public string NomeAluno { get; private set; }
        public double MediaAluno { get; private set; }
    }
}
