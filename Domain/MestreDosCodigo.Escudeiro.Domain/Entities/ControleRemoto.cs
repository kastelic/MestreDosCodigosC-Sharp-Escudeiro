using MestreDosCodigo.Escudeiro.Domain.Interfaces;

namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public class ControleRemoto
    {
        private readonly ITelevisao _televisao;
        public ControleRemoto(ITelevisao televisao)
        {
            _televisao = televisao;
        }

        public string AumentarVolume()
        {
            return _televisao.AumentarDimuirVolume(true);
        }
        public string DiminuirVolume()
        {
            return _televisao.AumentarDimuirVolume(false);
        }
        public string AumentarCanal()
        {
            return _televisao.AumentarDiminurCanal(true);
        }
        public string DiminuirCanal()
        {
            return _televisao.AumentarDiminurCanal(false);
        }
        public string MostrarConfiguracoes()
        {
            return _televisao.MostrarCanalVolumeAtual();
        }
        public string SelecionarCanal(int numeroCanal)
        {
            return _televisao.SelecionarCanal(numeroCanal);
        }
    }
}
