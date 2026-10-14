using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    public class Pessoa
    {
        //atributos
        public string Nome;
        public int Idade;

        //metodos
        public void Apresentacoes()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}
