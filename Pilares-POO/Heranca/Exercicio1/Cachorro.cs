using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Hrenca
{
    internal class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine($"{Nome}: Au, au!");
        }
    }
}
