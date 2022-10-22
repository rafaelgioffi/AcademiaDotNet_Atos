<<<<<<< HEAD
﻿namespace Exercicios_Lista9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Fazer um programa em VS que popule uma lista e um arquivo .csv de nomes, com
             * nomes completos obrigatoriamente. Ao cadastrar o nome na lista e no arquivo, o nome
             * deve ser validado para que tenha no mínimo duas palavras e que não esteja na lista.
             * Ao final, caso o nome não esteja na lista e arquivo, cadastra-lo em maiúsculo e 
             * exibir a lista ordenada.
             */

            /*
            List<Pessoa> pessoas = new List<Pessoa>();
            int opc = 0;
            Pessoa p;

            const string caminho = @"D:\Desenvolvimento\.NET\academiaDotNet_Atos\Exercicios_Lista9\";
            const string nomeArq = "nomes.csv";
            const string arq = caminho + nomeArq;

            //popula a list com os dados já no arquivo...
            Util.popularArquivoNaListaPessoa(pessoas, arq);

            //exibir no inicio...            
            Util.mostrarListaPessoa(pessoas);

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" === Cadastro de Nomes ===\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cadastrar um Nome");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2 - Listar Nomes");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - Sair");
                Console.ResetColor();
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Qual nome deseja cadastrar? ");
                        Console.ResetColor();
                        string nomeDigitado = Console.ReadLine().ToUpper();
                        string[] filtro = nomeDigitado.Split(" ");

                        if(filtro.Length > 1)
                        {
                            p = new Pessoa(nomeDigitado);
                            if (Util.jaNaListaPessoa(p, pessoas))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\n'{nomeDigitado}' já está cadastrado!\nUtilize outro\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                pessoas.Add(p);
                                Util.gravarPessoaArquivo(p, arq);
                            }
                        } else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Favor inserir um nome completo.\n");
                            Console.ResetColor();
                            break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Util.mostrarListaPessoa(pessoas);
                        break;
                    case 3: break;
                }
            } while (opc != 3);
            */

            /*
             * 2. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails 
             * e sair do programa. Os emails digitados devem ser cadastrados em uma lista e depois 
             * em um arquivo .csv e não pode haver emails duplicados, ou seja, o programa deve 
             * controlar essa situação. Quando o usuário solicitar a listagem dos emails, além 
             * dessa lista, o programa deve listar os domínios de emails cadastrados no programa.
             * 
             * Menu
             * 1 - Cadastrar email
             * 2 - Listar
             * 3 - Sair 
             * Opção: 
             */

            /*
            List<Emails> emails = new List<Emails>();
            int opc = 0;
            Emails email;

            const string caminho = @"D:\Desenvolvimento\.NET\academiaDotNet_Atos\Exercicios_Lista9\";
            const string nomeArq = "emails.csv";
            const string arq = caminho + nomeArq;

            //popula a list com os dados já no arquivo...
            Util.popularArquivoNaListaEmail(emails, arq);

            //exibir no inicio...            
            Util.mostrarListaEmail(emails);
            //Console.WriteLine();

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" === Cadastro de E-mails ===\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cadastrar um E-mail");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2 - Listar E-mails");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - Sair");
                Console.ResetColor();
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Qual e-mail deseja cadastrar? ");
                        Console.ResetColor();
                        string emailDigitado = Console.ReadLine();
                        string[] filtro = emailDigitado.Split("@");
                        if (filtro.Length > 1)
                        {
                            string usuario = filtro[0];
                            string dominio = filtro[1];
                            if (!dominio.Contains("."))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Favor incluir um e-mail válido.\nÉ necessário possuir ao menos um domínio válido.\n");
                                Console.ResetColor();
                                break;
                            }
                            email = new Emails(emailDigitado, dominio);

                            if (Util.jaNaListaEmail(email, emails))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\n'{emailDigitado}' já está cadastrado!\nUtilize outro\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                emails.Add(email);
                                Util.gravarEmailArquivo(email, arq);
                            }
                        } else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Favor inclua um e-mail completo: 'nome'@'domínio'\n");
                            Console.ResetColor();
                        }
                        break;
                    case 2:
                        Console.Clear();                        
                        Util.mostrarListaEmail(emails);
                        break;
                    case 3: break;
                }
            } while (opc != 3);
            */

            /*
             * 3. Fazer um programa em VS para gerenciar figurinhas da copa. O programa deve 
             * possuir um Menu 
             * 
             * Menu
             * 1 - Cadastrar figurinha repetida
             * 2 - Cadastrar figurinha faltante
             * 3 - Listar figurinhas repetidas
             * 4 - Listar figurinhas faltantes
             * 5 - Sair
             * Opção:
             * 
             * Para este programa, usar a classe Figurinha (codigo_figurinha, selecao, 
             * nome_jogador), lista que armazena as figurinhas em memória, arquivo .csv com os 
             * dados das figurinhas persistidos em disco.
             * 
             * Para as figurinhas repetidas, deve haver uma lista e um arquivo .csv; o mesmo para 
             * as figurinhas faltantes.
             */
            
            List<Figurinha> listaRepetidas = new List<Figurinha>();
            List<Figurinha> listaFaltantes = new List<Figurinha>();
            int opcao;

            //conectar com a base de dados
            //Util.popularArquivoNaListaFigurinha(listaRepetidas, "repetidas.csv");
            //Util.popularArquivoNaListaFigurinha(listaFaltantes, "faltantes.csv");

            do
            {
                Console.WriteLine("1 - Cadastrar figurinha Repetida");
                Console.WriteLine("2 - Cadastrar figurinha Faltante");
                Console.WriteLine("3 - Listar figurinha Repetida");
                Console.WriteLine("4 - Listar figurinha Faltante");
                Console.WriteLine("5 - Sair");
                Console.Write("\nOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        break;
                        case 2:
                        break;
                        case 3:
                        break;
                        case 4:
                        break;
                        case 5:
                        break;
                        default: break;
                }
            } while (opcao != 5);

        }
    }
=======
﻿namespace Exercicios_Lista9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Fazer um programa em VS que popule uma lista e um arquivo .csv de nomes, com
             * nomes completos obrigatoriamente. Ao cadastrar o nome na lista e no arquivo, o nome
             * deve ser validado para que tenha no mínimo duas palavras e que não esteja na lista.
             * Ao final, caso o nome não esteja na lista e arquivo, cadastra-lo em maiúsculo e 
             * exibir a lista ordenada.
             */

            /*
            List<Pessoa> pessoas = new List<Pessoa>();
            int opc = 0;
            Pessoa p;

            const string caminho = @"D:\Desenvolvimento\.NET\academiaDotNet_Atos\Exercicios_Lista9\";
            const string nomeArq = "nomes.csv";
            const string arq = caminho + nomeArq;

            //popula a list com os dados já no arquivo...
            Util.popularArquivoNaListaPessoa(pessoas, arq);

            //exibir no inicio...            
            Util.mostrarListaPessoa(pessoas);

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" === Cadastro de Nomes ===\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cadastrar um Nome");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2 - Listar Nomes");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - Sair");
                Console.ResetColor();
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Qual nome deseja cadastrar? ");
                        Console.ResetColor();
                        string nomeDigitado = Console.ReadLine().ToUpper();
                        string[] filtro = nomeDigitado.Split(" ");

                        if(filtro.Length > 1)
                        {
                            p = new Pessoa(nomeDigitado);
                            if (Util.jaNaListaPessoa(p, pessoas))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\n'{nomeDigitado}' já está cadastrado!\nUtilize outro\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                pessoas.Add(p);
                                Util.gravarPessoaArquivo(p, arq);
                            }
                        } else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Favor inserir um nome completo.\n");
                            Console.ResetColor();
                            break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Util.mostrarListaPessoa(pessoas);
                        break;
                    case 3: break;
                }
            } while (opc != 3);
            */

            /*
             * 2. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails 
             * e sair do programa. Os emails digitados devem ser cadastrados em uma lista e depois 
             * em um arquivo .csv e não pode haver emails duplicados, ou seja, o programa deve 
             * controlar essa situação. Quando o usuário solicitar a listagem dos emails, além 
             * dessa lista, o programa deve listar os domínios de emails cadastrados no programa.
             * 
             * Menu
             * 1 - Cadastrar email
             * 2 - Listar
             * 3 - Sair 
             * Opção: 
             */

            /*
            List<Emails> emails = new List<Emails>();
            int opc = 0;
            Emails email;

            const string caminho = @"D:\Desenvolvimento\.NET\academiaDotNet_Atos\Exercicios_Lista9\";
            const string nomeArq = "emails.csv";
            const string arq = caminho + nomeArq;

            //popula a list com os dados já no arquivo...
            Util.popularArquivoNaListaEmail(emails, arq);

            //exibir no inicio...            
            Util.mostrarListaEmail(emails);
            //Console.WriteLine();

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" === Cadastro de E-mails ===\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cadastrar um E-mail");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2 - Listar E-mails");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - Sair");
                Console.ResetColor();
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Qual e-mail deseja cadastrar? ");
                        Console.ResetColor();
                        string emailDigitado = Console.ReadLine();
                        string[] filtro = emailDigitado.Split("@");
                        if (filtro.Length > 1)
                        {
                            string usuario = filtro[0];
                            string dominio = filtro[1];
                            if (!dominio.Contains("."))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Favor incluir um e-mail válido.\nÉ necessário possuir ao menos um domínio válido.\n");
                                Console.ResetColor();
                                break;
                            }
                            email = new Emails(emailDigitado, dominio);

                            if (Util.jaNaListaEmail(email, emails))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\n'{emailDigitado}' já está cadastrado!\nUtilize outro\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                emails.Add(email);
                                Util.gravarEmailArquivo(email, arq);
                            }
                        } else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Favor inclua um e-mail completo: 'nome'@'domínio'\n");
                            Console.ResetColor();
                        }
                        break;
                    case 2:
                        Console.Clear();                        
                        Util.mostrarListaEmail(emails);
                        break;
                    case 3: break;
                }
            } while (opc != 3);
            */

            /*
             * 3. Fazer um programa em VS para gerenciar figurinhas da copa. O programa deve 
             * possuir um Menu 
             * 
             * Menu
             * 1 - Cadastrar figurinha repetida
             * 2 - Cadastrar figurinha faltante
             * 3 - Listar figurinhas repetidas
             * 4 - Listar figurinhas faltantes
             * 5 - Sair
             * Opção:
             * 
             * Para este programa, usar a classe Figurinha (codigo_figurinha, selecao, 
             * nome_jogador), lista que armazena as figurinhas em memória, arquivo .csv com os 
             * dados das figurinhas persistidos em disco.
             * 
             * Para as figurinhas repetidas, deve haver uma lista e um arquivo .csv; o mesmo para 
             * as figurinhas faltantes.
             */
            
            List<Figurinha> listaRepetidas = new List<Figurinha>();
            List<Figurinha> listaFaltantes = new List<Figurinha>();
            int opcao;

            //conectar com a base de dados
            //Util.popularArquivoNaListaFigurinha(listaRepetidas, "repetidas.csv");
            //Util.popularArquivoNaListaFigurinha(listaFaltantes, "faltantes.csv");

            do
            {
                Console.WriteLine("1 - Cadastrar figurinha Repetida");
                Console.WriteLine("2 - Cadastrar figurinha Faltante");
                Console.WriteLine("3 - Listar figurinha Repetida");
                Console.WriteLine("4 - Listar figurinha Faltante");
                Console.WriteLine("5 - Sair");
                Console.Write("\nOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        break;
                        case 2:
                        break;
                        case 3:
                        break;
                        case 4:
                        break;
                        case 5:
                        break;
                        default: break;
                }
            } while (opcao != 5);

        }
    }
>>>>>>> 7442f99 (Updating exercises lists)
}