using System;
using System.Collections.Generic;

namespace ExamenPrimerparcial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // List<Figurageometrica> Listita = new List<Figurageometrica>()
            //{new List<Figurageometrica>(){ nombrefigura = "rectangulo", color = "azul"  },
            //};

            List<Figurageometrica> Listita = new List<Figurageometrica>();
            Listita.Add(new Figurageometrica("Rectangulo", "azul"));
            Listita.Add(new Figurageometrica("Triangulo Rectangulo", "verde"));
            Listita.Add(new Figurageometrica("Circulo", "rojo"));
            foreach (var Figurageometrica in Listita)
                Console.WriteLine(Figurageometrica.nombrefigura, Figurageometrica.color);
            
            {

            }
        }
    }
}
