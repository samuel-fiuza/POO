using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Hrenca
{
    internal class Pessoa
    {
        //É a classe "Pai", define padrões que outras classes vão ter, mas não as restrigem a ela
        //Nesse caso sendo Nome e Idade
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade}");
        }
    }
}
