using MestreDosCodigo.Escudeiro.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigo.Escudeiro.Domain.Entities
{
    public class Televisao : ITelevisao
    {

        public Televisao()
        {
            CanaisTV();
            Volume = 10;
            Canal = 1;
        }

        public int Volume { get; private set; }
        public int Canal { get; private set; }
        public List<CanaisTV> Canais { get; private set; }

        public string AumentarDiminurCanal(bool aumentarCanal)
        {
            if (aumentarCanal)
            {
                Canal++;
                if (Canais.Any(a => a.NumeroCanal == Canal))
                {
                    return $"O Canal atual é: {Canal}-{Canais.Where(s => s.NumeroCanal == Canal).FirstOrDefault().NomeCanal}";
                }

                Canal--;
                return $"O Canal atual : {Canal}-{Canais.Where(s => s.NumeroCanal == Canal).FirstOrDefault().NomeCanal} é o último canal da lista.";
            }
            else
            {
                Canal--;
                if (Canais.Any(a => a.NumeroCanal == Canal))
                {
                    return $"O Canal atual é: {Canal}-{Canais.Where(s => s.NumeroCanal == Canal).FirstOrDefault().NomeCanal}";
                }

                Canal++;
                return $"O Canal atual : {Canal}-{Canais.Where(s => s.NumeroCanal == Canal).FirstOrDefault().NomeCanal} é o primeiro canal da lista.";
            }
        }

        public string AumentarDimuirVolume(bool aumentarVolume)
        {
            if (aumentarVolume)
            {
                if(Volume == 100)
                {
                    return $"Não é possivel aumentar mais o volume";
                }
                Volume++;
            }
            else
            {
                if (Volume == 0)
                {
                    return $"Não é possivel diminuir mais o volume";
                }
                Volume--;
            }

            return $"O Volume atual é: {Volume}";
        }

        public string MostrarCanalVolumeAtual()
        {
            return $"O Canal atual é: {Canal}-{Canais.Where(s => s.NumeroCanal == Canal).FirstOrDefault().NomeCanal} | O volume atual é: {Volume}";
        }

        public string SelecionarCanal(int numeroCanal)
        {
            var canalSelecionado = Canais.FirstOrDefault(a => a.NumeroCanal == numeroCanal);
            if (canalSelecionado != null)
            {
                Canal = numeroCanal;
                return $"O canal selecionado foi: {canalSelecionado.NumeroCanal}-{canalSelecionado.NomeCanal}";
            }

            return "Canal não encontrado";
        }



        public void CanaisTV()
        {
            Canais = new List<CanaisTV>();
            Canais.Add(new CanaisTV() { NumeroCanal = 1, NomeCanal = "GLOBO" });
            Canais.Add(new CanaisTV() { NumeroCanal = 2, NomeCanal = "SBT" });
            Canais.Add(new CanaisTV() { NumeroCanal = 3, NomeCanal = "BAND" });
            Canais.Add(new CanaisTV() { NumeroCanal = 4, NomeCanal = "NETFLIX" });
            Canais.Add(new CanaisTV() { NumeroCanal = 5, NomeCanal = "AMAZON" });
            Canais.Add(new CanaisTV() { NumeroCanal = 6, NomeCanal = "TV GATO NET" });

        }
    }
}
