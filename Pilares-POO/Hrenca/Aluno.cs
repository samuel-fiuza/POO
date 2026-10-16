using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Hrenca
{
    //Pega atributos e metodos da classe "Pai"
    internal class Aluno : Pessoa
    {
        // Tem Nome/Idade/Matricula não se restringindo apenas as classes do "Pai".
        //Mas podendo também adicionar algo a si mesmo
        public  string Matricula { get; set; }
    }
}
