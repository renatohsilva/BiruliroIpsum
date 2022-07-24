using BiruliroIpsum.Services.Interfaces;
using System.Reflection;

namespace BiruliroIpsum.Services
{
    public class ArquivosService : IArquivosService
    {
        public string BuscarImagem()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var files = assembly.GetManifestResourceNames()
                 .Where(str => str.ToUpper().EndsWith(".JPG"))
                 .OrderBy(a => Guid.NewGuid()).ToList();

            var stream = assembly.GetManifestResourceStream(files.FirstOrDefault());
            var bytes = ReadFully(stream);

            string base64 = $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";

            return base64;
        }

        public IEnumerable<string> LerArquivo(string nomeDoArquivo)
        {
            var assembly = Assembly.GetExecutingAssembly();

            string resourcePath = assembly.GetManifestResourceNames()
                    .SingleOrDefault(str => str.ToUpper().EndsWith(nomeDoArquivo.ToUpper()));

            if (string.IsNullOrWhiteSpace(resourcePath))
                yield return "";


            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
