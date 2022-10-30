<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista11
{
    class Emails
    {
        private string _nome { get; set; }
        private string _email { get; set; }

        public Emails (string nome, string email)
        {
            _nome = nome;
            _email = email;
        }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista11
{
    class Emails
    {
        private string _email { get; set; }
        private string _dominio { get; set; }

        public Emails (string email) 
        {
            Email = email;
        }

        public Emails(string dominio)
        {
            Dominio = dominio;
        }
        
        public string Email { get => _email; set => _email = value; }
        public string Dominio { get => _dominio; set => _dominio = value; }
    }
}
>>>>>>> f2baf1f (update)
