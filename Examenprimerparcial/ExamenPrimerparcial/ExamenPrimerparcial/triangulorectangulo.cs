using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerparcial
{
    class triangulorectangulo: Figurageometrica, Calculoperimetro
    {
        public int Base { get; set; }
        public int altura { get; set; }
        public int hipotenusa { get; set; }

        public void Calculoperimetro()
        {
            int resultado = Base + altura + hipotenusa;
            
        }
    }
}
