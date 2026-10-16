using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Hrenca
{
    internal class Funcionario
    {
        public Funcionario(string nome, int salario)
        {
            Nome = nome;
            Salario = salario;
        }
        public string Nome { get; set; }
        public int Salario { get; set; }

         
    }
}
