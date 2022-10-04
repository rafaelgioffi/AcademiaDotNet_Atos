<<<<<<< HEAD
﻿namespace Aulas
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
=======
﻿using System;

namespace Exercicios_Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ex. 1: 
             * Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. 
             * A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro
             * dos elementos da 1ª coluna.
            */

            /*
            int[,] matriz = new int[5, 3];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o valor da linha {0}, coluna 1 [{0},1]: ",i + 1);
                matriz[i, 0] = int.Parse(Console.ReadLine());
                matriz[i, 1] = matriz[i, 0] + 10;
                
                matriz[i, 2] = matriz[i, 0] * 2;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
            */

            /* Ex. 2
             * Solicite ao usuário, preencher uma Matriz 3x3
             * 
             * Informe ao usuário:
             * A soma dos elementos de cada linha
             * Ex: Linha 1: 30
             * Linha 2: 17
             * A soma dos elementos de cada coluna
             * -Ex: Coluna 1: 23
             * Coluna 2: 36
             */

            /*
            int[,] matriz = new int[3, 3];
            int[] linhas = new int[3];
            int[] colunas = new int[3];
            int linha=0, coluna=0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Informe o valor [{0},{1}]: ",i,j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    linha += matriz[i, j];
                }
                linhas[i] = linha;
                linha = 0;
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    coluna += matriz[j, i];
                }
                colunas[i] = coluna;
                coluna = 0;
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("Soma de todos elementos da linha {0}: {1}",i, linhas[i]);
            }
            
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                Console.WriteLine("Soma de todos elementos da coluna {0}: {1}",i, colunas[i]);
            }
            */

            /* Ex. 3: 
             * Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
             */

            /*
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Informe o valor [{0},{1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("[{0},{1}]: {2} ", i, j, matriz[i,j]);
                    }
                }                
            }
            */

            /* Ex. 4:
             * Popule uma matriz 5x5 e informe:
             * -Quantos números são pares
             * -Quantos números são impares
             * -Quantos números são positivos
             * -Quantos números são negativos
             * -Quantos zeros existem!
             */

            /*
            int[,] matriz = new int[5, 5];
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Informe o valor [{0},{1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i, j] % 2 == 0) { pares++; }
                    if (matriz[i, j] % 2 != 0) { impares++; }
                    if (matriz[i, j] >= 0) { positivos++; }
                    if (matriz[i, j] < 0) { negativos++; }
                }
            }
            Console.WriteLine("\nQuantidade de pares: " + pares);
            Console.WriteLine("Quantidade de ímpares: " + impares);
            Console.WriteLine("Quantidade de positivos: " + positivos);
            Console.WriteLine("Quantidade de negativos: " + negativos);
            */

            /* Ex. 5:
             * Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.
             */

            /*
            double[,] matrizA = new double[2, 3], matrizB = new double[2,3], matrizC = new double[2,3];
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    matrizA[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write("Informe o valor [{0},{1}] da Matriz B: ", i, j);
                    matrizB[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            Console.WriteLine("Soma dos valores: ");
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write(matrizC[i,j] + " ");
                }
            }
            */


            /* Ex. 6:
             * Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. 
             * Após isso determine o maior número da matriz.
             * Random random = new Random();
             * int randomNumber = random.Next(0, 100);
             */

            /*
            int[,] M = new int[4, 4];
            Random random = new Random();
            int maior=0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = random.Next(0, 100);
                }
            }
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i, j] > maior)
                    {
                        maior = M[i, j];
                    }
                    Console.WriteLine("[{0},{1}]: {2}",i, j, M[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("O maior valor da matriz M é " + maior);
            */


            /* Ex. 7:
             * Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada
             * elemento de C é a subtração do elemento correspondente de A com B.
             */

            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matrizA = new int[2, 3], matrizB = new int[2, 3], matrizC = new int[2, 3];
                        
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matrizA[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i, j, matrizA[i, j]);
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz B: ", i, j);
                    //matrizB[i, j] = int.Parse(Console.ReadLine());
                    matrizB[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i, j, matrizB[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];                    
                }
            }
            Console.WriteLine("Subtração dos valores: ");
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write(matrizC[i, j] + " ");
                }
            }
            */

            /* Ex. 9:
             * Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e 
             * inversa a que foram lidos.
             */

            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matriz = new int[4, 4];

            Console.WriteLine("==== Lista na ordem digitada ====");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i+1, j+1, matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("==== Lista na ordem invertida ====");
            
            for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matriz.GetLength(1) - 1; j >= 0 ; j--)
                {                    
                    Console.WriteLine("[{0},{1}]: {2}", i+1, j+1, matriz[i, j]);
                }
                Console.WriteLine();
            }


            /* Ex. 10:
             * Leia uma matriz 3x3. Em seguida, solicite um número qualquer ao usuário e 
             * pesquise na matriz se o número existe. Caso, seja verdade imprima a mensagem: 
             * “O número existe no vetor” , caso contrário “Número inexistente”.
             */

            /* Ex. 11:
             * Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida,
             * diga quantos dos elementos lidos estão abaixo, acima e na média.
             */

            /* Ex. 12:
             * Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante
             * da divisão dos elementos da matriz A pela soma dos seus indices.
             */

        }
    }
>>>>>>> 73c7814 (Updating exercises in fifth list)
}