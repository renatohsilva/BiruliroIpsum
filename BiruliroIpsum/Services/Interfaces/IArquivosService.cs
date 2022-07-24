namespace BiruliroIpsum.Services.Interfaces
{
    public interface IArquivosService
    {
        IEnumerable<string> LerArquivo(string nomeDoArquivo);
        string BuscarImagem();
    }
}
