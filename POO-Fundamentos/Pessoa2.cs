using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    public class Pessoa2
    {
        //Atributo
        public string Nome;

        //Metodos
        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }
        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($"Olá {outraPessoa}! Eu sou {Nome}");
        }
        public string ObterApresentação()
        {
            
            return $"Meu nome é {Nome}.";
        }
    }
}
