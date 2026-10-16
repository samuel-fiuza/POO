using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Hrenca
{
    public class Moto : Veiculos
    {
        public Moto(string marca, string modelo, int cilindradas) : base(marca, modelo)
        {
            Cilindradas = cilindradas;
        }

        public int Cilindradas { get; set; }

        public void ExibirCilindradas()
        {
            Console.WriteLine(Cilindradas);
        }
    }
}
