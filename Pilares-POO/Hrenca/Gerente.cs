using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Hrenca
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, int salario, double bonus) : base(nome, salario)
        {
            Bonus = bonus;
        }

        public double Bonus { get; set; }

        public double SalarioComBonus()
        {
            return Salario + Bonus;
        }
    }

}
