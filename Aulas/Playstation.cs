using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    class Playstation : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Estou ligando o Playstation...");
            //ligado = true;
            this.Ligado = true;
        }
    }
}
