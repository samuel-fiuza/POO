using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    public class ConversorTemp
    {
        //Metodos
        public double CalcularCelciusParaFahrenheint(double celcius)
        {
            return celcius * 1.8 + 32;
        }
        public bool EstaQuente(double celcius)
        {
            return (celcius >= 30 == true);
        }
    }
}
