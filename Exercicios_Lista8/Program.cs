using Exercicios_Lista8.Exercicio1;
using Exercicios_Lista8.Exercicio2;

namespace Exercicios_Lista8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1) Implemente um programa em C# no qual o usuário deverá informar o nome e o poder
             * (0 a 10) de três personagens.
             * O programa deverá informar o nome do personagem que possuir o maior poder.
             * Regras que deverão ser seguidas para a implementação do algoritmo:
             * 
             * É obrigatório o uso de classe para representar um Personagem e a mesma deverá 
             * possuir como propriedades (características) um nome e um poder.
             * A classe também deverá possuir um método chamado ExibirDados. Esse método deverá 
             * exibir o nome e o poder do personagem em questão. 
             * Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga),
             * um que não recebe parâmetro algum e outro que irá receber o nome e o poder de um
             * personagem
             */

            /*
            int persons = 0, opc = 0;

            List<Personagem> person = new List<Personagem>();

            while (persons < 3)
            {
                Console.WriteLine("\n== Bem vindo ao sistema de personagens ===");
                Console.WriteLine("1 - Cadastrar Personagem");
                Console.WriteLine("2 - Listar Personagens");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha sua opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("\nInforme o nome do personagem: ");
                        string nome = Console.ReadLine();
                        int poder;
                        do
                        {
                            Console.Write("Informe o poder do personagem '{0}': ", nome);
                            poder = int.Parse(Console.ReadLine());
                            if (poder < 0)
                            {
                                Console.WriteLine("Poder inválido. Valor mínimo: 0\n");
                            }
                            else if (poder > 10)
                            {
                                Console.WriteLine("Poder inválido. Valor máximo: 10\n");
                            }
                        } while (poder < 0 && poder > 10);

                        person.Add(new Personagem(nome, poder));
                        persons++;
                        break;
                    case 2:
                        Personagem.MaisPoderoso(person);
                        break;
                    case 3:
                        persons = 3;
                        break;
                }
            }
            Personagem.MaisPoderoso(person);
            */

            /*
             * 2) Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de
             * cinco animais de estimação. O programa deverá exibir na tela para o usuário quantos
             * Cachorros, Gatos e Peixes foram informados.
             * 
             * Regras que deverão ser seguidas para a implementação do programa:
             * 
             * Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
             * Caso seja informado um tipo diferente o programa repetir até o usuário digitar um
             * tipo válido. É obrigatório criar uma classe para representar o Animal.
             * A classe deverá possuir dois dados privados (propriedades) para representar as
             * características do animal.
             * A classe deverá possuir métodos de acesso (propriedade getter e setter) para 
             * permitir que o usuário armazene/leia os dados dos dois dados privados 
             * (propriedades).
            */

            
            string nome, tipo;
            int quant = 0, tp;

            List<Animal> animal = new List<Animal>();

            while (quant < 5)
            {
                Console.Clear();
                Console.Write("Informe o nome do animal: ");
                nome = Console.ReadLine();
                do
                {
                    Console.WriteLine("Informe o tipo do animal: ");
                    Console.WriteLine("1 - Cachorro");
                    Console.WriteLine("2 - Gato");
                    Console.WriteLine("3 - Peixe");
                    Console.Write("\nSua escolha: ");
                    tp = int.Parse(Console.ReadLine());

                    switch (tp)
                    {
                        case 1:
                            tipo = "Cachorro";                            
                            break;
                        case 2:
                            tipo = "Gato";                            
                            break;
                        case 3:
                            tipo = "Peixe";                            
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            tipo = "inválido";
                            break;
                    }
                } while (tipo != "Cachorro" && tipo != "Gato" && tipo != "Peixe");
                animal.Add(new Animal(nome, tipo));
                quant++;
            }
            Console.Clear();
            Animal.ExibeAnimais(animal);
            

            /*
             * 3) Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os 
             * asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que
             * represente uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso,
             * faça uma classe que contenha os atributos (privados) posição x, posição y
             * (do asteroide em um plano cartesiano), tamanho do asteroide (1 a 10), velocidade 
             * do asteroide (1 a 5) e energia (1 a 5). 
             * Para esses atributos privados, gerar os métodos de acesso (propriedades getter
             * e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro
             * passando todos os parâmetros de um objeto tipo Asteroide, e um terceiro que
             * constrói um asteroide com posição x e posição y.
             * O programa principal (main) deve conter a lista de Asteroides, preenchida pelo
             * usuário. Nesse programa principal, construir um método de classe que exiba todos
             * os asteróides da lista.
            */

            /*
            Asteroides ast = new Asteroides();
            List<Asteroides> ast2 = new List<Asteroides>();
            int opc = 0;

            do
            {
                Console.WriteLine("=== Jogo dos Asteroides ===\n");
                Console.WriteLine("1 - Registrar um novo asteróide");
                Console.WriteLine("2 - Exibir todos os asteróides");
                Console.WriteLine("3 - Encerrar");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch(opc)
                {
                    case 1:
                        
                }
            } while (opc != 3);

            Console.Clear();
            ast.getAsteroides();
            */
        }
    }
}