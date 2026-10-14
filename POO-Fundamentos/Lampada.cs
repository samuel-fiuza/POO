using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    public class Lampada
    {
        //Atributos
        public bool Ligada;
        //Metodos
        public void Ligar()
        {
            Ligada = true;
        }
        public bool Alternar()
        {
            if (Ligada = true)
            {
                Console.WriteLine("A Lampada está ligada");
            } else
            {
                Console.WriteLine("A Lampada está desligada");
            }
            return (Ligada);
        }
        public void Desligar()
        {
            Ligada = false;
        }
    }
}
