using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    abstract class Animal
    {
        protected string nome;
        protected string sexo;
        protected string raca;        

        public Animal(string nome, string sexo, string raca)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raca = raca;
        }

        public abstract void emitirSom();        

        public void dormir()
        {
            Console.WriteLine("Ta a mimir");
        }

        public void caminhar()
        {
            Console.WriteLine("Caminhando o indivíduo");
        }
        public void mostraDados()
        {
            Console.WriteLine("Nome: {0}   Sexo: {1}   Raça: {2}", nome, sexo, raca);
        }
    }
}