using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library
{
    public interface ICard
    {

        CardFace face { get; }

        CardSuit suit { get; }

        void Print(int x, int y);
    }
}
