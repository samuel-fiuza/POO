using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Polimorfismo.Exercicio3
{
    public class Violao : Instrumento
    {
        public override void Tocar()
        {
            Console.WriteLine("Violão: plim pllim");
        }
    }
}
