using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    public class Carro
    {
        private string placa;
        private string fabricante;
        private bool ligado = false;
        private double velocidadeMax;
        private string modelo;        
        private string cor;

        //getter e setter
        
        public bool getLigado()
        {
            return ligado;
        }
        public void ligar()
        {
            ligado = true;            
        }
        public void desligar()
        {
            ligado = false;
        }
        
        //getters e setters de forma manual
        public string getCor()
        {
            return cor;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }
    }
}
