using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    internal class Aviao
    {
        public string modelo;
        public double velocidade;
        public double altitude;
        public string marca;

        public void reduzir()
        {
            velocidade -= 10;
            Console.WriteLine("Reduzindo velocidade para " + velocidade);
        }
        public void acelerar()
        {
            velocidade += 10;
            Console.WriteLine("Acelerando velocidade para " + velocidade);
        }
        public void descer()
        {
            altitude -= 100;
            Console.WriteLine("Descendo a altitude para " + altitude);
        }
        public void subir()
        {
            altitude += 100;
            Console.WriteLine("Subindo a altitude para " + altitude);
        }
    }
}
