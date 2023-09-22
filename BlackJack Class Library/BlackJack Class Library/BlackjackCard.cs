using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library
{
    public class BlackjackCard: Card
    {

        public int Value { get; private set; }


        
        public BlackjackCard(CardSuit suit, CardFace face) : base(suit, face)
        {
            switch (face)
            {
                case CardFace.ace:
                    Value = 1;
                    break;
                case CardFace.two:
                    Value = 2;
                    break;
                case CardFace.three:
                    Value = 3;
                    break;
                case CardFace.four:
                    Value = 4;
                    break;
                case CardFace.five:
                    Value = 5;
                    break;
                case CardFace.six:
                    Value = 6;
                    break;
                case CardFace.seven:
                    Value = 7;
                    break;
                case CardFace.eight:
                    Value = 8;
                    break;
                case CardFace.nine:
                    Value = 9;
                    break;
                case CardFace.ten:
                    Value = 10;
                    break;
                case CardFace.Jack:
                    Value = 10;
                    break;
                case CardFace.Queen:
                    Value = 10;
                    break;
                case CardFace.King:
                    Value = 10;
                    break;
                default:
                    break;
            }
        }


    }
}
