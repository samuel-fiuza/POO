using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Polimorfismo.Exercicio2
{
    public class CalculadoraDeArea
    {
        public double CalcularArea(double a)
        {
            return a * a;
        }
        public double CalcularArea(double a, double b)
        {
            return a * b;
        }
    }
}
