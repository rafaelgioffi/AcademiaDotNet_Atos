using System;

namespace PrimeiraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aula dia 22/09
            //Parte 1
            /*
            int n;
            double x;
            Console.Write("Digite um valor para N: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor para X: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("O N digitado foi " + n);
            Console.WriteLine("O X digitado foi " + n);
            n = Convert.ToInt32(x);           
            */
            //comentário de 1 linha
            /* comentário de 2 ou mais linhas */

            //Parte 2
            //verificar se é positivo ou negativo
            /*
            int num;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positivo!");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negativo!");
            }
            else
            {
                Console.WriteLine("Zero!");
            }
            */

            //Aula dia 23/09
            // Ex. 4
            /*
            int num;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Divisível por 2");
            }
            if (num % 4 == 0)
            {
                Console.WriteLine("Divisível por 4");
            }
            if (num % 8 == 0)
            {
                Console.WriteLine("Divisível por 8");
            }
            */

            //Ex.12
            /*
            double num1, num2, resultado;
            int op;

            Console.WriteLine("Digite dois números: ");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a operação:\n1.Soma\n2.Subtração\n3.Multiplicação\n4.Divisão\n5.Potência\n\nEscolha:");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine("Soma: " + resultado);
            }
            else if (op == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine("Subtração: " + resultado);
            }
            else if (op == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine("Multiplicação: " + resultado);
            }
            else if (op == 4)
            {
                resultado = num1 / num2;
                Console.WriteLine("Divisão: " + resultado);
            }
            else if (op == 5)
            {
                resultado = Math.Pow(num1, num2);
                Console.WriteLine("Potência: " + resultado);
            }
            */

            //Ex. 19
            /*
            int l1, l2, l3;

            Console.WriteLine("Informe os 3 lados de um triângulo:");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());

            if (l1 < (l2 + l3) && l2 < (l1 + l3) && l3 < (l1 + l2))
            {
                Console.Write("É um triângulo ");

                if (l1 == l2 && l2 == l3)
                {
                    Console.WriteLine("equilátero");
                }
                else if (l1 == l2 || l1 == l3 || l2 == l3)
                {
                    Console.WriteLine("isósceles");
                }
                else
                {
                    Console.WriteLine("escaleno");
                }
            } else
            {
                Console.WriteLine("Não é um triângulo!");
            }
            */

            //================================
            // Lista de exercícios sequenciais
            //================================

            /* Exercício 1
             * Escreva um programa em C# e no Visual Studio
             * para calcular a média aritmética entre dois 
             * números quaisquer.
            */

            /*
            float nota1, nota2, resultado;

            Console.Write("Digite a Note 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a Note 2: ");
            nota2 = float.Parse(Console.ReadLine());

            resultado = (nota1 + nota2) / 2;

            Console.WriteLine("A média foi: " + resultado);
            */

            /* Exercício 2
             * Escreva um programa em C# e no Visual Studio
             * para calcular a média aritmética
             * entre quatro números quaisquer.
            */

            /*
            double[] notas = new double[4];
            double nota1, nota2, nota3, nota4, resultado=0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite a Nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
                resultado += notas[i];
            }

            resultado = resultado / 4;

            Console.WriteLine("\nA média foi: " + resultado);            
            */

            /* Exercício 3
             * Escreva a seqüência de atribuições, em forma de programa
             * em C# e no Visual Studio, para trocar entre si os valores
             * de duas variáveis A e B.
             */
            /*
            int a, b, auxiliar;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            auxiliar = b;
            b = a;
            a = auxiliar;

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            */

            /* Exercício 4 
             * (versão com int)
             * Faça um programa em C# e no Visual Studio que receba
             * a data na forma DDMMAAAA e imprima na forma AAAAMMDD
             * e AAMMDD. Note que o dia, o mês e o ano devem ser lidos 
             * em variáveis diferentes.
             */

            /*
            int dia, mes, ano;

            Console.Write("Informe o dia. Ex.: 22: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Informe o mês. Ex.: 05: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Informe o ano. Ex.: 2022: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine(ano + "/" + mes + "/" + dia);

            ano = ano % 100;

            Console.WriteLine(ano + "/" + mes + "/" + dia);
                        
            // ( versão com string)
            /*
            string dia, mes, ano;

            Console.Write("Informe o dia. Ex.: 22: ");
            dia = Console.ReadLine();

            Console.Write("Informe o mês. Ex.: 05: ");
            mes = Console.ReadLine();

            Console.Write("Informe o ano. Ex.: 2022: ");
            ano = Console.ReadLine();

            Console.WriteLine(ano + "/" + mes + "/" + dia);
            ano = ano.Substring(2, 2);
            Console.WriteLine(ano + "/" + mes + "/" + dia);
             */
            
            //versão com Datetime
            
            /*
            DateTime data;

            Console.Write("Informe a data no formato DD/MM/AAAA: ");
            data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\n" + String.Format("{0:yyyy/MM/dd}", data));
            Console.WriteLine("\n" + String.Format("{0:yy/MM/dd}", data));
            */

            /* Exercício 5
             * Escreva um programa em C# e no Visual Studio para calcular o consumo médio
             * de um automóvel (medido em Km/l), sendo que são conhecidos a distância total 
             * percorrida e o volume de combustível consumido para percorrê-la (medido em l).
             */

            /*
            double consumo, distancia, litros;

            Console.Write("Informe a distância percorrida: ");
            distancia = double.Parse(Console.ReadLine());

            Console.Write("Informe a gasolina gasta em Litros: ");
            litros = double.Parse(Console.ReadLine());

            consumo = distancia / litros;

            Console.Write("Você percorreu " + distancia + "Km e gastou " + litros + "L de combustível. Seu consumo médio foi de " + consumo + "Km/L");
            */

            /* Exercício 6
             * Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A 
             * e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário
             * de cada parafuso e a porcentagem de IPI (única) a ser acrescentada.
             */

            /*
            string codigoA, codigoB;
            double parafusoA, parafusoB, ipi, valorfinalA, valorfinalB;
            int quantA, quantB;

            Console.Write("Informe o código do Parafuso A: ");
            codigoA = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Informe a quantidade de Parafusos A: ");
            quantA = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Informe o valor unitário do Parafuso A: R$");
            parafusoA = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Clear();

            Console.Write("Informe o código do Parafuso B: ");
            codigoB = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Informe a quantidade de Parafusos B: ");
            quantB = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Informe o valor unitário do Parafuso B: R$");
            parafusoB = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Informe a % do IPI: ");
            ipi = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            valorfinalA = ((parafusoA * quantA) * (ipi / 100)) + (parafusoA * quantA);
            valorfinalB = ((parafusoB * quantB) * (ipi / 100)) + (parafusoB * quantB);

            Console.WriteLine("Parafuso A custará " + valorfinalA.ToString("C") + " e cada um custará " + (valorfinalA / quantA).ToString("C"));
            Console.WriteLine("Parafuso B custará " + valorfinalB.ToString("C") + " e cada um custará " + (valorfinalB / quantB).ToString("C"));
            */

            /* Exercício 7
             * Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, 
             * o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha 
             * sobre o total de vendas. Calcule o salário total do vendedor. 
             * Escreva o número do vendedor e o salário total do vendedor.
             */
            /*
            int numVendedor;
            double salario, totalVendas, percent, final;

            Console.Write("Informe o número do vendedor: ");
            numVendedor = int.Parse(Console.ReadLine());

            Console.Write("Informe o salário fixo do vendedor: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas do vendedor: ");
            totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Informe o percentual sobre as vendas do vendedor: ");
            percent = double.Parse(Console.ReadLine());

            final = salario + (totalVendas * (percent / 100));

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("O vendedor (" + numVendedor + ") irá receber " + final.ToString("C") + " esse mês.");
            */

            /* Exercício 8
             * Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
             * A fórmula da conversão é F=(9*C+160)/5.
            */
            /*
            double celsius, fahrenheit;

            Console.Write("Informe a temperatura em graus ºC: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine(celsius + " ºC é igual a " + fahrenheit + " ºF");
            */

            /* Exercício 9
             * Uma loja vende seus produtos no sistema de entrada mais duas prestações,
             * sendo a entrada maior do que ou igual às duas prestações, que devem ser iguais, 
             * inteiras e as maiores possíveis. Por exemplo, se o valor da mercadoria for R$ 270,00,
             * a entrada e as duas prestações são iguais a R$ 90,00; se o valor da mercadoria
             * for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00. 
             * Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e 
             * forneça o valor da entrada e das duas prestações, de acordo com as regras acima.
             * Observe que uma justificativa para a adoção desta regra é que ela facilita a 
             * confecção e o conseqüente pagamento dos boletos das duas prestações.
             */
            
            /*
            double valorProduto, prestacao=0, resto, entrada;

            Console.Write("Informe o valor total do produto: R$");
            valorProduto = double.Parse(Console.ReadLine());

            resto = valorProduto % 3;
            valorProduto = valorProduto - resto;
            prestacao = valorProduto / 3;
            entrada = prestacao + resto;
                        
            Console.WriteLine("Entrada: " + entrada.ToString("C"));
            Console.WriteLine("2 parcelas de " + prestacao.ToString("C"));
            */

            //Exercício 10
            /* Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum
             * mecanismo para decidir o número de notas de cada valor que deve ser disponibilizado
             * para o cliente que realizou o saque. Um possível critério seria o da “distribuição
             * ótima” no sentido de que as notas de menor valor fossem distribuídas em número mínimo
             * possível. Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria
             * indicar uma nota de R$ 50,00, três notas de R$ 10,00, uma nota de R$ 5,00
             * e duas notas de R$ 1,00. Escreva um programa que receba o valor da quantia
             * solicitada e retorne a distribuição das notas de acordo com o critério da
             * “distribuição ótima”.
             */

            /*
            int duzentos = 0, cem = 0, cinquenta = 0, vinte = 0, dez = 0, cinco = 0, dois = 0, um = 0;
            double valor;

            Console.Write("Informe o valor do saque: R$");
            valor = double.Parse(Console.ReadLine());

            duzentos = (int)(valor / 200);
            Console.WriteLine("Notas de R$200: " + duzentos);
            valor = valor - (100 * duzentos);
            
            cem = (int)(valor / 100);
            Console.WriteLine("Notas de R$100: " + cem);
            valor = valor - (100 * cem);

            cinquenta = (int)(valor / 50);
            Console.WriteLine("Notas de R$50: " + cinquenta);
            valor = valor - (50 * cinquenta);
            
            vinte = (int)(valor / 20);
            Console.WriteLine("Notas de R$20: " + vinte);
            valor = valor - (20 * vinte);
            
            dez = (int)(valor / 10);
            Console.WriteLine("Notas de R$10: " + dez);
            valor = valor - (10 * dez);
            
            cinco = (int)(valor / 5);
            Console.WriteLine("Notas de R$5: " + cinco);
            valor = valor - (5 * cinco);
            
            dois = (int)(valor / 2);
            Console.WriteLine("Notas de R$2: " + dois);
            valor = valor - (2 * dois);
            um = (int)(valor / 1);
            Console.WriteLine("Moedas de R$1: " + um);
            valor = valor - (1 * um);
            */           

            /* Exercício 11
             * Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, 
             * nulos e válidos. Calcule e escreva o percentual que cada um  representa em relação ao
             * total de eleitores.
             */

            /*
            int eleitores;
            double brancos, nulos, validos;

            Console.Write("Informe o total de eleitores do município: ");
            eleitores = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.Write("Informe o total de votos válidos: ");
            validos = int.Parse(Console.ReadLine());
            
            Console.Clear();

            Console.Write("Informe o total de votos brancos: ");
            brancos = int.Parse(Console.ReadLine());
            
            Console.Clear();

            Console.Write("Informe o total de votos nulos: ");
            nulos = int.Parse(Console.ReadLine());

            validos = (validos * 100) / eleitores;
            brancos = (brancos * 100) / eleitores;
            nulos = (nulos * 100) / eleitores;

            Console.Clear();
            Console.WriteLine(eleitores + " eleitores sendo:\n" + validos + "% dos votos válidos.\n" + brancos + "% dos votos em branco\n" + nulos + "% dos votos nulos");
            */

            /* Exercício 12
             *  Um motorista de taxi deseja calcular o rendimento de seu carro na praça. 
             *  Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler
             *  a marcação do odômetro (marcador de quilometragem) no início do dia, a marcação 
             *  no final do dia, o número de litros de combustível gasto e o valor total (R$)
             *  recebido dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro 
             *  líquido do dia.
             *  Fórmulas: 
             *  Total quilometragem =  
             *  marcação odômetro final do dia - marcação odômetro inicio do dia 
             *  Média do consumo = Total quilometragem/ quantidade de combustível gasto
             *  Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
             */
            /*
            int kmInicio, kmFim, totalKm;
            double precoCombustivel = 6.90, litrosDias, valorRecebido, media, lucroDia;

            Console.Write("Informe a kilometragem inicial do dia: ");
            kmInicio = int.Parse(Console.ReadLine());

            Console.Write("Informe a kilometragem final do dia: ");
            kmFim = int.Parse(Console.ReadLine());
            
            Console.Write("Informe quantos litros de combustível foram gastos no dia: ");
            litrosDias = double.Parse(Console.ReadLine());
            
            Console.Write("Informe o faturamento do dia: R$");
            valorRecebido = double.Parse(Console.ReadLine());

            totalKm = kmFim - kmInicio;
            media = totalKm / litrosDias;
            lucroDia = valorRecebido - (litrosDias * precoCombustivel);

            Console.Clear();
            Console.WriteLine("Hoje você percorreu " + totalKm + " Km e fez uma média de " + media + " Km/l e com isso lucrou " + lucroDia.ToString("C"));
            */

            /* Exercício 13
             * Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga 
             * a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o preço 
             * de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do 
             * salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas vendidas 
             * pelo vendedor, calcule e mostre: o salário do empregado
             */            
           
            /*
            double precoCusto, salario, comissao = 15, salarioBase, comissaoPorVenda, salarioCalculado;
            int bikesVendidas;

            Console.Write("Informe o preço de custo da bicicleta: R$");
            precoCusto = double.Parse(Console.ReadLine());
                        
            Console.Write("Informe a quantidade de bicicletas vendidas: ");
            bikesVendidas = int.Parse(Console.ReadLine());
            
            Console.Write("Informe o valor do salário mínimo: R$");
            salario = double.Parse(Console.ReadLine());

            Console.Clear();

            salarioCalculado = (salario * 2) + (precoCusto * (comissao / 100) * bikesVendidas);
                        
            Console.WriteLine("O vendedor receberá " + salarioCalculado.ToString("C") + " de salário esse mês");
            */
        }
    }
}
