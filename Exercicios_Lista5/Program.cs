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

            /* Ex. 8:
             * Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e 
             * inversa a que foram lidos.
             */

            /*
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
            */

            /* Ex. 9:
             * Leia uma matriz 3x3. Em seguida, solicite um número qualquer ao usuário e 
             * pesquise na matriz se o número existe. Caso, seja verdade imprima a mensagem: 
             * “O número existe no vetor” , caso contrário “Número inexistente”.
             */

            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matriz = new int[3, 3];
            int numeroSelecionado = random.Next(0, 20);
            bool numeroExiste = false;

            Console.WriteLine("Número selecionado: {0}\n", numeroSelecionado);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matriz[i, j]);
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == numeroSelecionado) { 
                        numeroExiste = true;
                        break;
                    } else
                    {
                        numeroExiste = false;
                    }
                }
            }

            if (numeroExiste)
            {
                Console.WriteLine("O número existe no vetor");
            }
            else
            {
                Console.WriteLine("Número inexistente");
            }
            */

            /* Ex. 10:
             * Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida,
             * diga quantos dos elementos lidos estão abaixo, acima e na média.
             */

            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matrizA = new int[4,4], matrizB = new int[4,4];
            int mediaA=0, mediaB=0, abaixoA=0, abaixoB=0, acimaA=0, acimaB=0, naMediaA=0, naMediaB=0;

            Console.WriteLine("Elementos da Matriz A:");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matrizA[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matrizA[i, j]);
                    mediaA += matrizA[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Elementos da Matriz B:");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizB[i, j] = int.Parse(Console.ReadLine());
                    matrizB[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matrizB[i, j]);
                    mediaB += matrizB[i, j];
                }
                Console.WriteLine();
            }

            mediaA /= 16;
            mediaB /= 16;

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //verifica os elementos da MatrizA
                    if (matrizA[i, j] == mediaA) 
                    {
                        naMediaA++;
                    }
                    else if (matrizA[i, j] > mediaA)
                    {
                        acimaA++;
                    }
                    else if (matrizA[i,j] < mediaA)
                    {
                        abaixoA++;
                    }
                    //verifica os elementos da MatrizB
                    if (matrizB[i, j] == mediaB)
                    {
                        naMediaB++;
                    }
                    else if (matrizB[i, j] > mediaB)
                    {
                        acimaB++;
                    }
                    else if (matrizB[i, j] < mediaB)
                    {
                        abaixoB++;
                    }
                }
            }

            Console.WriteLine("====================");
            Console.WriteLine("Média da Matriz A: " + mediaA);
            Console.WriteLine("Média da Matriz B: " + mediaB);
            Console.WriteLine("\nElementos na média na Matriz A: " + naMediaA);
            Console.WriteLine("Elementos na média na Matriz B: " + naMediaB);
            Console.WriteLine("\nElementos na acima da média na Matriz A: " + acimaA);
            Console.WriteLine("Elementos na acima da média na Matriz B: " + acimaB);
            Console.WriteLine("\nElementos na abaixo da média na Matriz A: " + acimaA);
            Console.WriteLine("Elementos na abaixo da média na Matriz B: " + acimaB);
            Console.WriteLine("====================");
            */

            /* Ex. 11:
             * Leia uma matriz A de tipo double de dimensão 3x3, crie uma nova matriz resultante
             * da divisão dos elementos da matriz A pela soma dos seus indices.
             */

            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            double[,] matrizA = new double[3, 3], matrizResult = new double[3, 3];
            string excesoes="";

            Console.WriteLine("Matriz A:\n");

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = double.Parse(Console.ReadLine());
                    matrizA[i, j] = random.Next(0, 20);
                    Console.Write("[{0},{1}]: {2} ", i + 1, j + 1, matrizA[i, j]);
                    
                    if (matrizA[i, j] == 0 || (i + j) == 0)
                    {
                        excesoes += "O elemento [" + i + "," + j + "] não pode ser dividido por ser zero\n";
                        matrizA[i, j] = 0;
                    }
                    else
                    {
                        matrizResult[i,j] = matrizA[i, j] / (i + j);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nMatriz resultante:\n");

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("[{0},{1}] = {2:F} ", i, j, matrizResult[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n" + excesoes);
            */

            /* Ex. 12:
            * Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na 
            * tela apenas os valores cuja soma dos índices (i+j) seja um número par.
            */

            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matriz = new int[4, 3];

            Console.WriteLine("Valores digitados da Matriz:\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
                    //matriz[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = random.Next(0, 20);
                    Console.Write("[{0},{1}]: {2} ", i + 1, j + 1, matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nValores da Matriz cujo índices são pares:\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("[{0},{1}]: {2} ", i + 1, j + 1, matriz[i, j]);
                    }
                }                
            }
            */


            /* Ex. 13:
            * Escreva um programa que leia uma matriz de ordem 5(ou seja, 5x5) e verifique se a
            * soma dos elementos da diagonal principal é igual a soma dos elementos da diagonal
            * secundária.
            */

            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matriz = new int[5, 5];
            int diagonalPrincipal = 0, diagonalSecundaria = 0;
                       
            Console.WriteLine("Valores digitados da Matriz:\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
                    //matriz[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = random.Next(0, 20);
                    Console.Write("[{0},{1}]: {2} ", i + 1, j + 1, matriz[i, j]);

                    if (i == j) { diagonalPrincipal += matriz[i, j]; }
                    if ((i + j) == matriz.GetLength(0) - 1) { diagonalSecundaria += matriz[i, j]; }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            if (diagonalPrincipal == diagonalSecundaria)
            {
                Console.WriteLine("A soma dos elementos da diagonal principal é igual a diagonal secundária.");
                Console.WriteLine("Diagonal principal: " + diagonalPrincipal);
                Console.WriteLine("Diagonal secundária: " + diagonalSecundaria);
            }
            else
            {
                Console.WriteLine("A soma dos elementos da diagonal principal não é igual a diagonal secundária.");
                Console.WriteLine("Diagonal principal: " + diagonalPrincipal);
                Console.WriteLine("Diagonal secundária: " + diagonalSecundaria);
            }
            */

            /* Ex. 14:
            * Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos 
            * da diagonal principal (da esquerda para a direita) são os mesmos da diagonal
            * secundária (direita pra esquerda).
            */

            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matriz = new int[5, 5];
            bool EhIgual = false;
            
            Console.WriteLine("Valores digitados da Matriz:\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
                    //matriz[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = random.Next(0, 20);
                    Console.Write("[{0},{1}]: {2} ", i, j, matriz[i, j]);                    
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (matriz[i, j] == matriz[i, (matriz.GetLength(0) - 1) - i])
                        {
                            EhIgual = true;
                        }
                        else
                        {
                            EhIgual = false;
                            break;
                        }
                    }
                }
            }

            if (EhIgual)
            {
                Console.WriteLine("\nOs elementos da diagonal principal são iguais da diagonal secundária!");
            }
            else
            {
                Console.WriteLine("\nOs elementos da diagonal principal Não são iguais da diagonal secundária...");
            }
            */

            /* Ex. 15:
            * Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. 
            * Mostrar a matriz resultante.
            */

            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matrizA = new int[4, 4], matrizB = new int[4, 4];

            Console.WriteLine("Valores digitados da Matriz A:\n");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matrizA[i, j] = random.Next(0, 20);
                    Console.Write("[{0},{1}]: {2} ", i, j, matrizA[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nValores digitados da Matriz B:\n");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
                    //matrizB[i, j] = int.Parse(Console.ReadLine());
                    matrizB[i, j] = random.Next(0, 20);
                    Console.Write("[{0},{1}]: {2} ", i, j, matrizB[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\nSoma das Matrizes:\n");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.WriteLine("MatrizA[{0},{1}] + MatrizB[{0},{1}] = {2} ", i, j, (matrizA[i, j] + matrizB[i,j]) );
                }                
            }
            */

            /* Ex. 16:
            * Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.Transpor uma
            * matriz significa transformar suas linhas em colunas e vice - versa.
            */

            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matrizA = new int[3, 4], matrizP = new int[4, 3];

            Console.WriteLine("Valores digitados da Matriz:\n");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matrizA[i, j] = random.Next(0, 20);
                    Console.Write("[{0},{1}]: {2} ", i, j, matrizA[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\nValores Transportados:\n");
            for (int i = 0; i < matrizP.GetLength(0); i++)
            {
                for (int j = 0; j < matrizP.GetLength(1); j++)
                {                    
                    matrizP[i, j] = matrizA[j,i];
                    Console.Write("[{0},{1}]: {2} ", i, j, matrizP[i, j]);
                }
                Console.WriteLine();
            }
            */

            /* Ex. 17:
            * Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e
            * escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o
            * maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.
            */

            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matriz = new int[10, 10];
            int maior = 0, menor = 1000000000, linhaMaior = 0, colunaMaior = 0, colunaMenor = 0;

            Console.WriteLine("Valores digitados da Matriz:");
            Console.WriteLine("=============================================================\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz: ", i, j);
                    //matriz[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = random.Next(0, 100);
                    Console.Write("[{0},{1}]: {2} ", i, j, matriz[i, j]);
                }
                Console.WriteLine();
            }

            // Buscando o  maior...
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        linhaMaior = i;
                        colunaMaior = j;
                    }
                }
            }

            //Buscando o menor...
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                if (matriz[linhaMaior, i] < menor)
                {
                    menor = matriz[linhaMaior, i];
                    colunaMenor = i;
                }
            }

            Console.WriteLine("=============================================================\n");
            Console.WriteLine("O maior elemento é o {0} e está na posição [{1},{2}] do vetor", maior, linhaMaior, colunaMaior);
            Console.WriteLine("O menor elemento da linha {0} é o {1} e está na coluna {2}", linhaMaior, menor, colunaMenor);

        }
    }
}