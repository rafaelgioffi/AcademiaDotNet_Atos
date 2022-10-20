using System.Security.Cryptography.X509Certificates;

namespace Exercicios_Lista9
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
            
            List<Pessoa> emails = new List<Pessoa>();
            int opc = 0;
            Pessoa pessoa;

            const string caminho = @"D:\Desenvolvimento\.NET\academiaDotNet_Atos\Exercicios_Lista9\";
            const string arq = caminho + "emails.csv";            

            //popula a list com os dados já no arquivo...
            Util.popularArquivoNaListaPessoa(emails, arq);
            
            //exibir no inicio...
            Console.WriteLine("E-mails já cadastrados");
            Util.mostrarListaPessoa(emails);
            Console.WriteLine();

            do
            {
                Console.WriteLine(" === Cadastro de Nomes ===");
                Console.WriteLine("1 - Cadastrar um E-mail");
                Console.WriteLine("2 - Listar E-mails");
                Console.WriteLine("3 - Sair");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch(opc)
                {
                    case 1:
                        Console.Write("Qual nome deseja cadastrar? ");
                        string nome = Console.ReadLine().ToUpper();
                        
                        Console.Write($"Qual e-mail do(a) '{nome}'? ");
                        string email = Console.ReadLine().ToLower();

                        pessoa = new Pessoa(nome, email);

                        if (Util.jaNaListaPessoa(pessoa, nomes))
                        {
                            Console.WriteLine("Esse nome já está cadastrado!\nUtilize outro");
                        }
                        else
                        {
                            nomes.Add(pessoa);
                            Util.gravarPessoaArquivo(pessoa, arq);
                        }
                        break;
                case 2:
                        Console.Clear();
                        Console.WriteLine("Pessoas cadastradas:");
                        Util.mostrarListaPessoa(nomes);
                break;
                    case 3: break;
                }
            } while (opc != 3);

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

            /*
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
            */

        }
    }
}