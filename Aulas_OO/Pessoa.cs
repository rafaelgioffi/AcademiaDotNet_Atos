using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    internal class Pessoa
    {
        /* 2 - Escreva uma classe Pessoa contendo todos os atributos de uma pessoa.
        * Faça métodos para apresentar os dados. */

        string nome;
        int idade;
        int altura;
        double peso;
        string sexo;
        string olhos;
        string cabelos;
        string raca;

        public Pessoa(string nome, int idade, int altura, double peso, string sexo, string olhos, string cabelos, string raca)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
            this.olhos = olhos;
            this.cabelos = cabelos;
            this.raca = raca;
        }
    }
}
