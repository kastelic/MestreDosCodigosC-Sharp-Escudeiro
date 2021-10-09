namespace MestreDosCodigo.Escudeiro.Domain.Interfaces
{
    public interface ITelevisao
    {
        string AumentarDimuirVolume(bool aumentarVolume);
        string AumentarDiminurCanal(bool aumentarCanal);
        string SelecionarCanal(int numeroCanal);
        string MostrarCanalVolumeAtual();

    }
}
