using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    public class Cliente
    {
        public string nome;
        public int idade;

        public static implicit operator Cliente(Estacionamento.Cliente v)
        {
            throw new NotImplementedException();
        }
    }
}
