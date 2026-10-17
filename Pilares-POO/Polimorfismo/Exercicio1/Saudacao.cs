using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Polimorfismo.Exercicio1
{
    public class Saudacao
    {
        public void Comprimentar()
        {
            Console.WriteLine("Olá!");
        }
        public void Comprimentar(string nome)
        {
            Console.WriteLine($"Olá {nome}!");
        }

        public void Comprimentar(string nome, int idade)
        {
            Console.WriteLine($"Olá {nome}! Você tem {idade}");
        }

    }
}
