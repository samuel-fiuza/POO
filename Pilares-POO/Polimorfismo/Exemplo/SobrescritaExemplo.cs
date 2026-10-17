using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Polimorfismo
{
    internal class SobrescritaExemplo
    {
        public virtual void FazerSom()
        {
            Console.WriteLine("O objeto faz som");
        }
    }

    internal class Pedra : SobrescritaExemplo
    {
        public override void FazerSom()
        {
            Console.WriteLine("Crack*");
        }
    }
    internal class Porta : SobrescritaExemplo
    {
        public override void FazerSom()
        {
            Console.WriteLine("Nhack*");
        }
    }
}
