using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library
{
    public class Hand
    {
        int x = 0;
        int y = 0;

        protected List<ICard> _cards = new List<ICard>();

        public Hand()
        {
        }
    
        public virtual void AddCard(ICard card)
        {
            _cards.Add(card);
        
        }

        public virtual void Print(int x, int y)
        {
            for (int i = 0; i < _cards.Count; i++)
            {
                _cards[i].Print(x, y);
                x = x+10;


            }
        }
    }
}
