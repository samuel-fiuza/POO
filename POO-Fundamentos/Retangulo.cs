using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    public class Retangulo
    {
        //Atributos
        public double Altura;
        public double Largura;

        //Metodos
        public double CalcularArea()
        {
            double Area = Largura * Altura;
            return Area;
        }

        public double CalcularPerimetro()
        {
            double Perimetro = 2 * (Largura + Altura);
            return Perimetro;
        }
    }
}
