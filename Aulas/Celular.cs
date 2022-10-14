using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    class Celular : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Android iniciando...");
            //ligado = true;
            this.Ligado = true;
        }
    }
}
