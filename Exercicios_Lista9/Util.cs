using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista9
{
    class Util
    {
        public static void mostrarListaFigurinha(List<Figurinha> lista)
        {
            foreach (var l in lista)
            {
                Console.WriteLine($"Código: {l.CodigoFigurinha}. Seleção: {l.Selecao}. Jogador: {l.NomeJogador}");
                Console.WriteLine("--------------------------");
            }
        }

        public static void popularArquivoNaListaFigurinha(List<string> lista, string nomeArquivo)
        {
            try
            {
                string linha;
                string[] dadosLinha;
                Figurinha figurinha;
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    linha = leitor.ReadLine();
                    lista.Add(leitor.ReadLine());
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deu problema no arquivo!");
            }
        }

        public static bool jaNaListaFigurinha(Figurinha figurinha, List<Figurinha> lista)
        {
            foreach (var l in lista)
            {
                if (figurinha.CodigoFigurinha == l.CodigoFigurinha)
                {
                    return true;
                }
            }
            return false;
        }
        //métood de classe
        public static void gravarFraseArquivo(string frase, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita
            escritor.WriteLine(frase.ToUpper());
            escritor.Flush();
            escritor.Close();
        }

        public static void gravarPessoaArquivo(Pessoa pessoa, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita
            escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email);
            escritor.Flush();
            escritor.Close();
        }

        public static void popularArquivoNaListaString(List<string> lista, string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    lista.Add(leitor.ReadLine());
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deu problema no arquivo!\n");
            }
        }

        public static void popularArquivoNaListaPessoa(List<Pessoa> lista, string nomeArquivo)
        {
            try
            {
                string linha;
                string[] dadosLinha;
                Pessoa pessoa;
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    linha = leitor.ReadLine();
                    dadosLinha = linha.Split(";");
                    pessoa = new Pessoa(dadosLinha[0], dadosLinha[1]);
                    lista.Add(pessoa);
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (FormatException)
            {
                Console.WriteLine("Arquivo em formato inválido.\n");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado!\nVerifique e tente novamente\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deu problema no arquivo!\nCódigo: {ex.Message}\n");
            }
        }

        public static void mostrarListaString(List<string> lista)
        {
            foreach (var l in lista)
            {
                Console.WriteLine(l);
            }
        }

        public static void mostrarListaPessoa(List<Pessoa> lista)
        {
            foreach (var l in lista)
            {
                Console.WriteLine($"Nome: {l.Nome}  |  Email: {l.Email}");
            }
        }

        public static bool jaNaListaPessoa(Pessoa pessoa, List<Pessoa> lista)
        {
            foreach (var l in lista)
            {
                if (pessoa.Email == l.Email)
                {
                    return true; //pessoa localizada pelo email
                }
            }
            return false; //pessoa não localizada pelo email
        }
    }
}
