using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Mittelstufe.Utils;

namespace Mittelstufe.Dateien
{
    class DateinAnlegen
    {
        public DateinAnlegen()
        {
            string[] options =
            {
                "[1] Addieren",
                "[2] Datein anlegen",
                "[3] Teiltext im Text suchen",
                "[4] Hallo Welt",
                "[0] Ende"
            };
            SuperMenu sm = new SuperMenu(options);
            switch(sm.GetResult())
            {
                case 0:
                    AddInMenu();
                    break;
                case 1:
                    GenerateFileMenu();
                    break;
                case 2:
                    SearchInTextMenu();
                    break;
                case 3:
                    HalloWeltMenu();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        public void HalloWeltMenu()
        {
            Console.WriteLine("Hallo Welt");
        }

        public void SearchInTextMenu()
        {
            string searchableText, searchedSnippet;

            WaitForInput(out searchableText, "Geben Sie Ihren Text ein: ");
            WaitForInput(out searchedSnippet, "Geben Sie ein was Sie im Text suchen: ");

            if(SearchInText(searchableText, searchedSnippet))
            {
                Console.WriteLine("\nDer Text wurde im Text gefunden");
            }
            else
            {
                Console.WriteLine("\nDer Text wurde nicht im Text gefunden");
            }
        }

        public bool SearchInText(string searchableText, string searchedSnippet)
        {
            if(searchableText.Contains(searchedSnippet))
            {
                return true;
            }
            return false;
        }

        public void GenerateFileMenu()
        {
            string fileName;
            WaitForInput(out fileName, "Bitte geben Sie den Dateinamen an: ");
            fileName = fileName + ".txt";
            File.Create(fileName);
            Console.WriteLine("\nDie Datei " + fileName + " wurde erstellt, der Dateiname hat " + fileName.ToCharArray().Length + " Zeichen");
        }


        public double AddTwoValues(double a, double b)
        {
            return (a + b);
        }

        public void AddInMenu()
        {
            double firstInput = 0, secInput = 0;
            Console.Clear();
            WaitForValidInput(out firstInput, "Bitte geben Sie die erste Zahl ein: ");
            WaitForValidInput(out secInput, "Bitte geben Sie die zweite Zahl ein: ");

            Console.WriteLine("\nDas Ergebnis ist: " + AddTwoValues(firstInput, secInput));
        }

        public void WaitForValidInput(out double validInput, string currentText)
        {
            bool isValid = false;
            validInput = 0;
            while(!isValid)
            {
                Console.Write(currentText);
                try
                {
                    validInput = Convert.ToDouble(Console.ReadLine());
                    isValid = true;
                } catch (Exception) { }
            }
        }

        public void WaitForInput(out string input, string currentText)
        {
            input = "";
            Console.Write(currentText);
            input = Console.ReadLine();
        }

    }
}
