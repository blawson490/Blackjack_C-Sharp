using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library
{
    public class ReadFromUser
    {
        public static int ReadInteger(String prompt, int min, int max)
        {

            string Error = "Hmmm, that doesn't seem to be a valid number";
            string userInput = string.Empty;
            int userInt;
            bool errorCheck = false;
            int userNumber = 0;

            Console.WriteLine(prompt);
            userInput = Console.ReadLine();


            while (!errorCheck)
            {
                if (int.TryParse(userInput, out userInt))
                {
                    if (userInt < min || userInt > max)
                    {
                        Console.WriteLine(Error);
                        Console.WriteLine(prompt);
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        errorCheck = true;
                        userNumber = userInt;
                        break;

                    }
                }
                else
                {
                    Console.WriteLine(Error);
                    Console.WriteLine(prompt);
                    userInput = Console.ReadLine();
                }
            }
            return userNumber;

        }

        public static void ReadChoice(String prompt, String[] options, out int selection)
        {
            //Print
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + options[i]);
            }

            //Reading selection
            selection = ReadInteger(prompt, 1, options.Length);
        }

        public static void ReadString(String prompt, ref String val)
        {

            bool valid = false;
            Console.Write(prompt);
            string userInput = Console.ReadLine();

            while (!valid)
            {
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Please enter a valid input.");
                    userInput = Console.ReadLine();
                }
                else
                {
                    valid = true;
                    val = userInput;
                    break;
                }

            }

        }
    }
}
