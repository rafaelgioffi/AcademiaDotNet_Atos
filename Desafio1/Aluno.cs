using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Aluno : Pessoa
    {
        private string _matricula { get; set; }
        private string _codigo { get; set; }
        private string _nomeCurso { get; set; }
        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, string matricula, string codigo, string nomeCurso) : base(nome, telefone, cidade, rg, cpf) 
        {
            _matricula = matricula;
            _codigo = codigo;
            _nomeCurso = nomeCurso;
        }

        public string Matricula { get => _matricula; set => _matricula = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string NomeCurso { get => _nomeCurso; set => _nomeCurso = value; }
    }
}
