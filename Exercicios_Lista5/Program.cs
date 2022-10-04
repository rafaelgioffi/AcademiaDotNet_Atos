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

            int[,] matriz = new int[4, 4];



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
}
