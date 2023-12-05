using System;
using System.Collections.Generic;

namespace Mittelstufe.Mathe
{
    class GeldAutomat
    {
        private int _500notes = 0;
        private int _200notes = 0;
        private int _100notes = 0;
        private int _50notes = 0;
        private int _20notes = 0;
        private int _10notes = 0;
        private int _5notes = 0;

        public GeldAutomat()
        {
            while(true)
            {
                _500notes = 0;
                _200notes = 0;
                _100notes = 0;
                _50notes = 0;
                _20notes = 0;
                _10notes = 0;
                _5notes = 0;
                int payout = 0;
                Console.WriteLine("Geldautomat Bank 22 Version 1.0");
                while(!isCashable(payout))
                {
                    Console.Write("Bitte den Betrag eingeben, der ausgezahlt werden soll : ");
                    try
                    {
                        payout = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception) { Console.WriteLine("Bitte geben Sie eine Zahl an"); break; }
                    if(payout > 10000)
                    {
                        Console.WriteLine("Bitte geben Sie einen Betrag unter 10.000 Euro ein");
                        break;
                    }
                    Dictionary<int, int> test = GetValuesAbgefuckt(payout);

                    Console.WriteLine("\nAuszahlung mit möglichst wenigen Scheinen:\n");

                    Console.WriteLine("Anzahl der 500\tEuro Scheine\t:\t" + getValueFromList(test, 500));
                    Console.WriteLine("Anzahl der 200\tEuro Scheine\t:\t" + getValueFromList(test, 200));
                    Console.WriteLine("Anzahl der 100\tEuro Scheine\t:\t" + getValueFromList(test, 100));
                    Console.WriteLine("Anzahl der 50\tEuro Scheine\t:\t" + getValueFromList(test, 50));
                    Console.WriteLine("Anzahl der 20\tEuro Scheine\t:\t" + getValueFromList(test, 20));
                    Console.WriteLine("Anzahl der 10\tEuro Scheine\t:\t" + getValueFromList(test, 10));
                    Console.WriteLine("Anzahl der 5\tEuro Scheine\t:\t" + getValueFromList(test, 5));

                }
               
            }
        }

        private int getValueFromList(Dictionary<int, int> test, int value)
        {
            if(test.ContainsKey(value))
            {
                return test[value];
            }
            else
            {
                return 0;
            }
        }

        private Dictionary<int, int> GetValuesAbgefuckt(int money)
        {
            int[] notes = { 500, 200, 100, 50, 20, 10, 5 };
            Dictionary<int, int> myValues = new Dictionary<int, int>();

            for(int i = 0; i < notes.Length; i++)
            {
                while(money > notes[i])
                {
                    try
                    {
                        myValues[notes[i]] = myValues[notes[i]] + 1;
                    }
                    catch(Exception)
                    {
                        myValues[notes[i]] = 1;
                    }
                    money = money - notes[i];
                }
            }

            return myValues;
        }

        private void GetValues(int money)
        {
            if (money == 0 || money < 0) return;

            if (money >= 500)
            {
                _500notes++;
                GetValues(money - 500);
            }
            else if (money >= 200)
            {
                _200notes++;
                GetValues(money - 200);
            }
            else if (money >= 100)
            {
                _100notes++;
                GetValues(money - 100);
            }
            else if (money >= 50)
            {
                _50notes++;
                GetValues(money - 50);
            }
            else if (money >= 20)
            {
                _20notes++;
                GetValues(money - 20);
            }
            else if (money >= 10)
            {
                _10notes++;
                GetValues(money - 10);
            }
            else if (money >= 5)
            {
                _5notes++;
                GetValues(money - 5);
            }
        }

        private bool isCashable(int money)
        {
            if (money == 0) return false;
            if(money % 5 == 0)
            {
                return true;
            }
            Console.WriteLine("Dieser Betrag ist nicht auszahlbar");
            return false;
        }
    }
}
