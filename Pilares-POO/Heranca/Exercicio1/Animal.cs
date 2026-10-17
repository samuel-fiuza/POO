using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Hrenca
{
    internal class Animal
    {
        public string Nome { get; set; }
        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo");
        }
    }
}
