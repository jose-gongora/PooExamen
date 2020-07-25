using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ExamenPrimerparcial
{
    class Rectangulo : Figurageometrica,  Calculoperimetro
    {
        public int altura { get; set; }
        public int Base { get; set; }

        public void Calculoperimetro()
        {
            int resultado = 2*(altura * Base);
            
        }
    }
}
