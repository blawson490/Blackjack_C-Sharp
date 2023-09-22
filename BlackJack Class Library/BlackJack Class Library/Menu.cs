using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BlackJack_Class_Library
{
    public class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        private int PrintX;
        private int PrintY;
        public Menu(string prompt, string[] options, int x, int y)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
            PrintX = x;
            PrintY = y;
        }

        private void DisplayOptions()
        {
            SetCursorPosition(PrintX, PrintY);

            WriteLine(Prompt);

            SetCursorPosition(PrintX + 2, PrintY + 2);

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";

                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                WriteLine(prefix + " " + currentOption);
                ResetColor();
            }
        }

        private void ClearOptions()
        {
            
            for (int i = Console.CursorTop; i < PrintY ; i--)
            {

            }
        }

        public int ShowMenu()
        {
            ConsoleKey keyPressed;

            do
            {
                
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                //Update SelectedIndex based off arrow keys

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    
}
}
