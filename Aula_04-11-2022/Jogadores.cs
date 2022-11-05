using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_11_2022
{
    class Jogadores
    {
        private string _nome { get; set; }
        private string _email { get; set; }

        public Jogadores(string nome, string email)
        {
            _nome = nome;
            _email = email;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
