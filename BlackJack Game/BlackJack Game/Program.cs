using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack_Class_Library;

namespace BlackJack_Game
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            //code to use symbols in code without error
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string welcome = "Welcome to Blackjack!";
            string instructions = "(Use Arrow Keys to select an option and press enter)";

            String[] MenuOptions = {
                "Play Blackjack",
                "Shuffle and Show Deck",
                "Exit" };


            int selection;
            int windowCenter = Console.WindowWidth / 2;

            while (true)
            {
                Console.SetCursorPosition(windowCenter - (welcome.Length / 2), 5);
                Console.WriteLine(welcome);
                Menu mainMenu = new Menu(instructions, MenuOptions, 0, 9);
                int choice = mainMenu.ShowMenu();
                //ReadFromUser.ReadChoice("Please make a selection: ", MenuOptions, out selection);
                //Console.Clear();
                switch (choice)
                {

                    case 0: //Play Blackjack
                        Console.Clear();
                        PlayBlackjack.BlackjackGame();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 1: //Shuffle and Show Deck

                        Console.Clear();
                        Console.WriteLine($"\nYou selected {MenuOptions.GetValue(choice)}");
                        Console.WriteLine(new string('-', windowCenter * 2));
                        var showdeck = new Deck();
                        showdeck.RemoveAllCards();
                        showdeck.Shuffle();
                        showdeck.Print();
                        showdeck.RemoveAllCards();
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 2: //Exit
                        Console.WriteLine($"\nYou selected {MenuOptions.GetValue(choice)}");
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    default: Console.WriteLine("\nYou did not make a valid selection\n"); break;

                }
            }
        }

    }
}