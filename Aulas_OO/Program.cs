using System.Runtime.Intrinsics.X86;

namespace Aulas_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aula do dia 06/10

            //Console.WriteLine("Apresentando Classes, objetos, métodos e orientação a objetos básica");

            /* Exemplo 1
            /* 
            * Lampada l1 = new Lampada();
            * bool retorno;
            *
            *l1.ligar();
            *retorno = l1.estaLigada();
            *
            *Console.WriteLine("Status da lâmpada: " + retorno);
            *l1.desligar();
            *retorno = l1.estaLigada();
            *Console.WriteLine("Status da lâmpada: " + retorno);
            */

            //Exemplo 2
            //Aviao a = new Aviao();
            //a.marca = "AirBus";
            //a.modelo = "A330";
            //a.altitude = 10000;
            //a.velocidade = 800;
            //a.acelerar();
            //a.descer();
            //a.reduzir();
            //a.subir();

            /* Exemplo 3
                         
            string ag;
            int tp;
            double val;
            string c;
            double s, d;
            
            Console.Write("Digite o número da agência: ");
            ag = Console.ReadLine();
            Console.Write("Digite o número da conta: ");
            c = Console.ReadLine();
            Console.Write("Digite o tipo da conta. 1 - para conta corrente\n2 - para conta poupança: ");
            tp = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor inicial a ser depositado na conta: ");
            val = double.Parse(Console.ReadLine());            

            TransacaoBancaria conta = new TransacaoBancaria(ag,c,tp,val);

            conta.ExibirDados();
            Console.WriteLine("Digite o valor do saque: ");
            s = double.Parse(Console.ReadLine());
            conta.Sacar(s);
            conta.ConsultarSaldo();
            Console.WriteLine("Digite o valor do depósito: ");
            d = double.Parse(Console.ReadLine());
            conta.Depositar(d);
            */

            //Aula 07/10/22

            //Carro carro = new Carro();
            //carro.ligar();

            ////carro.ligado = true;
            ////carro.ligado = false;
            ////carro.cor = "azul";
            //carro.setCor("azul");
            ////carro.modelo = "";
            ////carro.velocidadeMax = 100;
            ////carro.placa = "";

            ////string x = carro.placa;

            //Console.WriteLine(carro.getCor());

            //bool status = carro.getLigado();

            //if (status)
            //{
            //    Console.WriteLine("O carro foi ligado");
            //}
            //else
            //{
            //    Console.WriteLine("O carro foi desligado");
            //}

            // Exercicio:

            //Console.Write("Digite uma temperatura em Fahrenheit: ");

            //Temperatura temp = new Temperatura();
            //temp.setCelsius(double.Parse(Console.ReadLine()));

            //Console.WriteLine("--------------");
            //Console.WriteLine(temp.getCelsius());

            /*
            Cliente cliente = new Cliente();
            cliente.nome = "Fabrício";
            cliente.idade = 22;

            Conta c = new Conta(cliente, 999999.53, "Corrente");

            while (true)
            {
                Console.Write("Digite\n1 para sacar\n2 para depositar\n3 para consultar saldo\n4 para informações\ne 0 para sair\nOpção: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Quanto deseja sacar? ");
                        c.debitar(double.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Quanto deseja depositar? ");
                        c.creditar(double.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("O saldo é de {0:C}\n",c.getSaldo());
                        break;
                    case 4:
                        Console.Clear();
                        c.getInfo();
                        break;
                    default:
                        Console.Clear();
                        return;
                }
            }            

        }
    }
}