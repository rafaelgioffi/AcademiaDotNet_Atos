using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista9
{
     class Figurinha
    {
        private string _codigoFigurinha { get; set; }
        private string _selecao { get; set; }
        private string _nomeJogador { get; set; }

        public Figurinha(string codigo, string selecao, string nomeJogador)
        {
            _codigoFigurinha = codigo;
            _selecao = selecao;
            _nomeJogador = nomeJogador;
        }

        public string CodigoFigurinha { get => _codigoFigurinha; set => _codigoFigurinha = value; }
        public string Selecao { get => _selecao; set => _selecao = value; }
        public string NomeJogador { get => _nomeJogador; set => _nomeJogador = value;}
    }
}
