using System;
using System.Collections.Generic;
using System.Text;

namespace Mittelstufe.Elektrotechnik
{
    class Spannungsteiler
    {
        public Spannungsteiler()
        {
            Console.WriteLine("Geben Sie die Eingangsspannung ein: ");
            Spannung U = new Spannung();
            U._value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie den Widerstandswert für R1 ein: ");
            Widerstand R1 = new Widerstand();
            R1._value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie den Widerstandswert für R2 ein: ");
            Widerstand R2 = new Widerstand();
            R2._value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie den Widerstandswert für R1 ein: ");
            Widerstand RL = new Widerstand();
            RL._value = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            ParalelErgebnis eg = new ParalelErgebnis();
            eg = spannungsTeilerBerechnen(U, R1, R2, RL);

            Console.WriteLine("Das Ergebnis für Ihre Ausgangsspannung ist: " + eg._ausspannung);
            Console.WriteLine("Das Ergebnis für Ihren Gesammtwiderstand von R2 und RL ist: " + eg._gesamtwiderstand);
        }

        public struct Widerstand
        {
            public double _value;
        }

        public struct Spannung
        {
            public double _value;
        }

        public struct ParalelErgebnis
        {
            public double _ausspannung;
            public double _gesamtwiderstand;
        }

        public static ParalelErgebnis spannungsTeilerBerechnen(Spannung U, Widerstand R1, Widerstand R2, Widerstand RL)
        {
            ParalelErgebnis pe;
            pe._gesamtwiderstand = paralelWiderstand(R2, RL);

            pe._ausspannung = U._value * (pe._gesamtwiderstand / (R1._value + pe._gesamtwiderstand));


            return pe;
        }

        public static double paralelWiderstand(Widerstand R2, Widerstand RL)
        {
            var rechnung = (R2._value * RL._value) / (R2._value + RL._value);
            return rechnung;

        }
    }
}
