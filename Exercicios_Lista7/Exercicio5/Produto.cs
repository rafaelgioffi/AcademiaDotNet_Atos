using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista7.Exercicio5
{
    public class Produto
    {
        public string nome;
        public int quantidadeEstoque;
        public double valorUnit;
        public double valorVenda;

        public int vender(int quant)
        {
            if (quantidadeEstoque > quant)
            {
                Console.WriteLine("Venda autorizada!");
                quantidadeEstoque -= quant;
            }
            else
            {
                Console.WriteLine("Quantide insuficiente no estoque!\nVenda não autorizada!");
            }
            return quantidadeEstoque;
        }

        public int repor(int quant)
        {
            quantidadeEstoque += quant;
            return quantidadeEstoque;
        }
    }
}
