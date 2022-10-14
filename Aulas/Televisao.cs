using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    class Televisao : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Estou ligando a TV...");
            //_ligado = true;
            this.Ligado = true;
        }
    }
}
