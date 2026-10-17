using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Heranca.Exercicio3
{
    public class Carro1 : Veiculos
    {
        public Carro1(string marca, string modelo, int portas) : base(marca, modelo)
        {
            Portas = portas;
        }

        public int Portas { get; set; }

        public void ExibirPortas()
        {
            Console.WriteLine(Portas);
        }
    }
}
