using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    internal class TransacaoBancaria
    {
        private string agencia;
        private int tipoConta;
        private double valor;
        private string conta;
        
        public TransacaoBancaria(string ag, string co, int t, double val)
        {
            this.agencia = ag;
            this.conta = co;
            this.tipoConta = t;
            this.valor = val;
        }
        public void Depositar(double deposito)
        {
            valor += deposito;
            Console.WriteLine("Depositando {0:C}. O novo saldo é: {1:C}", deposito, valor);            
        }

        public void Sacar(double saque)
        {
            valor += saque;
            Console.WriteLine("Sacando {0:C}",valor);
            
        }
           
                saldo -= valor;
            }
            return saldo;
        }


        public void Saldo()
        {
            Console.WriteLine("Seu saldo é de {0:C}", saldo);
        }

        public void ExibirDados()
        {
            Console.WriteLine("\nDados do cliente: ");
            Console.WriteLine("\nAgência: {0}\nConta: {1}-{2}\nTipo: {3}", agencia, conta, digito, tipoConta);
        }
    }
}
