using Mittelstufe.Dateien;
using Mittelstufe.Elektrotechnik;
using Mittelstufe.Mathe;
using Mittelstufe.OOP;
using Mittelstufe.Statistik;
using Mittelstufe.Utils;
using System;

namespace Mittelstufe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] optionen = {
            "[1] Spannungsteiler Funktionen",
            "[2] Reihenschaltung 2 Widerstände",
            "[3] Artikelverwaltung",
            "[4] Bruchrechner",
            "[5] Schulstatistik",
            "[6] Dateien anlegen/addition",
            "[7] Geldautomat",
            "[8] Funktionen Dritten Grades berechnen",
            "[9] OOP"
            };
            SuperMenu sm = new SuperMenu(optionen);
            switch(sm.GetResult())
            {
                case 0:
                    new Spannungsteiler();
                    break;
                case 1:
                    new ReihenschaltungTwo();
                    break;
                case 3:
                    new Bruchrechner();
                    break;
                case 4:
                    new Schulstatistik();
                    break;
                case 5:
                    new DateinAnlegen();
                    break;
                case 6:
                    new GeldAutomat();
                    break;
                case 7:
                    new FunktionenDritter();
                    break;
                case 8:
                    new OOPEins();
                    break;
            }
        }
    }
}
