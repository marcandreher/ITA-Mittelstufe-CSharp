using System;
using System.Collections.Generic;

namespace Mittelstufe.Mathe
{
    class FunktionenDritter
    {


        public FunktionenDritter()
        {
            List<long> resultValues = new List<long>();
            long a3, a2, a1, a0;
            long startX;
            long endX;

            Console.Write("Bitte geben Sie einen Wertebereich an (0-20): ");
            string temp = Console.ReadLine();
            string[] temp2 = temp.Split("-");
            startX = Convert.ToInt64(temp2[0]);
            endX = Convert.ToInt64(temp2[1]);

            Console.Write("Bitte geben Sie einen Wert für a3 an: ");
            a3 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Bitte geben Sie einen Wert für a2 an: ");
            a2 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Bitte geben Sie einen Wert für a1 an: ");
            a1 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Bitte geben Sie einen Wert für a0 an: ");
            a0 = Convert.ToInt64(Console.ReadLine());

            for (long x = startX; x <= endX; x++)
            {
                resultValues.Add(getFunctionThirdGrade(x, a3, a2, a1, a0));
            }


            for(int i = 0; i < resultValues.Count; i++)
            {
                Console.WriteLine("x: \t " + i +" | y: \t " + resultValues[i]);
            }
        }

        long getFunctionThirdGrade(long x, long a3, long a2, long a1, long a0)
        {
            return ((long)(Math.Pow(a3 * x, 3)
                + Math.Pow(a2 * x, 2)
                + a1 * x + a0));
        }




    }
}
