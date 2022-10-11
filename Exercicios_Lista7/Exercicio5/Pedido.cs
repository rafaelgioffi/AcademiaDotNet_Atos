using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista7.Exercicio5
{
    public class Pedido
    {
        public int quantPedido;
        public string formaPagamento;
        public Produto produto;
        public double valorPedido;

        public void calcularPedido()
        {
            valorPedido = produto.valorVenda * quantPedido;
            Console.WriteLine("O pedido custará {0:C}", valorPedido);
        }
    }
}
