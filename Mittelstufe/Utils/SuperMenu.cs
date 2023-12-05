using System;
using System.Collections.Generic;
using System.Text;

namespace Mittelstufe.Utils
{
    public class SuperMenu
    {
        private string[] options;
        private int currentIndex = 0;

        public SuperMenu(string[] options)
        {
            this.options = options;

            bool isRunning = true;

            while (isRunning)
            {

                RenderOptions();
                ConsoleKey pressedKey = Console.ReadKey().Key;
                switch (pressedKey)
                {
                    case ConsoleKey.Enter:
                        isRunning = false;
                        break;
                    case ConsoleKey.DownArrow:
                        if (currentIndex >= (options.Length) - 1) break;
                        currentIndex++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (currentIndex == 0) break;
                        currentIndex--;
                        break;
                    default:
                        for(int i = 0; i <= options.Length; i++)
                        {
                            ConsoleKey gotKey;
                            Enum.TryParse<ConsoleKey>("D" + i, out gotKey);
                            if(pressedKey == gotKey)
                            {
                                currentIndex = i - 1;
                            }
                        }
                        
                        break;
                }
            }
        }

        public int GetResult()
        {
            Console.Clear();
            return currentIndex;
        }

        public string GetResultItem()
        {
            Console.Clear();
            return options[currentIndex];
        }

        private void RenderOptions()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < options.Length; i++)
            {
                if (currentIndex == i)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(options[i]);
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(options[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
