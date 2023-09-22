using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library
{
    public class Factory
    {
        public static ICard CreateCard(CardSuit suit, CardFace face)
        {
            return new Card(suit, face);


        }

        public static ICard CreateBlackjackCard(CardSuit suit, CardFace face)
        {
            return new BlackjackCard(suit, face);
        }

    }
}
