using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO.Exercicio1
{
    public class Livro
    {
        // 1 - Crie uma classe Livro que represente os dados básicos de um livro.
        private string titulo;
        private string autor;
        private string isbn;
        private int paginas;
        private string tipoCapa;

        public Livro(string titulo, string autor, string isbn, int paginas, string tipoCapa)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            this.paginas = paginas;
            this.tipoCapa = tipoCapa;
        }

        public void getLivro() {
            Console.Clear();
            Console.WriteLine("Livro '{0}' cadastrado!", this.titulo);
            Console.WriteLine("Autor: {0}  ISBN: {1}", autor, isbn);
            Console.WriteLine("{0} páginas.  Capa {1}", paginas, tipoCapa);
        }
    }
}
