using System.Collections.Generic;

namespace Exercicios_Aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex. 1:
             * Fazer um programa em VS que popule uma lista de nomes, com nomes completos
             * obrigatoriamente. Ao cadastrar o nome na lista, o nome deve ser validado para que 
             * tenha no mínimo duas palavras e que não esteja na lista. Ao final, caso o nome não
             * esteja na lista, cadastra-lo em maiúsculo e exibir a lista ordenada.
             */

            /*
            List<string> nomes = new List<string>();
            string nome;
            string[] valida;

            do
            {                
                Console.WriteLine("*** Sistema de cadastro de nomes ***");
                Console.Write("\nCadastre um nome ou 'sair' para encerrar: ");
                nome = Console.ReadLine().ToUpper();

                if (nome == "SAIR")
                {
                    break;
                }

                valida = nome.Split(" ");
                 
                if (valida.Length > 1)
                {
                    //verifica se o nome já está na lista
                    if (nomes.Contains(nome))
                    {
                        Console.Clear();
                        Console.WriteLine("\nO nome '{0}' já está cadastrado na lista. Favor insira outro.", nome);
                    }
                    else
                    {
                        //nome validado, cadastrando...
                        nomes.Add(nome);
                        Console.Clear();
                        Console.WriteLine("Nome cadastrado!\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nFavor insira seu nome completo. Você informou um nome com apenas {0} palavra\n", valida.Length);
                }

            }
            while (true);

            Console.Clear();

            Console.WriteLine("Cadastramos {0} nomes!\nExibindo os nomes:\n", nomes.Count);

            nomes.Sort();

            foreach (string n in nomes)
            {
                Console.WriteLine(n);
            }
            */

            /*
             * Ex. 2:
             * Fazer um programa em VS que popule uma lista com números inteiros (0 a 1000) que sejam
             * sorteados randomicamente. O programa deve pedir ao usuário quantos números deseja
             * armazenar. Ao final, o programa deve exibir os números populados na lista.
             */

            /*
            Random random = new Random();
            List<int> numeros = new List<int>();
            int quant;

            Console.Write("Favor informe quantos números deseja gerar aleatóriamente: ");
            quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                numeros.Add(random.Next(0, 1000));
            }

            Console.Clear();
            
            foreach (int n in numeros)
            {
                Console.WriteLine("Número {0}: {1}", numeros.IndexOf(n) + 1, n);
            }
            */

            /*
             * Ex. 3:
             * Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair 
             * do programa. Os emails digitados devem ser cadastrados em uma lista e não pode haver 
             * emails duplicados, ou seja, o programa deve controlar essa situação. Quando o usuário
             * solicitar a listagem dos emails, além dessa lista, o programa deve listar os domínios
             * de emails cadastrados no programa.
             * 
             * Menu
             * 1 - Cadastrar email
             * 2 - Listar 
             * 3 - Sair 
             * Opção: 
             */

            /*
            List<string> emails = new List<string>(), dominios = new List<string>();
            int opcao=0;
            string email;
            string[] partEmailFull, partEmail;

            do
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1 - Cadastrar email");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Sair\n");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("\nCadastre o e-mail desejado: ");
                    email = Console.ReadLine();

                    //break string in array to filter data..
                    //quebra a string em array para filtrar os dados..
                    partEmail = email.Split('@');
                    partEmailFull = email.Split('@','.');
                                        
                    //Check if the email is valid. If it has at least two parts, that is, a value before and one after the @
                    //verifica se o email é válido... Se possui ao menos 2 partes, ou seja, um valor antes do @ e um depois...
                    if (partEmailFull.Length < 3)
                    {
                        Console.Clear();
                        Console.WriteLine("\nFavor preencher o e-mail em um formato válido!\nseu_e-mail@domínio.com\n");
                    }
                    else
                    {
                        //check if email is no longer in list...
                        //verifica se o e-mail já não existe na lista...
                        if (emails.Contains(email))
                        {
                            Console.WriteLine("\nE-mail já cadastrado! Favor utilizar outro.\n");
                        }
                        //if all rigth, add email in list
                        //se tudo estiver certo, insere o email na lista
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("E-mail cadastrado!\n");
                            emails.Add(email);

                            if (!dominios.Contains(partEmail[1])) {
                                dominios.Add(partEmail[1]);
                            }
                        }
                    }                    
                }

                if (opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("E-mails cadastrados: {0}\n", emails.Count);
                    foreach (string em in emails)
                    {
                        Console.WriteLine(em);
                    }

                    Console.WriteLine("\nDomínios: {0}\n", dominios.Count);

                    foreach(string dom in dominios)
                    {
                        Console.WriteLine(dom);
                    }
                    Console.WriteLine();
                }

            } while (opcao != 3);
            */

            /* Ex. 4:
             * Fazer um programa em VS que realize um CRUD (inserir, pesquisar, atualizar e deletar)
             * completo em uma lista de nomes de criptomoedas. Neste programa, somente o nome da
             * criptomoeda deve ser cadastrado (em maiúsculo). Ao cadastrar, não pode haver
             * duplicidade de dados na lista. Sempre que a opção listar for acionada, a listagem deve 
             * ser exibida de forma ordenada. No processo de remoção, o usuário entra com o nome da 
             * criptomoeda que deseja remover. Caso o programa a encontre, deve remover e avisar o 
             * usuário que a operação ocorreu corretamente, e caso não a encontre, avisar ao usuário 
             * que nome não foi encontrado.
             * 
             * Menu 
             * 1 - Cadastrar criptomoeda 
             * 2 - Listar criptomoedas
             * 3 - Remover criptomoeda
             * 4 - Sair
             * Opção: 
             */

            List<string> cripto = new List<string>();
            int opcao=0;
            string criptoDigit;

            do
            {
                Console.WriteLine("==== Menu ====");
                Console.WriteLine("1 - Cadastrar criptomoeda");
                Console.WriteLine("2 - Listar criptomoedas");
                Console.WriteLine("3 - Remover criptomoeda");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("\nCadastre a criptomoeda desejada: ");
                    criptoDigit = Console.ReadLine().ToUpper();

                    if (cripto.Contains(criptoDigit))
                    {
                        Console.WriteLine("\nCriptomoeda já cadastrada! Favor utilizar outra.\n");
                    }
                }
            }
            while (opcao != 4);

            

            /*
             * Ex. 5:
             * Crie um programa em VS que popule duas listas (lista1 e lista2) com números aleatórios
             * (100 a 200). A quantidade de números deve ser informada pelo usuário. Em seguida, o
             * programa deve listar os conteúdos das duas listas e exibir os números que aparecem em
             * ambas as listas.
             */

            /*
             * Ex. 6:
             * Continuação do exercício 1. Entretanto, quando listar os nomes, mostrar somente os
             * sobrenomes. Além disso, o programa deve mostrar as pessoas que são da mesma família.
             */

        }
    }
}