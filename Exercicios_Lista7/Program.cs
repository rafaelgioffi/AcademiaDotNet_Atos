using Exercicios_Lista7.Exercicio6;

namespace Exercicios_Lista7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1 - Crie uma classe Livro que represente os dados básicos de um livro.
             * Faça a leitura pelo teclado dos atributos e crie um construtor para fazer
             * o instanciamento. 
            */

            /*
            Console.Write("Informe o título do livro: ");
            string titulo = Console.ReadLine();

            Console.Write("Informe o autor do livro '{0}': ", titulo);
            string autor = Console.ReadLine();

            Console.Write("Informe o ISBN do livro '{0}': ", titulo);
            string isbn = Console.ReadLine();

            Console.Write("Informe o número de páginas do livro '{0}': ", titulo);
            int paginas = int.Parse(Console.ReadLine());

            Console.Write("Informe o tipo de capa do livro '{0}',\n'Dura' ou 'Fina': ", titulo);
            string capa = Console.ReadLine();

            Livro livro = new Livro(titulo,autor,isbn,paginas,capa);
            livro.getLivro();
            */

            /*
            * 2 - Escreva uma classe Pessoa contendo todos os atributos de uma pessoa.
            * Faça métodos para apresentar os dados.
            */

            /*
            Console.Write("Informe o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a idade do(a) '{0}': ", nome);
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o peso do(a) '{0}': ", nome);
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do(a) '{0}': ", nome);
            double altura = double.Parse(Console.ReadLine());

            string sexo;
            do
            {
                Console.Write("Informe o sexo do(a) '{0}'. (m)asculino ou (f)eminino: ", nome);
                sexo = Console.ReadLine();

                if (sexo == "m" || sexo == "M")
                {
                    sexo = "Masculino";
                    break;
                }
                else if (sexo == "f" || sexo == "F")
                {
                    sexo = "Feminino";
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida!\nUtilize apenas 'm' ou 'f'");
                }
            } while (sexo != "m" && sexo != "M" && sexo != "f" && sexo != "F");

            Console.Write("Informe a cor do olhos do(a) '{0}': ", nome);
            string olhos = Console.ReadLine();

            Console.Write("Informe a cor dos cabelos do(a) '{0}': ", nome);
            string cabelo = Console.ReadLine();

            Console.Write("Informe a raça do(a) '{0}': ", nome);
            string raca = Console.ReadLine();            

            Pessoa pessoa1 = new Pessoa(nome, idade, altura, peso, sexo, olhos, cabelo, raca);
            pessoa1.getPessoa();
            */

            /*
             * 3 - Faça um programa para controlar o aluguel de carros. Deve ter as classes Carro,
             * aluguel e cliente.
             */

            /*
            Exercicio3.Carro carro = new Exercicio3.Carro();
            carro.setPlaca("ABC-1234");
            carro.setModelo("Chevrolet Prisma");
            carro.setCor("Prata");

            Exercicio3.Cliente cliente = new Exercicio3.Cliente();
            cliente.setNome("José da Silva");
            cliente.setCpf("123.456.789-10");
            cliente.setTelefone("(22)99988-7766");
            cliente.setEmail("jose@gmail.com");

            Exercicio3.Aluguel aluguel = new Exercicio3.Aluguel();
            aluguel.alugar(DateTime.Parse("9/10/2022 11:00:00 AM"), DateTime.Parse("13/10/2022 12:00:00"), 80);
            aluguel.carro = carro;
            aluguel.cliente = cliente;
            Console.WriteLine("Aluguel realizado com sucesso! O valor total de {0:C}.", aluguel.valorAluguel());
            */

            /*
             * 4 - Faça um programa que represente a arvore genealógica da tua familia. Para isso,
             * uma classe Pessoa precisa ser indicar quem são seus pais, alem de informações 
             * básicas sobre a pessoa.
             */

            /* minha solução

            Console.Write("Informe o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a idade do(a) '{0}': ", nome);
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o peso do(a) '{0}': ", nome);
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do(a) '{0}': ", nome);
            double altura = double.Parse(Console.ReadLine());

            string sexo;
            do
            {
                Console.Write("Informe o sexo do(a) '{0}'. (m)asculino ou (f)eminino: ", nome);
                sexo = Console.ReadLine();

                if (sexo == "m" || sexo == "M")
                {
                    sexo = "Masculino";
                    break;
                }
                else if (sexo == "f" || sexo == "F")
                {
                    sexo = "Feminino";
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida!\nUtilize apenas 'm' ou 'f'");
                }
            } while (sexo != "m" && sexo != "M" && sexo != "f" && sexo != "F");

            Console.Write("Informe a cor do olhos do(a) '{0}': ", nome);
            string olhos = Console.ReadLine();

            Console.Write("Informe a cor dos cabelos do(a) '{0}': ", nome);
            string cabelo = Console.ReadLine();

            Console.Write("Informe a raça do(a) '{0}': ", nome);
            string raca = Console.ReadLine();

            Console.Write("Informe o nome do pai do(a) '{0}': ", nome);
            string pai = Console.ReadLine();

            Console.Write("Informe o nome da mãe do(a) '{0}': ", nome);
            string mae = Console.ReadLine();

            Familia familia = new Familia(nome, idade, altura, peso, sexo, olhos, cabelo, raca, pai, mae);
            familia.getFamilia();
            */

            /*
            Exercicio4.Pessoa pessoaFilho = new Exercicio4.Pessoa();
            pessoaFilho.idade = 12;
            pessoaFilho.nome = "Diego";

            Exercicio4.Pessoa pessoaMae = new Exercicio4.Pessoa();
            pessoaMae.nome = "Erika";
            pessoaMae.idade = 35;

            Exercicio4.Pessoa pessoaPai = new Exercicio4.Pessoa();
            pessoaPai.nome = "Sergio";
            pessoaPai.idade = 31;

            Exercicio4.Pessoa pAvoPai = new Exercicio4.Pessoa();
            pAvoPai.nome = "João";
            pAvoPai.idade = 80;

            Exercicio4.Pessoa pAvohPai = new Exercicio4.Pessoa();
            pAvohPai.nome = "Josefina";
            pAvohPai.idade = 78;

            pessoaPai.pai = pAvoPai;
            pessoaPai.mae = pAvohPai;
            pessoaFilho.mae = pessoaMae;
            pessoaFilho.pai = pessoaPai;
            */

            /*
             * 5 - Identifique as classes e implemente um programa para a seguinte especificação:
             * "O supermercado vende diferentes tipos de produtos. Cada produto tem um preço e uma
             * quantidade em estoque. Um pedido de	um cliente é composto de itens,	onde cada item
             * especifica o	produto que o cliente deseja e a respectiva quantidade. Esse pedido 
             * pode	ser	pago em	dinheiro, cheque ou cartão."
             */

            /*
            Produto prod1 = new Produto();
            prod1.nome = "Arroz 5kg";
            prod1.quantidadeEstoque = 150;
            prod1.valorUnit = 9.79;
            prod1.valorVenda = 16;

            Pedido pedido1 = new Pedido();
            pedido1.quantPedido = 2;
            pedido1.formaPagamento = "Vale-Alimentação";
            pedido1.produto = prod1;
            pedido1.calcularPedido();
            */

            /*
             * 6 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de
             * realizar as seguintes operações:
             * void armazenaPessoa(String nome, int idade, float altura);
             * void removePessoa(String nome);
             * int buscaPessoa(String nome); // informa em que posição da agenda está a pessoa
             * void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
             */

            Agenda ag1 = new Agenda();
            string nome;
            int opc=5, nomes=0, idade, id;
            float altura;

            do
            {
                Console.WriteLine("=== Sistema de Agenda ===");
                Console.WriteLine("1 - Cadastrar Pessoa ({0})", nomes);
                Console.WriteLine("2 - Remover Pessoa");
                Console.WriteLine("3 - Localizar Pessoa");
                Console.WriteLine("4 - Listar agenda");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha sua opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {                    
                    case 1:
                        Console.Clear();
                        Console.Write("Informe o nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Informe a idade: ");
                        idade = int.Parse(Console.ReadLine());
                        Console.Write("Informe a altura: ");
                        altura = float.Parse(Console.ReadLine());

                        ag1.armazenaPessoa(nome,idade,altura);                        
                        nomes++;
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Qual nome deseja remover? ");
                        ag1.removePessoa(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Informe o nome que deseja localizar: ");
                        nome = Console.ReadLine();
                        id = ag1.buscaPessoa(nome);
                            Console.Clear();
                            Console.WriteLine("Nome: {0}", ag1.pessoa[id].nome);
                            Console.WriteLine("{0} anos", ag1.pessoa[id].idade);
                            Console.WriteLine("{0}m de altura\n", ag1.pessoa[id].altura);
                        break;
                    case 4:
                        ag1.imprimeAgenda();
                        break;
                }

                if (nomes > 9) { break; }
            
            } while (opc != 0);



        }
    }
}