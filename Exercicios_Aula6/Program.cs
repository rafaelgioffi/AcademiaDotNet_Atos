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

            /*
             * Ex. 2:
             * Fazer um programa em VS que popule uma lista com números inteiros (0 a 1000) que sejam
             * sorteados randomicamente. O programa deve pedir ao usuário quantos números deseja
             * armazenar. Ao final, o programa deve exibir os números populados na lista.
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