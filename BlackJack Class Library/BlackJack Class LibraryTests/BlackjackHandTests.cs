using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {
        [TestMethod()]

        

        public void AddCardTest()
        {

            BlackjackHand hand = new BlackjackHand();
            ICard Ace = Factory.CreateBlackjackCard(CardSuit.Spades, CardFace.ace);
            ICard Eight = Factory.CreateBlackjackCard(CardSuit.Spades, CardFace.Jack);
            
            hand.AddCard(Ace);
            hand.AddCard(Eight);

            Assert.AreEqual(21, hand.score);


            //hand.AddCard(Ace);

            //Assert.AreEqual(20, hand.score);

        }
    }

}