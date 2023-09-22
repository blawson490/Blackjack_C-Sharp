using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library
{
    public class Deck
    {
        public static List<ICard> _cards = new List<ICard>(52);

        public static void GenerateDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                
                {
                   _cards.Add(Factory.CreateBlackjackCard((CardSuit)i, (CardFace)j));
                }
            }
        }


        public Deck() 
        {
            GenerateDeck();
        }
         
        public void Shuffle()
        {
            if (_cards.Count == 0)
            {
                GenerateDeck();
            }


            Random ran = new Random();
            for (int i = 0; i < _cards.Count; i++)
            {
                if (i < _cards.Count)
                {
                    ICard temp = _cards[i];
                    int j = ran.Next(i, _cards.Count);
                    _cards[i] = _cards[j];
                    _cards[j] = temp;
                }
                else
                {
                    i = 0;
                }
            }

        }

        public ICard Deal ()
        {
            if (_cards.Count == 0)
            {
                GenerateDeck();
                Shuffle();
            }


            ICard temp = _cards[0];
            _cards.Remove(temp);
            
            

            return temp;
        }

        public void Print()
        {

            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            int windowwidth = Console.WindowWidth;
            for (int i = 0; i <= _cards.Count - 1; i++)
            {
                _cards[i].Print(x, y);
                x = x + 9;
                if (x + 9 > windowwidth) 
                { 
                    y = y+9 ;
                    x = 0;
                
                }
            }
        }

        public void RemoveAllCards()
        {
            _cards.Clear();
        }
    }
}
