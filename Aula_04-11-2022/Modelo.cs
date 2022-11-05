using System.Text;

namespace Aula_04_11_2022
{
    class Modelo
    {

        public static void gravarLista(List<string> Lista, string nomeArquivo)
        {
            StreamWriter sw = new StreamWriter(nomeArquivo);
            foreach (var l in Lista)
            {
                sw.WriteLine(l);
            }
            sw.Close();
        }

        public static void lerArquivo(List<string> Lista, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                StreamReader sr = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    Lista.Add(sr.ReadLine());
                } while(!sr.EndOfStream);
                sr.Close();            
            }
        }
    }
}