using System.ComponentModel;

namespace Exercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 1
             * Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos
             * valores da base e da altura lidos pelo teclado: 
             * Área do triangulo = (base * altura) / 2; 
             * Teste se a base ou a altura digitada não foi igual a zero. 
             */
            /*
            double baseT, alturaT;

            Console.Write("Informe a base do triângulo: ");
            baseT = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do triângulo: ");
            alturaT = double.Parse(Console.ReadLine());

            if (baseT > 0 && alturaT > 0)
            {
                Console.WriteLine("Área do triângulo: " + (baseT * alturaT) / 2);
            }
            else
            {
                Console.WriteLine("A área e/ou altura do triângulo precisam ser maiores que zero");
            }
            */

            /* Exercício 2
             * Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.
             */
            /*
            int num;

            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Número par!");
            }
            else
            {
                Console.WriteLine("Número ímpar!");
            }
            */

            /* Exercício 3
             * Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, 
             * e escrever na tela os que são superiores à média.
             */

            /*
            int media=0;
            int[] valores = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Informe o Valor " + i + ": ");
                valores[i] = int.Parse(Console.ReadLine());
                media += valores[i];
            }

            media /= 4;

            Console.WriteLine("\nMédia: " + media);

            for (int i = 0; i < 4; i++)
            {
                if (valores[i] > media) {
                    Console.WriteLine("\nValor {0} é maior que a média!", i);
                }
            }
            */

            /* Exercício 4
            /* Escrever um algoritmo para ler a quantidade de horas aula dadas por dois 
             * professores e o valor por hora recebido por cada um deles. Mostrar na tela
             * qual dos professores tem o maior salário total.
             */

            /*
            double[] valorProf = new double[2], salProf = new double[2];
            int[] horaProf = new int[2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Informe as horas/aula do Professor {0}: ", i+1);
                horaProf[i] = int.Parse(Console.ReadLine());

                Console.Write("Informe o valor da hora/aula do Professor {0}: ", i);
                valorProf[i] = double.Parse(Console.ReadLine());
                
                Console.Clear();

                salProf[i] = valorProf[i] * horaProf[i];
            }
            
            if (salProf[0] > salProf[1])
            {
                Console.WriteLine("Professor 1 tem o salário maior que o professor 2");
            }
            else
            {
                Console.WriteLine("Professor 2 tem o salário maior que o professor 1");
            }
            */

            /* Exercício 5
             * Escrever um algoritmo para ler duas notas de um aluno e escrever na
             * tela a palavra “Aprovado” se a média das duas notas for maior ou igual a 7,0.
             * Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e 
             * calcular a média final, é a média entre a nota do exame e a média das
             * 2 notas. Se esta média final for maior ou igual a 5,0, o programa deve 
             * escrever “Aprovado”, caso contrário deve escrever “Reprovado”.
             */
            /*
            double n1, n2, media, exame, mediaFinal;

            Console.Write("Informe a Nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            
            Console.Write("Informe a Nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            media = (n1 + n2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado com média " + media + "!");
            }
            else
            {
                Console.Write("Informe a nota do exame: ");
                exame = double.Parse(Console.ReadLine());
                mediaFinal = (media + exame) / 2;

                if ( mediaFinal >= 5)
                {
                    Console.WriteLine("Aprovado com média " + mediaFinal + "!");
                }
                else
                {
                    Console.WriteLine("Reprovado com média " + mediaFinal + "...");
                }
            }
            */

            /* Exercício 6
             * Faça um programa em C# e no Visual Studio para receber o nome 
             * (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
             * O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao 
             * usuário e informar sua situação conforme a tabela. O cálculo do
             * imc = peso / (altura * altura)
             * IMC 
             * menor que 18                -> baixo peso
             * maior que 18 e menor que 25 -> peso normal
             * maior que 25 e menor que 30 -> sobrepeso
             * maior que 30 e menor que 35 -> obesidade
             * maior que 35                -> obesidade grau sério
            */
            /*
            string nome;
            double altura, peso, imc;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine().ToUpper();
            
            Console.Write(nome + ", informe seu peso: ");
            peso = double.Parse(Console.ReadLine());
            
            Console.Write(nome + ", informe sua altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Clear();

            imc = peso / (altura * altura);

            if (imc < 18)
            {
                Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está abaixo do peso ideal...");
            }
            else if (imc > 18 && imc < 25)
            {
                Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está no peso ideal!");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está com sobrepeso...");
            }
            else if (imc > 30 && imc < 35)
            {
                Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está obeso...");
            }
            else if (imc > 35)
            {
                Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está com um grau sério de obesidade...");
            }            
            */

            /* Exercício 7
             * Faça um programa em C# e no VS para receber uma frase qualquer
             * e uma palavra de pesquisa. O programa deve avaliar se a palavra 
             * aparece na frase, informando o usuário via mensagem, como por 
             * exemplo, A palavra encontra-se na frase ou A palavra não se 
             * encontra na frase.
            */
            /*
            string palavra, frase;
            bool busca;

            Console.Write("Por favor, digite uma frase: ");
            frase = Console.ReadLine();
            
            Console.Write("Por favor, digite a palavra que deseja encontrar: ");
            palavra = Console.ReadLine();
            busca = frase.Contains(palavra);

            if (busca)
            {
                Console.WriteLine("A palavra '" + palavra + "' está presente na frase!");
            }
            else
            {
                Console.WriteLine("A palavra '" + palavra + "' não foi encontrada na frase!");
            }
            */

            /* Exercício 8
             * Faça um programa no VS que receba o código, nome, salário base 
             * e o total de vendas de um funcionário. Caso o total de vendas seja
             * acima de R$ 500,00, adicionar ao seu salário final 5% do total 
             * de vendas. Caso o total de vendas seja mais que R$ 1000,00, 
             * adicionar ao seu salário final 7% do total de vendas. E por fim, 
             * se o total de vendas seja maior que R$ 5000,00, adicionar ao seu 
             * salário final 10% do total de vendas. 
            */
            
            /*
            string codigo, nome;
            double salarioBase, salarioFinal, totalVendas;

            Console.Write("Digite o código do funcionário: ");
            codigo = Console.ReadLine();
            
            Console.Write("Digite o nome do funcionário: ");
            nome = Console.ReadLine();
            
            Console.Write("Digite o salário base do funcionário " + nome + ": ");
            salarioBase = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o total em vendas do funcionário " + nome + ": ");
            totalVendas = double.Parse(Console.ReadLine());

            Console.Clear();

            if (totalVendas > 500 && totalVendas < 1000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.05);
                Console.WriteLine("O funcionário {0} receberá uma comissão de 5% e seu salário final será {1:C}", nome, salarioFinal);
            }
            else if (totalVendas > 1000 && totalVendas < 5000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.07);            
                Console.WriteLine("O funcionário {0} receberá uma comissão de 7% e seu salário final será {1:C}", nome, salarioFinal);
            }
            else if (totalVendas > 5000)
            {
                salarioFinal = salarioBase + (totalVendas * 0.1);                
                Console.WriteLine("O funcionário {0} receberá uma comissão de 10% e seu salário final será {1:C}", nome, salarioFinal);
            }
            else
            {
                salarioFinal = salarioBase;                
                Console.WriteLine("O funcionário {0} não bateu a meta e não receberá comissão. Seu salário final será {1:C}", nome, salarioFinal);
            }
            */

            /* Exercício 9
             * Faça um programa no VS que receba do usuário 3 valores de glicemia
             * em jejum, representando a medição diária de um paciente diabético.
             * Para cada valor recebido analisar e informar ao paciente o seguinte:
             * Se o valor diário for menor que 65, avisá-lo que corre risco de 
             * hipoglicemia Se o valor diário for maior que 250, avisá-lo que 
             * corre risco de hiperglicemia. Além disso, o programa deve fazer 
             * a média dos 3 valores de glicemia coletados. E se a média for 
             * menor que 80, avisá-lo que é preciso diminuir 2 unidades de 
             * insulina. Se a média for maior que 150, avisá-lo que será necessário 
             * adicionar 2 unidades de insulina.
            */

            /*
            double[] glicemia = new double[3];
            double mediaDiaria=0;
            bool menorQue65 = false, maiorQue250 = false;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Informe o {0}º valor da glicemia em jejum: ", i+1);
                glicemia[i] = double.Parse(Console.ReadLine());
                mediaDiaria += glicemia[i];
                
                if (glicemia[i] < 65) { menorQue65 = true; }
                if (glicemia[i] > 250) { maiorQue250 = true; }
            }
            mediaDiaria /= 3;
            Console.Clear();

            if (menorQue65)
            {
                Console.WriteLine("Um dos seus valores está abaixo de 65.\nVocê corre risco de Hipoglicemia!");
            }
            if (maiorQue250)
            {
                Console.WriteLine("Um dos seus valores está acima de 250.\nVocê corre risco de Hiperglicemia!");
            }

            if (mediaDiaria < 80)
            {
                Console.WriteLine("A sua média está em " + mediaDiaria.ToString("F") + " e você deve diminuir 2 unidades de insulina");
            }
            else if (mediaDiaria > 150)
            {
                Console.WriteLine("A sua média está em " + mediaDiaria.ToString("F") + " e você deve adicionar 2 unidades de insulina");
            }            
            */

            /* Exercício 10
             * Faça um programa no VS que receba dados de dois atletas (nome, 
             * idade e altura). O programa deve mostrar os dados do atleta mais 
             * novo e mais alto.
            */

            /*
            string[] nomes = new string[2];            
            int[] idades = new int[2];
            int indiceMaisNovo=0, indiceMaisAlto=0, idadeMaisNovo=100;
            double[] alturas = new double[2];
            double alturaMaisAlto=0;
            

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Informe o nome do atleta {0}: ", i+1);
                nomes[i] = Console.ReadLine();

                Console.Write("Informe a idade do atleta {0}: ", i+1);
                idades[i] = int.Parse(Console.ReadLine());
                
                if (idades[i] < idadeMaisNovo) { 
                    idadeMaisNovo = idades[i];
                    indiceMaisNovo = i; 
                }                

                Console.Write("Informe a altura do atleta {0}: ", i+1);
                alturas[i] = double.Parse(Console.ReadLine());

                if (alturas[i] > alturaMaisAlto) { 
                    alturaMaisAlto = alturas[i];
                    indiceMaisAlto = i; 
                }
                Console.WriteLine();
            }

            Console.Clear();
                        
            Console.WriteLine("\nAtleta mais novo: ");
            Console.WriteLine(nomes[indiceMaisNovo]);
            Console.WriteLine(idades[indiceMaisNovo] + " anos");
            Console.WriteLine("{0:0.00m}", alturas[indiceMaisNovo]);
            Console.WriteLine("\n-------------------\n");
            Console.WriteLine("Atleta mais alto: ");
            Console.WriteLine(nomes[indiceMaisAlto]);
            Console.WriteLine(idades[indiceMaisAlto] + " anos");
            Console.WriteLine("{0:0.00}m",alturas[indiceMaisAlto]);
            */

            /* Exercício 11
             * Faça um programa no VS que receba uma hora, dividida em 2 variáveis 
             * (uma para hora e outra para minutos). O programa deve exibir se a 
             * hora digitada está ou não válida. Lembre que usaremos o padrão de 
             * hora com 24h, de 0 a 23.
            */

            /*
            int hora, minuto;
            bool valido = false;

            Console.Write("Informe a hora: ");
            hora = int.Parse(Console.ReadLine());
            
            Console.Write("Informe os minutos: ");
            minuto = int.Parse(Console.ReadLine());

            if (hora >= 0 && hora <= 23)
            {
                valido = true;
            }

            if (minuto >= 0 && minuto <= 59)
            {
                valido = true;
            }

            if (valido == true)
            {
                Console.WriteLine("{0:00}:{1:00} é uma hora válida!", hora, minuto);
            }
            */

            /* Exercício 12
             * Elabore um programa em VS que leia as variáveis "codigo" e 
             * "numeroHoras", respectivamente código e número de horas trabalhadas
             * de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
             * R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o 
             * excesso de pagamento armazenando-o na variável "extra", caso contrário 
             * zerar tal variável. A hora excedente de trabalho vale R$ 20,00. No final
             * do processamento, exibir o salário total e o salário excedente do operário.
            */
            /*
            string codigo;
            int numeroHoras;
            double salario, extra, salarioFinal=0;

            Console.Write("Informe o código do funcionário: ");
            codigo = Console.ReadLine();
            
            Console.Write("Informe o número de horas trabalhadas do funcionário: ");
            numeroHoras = int.Parse(Console.ReadLine());

            if (numeroHoras < 50)
            {
                salarioFinal = numeroHoras * 10;
            }
            if (numeroHoras > 50)
            {
                numeroHoras -= 50;
                salario = 10 * 50;
                extra = numeroHoras * 20;
                salarioFinal = salario + extra;
            }

            Console.WriteLine("Salário final do funcionário: " + salarioFinal.ToString("C"));
            */

            /* Exercício 13
             * Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa 
             * no VS que calcule seu peso ideal, utilizando as seguintes fórmulas:
             * Para homens: (72.7 * h) - 58
             * Para mulheres: (62.1 * h) - 44.7
            */
            /*
            double h, pesoIdeal;
            char sexo;

            Console.Write("Você é do sexo (M)asculino ou (F)eminino? ");
            sexo = char.Parse(Console.ReadLine());
            
            Console.Write("Informe sua altura: ");
            h = double.Parse(Console.ReadLine());

            if (sexo == 'm' || sexo == 'M')
            {
                pesoIdeal = (72.7 * h) - 58;
                Console.WriteLine("Peso ideal: " + pesoIdeal.ToString("F") + "Kg");
            }
            else if (sexo == 'f' || sexo == 'F')
            {
                pesoIdeal = (62.1 * h) - 44.7;
                Console.WriteLine("Peso ideal: " + pesoIdeal.ToString("F") + "Kg");
            }
            else
            {
                Console.WriteLine("Informe um sexo válido!\nM para masculino ou F para feminino");
            }
            /*

            /* Exercício 14
             * Faça um programa que peça o tamanho de um arquivo para download (em MB) e a 
             * velocidade de um link de Internet (em Mbps). Em seguida, calcule e informe 
             * o tempo aproximado de download do arquivo usando este link (em minutos).
            */
            
            /*
            double tamanhoArq, velocidadeInternet, minutos;

            Console.Write("Informe o tamanho do arquivo (em MB): ");
            tamanhoArq = double.Parse(Console.ReadLine());
            Console.Write("Informe a velocidade da conexão (em Mbp/s): ");
            velocidadeInternet = double.Parse(Console.ReadLine());

            minutos = tamanhoArq / velocidadeInternet;
                        
            Console.WriteLine("Tempo de download: {0:0.00} minutos.", minutos);
            */

            /* Exercício 15
             * Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho 
             * em metros quadrados da área a ser pintada. Considere que a cobertura da 
             * tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida 
             * em latas de 18 litros, que custam R$ 80,00. Informe ao usuário a quantidades
             * de latas de tinta a serem compradas e o preço total.
            */
            /*
            double metrosQuadrados, latas, valor;

            Console.Write("Informe a área a ser pintada (em m²): ");
            metrosQuadrados = double.Parse(Console.ReadLine());
            latas = Math.Ceiling(metrosQuadrados / 54);
            valor = latas * 80;

            if (latas == 1)
            {
                Console.WriteLine("\nSerá necessária " + latas  + " lata de 18L no valor de " + valor.ToString("C"));
            }
            else if (latas > 1)
            {
                Console.WriteLine("\nSerão necessárias " + latas  + " latas de 18L no valor de " + valor.ToString("C"));
            }
            */

            /* Exercício 16
             * Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa
             * do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de 
             * diferença, mostre na tela uma mensagem indicando que o time de fora já se 
             * classificou para a próxima fase. Caso contrário, mostre uma mensagem 
             * indicando que os dois times irão se enfrentar novamente em um novo jogo.
             * ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão 
             * em um novo jogo" 
             * ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
             * plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga 
             * quem passou de fase.
             */
            /*
            int timeDaCasa, timedeFora;

            Console.Write("Informe a quantidade de gols do time da casa: ");
            timeDaCasa = int.Parse(Console.ReadLine());
            
            Console.Write("Informe a quantidade de gols do time de fora: ");
            timedeFora = int.Parse(Console.ReadLine());
            if (timedeFora >= timeDaCasa + 2)
            {
                Console.WriteLine("\nO time de fora já se classificou");
            }
            else
            {
                Console.WriteLine("\nOs times se enfrentarão em um novo jogo\n\n");

                Console.Write("Informe a quantidade de gols do time da casa: ");
                timeDaCasa = int.Parse(Console.ReadLine());
            
                Console.Write("Informe a quantidade de gols do time de fora: ");
                timedeFora = int.Parse(Console.ReadLine());
            
                if (timeDaCasa > timedeFora)
                {
                    Console.Clear();
                    Console.WriteLine("Time da casa passou de fase!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Time de fora passou de fase!");
                }
            }
            */

            /* Exercício 17
             * Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), 
             * e então diga se esses lados podem ou não formar um triangulo. Para que os lados
             * formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros 
             * dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos 
             * os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são 
             * diferentes).
             */
            /*
            int ladoA, ladoB, ladoC;

            Console.Write("Informe o lado A do triângulo: ");
            ladoA = int.Parse(Console.ReadLine());
            
            Console.Write("Informe o lado B do triângulo: ");
            ladoB = int.Parse(Console.ReadLine());
            
            Console.Write("Informe o lado C do triângulo: ");
            ladoC = int.Parse(Console.ReadLine());


            if (ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB))
            {
                Console.Write("\nÉ um triângulo ");
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("equilátero");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("isósceles");
                }
                else
                {
                    Console.WriteLine("escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo!");
            }
            */

            /* Exercício 18
             * Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior
             * deles.
             */

            //versão com inteiros
            /*
            int valor1, valor2, valor3;

            Console.Write("Informe o valor 1: ");
            valor1 = int.Parse(Console.ReadLine());
            
            Console.Write("Informe o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());
            
            Console.Write("Informe o valor 3: ");
            valor3 = int.Parse(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine("\n" + valor1 + " é o maior valor.");
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine("\n" + valor2 + " é o maior valor.");
            }
            else if (valor3 > valor1 && valor3 > valor2)
            {
                Console.WriteLine("\n" + valor3 + " é o maior valor.");
            }
            */

            //------------------

            //versão com strings
            /*
            string valor1, valor2, valor3;
            int tamVal1, tamVal2, tamVal3;

            Console.Write("Informe o valor 1: ");
            valor1 = Console.ReadLine();

            Console.Write("Informe o valor 2: ");
            valor2 = Console.ReadLine();

            Console.Write("Informe o valor 3: ");
            valor3 = Console.ReadLine();

            tamVal1 = valor1.Length;
            tamVal2 = valor2.Length;
            tamVal3 = valor3.Length;

           if (tamVal1 > tamVal2 && tamVal1 > tamVal3)
            {
                Console.WriteLine("\n'" + valor1 + "' é o maior valor com " + tamVal1 + " caracteres.");
            }
           else if (tamVal2 > tamVal1 && tamVal2 > tamVal3)
            {
                Console.WriteLine("\n'" + valor2 + "' é o maior valor com " + tamVal2 + " caracteres.");
            }
           else if (tamVal3 > tamVal1 && tamVal3 > tamVal2)
            {
                Console.WriteLine("\n'" + valor3 + "' é o maior valor com " + tamVal3 + " caracteres.");
            }
            */

            /* Exercício 19
             * Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
             */

            /*
            int valor1, valor2, valor3;
            string maior="", meio="", menor="";

            Console.Write("Informe o valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor 3: ");
            valor3 = int.Parse(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                maior = "Valor 1: " + valor1;

                if (valor2 > valor3)
                {
                    meio = "Valor 2: " + valor2;
                    menor = "Valor 3: " + valor3;
                }
                else
                {
                    meio = "Valor 3: " + valor3;
                    menor = "Valor 2: " + valor2;
                }
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                maior = "Valor 2: " + valor2;

                if (valor1 > valor3)
                {
                    meio = "Valor 1: " + valor1;
                    menor = "Valor 3: " + valor3;
                }
                else
                {
                    meio = "Valor 3: " + valor3;
                    menor = "Valor 1: " + valor1;
                }
            }
            else if (valor3 > valor1 && valor3 > valor2)
            {
                maior = "Valor 3: " + valor3;

                if (valor1 > valor2)
                {
                    maior = "Valor 1: " + valor1;
                    menor = "Valor 2: " + valor2;
                }
                else
                {
                    meio = "Valor 2: " + valor2;
                    menor = "Valor 1: " + valor1;
                }
            }

            Console.Clear();

            Console.WriteLine("Números em ordem crescente: ");
            Console.WriteLine(maior);
            Console.WriteLine(meio);
            Console.WriteLine(menor);
            */

            /* Exercício 20
             * Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 
             * chances e recebe dicas do tipo “é maior” ou “é menor”. 
             * plus: você pode gerar o número de forma randomica (função random c#).
            */

            
            int numSecreto = 10, tentativas = 3, opcao;

            Console.WriteLine("Bem vindo ao jogo Número Secreto!");
            Console.WriteLine("---------------------------------");

            do
            {
                Console.Write("Digite a sua tentativa: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao != numSecreto)
                {
                    tentativas -= 1;
                    Console.WriteLine("\nVocê errou!");
                    if (numSecreto > opcao)
                    {
                        Console.WriteLine("O número secreto é maior!");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é menor!");
                    }

                    if (tentativas > 1)
                    {
                        Console.WriteLine("Você possui mais " + tentativas + " tentivas...\n");
                    }
                    else if (tentativas == 0)
                    {
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("Sua última tentativa!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número secreto!");
                    break;
                }                
            }
            while (tentativas > 0);
            

        }
    }
}
