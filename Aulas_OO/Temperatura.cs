using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_OO
{
    internal class Temperatura
    {
        private double celsius = 0;

        public double getCelsius()
        {
            return (((celsius * 9) / 5) + 32);  //converte para fahrenheit
        }

        public void setCelsius(double fahrenheit)
        {
            Console.WriteLine("Fahrenheit: {0:F}", fahrenheit);
            celsius = (((fahrenheit - 32) * 5) / 9);  //converte para celsius
            Console.WriteLine("Celsius: {0:F}", celsius);
        }
    }
}
