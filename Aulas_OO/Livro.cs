using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    internal class Livro
    {
        // 1 - Crie uma classe Livro que represente os dados básicos de um livro.
        string titulo;
        string autor;
        string isbn;
        int paginas;
        string tipoCapa;

        public Livro(string titulo, string autor, string isbn, int paginas, string tipoCapa)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            this.paginas = paginas;
            this.tipoCapa = tipoCapa;
        }
    }
}
