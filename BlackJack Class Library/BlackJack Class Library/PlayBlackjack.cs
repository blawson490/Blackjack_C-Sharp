using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Class_Library
{
    public class PlayBlackjack
    {
        public static Deck deck = new Deck();


        public static BlackjackHand dealerHand = new BlackjackHand();
        public static BlackjackHand playerHand = new BlackjackHand();


        public static int playerScore = 0;
        public static int dealerScore = 0;
        public static int playerPoints = 0;
        public static int dealerPoints = 0;
        public static int handsPlayed = 0;
        public static bool gameLoop = true;



        

        #region Intro
        public static void Intro()
        {
            string intro = "Welcome to Blackjack!";
            int introLength = intro.Length;
            int windowWidth = Console.WindowWidth;
            int centerIntro = (windowWidth / 2) - (introLength / 2); 
            Console.SetCursorPosition(centerIntro, 0);
            Console.WriteLine(intro);
        }
        #endregion

        #region Scoreboard

        
        public static void Scoreboard()
        {
            int windowWidth = Console.WindowWidth;
            string handsPlayedString = "Hands Played: ";
            string scoreboard = "Dealer Points: " + dealerPoints + "\t Player Points: " + playerPoints;
            int centerScore = (windowWidth / 2);


            Console.SetCursorPosition(centerScore - (handsPlayedString.Length /2), 2);
            Console.WriteLine(handsPlayedString + handsPlayed);
            Console.SetCursorPosition(centerScore - (scoreboard.Length / 2), 3);
            Console.WriteLine(scoreboard);
           
        }
        #endregion


        #region Print Intro
        public static void PrintIntro()
        {

            
            int windowWidth = Console.WindowWidth;
            Intro();

            Console.WriteLine(new string('-', windowWidth));
            Console.WriteLine("\n\n");
            Scoreboard();

        }

        #endregion


        #region Shuffle and Deal Innital Cards

        public static void DealInitialCards()
        {

            deck.Shuffle();
            dealerHand.ClearHand();
            playerHand.ClearHand();


            dealerHand.isDealer = true;

            for (int i = 0; i < 2; i++)
            {

                playerHand.AddCard(deck.Deal());
                dealerHand.AddCard(deck.Deal());
            }


        }

        #endregion 

        #region Draw and Clear Cards


        #region Dealer Cards
        public static void DrawDealersCards()
        {
            int dealerDrawStartLeft = (Console.WindowWidth / 2) - (Console.WindowWidth / 4) - 10;
            Console.SetCursorPosition(dealerDrawStartLeft, 10);
            Console.WriteLine("Dealers Hand:");
            dealerHand.Print(dealerDrawStartLeft, 12);
            Console.WriteLine("\n");
            dealerScore = dealerHand.score;

        }

        public static void ClearDealersDraw()
        {

            int dealerDrawStart = (Console.WindowWidth / 2) - (Console.WindowWidth / 4) - 10;
            int dealerDrawStartTop = 10;
            int dealerDrawEnd = 18;
            for (int i = dealerDrawEnd; i >= dealerDrawStartTop; i--)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth / 2));
            }

            Console.SetCursorPosition(5, dealerDrawStart);
        }
        #endregion 

        #region Player Cards
        public static void DrawPlayersCards()
        {
            int playerDrawStartLeft = (Console.WindowWidth / 4) + (Console.WindowWidth / 2) - 10;
            Console.SetCursorPosition(playerDrawStartLeft, 10);
            Console.WriteLine("Your Hand:");
            playerHand.Print(playerDrawStartLeft, 12);
            Console.WriteLine("\n");
            playerScore = playerHand.score;
        }
        public static void ClearPlayerDraw()
        {
            int playerDrawStartLeft = (Console.WindowWidth / 4) + (Console.WindowWidth / 2) - 10;
            int playerDrawStartTop = 10;
            int playerDrawEnd = 18;
            for (int i = playerDrawEnd; i >= playerDrawStartTop; i--)
            {
                Console.SetCursorPosition(playerDrawStartLeft, i);
                Console.Write(new string(' ', Console.WindowWidth - playerDrawStartLeft));
            }

            Console.SetCursorPosition(playerDrawStartLeft, playerDrawStartTop);
        }

        #endregion
        #endregion

        #region Turns

        #region Players Turn
        public static void PlayersTurn()
        {
            String[] hitOrStand = { "Hit", "Stand" };
            while (playerScore < 21)
            {
                //ReadFromUser.ReadChoice("Which would you like to do?", hitOrStand, out choice);
                Menu HitOrStand = new Menu("Please make a selection     ", hitOrStand, 0, 20);
                int choice = HitOrStand.ShowMenu();
                switch (choice)
                {
                    case 0:
                        playerHand.AddCard(deck.Deal());
                        ClearPlayerDraw();
                        DrawPlayersCards();

                        Console.SetCursorPosition(0, 20);
                        for (int i = 0; i < 20; i++)
                        {
                            Console.SetCursorPosition(0, Console.CursorTop + 1);
                            Console.Write(new string(' ', 50));
                        }
                        Console.SetCursorPosition(0, 20);
                        break;
                    case 1:
                        Console.SetCursorPosition(0, 20);
                        for (int i = 0; i < 20; i++)
                        {
                            Console.SetCursorPosition(0, Console.CursorTop + 1);
                            Console.Write(new string(' ', 50));
                        }
                        Console.SetCursorPosition(0, 20);
                        return;


                    default:

                        Console.WriteLine("\nYou did not make a valid selection\n");
                        break;
                }
            }
            if (playerScore == 21)
            {
                return;
            }
            else if (playerScore > 21)
            {
                return;
            }
        }

        #endregion

        #region Dealers Turn
        public static void DealersTurn()
        {
            dealerHand.isDealer = false;
            ClearDealersDraw();
            DrawDealersCards();
            if (playerScore < 22)
            {
                if (dealerScore < 17)
                {
                    dealerHand.AddCard(deck.Deal());
                    DealersTurn();
                }
                else if (dealerScore >= 17)
                {
                    return;
                }
            }
            else if (playerScore > 21)
            {
                return;
            }



        }

        #endregion

        #endregion

        #region Declare the Winner of the hand
        public static void DeclareWinner()
        {
            int centerScreen = Console.WindowWidth / 2;
            string[] again = { "Yes", "No" };
            //int againselection;
            Console.SetCursorPosition(0, 20);
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write(new string(' ', 50));
            }
            Console.SetCursorPosition(0, 20);
            if (playerScore > 21)

            {
                Console.WriteLine("You Busted. Dealers point.\n\n");
                dealerPoints++;
                handsPlayed++;
            }
            else if (dealerScore > 21)
            {
                Console.WriteLine("Dealer Busted. Players point.\n\n");
                playerPoints++;
                handsPlayed++;
            }
            else if (playerScore > dealerScore)
            {
                Console.WriteLine("You Win! Players point.\n\n");
                playerPoints++;
                handsPlayed++;
            }
            else if (dealerScore > playerScore)
            {
                Console.WriteLine("Dealer Won! Dealers point.\n\n");
                dealerPoints++;
                handsPlayed++;
            }
            else if (playerScore == dealerScore)
            {
                Console.WriteLine("It's a Tie, Push point. (No points given)\n\n");
                handsPlayed++;
            }

            Menu PlayAgain = new Menu("Would you like to play again?", again, 0, 22);
            int choice = PlayAgain.ShowMenu();

            switch (choice)
            {
                case 0:
                    Console.Clear();
                    gameLoop = true;
                    return;
                case 1:
                    gameLoop = false;

                    return;
                default:
                    Console.WriteLine("\nYou did not make a valid selection\n");
                    break;
            }

        }

        #endregion 

        #region End Blackjack Game and Declare Game Winner

        public static void EndGame()
        {
            Console.Clear();
            Console.WriteLine($"\n\nFinal Score: \nPlayer: {playerPoints} \nDealer: {dealerPoints}");
            if (playerPoints > dealerPoints)
            {
                Console.WriteLine("\n\nYou win the Game!!");
                Console.WriteLine("Press any key to continue");
            }
            else if (playerPoints == dealerPoints)
            {
                Console.WriteLine("\n\nIt's a tie game, no one wins, no one loses.");
                Console.WriteLine("Press any key to continue");
            }
            else if (playerPoints < dealerPoints)
            {
                Console.WriteLine("\n\nDealer won the game.");
                Console.WriteLine("Press any key to continue");
            }
        }
        #endregion


        public static void BlackjackGame()
        {



            //Intro

            gameLoop = true;
            Console.Clear();
            dealerPoints = 0;
            playerPoints = 0;
            dealerHand.ClearHand();
            playerHand.ClearHand();
            handsPlayed = 0;


            while (gameLoop)
            {
                Console.Clear();
                PrintIntro();
                DealInitialCards();
                DrawDealersCards();
                DrawPlayersCards();
                PlayersTurn();
                DealersTurn();
                DeclareWinner();


            }
            EndGame();
            
        }

    }
}
