using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO.AluguelDeCarros
{
    public class Carro
    {
        private string placa;
        private string modelo;
        private string cor;
        
        public void setPlaca(string placa)
        {
            this.placa = placa;
        }

        public string getPlaca()
        {
            return placa;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getModelo()
        {
            return modelo;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }

        public string getCor()
        {
            return cor;
        }
    }
}
