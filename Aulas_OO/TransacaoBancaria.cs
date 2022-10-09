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
        private int tipo;
        private double valor;
        private string conta;
        
        public TransacaoBancaria(string agencia, string conta, int tipo, double valor)
        {
            this.agencia = agencia;
            this.conta = conta;
            this.tipo = tipo;
            this.valor = valor;
        }
        public void Depositar(double deposito)
        {
            valor += deposito;
            Console.WriteLine("Depositando {0:C}. O novo saldo é: {1:C}", deposito, valor);            
        }

        public void Sacar(double saque)
        {
            valor -= saque;
            Console.WriteLine("Sacando {0:C}. O novo saldo é: {1:C}",saque,valor);            
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Seu saldo é de {0:C}", valor);
        }

        public void ExibirDados()
        {
            Console.WriteLine("\nDados do cliente: ");
            Console.WriteLine("Agência: {0}\nConta: {1}\nTipo: {2}\nSaldo: {3}", agencia, conta, tipo,valor);
        }
    }
}
