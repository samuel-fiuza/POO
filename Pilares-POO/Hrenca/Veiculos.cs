using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Hrenca
{
    public class Veiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Veiculos(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void Exibir()
        {
            Console.WriteLine($"{Marca} | {Modelo}");
        }
    }
}
