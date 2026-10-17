using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Polimorfismo.Exercicio3
{
    public class Instrumento
    {
        public virtual void Tocar()
        {
            Console.WriteLine("Tocando um Instrumento");
        }
    }
}
