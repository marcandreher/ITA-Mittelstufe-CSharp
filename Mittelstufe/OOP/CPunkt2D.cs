using System;
using System.Collections.Generic;
using System.Text;

namespace Mittelstufe.OOP
{
    class CPunkt2D
    {
        private int X;
        private int Y;

        public int GetX()
        {
            return X;
        }

        public void SetX(int X)
        {
            this.X = X;
        }

        public int GetY()
        {
            return Y;
        }

        public void SetY(int Y)
        {
            this.Y = Y;
        }

        public double CalculateDistanceFromOrigin()
        {
            CPunkt2D origin = new CPunkt2D();
            origin.SetY(0);
            origin.SetX(0);

            return CalculateDistanceFromPoint(origin);
        }

        public void CalculateTriangleWinkel(CPunkt2D diffPunktOne, CPunkt2D diffPunktTwo, out double al, out double ß, out double y)
        {
            double a = CalculateDistanceFromPoint(diffPunktOne);
            double b = diffPunktOne.CalculateDistanceFromPoint(diffPunktTwo);
            double c = diffPunktTwo.CalculateDistanceFromPoint(this);
            Console.WriteLine((Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * b * c));
            al = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * b * c));
            ß = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) + Math.Pow(b, 2)) / (2 * b * c));
            y = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) / (2 * b * c));
        }

        public double CalculateDistanceFromPoint(CPunkt2D point)
        {
            return Math.Sqrt(Math.Pow((point.GetX() - (GetX())), 2) + Math.Pow((point.GetY() - GetY()), 2));
        }
    }
}
