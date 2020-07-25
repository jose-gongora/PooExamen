using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerparcial
{
    class circulo:Figurageometrica, Calculoperimetro
    {
        public int Radio { get; set; }
        public char pi { get; set; }

        public void Calculoperimetro()
        {
            int resultado = pi * (Radio * Radio);
            
        }
    }
}
