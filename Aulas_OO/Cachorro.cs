using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public override void emitirSom()
        {
            Console.WriteLine("Latindo o cusco");
        }
    }
}
