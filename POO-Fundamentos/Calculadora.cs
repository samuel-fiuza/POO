using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    public class Calculadora
    {
        //Metodos
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public void MostrarResultaos (int Valor)
        {
            Console.WriteLine(Valor);
        }
    }
}
