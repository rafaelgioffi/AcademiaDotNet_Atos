using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista8.Exercicios3
{
    public class Asteroides
    {
        /*
        * crie um programa em C# que represente uma lista de asteroides que deveriam ser 
        * 'inseridos' no jogo. Para isso,
        * faça uma classe que contenha os atributos (privados) posição x, posição y
        * (do asteroide em um plano cartesiano), tamanho do asteroide (1 a 10), velocidade 
        * do asteroide (1 a 5) e energia (1 a 5). 
        * Para esses atributos privados, gerar os métodos de acesso (propriedades getter
        * e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro
        * passando todos os parâmetros de um objeto tipo Asteroide, e um terceiro que
        * constrói um asteroide com posição x e posição y.
        * O programa principal (main) deve conter a lista de Asteroides, preenchida pelo
        * usuário. Nesse programa principal, construir um método de classe que exiba todos
        * os asteróides da lista.
    */
        private float _posX { get; set; }
        private float _posY { get; set; }
        private int _tamanho { get; set; }
        private int _velocidade { get; set; }
        private int _energia { get; set; }

        List<Asteroides> asteroide = new List<Asteroides>();
        public Asteroides() { }

        public Asteroides(float posX, float posY, int tamanho, int velocidade, int energia)
        {
            _posX = posX;
            _posY = posY;
            _tamanho = tamanho;
            _velocidade = velocidade;
            _energia = energia;

            Console.WriteLine("Asteroide cadastrado!");
        }

        public Asteroides(float posX, float posY)
        {
            _posX = posX;
            _posY = posY;
        }

        public void CadastraAsteroide(float posX, float posY, int tamanho)
        {
            //Asteroides(posX, posY, tamanho);
        }
        public void getAsteroides()
        {
            foreach (Asteroides a in asteroide)
            {
                Console.WriteLine("X: {0}   Y: {1}   Tamanho: {2}   Velocidade: {3} Mph   Energia: {4}", a._posX, a._posY, a._tamanho, a._velocidade);
            }
        }
    }
}
