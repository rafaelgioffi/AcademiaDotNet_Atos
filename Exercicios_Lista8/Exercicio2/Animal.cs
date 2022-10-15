using Exercicios_Lista8.Exercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista8.Exercicio2
{
    public class Animal
    {
        private string _nome { get; set; }
        private string _tipo { get; set; }
               
        public Animal() { }
        public Animal(string nome, string tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }
        public string Nome { get => _nome; set => _nome = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }       

        public static void ExibeAnimais(List<Animal> a)
        {
            Console.WriteLine("*** Relatório final ***");
            Console.WriteLine("{0} cachorros.",a.Count((a) => a._tipo == "Cachorro"));
            Console.WriteLine("{0} gatos.",a.Count((a) => a._tipo == "Gato"));
            Console.WriteLine("{0} peixes.",a.Count((a) => a._tipo == "Peixe"));            
        }

    }
}
