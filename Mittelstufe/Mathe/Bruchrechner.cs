using System;
using System.Collections.Generic;
using System.Text;

namespace Mittelstufe.Mathe
{
    class Bruchrechner
    {
        struct Bruch
        {
            public double zaeler;
            public double nenner;
        }

        public Bruchrechner()
        {
            Bruch bruchEins, bruchZwei, bruchErg, bruchZw, bruchZw2 = new Bruch();
            string operatorBr;


            while (true)
            {
                Console.Clear();
                start();
                bruchEins.zaeler = Convert.ToDouble(Console.ReadLine());
                WriteColors(ConsoleColor.Red, "\t—\n\t");
                bruchEins.nenner = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                start();
                Console.WriteLine(bruchEins.zaeler + "\n\t—\n\t" + bruchEins.nenner);
                for (int i = 0; i < 50; i++) Console.Write("-");
                Console.WriteLine();
                Console.Write("Welche Mathematischer Opetator soll auf Ihre Brüche angewandt werden? (+,-,*,/): ");
                operatorBr = Console.ReadLine();

                Console.Clear();
                start();
                Console.WriteLine(bruchEins.zaeler + "\n\t—\t" + operatorBr + "\n\t" + bruchEins.nenner);
                for (int i = 0; i < 50; i++) Console.Write("-");
                Console.Write("\n\t");
                bruchZwei.zaeler = Convert.ToDouble(Console.ReadLine());
                WriteColors(ConsoleColor.Red, "\t—\n\t");
                bruchZwei.nenner = Convert.ToDouble(Console.ReadLine());

                Console.Clear();
                start();
                Console.WriteLine(bruchEins.zaeler + "\t\t" + bruchZwei.zaeler + "\n\t—\t" + operatorBr + "\t—\n\t" + bruchEins.nenner + "\t\t" + bruchZwei.nenner);
                for (int i = 0; i < 50; i++) Console.Write("-");
                Console.Write("\n\t");
                bruchErg.zaeler = 0;
                bruchErg.nenner = 0;
                double gdcBruchEins = findGDCBetter(bruchEins);
                double gdcBruchZwei = findGDCBetter(bruchZwei);
                switch (operatorBr)
                {
                    case "*":
                        bruchErg.zaeler = bruchEins.zaeler * bruchZwei.zaeler; // Multipliziere mit Zaeler
                        bruchErg.nenner = bruchEins.nenner * bruchZwei.nenner;
                        var bruchErgGDC = findGDCBetter(bruchErg);
                        if (bruchErgGDC != 0)
                        {
                            bruchErg.zaeler = bruchErg.zaeler / bruchErgGDC;
                            bruchErg.nenner = bruchErg.nenner / bruchErgGDC;
                        }
                        break;
                    case "/":
                        bruchErg.zaeler = bruchEins.zaeler * bruchZwei.nenner; // Multipliziere mit Nenner
                        bruchErg.nenner = bruchEins.nenner * bruchZwei.zaeler;
                        var bruchErgGDC2 = findGDCBetter(bruchErg);
                        if (bruchErgGDC2 != 0)
                        {
                            bruchErg.zaeler = bruchErg.zaeler / bruchErgGDC2;
                            bruchErg.nenner = bruchErg.nenner / bruchErgGDC2;
                        }
                        break;
                    case "+":
                        bruchZw = bruchEins;
                        bruchZw2 = bruchZwei;
                        bruchEins.zaeler = bruchZw2.nenner * bruchZw.zaeler;
                        bruchEins.nenner = bruchZw2.nenner * bruchZw.nenner;

                        bruchZwei.zaeler = bruchZw.nenner * bruchZw2.zaeler;
                        bruchZwei.nenner = bruchZw.nenner * bruchZw2.nenner;

                        bruchErg.zaeler = (bruchEins.zaeler + bruchZwei.zaeler);
                        bruchErg.nenner = bruchEins.nenner;

                        gdcBruchEins = findGDCBetter(bruchErg);
                        if (gdcBruchEins != 0)
                        {
                            bruchErg.zaeler = bruchErg.zaeler / gdcBruchEins;
                            bruchErg.nenner = bruchErg.nenner / gdcBruchEins;
                        }

                        break;
                    case "-":
                        bruchZw = bruchEins;
                        bruchZw2 = bruchZwei;
                        bruchEins.zaeler = bruchZw2.nenner * bruchZw.zaeler;
                        bruchEins.nenner = bruchZw2.nenner * bruchZw.nenner;

                        bruchZwei.zaeler = bruchZw.nenner * bruchZw2.zaeler;
                        bruchZwei.nenner = bruchZw.nenner * bruchZw2.nenner;

                        bruchErg.zaeler = (bruchEins.zaeler - bruchZwei.zaeler);
                        bruchErg.nenner = bruchEins.nenner;

                        gdcBruchEins = findGDCBetter(bruchErg);
                        if (gdcBruchEins != 0)
                        {
                            bruchErg.zaeler = bruchErg.zaeler / gdcBruchEins;
                            bruchErg.nenner = bruchErg.nenner / gdcBruchEins;
                        }


                        break;
                }
                Console.Clear();
                start();
                Console.WriteLine(bruchEins.zaeler + "\t\t" + bruchZwei.zaeler + "\t\t" + bruchErg.zaeler + "\n\t—\t" + operatorBr + "\t—\t=\t—\n\t" + bruchEins.nenner + "\t\t" + bruchZwei.nenner + "\t\t" + bruchErg.nenner);
                for (int i = 0; i < 50; i++) Console.Write("-");
                Console.Write("\n\t");
                Console.ReadLine();
            }


            static double findGDCBetter(Bruch b)
            {
                double highestNumber = 0;
                if (b.nenner > highestNumber) highestNumber = b.nenner;
                if (b.zaeler > highestNumber) highestNumber = b.zaeler;

                while (true)
                {
                    if (highestNumber == 0 || highestNumber == 1) break;
                    if (b.nenner % highestNumber == 0 && b.zaeler % highestNumber == 0)
                    {
                        return highestNumber;
                    }
                    else
                    {
                        highestNumber--;
                    }
                }
                return 0;
            }

            static void start()
            {
                WriteColors(ConsoleColor.Red, "[", ConsoleColor.DarkRed, "Bruchrechner", ConsoleColor.Red, "]\n");
                WriteColors(ConsoleColor.Red, "Ihre Eingabe:\n");
                for (int i = 0; i < 50; i++) Console.Write("-");
                Console.Write("\n\t");
            }

            static void WriteColors(params object[] input)
            {
                foreach (object o in input)
                {
                    if (o is ConsoleColor)
                    {
                        Console.ForegroundColor = (ConsoleColor)o;
                    }
                    else
                    {
                        Console.Write(o.ToString());
                    }
                }
            }
        }
    }
}
