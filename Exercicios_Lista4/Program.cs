using System.Runtime.ConstrainedExecution;

namespace Exercicios_Lista4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ex. 1
             * Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então
             * mostre na tela a quantidade de números pares e ímpares.
             */

            /*
            int[] numeros = new int[10];
            int pares = 0, impares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0}: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
                
                if (numeros[i] % 2 == 0)
                {
                    pares++;
                }
                else if (numeros[i] % 2 != 0)
                {
                    impares++;
                }
            }

            Console.Clear();
            
            Console.WriteLine("Números pares: {0}", pares);
            Console.WriteLine("Números ímpares: {0}", impares);                
            */

            /* Ex. 2
             * Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então
             * realize a soma dos elementos da mesma posição, armazenando o resultado em um 
             * outro vetor.
             */

            /*
            int[] vetor1 = new int[20], vetor2 = new int[20], vetorSoma = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 1: ",i);
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 2: ",i);
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            
            for (int i = 0; i < 20; i++)
            {
                vetorSoma[i] = vetor1[i] + vetor2[i];
                Console.WriteLine("Vetor1[{0}] + Vetor2[{0}]: {1}", i, vetorSoma[i]);                
            }
            */

            /* Ex. 3
             * Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então
             * mostre na tela o índice da posição dos valores correspondentes a números primos.
             */

            /*
            int[] vetor = new int[20], vetorPrimo = new int[20];
            int resto, cont=0, pos=0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 1: ", i);
                vetor[i] = int.Parse(Console.ReadLine());

                for (int j = 0; j < vetor[i]; j++)
                {
                    resto = vetor[i] % (j + 1);
                    if (resto == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2) {
                    vetorPrimo[pos] = i;
                    pos++;
                }
                cont = 0;
            }

            Console.Write("\nPosição dos números primos: ");

            for (int i = 0; i < pos; i++)
            {
                Console.Write(vetorPrimo[i] + " ");                
            }            
            */

            /* Ex. 4
             * Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação 
             * dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. 
             * Mostre o vetor resultante.
             */

            /*
            int[] vetor1 = new int[10], vetor2 = new int[10], vetorMulti = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 1: ", i);
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 2: ", i);
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                vetorMulti[i] = vetor1[i] * vetor2[i];
                Console.WriteLine("Vetor1[{0}] + Vetor2[{0}]: {1}", i, vetorMulti[i]);
            }
            */

            /* Ex. 5
             * Escreva um algoritmo que leia um vetor de 80 elementos inteiros. 
             * Encontre e mostre o menor elemento e a sua posição.
             */

            /*
            int[] vetor = new int[80];
            int menor=1000000000, pos = 0;

            for (int i = 0; i < 5;i++)
            {
                Console.Write("Informe o {0}º número: ", i+1);
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    pos = i;
                }
            }
            
            Console.WriteLine("O menor valor é {0} e está na posição {1} do vetor.", menor, pos);
            */

            /* Ex. 6
             * Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem
             * de leitura.Exemplo:
             * a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
             * b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |
             */

            /*
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 9; i >= 0; i--)
            {                
                Console.Write("\n" + numeros[i] + " ");
            }
            */

            /* Ex. 7
             * Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e 
             * escreva primeiramente todos os números pares lidos e após todos os ímpares. 
             * Exemplo:
             * a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
             *  b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |
             */

            /*
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }
            */

            /* Ex. 8
             * Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após 
             * escreva a posição de cada número menor que zero desse vetor. Exemplo:
             * a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 
             * | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
             * 
             * b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .
             */

            /*
            double[] numeros = new double[30];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0) {
                    Console.Write(i + 1 + " ");
                }
            }
            */

            /* Ex. 9
             * Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene 
             * em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.
             */

            /* -------- Versão sem usar Array.Sort -------- */             
           /*
            int[] numeros = new int[] { 7, 40, 3, 9,21,0,63,31,7,22 }, usados = new int[numeros.Length], ordenado = new int[numeros.Length];
            int menor = 0;
            
            for (int i = 0; i < numeros.Length; i++)    //roda a quantidade de vezes que tiver no vetor
            {
                for (int j = 0; j < numeros.Length - 1; j++)
                {    //faz a busca do menor número

                    if (numeros[j + 1] < numeros[j])
                    {
                        menor = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = menor;
                    }
                }
            }

            Console.WriteLine("Ordenado");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
           */

            /* --------- Versão usando Array.Sort ----------
             * 
            int[] numeros = new int[10], ordem = new int[10];            

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.WriteLine("Vetor em ordem crescente:\n");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("{0} ", numeros[i]);
            }

            /*
            for (int i = 0; i < ordem.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[j] < menor && numeros[j] < ordem[i])
                    {
                        menor = numeros[j];
                    }
                }
                ordem[i] = menor;
                menor = ordem[i];
            }

            for (int i = 0; i < ordem.Length; i++)
            {
                Console.Write("{0} | ",ordem[i]);
            }
            */

            /* Ex. 10
             * Escreva um algoritmo que leia um vetor inteiro de 20 posições.Crie um segundo vetor,
             * substituindo os valores nulos por 2.Mostre os vetores lidos e o vetor resultado.
             */

            /*
            int[] numeros = new int[20], validados = new int[20];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0 || numeros[i] == null)
                {
                    validados[i] = 2;
                }
                else
                {
                    validados[i] = numeros[i];
                }                
            }
            Console.Clear();
            
            for (int i = 0; i < validados.Length; i++)
            {
                Console.WriteLine("Valor do vetor na posição {0}: {1}",i, numeros[i]);
            }
            
            Console.WriteLine("--------------------------------");
            
            for (int i = 0; i < validados.Length; i++)
            {
                Console.WriteLine("Valor do vetor validado na posição {0}: {1}",i, validados[i]);
            }
            */

            /* Ex. 11
             * Escreva um programa que leia valores em um vetor de 5 posições.Escrever os elementos
             * do vetor e após escrever os elementos na ordem inversa.
             */

            /*
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.Write("\n" + numeros[i] + " ");
            }
            */

            /* Ex. 12
             * Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um 
             * número N, fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) 
             * posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".
             */

            /*
            int[] numeros = new int[10];
            int busca, pos=0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nQual número deseja procurar no vetor? ");
            busca = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == busca)
                {
                    pos = i;
                }
            }

            Console.Clear();

            if (pos != 0)
            {
                Console.WriteLine("O número {0} encontra-se na posição {1} do vetor!", busca, pos);
            }
            else
            {
                Console.WriteLine("O número {0} não existe no vetor...", busca);
            }
            */

            /* Ex. 13
             * Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas
             * vezes aparecem os números 2, 4 e 8.O vetor terá no máximo 100 posições.
             * Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do 
             * vetor.
             */

            /*
            int[] numeros = new int[100];
            int dois=0, quatro=0, oito=0;

            Console.WriteLine("Digite -1 ou 100 números para encerrar o programa");
            
            for (int i = 0; i < numeros.Length; i++) {
                
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] == -1)
                {
                    break;
                }

                if (numeros[i] == 2) { dois++; }
                if (numeros[i] == 4) { quatro++; }
                if (numeros[i] == 8) { oito++; }                
            }

            Console.Clear();

            Console.WriteLine("O número 2 apareceu {0} vezes.", dois);
            Console.WriteLine("O número 4 apareceu {0} vezes.", quatro);
            Console.WriteLine("O número 8 apareceu {0} vezes.", oito);
            */

            /* Ex. 14
             * Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições
             * de números.Se o código for zero, termine o algoritmo.Se o código for 1, mostre o 
             * vetor na ordem em que foi lido.Se o código for 2, mostre o vetor na ordem inversa, 
             * do último elemento até o primeiro.
             */

            /*
            int codigo=0, numeros=0;
            int[] vetor = new int[50];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("0: Encerra o programa");
                Console.WriteLine("1: Encerra o programa e mostra os números na ordem que foram digitadas");
                Console.WriteLine("2: Encerra o programa e mostra os números na ordem inversa que foram digitados");
                Console.WriteLine("Digite o número desejado para prosseguir");
                Console.Write("\nDigite o código: ");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 0 || codigo == 1 || codigo == 2) { break; }
                else
                {
                    Console.Write("Digite um número para a posição {0} do vetor: ", i);
                    vetor[i] = int.Parse(Console.ReadLine());
                    numeros++;
                }
            }

            if (codigo == 1)
            {
                Console.Clear();
                
                Console.Write("\nNúmeros na ordem digitada: ");
                for (int i = 0; i < numeros; i++)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
            
            if (codigo == 2)
            {
                Console.Clear();
                
                Console.Write("\nNúmeros na ordem inversa: ");
                for (int i = numeros - 1; i >= 0; i--)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
            */

            /* Ex. 15
             * Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos
             * do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem.Assim, o 
             * valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento
             * do segundo vetor, por exemplo.Mostrar os conteúdos do primeiro vetor em uma linha
             * e os do segundo uma linha abaixo.
             */

            /*
            int[] vetor = new int[20], vetorInvert = new int[20];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Informe o valor {0} do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());

                vetorInvert[19 - i] = vetor[i];
            }
            Console.Clear();
            
            Console.Write("\nConteúdo do vetor: ");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0} ", vetor[i]);
            }
            
            Console.Write("\nConteúdo do vetor em ordem invertida: ");

            for (int i = 0; i < vetorInvert.Length; i++)
            {
                Console.Write("{0} ", vetorInvert[i]);
            }
            Console.WriteLine("");
            */

            /* Ex. 16
             * Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva.Crie, a seguir,
             * um vetor para cada uma das operações:
             * A união de X com Y
             * A diferença entre X e Y
             * A interseção entre X e Y
             * Escreva o vetor resultado de cada uma das operações.
             * 
             * união - elementos de X e elementos de Y que não estão em X
             * diferença - elementos de X que não estão no Y
             * interseção - elementos que aparecem em X e Y            
             */

            
            int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] y = new int[10] { 1, 6, 30,4, 5,60, 7, 9,10, 11 };
            
            int[] uniao = new int[20];
            int[] diferenca = new int[20];
            int[] intersecao = new int[10];

            Console.WriteLine("UNIÃO");

            x.CopyTo(uniao, 0);
            int auxU = 10;

            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        break;
                    }

                    if (j == (x.Length - 1))
                    {
                        uniao[auxU] = y[i];
                        auxU++;
                    }
                }
            }

            for (int i = 0; i < auxU; i++)
            {
                Console.WriteLine(uniao[i]);
            }

            Console.WriteLine("");

            Console.WriteLine("DIFERENÇA");

            int auxD = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }

                    if (j == (y.Length - 1))
                    {
                        diferenca[auxD] = x[i];
                        auxD++;
                    }
                }
            }

            for (int i = 0; i < auxD; i++)
            {
                Console.WriteLine(diferenca[i]);
            }

            Console.WriteLine("");

            Console.WriteLine("INTERSEÇÃO");

            int auxI = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        intersecao[auxI] = x[i];
                        auxI++;
                        break;
                    }
                }
            }

            for (int i = 0; i < auxI; i++)
            {
                Console.WriteLine(intersecao[i]);
            }
        
      }
    }
}
