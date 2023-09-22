using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library
{
    public class BlackjackHand : Hand
    {
        public int score { get; private set; }
        public bool isDealer { get; set; } = false;
        

        
        public override void AddCard(ICard card)
        {
            base.AddCard(card);
            int aceCounter = 0;
            score = 0;
            for (int i = 0; i < _cards.Count; i++)
            {
                BlackjackCard temp = (BlackjackCard)_cards[i];
                if (temp.face == CardFace.ace)
                {
                    aceCounter++;
                }
                else
                {
                    score += temp.Value;
                }
            }
            for (int i = 0; i < aceCounter; i++)
            {
                if (score + 11 < 22)
                {
                    score += 11;
                }
                else
                {
                    score += 1;
                }
            }
        }

        public void ClearHand()
        {
            _cards.Clear();
        }

        public override void Print(int x, int y)
        {
            if (isDealer == false)
            {
                base.Print(x, y);
                Console.Write("\n");
                Console.CursorLeft = x;
                Console.WriteLine($"Your current score is {score}");
            }
            else
            {
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("?      ");
                y++;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("       ");
                y++;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("Casino ");
                y++;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("       ");
                y++;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("      ?");
                for (int i = 1; i < _cards.Count; i++)
                {
                    _cards[i].Print(x + 8, y-4);
                    x++;
                }Console.Write("\n");
                Console.CursorLeft = x - 1;
                Console.WriteLine("The dealers current score is unknown.");
            }

        }

    }
}
