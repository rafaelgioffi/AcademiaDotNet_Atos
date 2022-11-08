using System.Text;

namespace Exercicios_Lista9
{
    class Util
    {
        //método de classe
        //Exemplo em aula
        // métodos para gravações de arquivos
        public static void gravarFraseArquivo(string frase, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita
            escritor.WriteLine(frase.ToUpper());
            escritor.Flush();
            escritor.Close();
        }

        public static void gravarPessoaArquivo(Pessoa pessoa, string nomeArquivo)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gravando os dados, aguarde...");
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita
            escritor.WriteLine(pessoa.Nome);
            escritor.Flush();
            escritor.Close();
            Console.Clear();
            Console.WriteLine($"Dados gravados no arquivo '{nomeArquivo}'");
            Console.ResetColor();
            Console.WriteLine($"'{pessoa.Nome}' cadastrado com sucesso!\n");
        }
        public static void gravarEmailArquivo(Emails email, string nomeArquivo)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gravando os dados, aguarde...");
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita
            escritor.WriteLine(email.Email + ";" + email.Dominio);
            escritor.Flush();
            escritor.Close();
            Console.Clear();
            Console.WriteLine($"Dados gravados no arquivo '{nomeArquivo}'");
            Console.ResetColor();
            Console.WriteLine($"'{email.Email}' cadastrado com sucesso!\n");
        }
        public static void gravarFigurinhaArquivo(Figurinha figurinha, string nomeArquivo)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gravando os dados, aguarde...");
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita
            escritor.WriteLine($"{figurinha.CodigoFigurinha};{figurinha.Selecao};{figurinha.NomeJogador}");
            escritor.Flush();
            escritor.Close();
            Console.Clear();
            Console.WriteLine($"Dados gravados no arquivo '{nomeArquivo}'");
            Console.ResetColor();
            Console.WriteLine($"'{figurinha.NomeJogador}' cadastrado com sucesso!\n");
        }

        //métodos para popular as listas
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
                    pessoa = new Pessoa(linha);
                    lista.Add(pessoa);
                } while (!leitor.EndOfStream);

                leitor.Close();
                lista.Reverse();
            }
            catch (AccessViolationException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Acesso negado ao arquivo '{nomeArquivo}'. Verifique a permissão e tente novamente");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Arquivo '{nomeArquivo}' em formato inválido.\n");
                Console.ResetColor();
            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Arquivo '{nomeArquivo}' não encontrado!\nDigite 3 para sair ou será criado um novo ao cadastrar\n");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Deu problema no arquivo '{nomeArquivo}'!\nCódigo: {ex.Message}\n");
                Console.ResetColor();
            }
        }
        public static void popularArquivoNaListaEmail(List<Emails> lista, string nomeArquivo)
        {
            try
            {
                string linha;
                string[] dadosLinha;
                Emails email;
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    linha = leitor.ReadLine();
                    dadosLinha = linha.Split(";");
                    if (!dadosLinha[1].Contains("."))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("E-mail em formato inválido.\nÉ necessário possui ao menos um domínio válido.");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        email = new Emails(dadosLinha[0], dadosLinha[1]);
                        lista.Add(email);

                    }
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (AccessViolationException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Acesso negado ao arquivo '{nomeArquivo}'. Verifique a permissão e tente novamente");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Arquivo '{nomeArquivo}' em formato inválido.\n");
                Console.ResetColor();
            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Arquivo '{nomeArquivo}' não encontrado!\nDigite 3 para sair ou será criado um novo ao cadastrar\n");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Deu problema no arquivo '{nomeArquivo}'!\nCódigo: {ex.Message}\n");
                Console.ResetColor();
            }
        }
        public static void popularArquivoNaListaFigurinha(List<Figurinha> lista, string nomeArquivo)
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
                    dadosLinha = linha.Split(";");
                    if (dadosLinha.Length < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Dados faltantes no arquivo. É necessário possuir o código da figurinha, nome da selação e nome do jogador.");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        figurinha = new Figurinha(dadosLinha[0], dadosLinha[1], dadosLinha[2]);
                        lista.Add(figurinha);

                    }
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (AccessViolationException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Acesso negado ao arquivo '{nomeArquivo}'. Verifique a permissão e tente novamente");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Arquivo '{nomeArquivo}' em formato inválido.\n");
                Console.ResetColor();
            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Arquivo '{nomeArquivo}' não encontrado!\nDigite 3 para sair ou será criado um novo ao cadastrar\n");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Deu problema no arquivo '{nomeArquivo}'!\nCódigo: {ex.Message}\n");
                Console.ResetColor();
            }
        }

        //métodos para mostrar os dados
        public static void mostrarListaString(List<string> lista)
        {
            foreach (var l in lista)
            {
                Console.WriteLine(l);
            }
        }

        public static void mostrarListaPessoa(List<Pessoa> lista)
        {
            if (lista.Count > 0)
            {
                Console.WriteLine("Pessoas já cadastradas\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (var l in lista)
                {
                    Console.WriteLine($"Nome: {l.Nome}");
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum nome cadastrado ainda!\n");
                Console.ResetColor();
            }
        }

        public static void mostrarListaEmail(List<Emails> lista)
        {
            if (lista.Count > 0)
            {
                Console.WriteLine("E-mails já cadastrados\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (var l in lista)
                {
                    Console.WriteLine($"Email: {l.Email}  |  Domínio: {l.Dominio}");
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNenhum e-mail cadastrado ainda!\n");
                Console.ResetColor();
            }
        }
        public static void mostrarListaFigurinha(List<Figurinha> lista, string tipo)
        {
            Console.Clear();
            if (lista.Count > 0)
            {
                Console.WriteLine($"Figurinhas {tipo} cadastradas\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("------------------------------------------------------------------------");
                foreach (var l in lista)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Código: {l.CodigoFigurinha}   Seleção: {l.Selecao}   Nome do jogador: {l.NomeJogador}");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\nNenhuma figurinha {tipo} cadastrada ainda!\n");
                Console.ResetColor();
            }
        }

        //métodos de checagem de listas
        public static bool jaNaListaPessoa(Pessoa pessoa, List<Pessoa> lista)
        {
            foreach (var l in lista)
            {
                if (pessoa.Nome == l.Nome)
                {
                    return true; //pessoa localizada pelo email
                }
            }
            return false; //pessoa não localizada pelo email
        }

        public static bool jaNaListaEmail(Emails email, List<Emails> lista)
        {
            foreach (var l in lista)
            {
                if (email.Email == l.Email)
                {
                    return true;
                }
            }
            return false;
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

    }

}
