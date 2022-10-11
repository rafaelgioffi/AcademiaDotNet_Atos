using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista7.Exercicio7
{
    public class Elevador
    {        
        public int andar { get; set; }
        public int andares { get; set; }
        public int pessoas { get; set; }
        public float capacidade { get; set; }
              
        public void inicializa(float capacidade, int andares)
        {
            this.capacidade = capacidade;
            this.andares = andares;
            this.pessoas = 0;
        }

        public void entra()
        {
            if (pessoas + 1 < capacidade)
            {
                pessoas++;
                Console.WriteLine("{0}/{1} ocupado.", pessoas,capacidade);
            }
            else
            {
                Console.WriteLine("Elevador lotado.");
            }
        }

        public void sai()
        {
            if (pessoas > 0)
            {
                pessoas--;
                Console.WriteLine("{0}/{1} ocupado.", pessoas,capacidade);
            } 
            else
            {
                Console.WriteLine("O elevador está vazio.");
            }
        }

        public void subir()
        {
            if (andar + 1 <= andares)
            {
                andar++;
                Console.WriteLine("Subindo para o {0}º andar...",andar);
            }
            else
            {
                Console.WriteLine("Não foi possível subir. Já estamos no último andar...");

            }
        }
        public void descer()
        {
            if (andar - 1 >= 0)
            {
                andar--;
                Console.WriteLine("Descendo para o {0}º andar...",andar);
            }
            else
            {
                Console.WriteLine("Não foi possível descer. Já estamos no térreo...");
            }
        }

    }
}
