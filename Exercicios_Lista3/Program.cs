using System.Drawing;
using static System.ConsoleColor;

namespace Exercicios_Lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista de exercícios 3

            /* Ex.: 1.
            * Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando
            * a entrada de dados (informando se ele estiver errado e repetindo a solicitação até
            * que esteja correto). Após o programa em VS deve informar todos os números pares 
            * existentes entre 1 e o número fornecido pelo usuário.
            * Exemplo:
            * Digite um número inteiro positivo: -8
            * Valor incorreto!
            * Digite um número inteiro positivo: 8
            * Numero digitado: 8
            * Números inteiros pares entre 1 e 8: 2, 4, 6.
            */

            /*
            int numero;

            Console.Write("Informe um número positivo: ");
            numero = int.Parse(Console.ReadLine());

            while (numero <= 0)
            {
                Console.Clear();
                Console.Write("Informe um número positivo: ");
                numero = int.Parse(Console.ReadLine());            
            }

            Console.Write("Números inteiros pares entre 1 e {0}: ",numero);

            for (int i = 1; i < numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ",i);
                }
            }
            */

            /* Ex. 2
             * Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele
             * deseja informar um outro número. Caso positivo, o programa em VS deve ser repetido.
             * Exemplo:
             * Digite um número inteiro positivo: 8
             * Numero digitado: 8
             * Números inteiros pares entre 1 e 8: 2, 4, 6.
             * 
             * Deseja informar outro número (s/n)? S
             * 
             * Digite um número inteiro positivo: 12
             * Numero digitado: 20
             * Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
             * 
             * Deseja informar outro número (s/n)? N 
            */

            /*
            int numero;
            char opcao = 's';

            while (opcao == 's' || opcao == 'S')
                {
                    Console.Write("Informe um número positivo: ");
                    numero = int.Parse(Console.ReadLine());

                    while (numero <= 0)
                    {
                        Console.Clear();
                        Console.Write("Informe um número positivo: ");
                        numero = int.Parse(Console.ReadLine());            
                    }

                    Console.Write("Números inteiros pares entre 1 e {0}: ",numero);

                    for (int i = 1; i < numero; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("{0} ",i);
                        }
                    }
                        Console.Write("\n\nDeseja informar outro número? (s)im ou (n)ão? ");
                        opcao = char.Parse(Console.ReadLine());
                }
              */

            /*Ex.: 3
             * Fazer um laço (repetição) que fique solicitando números ao usuário. Se o usuário 
             * digitar 0 o programa em VS deve parar. Caso contrário, o programa em VS deve 
             * informar se o número é par ou ímpar e se ele é um número primo.
             */

            /*
            int numero=1;
            string resultado="";

            while (numero != 0)
            {
                Console.Write("Informe um número (0 para parar): ");
                numero = int.Parse(Console.ReadLine());
                Console.Clear();

                if (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("{0} é par.", numero);
                    }
                    else
                    {
                        Console.WriteLine("{0} é ímpar.", numero);
                    }

                    if (numero == 1)
                    {

                        Console.WriteLine("{0} não pode ser número primo. O cálculo só pode ser realizado a partir de 2.\n", numero);
                    }
                    else if (numero > 1)
                    {

                        for (int i = 2; i < numero; i++)
                        {
                            int resto = numero % i;
                            if (resto == 0)
                            {
                                resultado = numero + " não é um número primo.";
                                i = numero + 1;
                            }
                            else
                            {
                                resultado = numero + " é um número primo.";
                            }
                        }

                        Console.WriteLine(resultado + "\n");
                    }
                }
            }
            */

            /* Ex. 4
             * Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
             * Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
             * Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. 
             * O mesmo para ZECA. Você também pode aceitar votos em branco (palavra BRANCO). 
             * O programa em VS termina quando o usuário escrever FIM. Ao final devem ser mostradas
             * as quantidades de votos para cada um dos candidatos e o número de votos em branco. 
            */

            /*
            int joao=0, zeca=0, brancos=0;
            string opcao="";
            
            while (opcao != "FIM")
            {
                if (opcao != "JOAO" && opcao != "ZECA" && opcao != "BRANCO" && opcao != "")
                {
                    Console.Clear();
                   
                    Console.WriteLine("Opção inválida\n");
                    Console.WriteLine("Escolha uma opção de voto:\n");
                    Console.WriteLine("JOAO para votar em João");
                    Console.WriteLine("ZECA para votar em Zeca");
                    Console.WriteLine("BRANCO para votar em branco");
                    Console.WriteLine("FIM para encerrar a votação");

                    Console.Write("\nInforme sua opção: ");
                    opcao = Console.ReadLine().ToUpper();

                }
                if (opcao == "JOAO" || opcao == "ZECA" || opcao == "BRANCO" || opcao == "")
                {
                    Console.Clear();
                    
                    Console.WriteLine("Escolha uma opção de voto:\n");
                    Console.WriteLine("JOAO para votar em João");
                    Console.WriteLine("ZECA para votar em Zeca");
                    Console.WriteLine("BRANCO para votar em branco");
                    Console.WriteLine("FIM para encerrar a votação");

                    Console.Write("\nInforme sua opção: ");

                    opcao = Console.ReadLine().ToUpper();
                    switch (opcao)
                    {
                        case "JOAO":
                            joao++;
                            break;

                        case "ZECA":
                            zeca++;
                            break;

                        case "BRANCO":
                            brancos++;
                            break;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("Resultado:\n");
            Console.WriteLine("João: {0}",joao);
            Console.WriteLine("Zeca: {0}",zeca);
            Console.WriteLine("\nVotos brancos: {0}",brancos);
            */

            /* Ex. 5
             * Modifique o programa em VS anterior para aceitar votos nulos (qualquer nome 
             * diferente de FIM, JOAO, ZECA e BRANCO). Ao final, informe o nome do candidato
             * vencedor, o número de votos nulos e o número de pessoas que votaram.
            */

            /*
            int joao = 0, zeca = 0, brancos = 0, nulos=0, total=0;
            string opcao = "";

            while (opcao != "FIM")
            {                
                Console.Clear();
                
                Console.WriteLine("Escolha uma opção de voto:\n");
                Console.WriteLine("JOAO para votar em João");
                Console.WriteLine("ZECA para votar em Zeca");
                Console.WriteLine("BRANCO para votar em branco");
                Console.WriteLine("FIM para encerrar a votação");
                Console.WriteLine("Atenção: Qualquer outro valor diferente desse ANULA o seu voto!");

                Console.Write("\nInforme sua opção: ");

                opcao = Console.ReadLine().ToUpper();
                switch (opcao)
                {
                    case "JOAO":
                        joao++;                        
                        break;

                    case "ZECA":
                        zeca++;
                        break;

                    case "BRANCO":
                        brancos++;
                        break;

                    default:
                        nulos++;
                        break;
                }
                total++;
            }            

            Console.Clear();
            Console.WriteLine("Resultado:\n");
            
            Console.WriteLine("Total de votos: {0}\n", total);
            Console.ForegroundColor = ConsoleColor.Green;

            if (joao > zeca)
            {
                Console.WriteLine("João venceu com {0} votos!", joao);
            }
            else
            {
                Console.WriteLine("Zeca venceu com {0} votos!", zeca);
            }
            Console.ResetColor();

            Console.WriteLine("\nVotos brancos: {0}", brancos);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nVotos nulos: {0}", nulos);
            Console.ResetColor();
            */

            /* Ex. 6
             * Faça um programa em VS que solicite ao o usuário que informe a idade e valide
             * a entrada de dados, ou seja, repita a leitura até que ela esteja correta 
             * (maior do que zero). Ao final, mostre a idade digitada.
            */

            /*
            int idade=0;

            while (idade <= 0)
            {
                Console.Clear();
                Console.Write("Informe uma idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n{0} é uma idade válida!", idade);
            */

            /* Ex. 7
             * Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
             * A cada solicitação, teste se o usuário informou um valor válido.
             * Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco
             * ou se for um número), informe que ele está incorreto e saia do programa em VS.
             * Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou 
             * igual a zero), informe que está errada e saia. Se estiver correta, solicite o 
             * salário. Se ele estiver incorreto (menor ou igual a zero), informe que está
             * incorreto e saia. Se estiver correto, mostre todos os valores lidos.
             */

            /* solução do professor
             * 
            string nome;
            int idade;
            float salario;
            do
            {​
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                if (nome.Any(char.IsDigit) || string.IsNullOrWhiteSpace(nome))
                {​
                    Console.WriteLine("Digite um nome válido!!");
                }​ else
                {​
                    break;
                }​
            }​ while (true);
            do
            {​
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade <= 0)
                {​
                    Console.WriteLine("Digite uma idade válida!!");
                }​ else
                {​
                    break;
                }​
            }​ while (true);
            do
            {​
                Console.Write("Salário: ");
                salario = float.Parse(Console.ReadLine());
                if (salario <= 0)
                {​
                    Console.WriteLine("Digite um salário válido!!");
                }​ else
                {​
                    break;
                }​
            }​ while (true);
            Console.WriteLine("Seus dados são: ");
            Console.WriteLine("Nome: " + nome.ToUpper());
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario);
    

            /* minha solução

            string nome="";
            int idade=0;
            double salario=0;            

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome) || nome.Any(char.IsDigit))
            {
                Console.WriteLine("{0} não é um nome válido! Tente novamente...", nome);
                //corrigindo o bug do console fechando automaticamente
                Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.Read();
            }
            else
            {
                Console.Write("{0}, informe sua idade: ", nome);
                idade = int.Parse(Console.ReadLine());
                
                if (idade <= 0)
                {
                    Console.WriteLine("{0} não é uma idade válida! Tente novamente...", idade);
                    //corrigindo o bug do console fechando automaticamente
                    Console.WriteLine("\nPressione qualquer tecla para sair...");
                    Console.Read();
                }
                else
                {
                    Console.Write("{0}, informe seu salário: ", nome);
                    salario = double.Parse(Console.ReadLine());

                    if (salario <= 0)
                    {
                        Console.Write("Salário inválido! Tente novamente...");
                        //corrigindo o bug do console fechando automaticamente
                        Console.WriteLine("\nPressione qualquer tecla para sair...");
                        Console.Read();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("{0}, {1} anos, {2:C} de salário", nome, idade, salario);
                        //corrigindo o bug do console fechando automaticamente
                        Console.WriteLine("\nPressione qualquer tecla para sair...");
                        Console.Read();
                    }
                }
            }
            */

            /* Ex. 8
             * Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, 
             * solicite-o até que seja. após, informe se ele é par ou impar. Finalmente, pergunte ao 
             * usuário se ele quer repetir o programa em VS.
             */

            /*
            int numero=0;
            char opcao = 's';

            while (opcao == 's' || opcao == 'S')
                {
                    Console.Write("Informe um número inteiro: ");
                    numero = int.Parse(Console.ReadLine());

                    while (numero < 0)
                    {
                        Console.Clear();
                        Console.Write("Informe um número inteiro: ");
                        numero = int.Parse(Console.ReadLine());            
                    }                    

                Console.Write("\nNúmeros pares entre 0 e {0}: ", numero);

                for (int i = 0; i < numero + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("{0} ",i);
                    }
                }

                Console.Write("\n\nDeseja informar outro número? (s)im ou (n)ão? ");
                opcao = char.Parse(Console.ReadLine());
                Console.Clear();
                }
                */

            /* Ex. 9
             * Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas
             * que visitaram o zoológico num determinado dia, imprimindo:
             * Quantas pessoas tem entre 1 e 3 filhos.
             * Quantas pessoas tem entre 4 e 7 filhos.
             * Quantas pessoas tem mais de 8 filhos.
             * Quantas pessoas não tem filhos.
             */

            /*
            int filhos, filhos1a3=0, filhos4a7=0, filhos8=0, filhos0=0;

            for (int i = 1; i < 5; i++)     //usado 5 para fins de testes...
            {
                Console.Write("Informe quantos filhos o visitante {0} possui (0 para nenhum): ",i);
                filhos = int.Parse(Console.ReadLine());
                Console.Clear();

                if (filhos == 0)
                {
                    filhos0++;
                }
                if (filhos >= 1 && filhos <= 3)
                {
                    filhos1a3++;
                }
                if (filhos >= 4 && filhos <= 7)
                {
                    filhos4a7++;
                }
                if (filhos >= 8)
                {
                    filhos8++;
                }
            }

            Console.Clear();
            Console.WriteLine("Visitantes sem filhos: {0}", filhos0);
            Console.WriteLine("Visitantes com 1 a 3 filhos : {0}", filhos1a3);
            Console.WriteLine("Visitantes com 4 a 7 filhos : {0}", filhos4a7);
            Console.WriteLine("Visitantes com mais de 8 filhos : {0}", filhos4a7);

            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 10
             * Ler nome, sexo e idade de 50 pessoas e após imprimir:
             * Número de pessoas do sexo masculino.
             * Número de pessoas do sexo feminino.
             * Número de pessoas com idade inferior a 30 anos.
             * Número de pessoas com idade superior a 60 anos.
             * Média de idade das mulheres.
            */

            /*
            string nome;
            int idade, masculino=0, feminino=0, menosDe30=0, maior60=0, mediaIdadeMulheres=0;
            char sexo;

            for (int i = 1; i <= 5; i++)     //feito com 5 para fins de testes...
            {
                Console.Write("Informe o {0}º nome: ",i);
                nome = Console.ReadLine();
                
                Console.Write("Informe o sexo do(a) {0} (m)asculino ou (f)eminino: ", nome);
                sexo = char.Parse(Console.ReadLine());
                
                Console.Write("Informe a idade do(a) {0}: ", nome);
                idade = int.Parse(Console.ReadLine());

                Console.Clear();

                if (sexo == 'm' || sexo == 'M') { masculino++; }

                if (sexo == 'f' || sexo == 'F')
                {
                    feminino++;
                    mediaIdadeMulheres += idade;
                }

                if (idade < 30) { menosDe30++; }
                else if (idade > 60) { maior60++; }
            }

            mediaIdadeMulheres = mediaIdadeMulheres / feminino;

            Console.Clear();
            Console.WriteLine("Pessoas do sexo masculino: " + masculino);
            Console.WriteLine("Pessoas do sexo feminino: " + feminino);
            Console.WriteLine("Pessoas com menos de 30 anos: " + menosDe30);
            Console.WriteLine("Pessoas com mais de 60 anos: " + maior60);
            Console.WriteLine("Média de idade das mulheres: " + mediaIdadeMulheres);

            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 11
             * Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota 
             * mais baixa, a média aritmética da turma e a quantidade de alunos da turma. 
             * Usar -1 para encerrar a leitura.
             */

            /*
            double nota=0, notaMaisAlta=0, notaMaisBaixa=10, media=0;
            int quantidade=0;

            while (nota != -1)
            {
                    Console.Write("Informe a nota do(a) aluno(a) (use -1 para encerrar): ");
                    nota = double.Parse(Console.ReadLine());

                    if (nota > notaMaisAlta) { notaMaisAlta = nota; }
                    if (nota < notaMaisBaixa && nota > -1) { notaMaisBaixa = nota; }

                    if (nota > -1)
                    {                
                        media += nota;
                        quantidade++;
                    }
            }

            media = media / quantidade;

            Console.WriteLine("\nNota mais alta: {0}", notaMaisAlta);
            Console.WriteLine("Nota mais baixa: {0}", notaMaisBaixa);
            Console.WriteLine("Média da turma: {0:0.0}", media);
            Console.WriteLine("Alunos na turma: {0}", quantidade);

            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 12 
             * Apresentar o total da soma dos cem primeiros números inteiros. 
             */

            /*
            int numeros=0;

            for (int i = 1; i <= 100; i++)
            {
                numeros += i;
            }

            Console.WriteLine(numeros);
            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 13 
             * Elaborar um programa que apresente o somatório dos valores pares existentes
             * entre 1 e 500.
             */

            /*
            int numeros=0;

            for (int i=1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    numeros += i;
                }
            }
            Console.WriteLine("Soma dos pares existentees entre 1 e 500: {0}", numeros);

            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 14
             * Mostrar as potências de 2 variando de 0 a 10.
             */

            /*
            int potencias;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("2^{0}: {1}",i, Math.Pow(2,i));
            }

            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 15
             * Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem 
             * dizendo se ele está aprovado ou reprovado, após ter calculado sua média ponderando,
             * considerando pesos 2, 1, 2, e 4, respectivamente. 
             * Considerar nota 7,0 como mínima para aprovação.
             */

            /*
            double[] notas = new double[4], pesos = {2, 1, 2, 4};
            double media=0, divisao=0;
                        
            for (int i = 0; i < pesos.Length; i++)
            {
                Console.Write("Informe a nota {0}: ", i + 1);
                notas[i] = double.Parse(Console.ReadLine());
                Console.Clear();

                media += notas[i] * pesos[i];
                divisao += pesos[i];
            }

            media = media / divisao;

            Console.WriteLine(media >= 7 ? "\nAprovado!" : "\nReprovado...");
            
            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 16
             * Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
             * multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
             * (N*3; N*3*3; N*3*3*3; etc).
             */

            /*
            Random aleatorio = new Random();
            int numero = aleatorio.Next(1, 50);
            int aux = 0;

            Console.WriteLine("Número sorteado: {0}",numero);

            while (numero < 250)
            {
                aux = numero;
                numero *= 3;
            }

            Console.WriteLine(aux);
            */         

            /* Ex. 17
             * Apresentar os quadrados dos números inteiros de 15 a 200.
             */

            /*
            for (int i = 15; i <= 200; i++)
            {
                Console.WriteLine("{0}² = {1}",i, (Math.Pow(i,2)));
            }            

            //corrigindo o bug do console fechando automaticamente
            Console.Write("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 18
             * Elaborar um programa que apresente o valor de uma potência de uma base qualquer
             * elevada a um expoente qualquer, ou seja, NM.
             */

            /*
            double Base, potencia;

            Console.Write("Informe a base: ");
            Base = double.Parse(Console.ReadLine());
            
            Console.Write("Informe o expoente: ");
            potencia = double.Parse(Console.ReadLine());

            Console.WriteLine("\n{0} elevado a {1} é igual a {2}", Base, potencia, (Math.Pow(Base,potencia)));
            
            //corrigindo o bug do console fechando automaticamente
            Console.Write("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 19
             * A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados 
             * sobre o salário e número de filhos. A prefeitura deseja saber: 
             * a) média do salário da população;
             * b) média do número de filhos;
             * c) maior salário;
             * d) percentual de pessoas com salário até R$ 100,00.
             * 
             * O final da leitura de dados se dará com a entrada de um salário negativo.
             */

            /*
            double salario=0, mediaSalario=0, maiorSalario=0;
            int filhos, numFilhos=0, mediaFilhos=0, salariosAteCem=0, habitantes=0;

            while (salario > -1)
            {
                Console.Clear();
                Console.WriteLine("Habitante {0}\n", habitantes);
                Console.Write("Qual o seu salário? R$");
                salario = double.Parse(Console.ReadLine());

                if (salario < 0) { break; }

                if (salario <= 100) { salariosAteCem++; }

                if (salario > maiorSalario) { maiorSalario = salario; }

                mediaSalario += salario;

                Console.Write("\nQuantos filhos você tem? ");
                filhos = int.Parse(Console.ReadLine());

                mediaFilhos += filhos;
                habitantes++;
            }

            mediaSalario /= habitantes;
            mediaFilhos /= habitantes;
            salariosAteCem = (100 * salariosAteCem) / habitantes;
            
            Console.Clear();
            Console.WriteLine("População: {0}", habitantes);
            Console.WriteLine("Média de salário da população: {0:C}",mediaSalario);
            Console.WriteLine("Média de filhos da população: {0}",mediaFilhos);
            Console.WriteLine("Maior salário da população: {0:C}",maiorSalario);
            Console.WriteLine("{0}% da população recebe até R$100.",salariosAteCem);
            */

            /* Ex. 20
             * Foi realizada uma pesquisa de algumas características físicas da população de uma
             * certa região, a qual coletou os seguintes dados referentes a cada habitante para
             * serem analisados:
             * - sexo (masculino e feminino)
             * - cor dos olhos (azuis, verdes ou castanhos)
             * - cor dos cabelos ( louros, castanhos, pretos)
             * - idade 
             * 
             * Faça um algoritmo que determine e escreva: 
             * 
             * - a maior idade dos habitantes
             * - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos 
             * inclusive e que tenham olhos verdes e cabelos louros.
             * O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
             */

            
            int maiorIdade=0, feminino18_35=0, idade=1;
            char sexo, olho, cabelo;

            while (idade > 0)
            {
                Console.WriteLine("Informe a idade -1 para encerrar o programa.\n");
                
                Console.Write("Informe a idade: ");
                idade = int.Parse(Console.ReadLine());
                
                if (idade < 0) { break; }

                Console.Write("Informe o sexo: (m)asculino ou (f)eminino: ");
                sexo = char.Parse(Console.ReadLine());

                Console.Write("Informe a cor dos olhos: (a)zuis ou (v)erdes ou (c)astanhos: ");
                olho = char.Parse(Console.ReadLine());

                Console.Write("Informe a cor dos cabelos: (l)ouros ou (p)retos ou (c)astanhos: ");
                cabelo = char.Parse(Console.ReadLine());


                if (idade > maiorIdade) { maiorIdade = idade; }

                if (
                    (sexo == 'f' || sexo == 'F')
                    && (idade >= 18 && idade <= 35)
                    && (olho == 'v' || olho == 'V')
                    && (cabelo == 'l' || cabelo == 'L') )
                {
                    feminino18_35++;
                }
            Console.Clear();
            }

            Console.Clear();

            Console.WriteLine("Maior idade dos habitantes: " + maiorIdade);
            Console.WriteLine("Indivíduos do sexo feminino entre 18 e 35 anos com olhos verdes e cabelos louros: " + feminino18_35);
            

        }
    }
}
