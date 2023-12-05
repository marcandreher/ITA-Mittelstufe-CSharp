using System;
using System.Collections.Generic;
using System.Text;

namespace Mittelstufe.OOP
{
    class OOPEins
    {
        public OOPEins()
        {
            CPunkt2D punktEins = new CPunkt2D();
            punktEins.SetX(0);
            punktEins.SetY(0);

            CPunkt2D punktZwei = new CPunkt2D();
            punktZwei.SetX(7);
            punktZwei.SetY(1);
           

            CPunkt2D punktDrei = new CPunkt2D();
            punktDrei.SetX(5);
            punktDrei.SetY(5);

            Console.WriteLine("Punkt 1\nAbstand vom Ursprung: " + punktEins.CalculateDistanceFromOrigin());
            Console.WriteLine("Abstand von Punkt 2: " + punktEins.CalculateDistanceFromPoint(punktZwei));
            Console.WriteLine("Abstand von Punkt 3: " + punktEins.CalculateDistanceFromPoint(punktDrei));

            Console.WriteLine("Punkt 2\nAbstand vom Ursprung: " + punktZwei.CalculateDistanceFromOrigin());
            Console.WriteLine("Abstand von Punkt 1: " + punktZwei.CalculateDistanceFromPoint(punktEins));
            Console.WriteLine("Abstand von Punkt 3: " + punktZwei.CalculateDistanceFromPoint(punktDrei));

            Console.WriteLine("Punkt 3\nAbstand vom Ursprung: " + punktDrei.CalculateDistanceFromOrigin());
            Console.WriteLine("Abstand von Punkt 1: " + punktDrei.CalculateDistanceFromPoint(punktEins));
            Console.WriteLine("Abstand von Punkt 2: " + punktDrei.CalculateDistanceFromPoint(punktZwei));

            double al;
            double ß;
            double y;
            punktEins.CalculateTriangleWinkel(punktZwei, punktDrei, out al, out ß, out y);
            Console.WriteLine("Dreieck:\nAl: " + al + " * \nß: " + ß + " \nY: " + y);
        }
    }
}
