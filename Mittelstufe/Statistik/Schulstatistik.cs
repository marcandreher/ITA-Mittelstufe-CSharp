using System;
using System.Collections.Generic;
using System.Text;

namespace Mittelstufe.Statistik
{
    class Schulstatistik
    {
        public enum Stufe
        {
            Undefined,
            UNTER,
            OBER,
            MITTEL
        }

        public struct Klasse
        {
            public string _bezeichnung;
            public int _anzahlalleschueler;
            public int _anzahlschueler;
            public int _anzahlschuelerinnen;
            public Stufe _stufe;
        }
        public Schulstatistik()
        {
            string input = null;
            List<Klasse> klassen = new List<Klasse>();
            while (true)
            {
                Console.Write("(1) Klassendaten einlesen\n(2) Klassendaten ausgeben\n(0) Programm beenden\n=> ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("[Input] geben Sie die Statistik für Ihre Klasse ein");
                        Klasse k = new Klasse();
                        k._stufe = Stufe.Undefined;
                        Console.Write("[Input] Geben Sie die Klassenbezeichnung ein: ");
                        k._bezeichnung = Console.ReadLine();
                        Console.Write("[Input] Geben Sie die Anzahl aller Schüler ein: ");
                        k._anzahlalleschueler = Convert.ToInt32(Console.ReadLine());
                        Console.Write("[Input] Geben Sie die Anzahl der Schüler ein: ");
                        k._anzahlschueler = Convert.ToInt32(Console.ReadLine());
                        Console.Write("[Input] Geben Sie die Anzahl der Schülerinnen ein: ");
                        k._anzahlschuelerinnen = Convert.ToInt32(Console.ReadLine());
                        while (k._stufe == Stufe.Undefined)
                        {

                            Console.Write("[Input] Geben Sie die Stufe ein (UNTER/MITTEL/OBER): ");

                            switch (Console.ReadLine())
                            {
                                case "OBER":
                                    k._stufe = Stufe.OBER;
                                    break;
                                case "MITTEL":
                                    k._stufe = Stufe.MITTEL;
                                    break;
                                case "UNTER":
                                    k._stufe = Stufe.UNTER;
                                    break;
                                default:
                                    Console.WriteLine("[Fehler] Keiner der validen Inputs (UNTER/MITTEL/OBER)");
                                    break;
                            }
                        }
                        klassen.Add(k);
                        Console.WriteLine("[Info] Datensatz hinzugefügt");

                        break;
                    case "2":

                        foreach (Klasse s in klassen)
                        {
                            for (int i = 0; i < 40; i++) Console.Write("-");
                            Console.WriteLine();
                            Console.WriteLine("Bezeichnung: " + s._bezeichnung);
                            Console.WriteLine("Anzahl aller Schüler: " + s._anzahlalleschueler);
                            Console.WriteLine("Anzahl Schüler: " + s._anzahlschueler);
                            Console.WriteLine("Anzahl Schülerinnen: " + s._anzahlschuelerinnen);
                            Console.WriteLine("Stufe: " + s._stufe.ToString());
                            for (int i = 0; i < 40; i++) Console.Write("-");
                            Console.WriteLine();
                        }
                        break;

                    case "3":

                        int schueler = 0, schuellerinnen = 0, gesamt = 0;
                        for (int i = 0; i < klassen.Count; i++)
                        {
                            schueler += klassen[i]._anzahlschueler;
                            schuellerinnen += klassen[i]._anzahlschuelerinnen;
                            gesamt += klassen[i]._anzahlalleschueler;
                        }

                        Console.WriteLine("Schüler: " + schueler + "\nSchülerrinnen: " + schuellerinnen + "\nGesamt: " + gesamt);
                        Console.ReadKey();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("[Fehler] Keinen validen input eingegeben");
                        continue;
                }

            }
        }


    }
}
