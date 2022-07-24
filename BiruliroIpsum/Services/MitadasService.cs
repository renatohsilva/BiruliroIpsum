using BiruliroIpsum.Services.Interfaces;
using System.Text;

namespace BiruliroIpsum.Services
{
    public class MitadasService : IMitadasService
    {
        private readonly IArquivosService arquivosService;
        private IEnumerable<string> baseDeMitadas;

        public MitadasService(IArquivosService arquivosService)
        {
            this.arquivosService = arquivosService;
        }

        public Mitada GerarMitada(int numeroParagrafos)
        {
            baseDeMitadas = arquivosService.LerArquivo("Mitadas.txt");

            var mitada = new Mitada();
            mitada.ListaDeMitadas.AddRange(CriarTexto(numeroParagrafos));
            mitada.ImagemDoMito = arquivosService.BuscarImagem();

            return mitada;
        }


        private IEnumerable<string> CriarTexto(int numeroDeMitadas)
        {
            var mitadas = new List<string>();
            for (int index = 0; index < numeroDeMitadas; index++)
            {
                mitadas.Add(CriarLinha());
            }

            return mitadas;
        }

        private string CriarLinha()
        {
            var tamanhoMaximoLinha = 500;

            var random = new Random();

            var listaDeMitadas = EmbaralharMitadas();

            var mitada = new StringBuilder();


            while (mitada.Length <= tamanhoMaximoLinha)
            {
                int indiceDaMitada = random.Next(listaDeMitadas.Count());
                mitada.Append(listaDeMitadas[indiceDaMitada]);
                mitada.Append(' ');
            }

            return mitada.ToString();
        }

        private List<string> EmbaralharMitadas()
        {
            return baseDeMitadas.OrderBy(a => Guid.NewGuid()).ToList();
        }
    }
}
