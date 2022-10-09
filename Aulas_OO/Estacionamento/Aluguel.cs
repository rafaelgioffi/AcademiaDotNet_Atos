using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Aulas_OO.Estacionamento
{
    public class Aluguel
    {
        private DateTime inicioAluguel;
        private DateTime fimAluguel;
        private double valorDiaria;


        public void alugar(DateTime inicio, DateTime fim, double valor)
        {
            this.inicioAluguel = inicio;
            this.fimAluguel = fim;
            this.valorDiaria = valor;
        }
        
    }
}
