using Exercicios_Lista8.Exercicio6;
using Exercicios_Lista8.Exercicio7;

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

            /*
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
            */

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
            List<Asteroides> ast = new List<Asteroides>();
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
                        Console.Write("Informe a posição X inicial: ");
                        float posX = float.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Informe a posição Y inicial: ");
                        float posY = float.Parse(Console.ReadLine());
                        int tam;
                        do
                        {
                            Console.Clear();
                            Console.Write("Informe o tamanho do asteróide: ");
                            tam = int.Parse(Console.ReadLine());

                            if (tam < 1 || tam > 10)
                            {
                                Console.Clear();
                                Console.Write("Informe um tamanho válido para o asteróide (1 - 10): ");
                                tam = int.Parse(Console.ReadLine());
                            }
                        } while (tam < 1 || tam > 10);
                        int velocidade;
                        do
                        {
                            Console.Clear();
                            Console.Write("Informe a velocidade do asteróide: ");
                            velocidade = int.Parse(Console.ReadLine());

                            if (velocidade < 1 || velocidade > 5)
                            {
                                Console.Clear();
                                Console.Write("Informe uma velocidade válida para o asteróide (1 - 5): ");
                                velocidade = int.Parse(Console.ReadLine());
                            }
                        } while (velocidade < 1 || velocidade > 5);
                        int energia;
                        do
                        {
                            Console.Clear();
                            Console.Write("Informe a energia do asteróide: ");
                            energia = int.Parse(Console.ReadLine());

                            if (energia < 1 || energia > 5)
                            {
                                Console.Clear();
                                Console.Write("Informe uma energia válida para o asteróide (1 - 5): ");
                                energia = int.Parse(Console.ReadLine());
                            }
                        } while (energia < 1 || energia > 5);

                        ast.Add(new Asteroides(posX,posY,tam,velocidade,energia));
                        break;

                    case 2:
                        Asteroides.getAsteroides(ast);
                        break;

                    case 3:
                        break;
                }
            } while (opc != 3);

            Console.Clear();
            Asteroides.getAsteroides(ast);
            */

            /*
             * 4) Crie uma classe para representar um item de cenário, com os atributos privados de:
             * descrição (string), data de criação 
             * (date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
             * altura (float). 
             * 
             * Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método
             * para imprimir todos dados de um item de cenário.
             * Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa 
             * em C# para testar a classe criada.
             */

            /*
            List<Cenario> cena = new List<Cenario>();
            int opc;

            do
            {
                Console.WriteLine(" Cenários \n");
                Console.WriteLine("1 - Registrar um novo cenário");
                Console.WriteLine("2 - Exibir dados de um cenário");
                Console.WriteLine("3 - Exibir tempo de criação do cenário");
                Console.WriteLine("4 - Encerrar");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("Informe a descrição do cenário: ");
                        string descricao = Console.ReadLine();
                        Console.Write("Informa a data (01/01/2022 00:00:00) \nou deixe vazio para usar a data e hora atual: ");
                        var data = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(data))
                        {
                            data = DateTime.Now.ToString();
                        }

                        DateTime dataValidada;
                        DateTime.TryParse(data, CultureInfo.CurrentCulture, DateTimeStyles.None, out dataValidada);

                        Console.Write("Informe a altura do cenário: ");
                        float altura = float.Parse(Console.ReadLine());

                        cena.Add(new Cenario(descricao, dataValidada, altura));

                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Qual cenário deseja exibir (informe o índice)? ");
                        int index = int.Parse(Console.ReadLine());
                        index--;
                        Console.WriteLine("\nCenários:");
                        Cenario.DetalhesCenario(cena, index);
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Qual cenário deseja exibir o tempo de criação (informe o índice)? ");
                        index = int.Parse(Console.ReadLine());
                        index--;
                        Cenario.TempoItem(cena, index);
                        break;
                    case 4: break;
                }
            } while (opc != 4);
            */

            /*
             * 5) Crie uma classe para representar um objeto em um Plano Cartesiano. 
             * Todo objeto no plano cartesiano tem como atributos 'x' e 'y'. Dessa forma, 
             * crie os getters e setter de 'x' e 'y', o construtor básico e um método para
             * exibir um objeto (x,y).
             * Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), 
             * um método de que exiba os objetos da lista.
            */

            /*
            List<Cartesiano> cart = new List<Cartesiano>();
            int opc;
            int quant = 0;

            do
            {
                Console.WriteLine(" Plano Cartesiano \n");
                Console.WriteLine("1 - Registrar um novo plano");
                Console.WriteLine("2 - Exibir dados de um plano");
                Console.WriteLine("3 - Exibir lista de planos");
                Console.WriteLine("4 - Encerrar");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Informe o valor de X: ");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("Informe o valor de Y: ");
                        double y = double.Parse(Console.ReadLine());

                        cart.Add(new Cartesiano(x, y));
                        quant++;
                        Console.WriteLine($"Valor registrado no índice {quant}");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Qual índice gostaria de consultar? ");
                        int indice = int.Parse(Console.ReadLine());
                        indice--;
                        Cartesiano.getXY(cart, indice);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Planos Cartesianos:\n");
                        foreach (var c in cart) {
                            Console.WriteLine($"X: {c.X}  |  Y: {c.Y}");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!\n");
                        break;
                }
            } while (opc != 4);
            */

            /*
             * 6) Crie uma classe para funcionário. Ele deve ter o nome do funcionário, o 
             * departamento onde trabalha, seu salário (double), a data de entrada no banco
             * (String), seu RG (String) e um valor booleano que indique se o funcionário
             * ainda está ativa na empresa no momento ou se já foi mandado embora.
             * Você deve criar alguns métodos de acordo com sua necessidade. Além deles,
             * crie um método bonifica que aumenta o salario do funcionário de acordo com o
             * parâmetro passado como argumento. Crie, também, um método demite, que não 
             * recebe parâmetro algum, só modifica o valor booleano indicando que o 
             * funcionário não trabalha mais aqui.
             * Crie uma lista de funcionários e faça um menu iterativo onde você pode inserir
             * e consultar todos os funcionários cadastratos.
             * 
             * Utilizando o exercício anterior, faça um método abstrato na classe funcionário
             * chamado "ExecutaTrabalho". Haverá duas implementações da classe Funcionario 
             * chamada de Gerente e Operador.
             * Nos metodos de cada uma das classes Gerente e Operador deverá aparecer a
             * mensagem informando qual é a função desempenhada pelo funcionário
             */

            /*
            List<Funcionario> func = new List<Funcionario>();
            int opc;

            do
            {
                Console.WriteLine(" === Bem-vindo ao sistema de funcionários === \n");
                Console.WriteLine("1 - Registrar um novo funcionário");
                Console.WriteLine("2 - Exibir todos os funcionários");
                Console.WriteLine("3 - Bonificar um funcionário");
                Console.WriteLine("4 - Demitir um funcionário");
                Console.WriteLine("5 - Encerrar");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("Informe o nome do funcionário: ");
                        string nome = Console.ReadLine();
                        Console.Write($"Informe o departamento do funcionário '{nome}': ");
                        string departamento = Console.ReadLine();
                        Console.Write($"Informe o salário do funcionário '{nome}': ");
                        double salario = double.Parse(Console.ReadLine());
                        Console.Write($"Informe a data de entrada do funcionário '{nome}' \n(01/01/2022) ou pressione Enter para a data de hoje: ");
                        string data = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(data))
                        {
                            data = DateTime.Now.ToShortDateString();
                        }
                        Console.Write($"Informe o RG do funcionário '{nome}': ");
                        string rg = Console.ReadLine();

                        func.Add(new Funcionario(nome, departamento, salario, data, rg, true));
                        Console.WriteLine($"\n'{nome}' cadastrado com sucesso!\n");
                        break;
                    case 2:
                        Console.Clear();
                        foreach (var f in func)
                        {
                            Console.WriteLine($"Funcionário: {f.Nome}  |  Departamento: {f.Departamento}  |  Salário: {f.Salario:C}");
                            Console.Write($"Contratado em: {f.DataEntrada}  |  RG: {f.Rg}  |  ");
                            if (f.Ativo)
                            {
                                Console.WriteLine($"Situação atual: 'Admitido'");
                            }
                            else
                            {
                                Console.WriteLine($"Situação atual: 'Demitido'");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:

                        break;
                }
            } while (opc != 5);
            */

            /*
             * 7) Crie um dicionário que faça o armazenamento de Livros. Os dados para serem
             * armazenados serão o nome do livro e a quantidade de páginas. Em um menu inicial,
             * possibilite que o usuário do sistema possa cadastrar, consultar todos livros 
             * cadastrados ou pesquisar pelo nome do livro.
            */

            Dictionary<string, int> livros = new Dictionary<string, int>();
            int opc;

            do
            {
                Console.WriteLine(" === Bem-vindo ao sistema de Livros === \n");
                Console.WriteLine("1 - Registrar um novo livro");
                Console.WriteLine("2 - Exibir todos os livros");
                Console.WriteLine("3 - Pesquisar um livro");
                Console.WriteLine("4 - Encerrar");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Informe o nome do livro: ");
                        string livro = Console.ReadLine();
                        Console.Write($"Informe a quantidade de páginas do livro '{livro}': ");
                        int paginas = int.Parse(Console.ReadLine());

                        livros.Add(livro, paginas);
                        Console.WriteLine($"'{livro}' cadastrado com sucesso!\n");
                        break;
                    case 2:
                        Console.Clear();
                        foreach (var l in livros)
                        {
                            Console.WriteLine($"Titulo: {l.Key}  |  Páginas: {l.Value}");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Informe o título do livro a ser localizado: ");
                        string titulo = Console.ReadLine();
                        int result;
                        if (livros.ContainsKey(titulo))
                        {
                            livros.TryGetValue(titulo, out result);
                            Console.WriteLine($"Titulo: {livros.Select(x => x.Key).First()}  |  Páginas: {result}");
                        }
                        else
                        {
                            Console.WriteLine("\nTítulo não encontrado. Verifique a ortografia e tente novamente.\nObs.: Maiúsculos e minúsculos são diferentes.\n");
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!\n");
                        break;
                }
            } while (opc != 4);


        }
    }
}