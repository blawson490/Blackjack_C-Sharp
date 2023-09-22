using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJack_Class_Library
{
    public class Card : ICard
    {


        public CardFace face { get; private set; }

        public CardSuit suit { get; private set; }
        public void Print(int x, int y)
        {
            int windowwidth = Console.WindowWidth;
            
            #region Console Color For Card
            Console.BackgroundColor = ConsoleColor.White;
            if (suit == CardSuit.Hearts || suit == CardSuit.Diamonds)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (suit == CardSuit.Spades || suit == CardSuit.Clubs)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            #endregion

            #region Suit Conversion
            string suitValue = "";
            switch (suit)
            {
                case CardSuit.Spades:
                    suitValue = "♠";
                    break;
                case CardSuit.Hearts:
                    suitValue = "♥";
                    break;
                case CardSuit.Clubs:
                    suitValue = "♣";
                    break;
                case CardSuit.Diamonds:
                    suitValue = "♦";
                    break;
                default:
                    break;
            }

            #endregion

            #region Face Conversion
            string faceValue = " ";
            string faceConversionSymbol = "";

            switch (face)
            {
                case CardFace.ace:
                    faceValue = "A";
                    break;
                case CardFace.two:
                    faceValue = "2";
                    break;
                case CardFace.three:
                    faceValue = "3";
                    break;
                case CardFace.four:
                    faceValue = "4";
                    break;
                case CardFace.five:
                    faceValue = "5";
                    break;
                case CardFace.six:
                    faceValue = "6";
                    break;
                case CardFace.seven:
                    faceValue = "7";
                    break;
                case CardFace.eight:
                    faceValue = "8";
                    break;
                case CardFace.nine:
                    faceValue = "9";
                    break;
                case CardFace.ten:
                    faceValue = "10";
                    break;
                case CardFace.Jack:
                    faceValue = "J";
                    faceConversionSymbol = "♔";
                    break;
                case CardFace.Queen:
                    faceValue = "Q";
                    faceConversionSymbol = "♚";
                    break;
                case CardFace.King:
                    faceValue = "K";
                    faceConversionSymbol = "♛";
                    break;
                default:
                    break;
            }

            #endregion

            #region Card Layout

            switch (face)
            {
                case CardFace.ace:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    
                    Console.WriteLine($"   {suitValue}   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.two:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"   {suitValue}   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"   {suitValue}   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.three:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"   {suitValue}   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"   {suitValue}   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"   {suitValue}   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.four:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue} {suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue} {suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.five:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue} {suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"   {suitValue}   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue} {suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.six:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"       ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.seven:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"   {suitValue}   ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.eight:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue} {suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.nine:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.ten:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}     ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($" {suitValue}{suitValue} {suitValue}{suitValue} ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"     {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.Jack:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($" {suitValue}{suitValue} {suitValue}{suitValue} ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.Queen:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($" {suitValue}{suitValue} {suitValue}{suitValue} ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                case CardFace.King:
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"{faceValue}      ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($" {suitValue}{suitValue} {suitValue}{suitValue} ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"  {suitValue}{suitValue}{suitValue}  ");
                    y++;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine($"      {faceValue}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    x += 7;
                    if (x + 7 > windowwidth) { y++; }
                    break;
                default:
                    break;
            }
            #endregion
        }

        public Card(CardSuit suit, CardFace face)
        {
            this.suit = suit;
            this.face = face;
        }


        
        
    }


        
    
}
