using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO
{
    public class ContVisit
    {
        public int Visitas { get; private set; }
        public int RegistrarVisitas()
        {
            Visitas++;
                return Visitas;
        }

        public int ValorTotal()
        {
            
            return Visitas;
        }
        
    }
}
