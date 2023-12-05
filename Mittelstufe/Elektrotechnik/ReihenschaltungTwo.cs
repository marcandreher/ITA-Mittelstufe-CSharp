using System;
using System.Collections.Generic;
using System.Text;

namespace Mittelstufe.Elektrotechnik
{
    class ReihenschaltungTwo
    {
        public ReihenschaltungTwo()
        {
            double eingangsSpannung, widerstandEins, widerstandZwei, ergebnis, stromstärke;
            while (true)
            {
                WriteColors(ConsoleColor.Cyan, "[", ConsoleColor.Blue, "Berechnung einer Reihenschaltung mit zwei Widerständen", ConsoleColor.Cyan, "]");
                WriteColors(ConsoleColor.Cyan, "\nBitte geben Sie die Eingangspannung ein", ConsoleColor.Blue, " (in V): ");
                eingangsSpannung = double.Parse(Console.ReadLine());

                WriteColors(ConsoleColor.Cyan, "Bitte geben Sie den Wert ihres ersten Widerstandes ein", ConsoleColor.Blue, " (in Ohm): ");
                widerstandEins = double.Parse(Console.ReadLine());

                WriteColors(ConsoleColor.Cyan, "Bitte geben Sie den Wert ihres zweiten Widerstandes ein", ConsoleColor.Blue, " (in Ohm): ");
                widerstandZwei = double.Parse(Console.ReadLine());

                WriteColors(ConsoleColor.Cyan, "\nÜberprüfen Sie ihre eigegebenen Werte:");
                WriteColors(ConsoleColor.Cyan, "\neingangsSpannung: ", ConsoleColor.Blue, eingangsSpannung, ConsoleColor.Cyan, " in V\n");
                WriteColors(ConsoleColor.Cyan, "widerstandEins: ", ConsoleColor.Blue, widerstandEins, ConsoleColor.Cyan, " in Ohm\n");
                WriteColors(ConsoleColor.Cyan, "widerstandZwei: ", ConsoleColor.Blue, widerstandZwei, ConsoleColor.Cyan, " in Ohm\n");
                stromstärke = eingangsSpannung / (widerstandEins + widerstandZwei);
                WriteColors(ConsoleColor.Cyan, "stromstärke: ", ConsoleColor.Blue, stromstärke, ConsoleColor.Cyan, " in Ampere\n\n");
                ergebnis = widerstandZwei * stromstärke;

                WriteColors(ConsoleColor.Cyan, "Das Ergebnis ist: ", ConsoleColor.Blue, ergebnis, ConsoleColor.Cyan, " V\n\n");
                Console.ReadKey();
            }
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
