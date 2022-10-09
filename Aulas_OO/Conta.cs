using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    public class Conta
    {
        public Cliente cliente;
        private double saldo = 0;
        private string tipo = "corrente";

        public Conta(Cliente cliente, double saldo, string tipo)
        {
            this.cliente = cliente;
            this.saldo = saldo;
            this.tipo = tipo;
        }

        public void creditar(double valor)
        {
            saldo += valor;
            Console.WriteLine("Creditado {0:C}\n", valor);
        }

        public void debitar(double valor)
        {
            saldo -= valor;
            Console.WriteLine("Debitado {0:C}\n", valor);
        }

        public double getSaldo()
        {
            return saldo;
        }

        public void getInfo()
        {
            Console.Clear();
            Console.WriteLine("Cliente: {0}", cliente.nome);
            Console.WriteLine("Idade: {0} anos", cliente.idade);
            Console.WriteLine("Conta: {0}", tipo);
            Console.WriteLine("Saldo: {0:C}\n", getSaldo());
        }
    }
}
