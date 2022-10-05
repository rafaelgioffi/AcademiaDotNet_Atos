namespace Aulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aula 5 - 27/09/2022
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Olá!");
            }
            */

            //contar quantos valores tem entre 55 e 127
            /*
            int contador = 0;
            for (int i = 56; i < 127; i++)
            {
                contador++;
            }
            Console.WriteLine("{0} valores", contador);
            */

            //somar os valores entre 55 e 127
            /*
            int acumulador = 0;
            for (int i = 56; i < 127; i++)
            {
                acumulador += i;
            }
            Console.WriteLine("A soma de todos os valores é: {0}", acumulador);
            */

            //incrementar salário até 5000
            /*
            int contagem = 0;
            double salario = 1000;
            for (; salario < 5000; salario += 700)
            {
                contagem++;
            }
            Console.WriteLine(contagem);
            Console.WriteLine(salario);
            */

            //contar quantos pares em 55 e 127
            /*
            int contagem = 0;
            for (int i = 56; i < 127; i++)
            {
                if (i % 2 == 0)
                {
                    contagem++;
                }
            }
            Console.WriteLine("Pares entre 55 e 127: {0}", contagem);
            */

            //contar os ímpares e somar os pares entre 55 e 127
            /*
            int impares = 0, pares=0;

            for (int i = 56; i < 127; i++)
            {
                if (i % 2 == 0)
                {
                    pares += i;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("Ímpares: {0}\nSoma dos Pares: {1}",impares,pares);
            */

            //informar os impares e somar os pares entre o intervalo informado pelo usuário

            /*
            int inicio, fim=0, pares=0, impares=0;

            Console.Write("Informe o valor inicial: ");
            inicio = int.Parse(Console.ReadLine());

            while (inicio > fim)
            {
                Console.Write("Informe o valor final: ");
                fim = int.Parse(Console.ReadLine());
            }

            for (int i = inicio + 1; i < fim; i++)
                {
                    if (i % 2 == 0)
                    {
                        pares += i;
                    }
                    else
                    {
                        impares++;
                    }
                }
            Console.WriteLine("Ímpares: {0}\nSoma dos Pares: {1}", impares, pares);int inicio, fim=0, pares=0, impares=0;

            Console.Write("Informe o valor inicial: ");
            inicio = int.Parse(Console.ReadLine());

            while (inicio > fim)
            {
                Console.Write("Informe o valor final: ");
                fim = int.Parse(Console.ReadLine());
            }

            for (int i = inicio + 1; i < fim; i++)
                {
                    if (i % 2 == 0)
                    {
                        pares += i;
                    }
                    else
                    {
                        impares++;
                    }
                }
            Console.WriteLine("Ímpares: {0}\nSoma dos Pares: {1}", impares, pares);
            */


            /* contar quantos valores pares o usuário digitou
            * até ele digitar um valor negativo
            */

            /*
            int valor=0, pares = 0;

            while (valor >= 0)
            {
                Console.Write("Informe um valor (informe um negativo para interromper): ");
                valor = int.Parse(Console.ReadLine());

                if (valor < 0)
                {
                    //continue;   //encerra a iteração atual e parte para a seguinte
                    break;        //encerra o laço de repetição
                }

                if (valor % 2 == 0)
                    {
                        pares++;
                    }
            }
            Console.WriteLine("\n{0} pares!", pares);
            */

            //----------------------------------------------------------
            // Aula dia 29/09/22

            /*
            double[] b = new double[5];

            b[0] = 2;
            b[2] = 5;
            b[1] = b[0] - b[2];
            b[3] = Math.Pow(b[2], 2);
            b[4] = b[3] - 1;

            Console.WriteLine(b[0] + " " + b[1]);
            */

            /*
            int i;
            int[] b = new int[5];
            Console.WriteLine("------- - Leitura dos valores: ---------");

            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o valor " + i + ": ");
                b[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\nValor índice " + i + " é igual a " + b[i]);
            }
            */

            /*
            double[] notas = new double[50];
            double media;
            int i;

            Console.WriteLine("----------Leitura dos valores:--------");
            for (i = 0; i < 50; i++)
            {
                Console.Write("Digite a nota do aluno " + i + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            media = 0;

            Console.WriteLine("-----------Calculo da média sendo feito:-------");

            for (i = 0; i < 50; i++)
            {
                media += notas[i];
            }
            media /= 50;

            Console.WriteLine("-------Mostra a média:------");
            Console.WriteLine("A média de notas é igual " + media);
            */

            /*
            int[] idade = new int[40];
            int i, conta = 0;
            Console.WriteLine("Informe as idades dos alunos da turma:");
            for (i = 0; i < 40; i++)
            {
                idade[i] = int.Parse(Console.ReadLine());
                if (idade[i] >= 18)
                {
                    conta++;
                }
            }
            Console.WriteLine("Existem " + conta + " alunos com idade maior ou igual a 18 anos");

            for (i = 0; i < 40; i++)
            {
                if (idade[i] >= 18)
                {
                    Console.WriteLine("Aluno " + i + " tem " + idade[i] + " anos");
                }
            }
            */

            /*
            int[] vetor = new int[10];
            int i, maior, pos, menor, posMenor;
            //laço apra leitura dos elementos
            for (i = 0; i < 10; i++)
            {
                Console.Write("Informe o valor {0}: ", i);
                vetor[i] = int.Parse(Console.ReadLine());
            }
            maior = vetor[0];  //define o primeiro como maior
            pos = 0;

            for (i=0; i < 10; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    pos = i;
                }
            }

            Console.WriteLine("O maior elemento é: " + maior + " e está na posição " + pos);
            menor = vetor[0];
            posMenor = 0;
            for (i=0; i < 10; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posMenor = i;
                }
            }

            Console.WriteLine("O menor elemento é: " + menor + " e está na posição " + posMenor);
            */

            //calcular todos os elementos e somar no final
            /*

            int[] vetorA = new int[10], vetorB = new int[10];
            int i, prod = 0;

            Console.WriteLine("Leitura dos elementos do vetor A");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o elemento " + i + " do vetor A: ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nLeitura dos elementos do vetor B");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o elemento " + i + " do vetor B: ");
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                prod += vetorA[i] * vetorB[i];
            }

            Console.WriteLine("O produto dos elementos dos vetores A e B = " + prod);
            */


            //----------------------------------------------------------
            // Aula dia 03/10/22

            //int[] vetor = new int[5];

            /*
            int[,] matriz = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Informe um valor para a posição [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
            */

            //dobrar todos os valores de uma matriz
            /*
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Informe um valor para a posição [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = matriz[i,j] * 2;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            */

            //dobrar todos os valores da vertical principal da matriz
            
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Informe um valor para a posição [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        matriz[i, j] = matriz[i,j] * 2;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}