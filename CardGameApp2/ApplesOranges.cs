using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp2
{
    public class ApplesOranges : Game
    {
        string[] Suits = { "Hearts","Spades" };

        Player player;
        Deck deck = new Deck();

        //this game is simple we need to split the deck
        //have the player draw a card and show it to them
        //The player will then decide if the next card will be the same suit or different
        //repeat

        public void StartingUp(Player thePlayer)
        {
            Console.Clear();
            player = thePlayer;
            deck.SetUpCustomDeck(Suits);
            Console.WriteLine("Welcome To 'Apples or Oranges'!!!");
            Console.WriteLine("1) Play \n2) Quit ");
            switch (Console.ReadLine())
            {
                case "1":
                    GamePlayLoop();
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("input not valid");
                    Console.ReadLine();
                    StartingUp(player);
                    break;

            }
        }

        public void GamePlayLoop()
        {
            Console.Clear();
            string choice = "";

            deck.SecondDeck = deck.Shuffle(deck.SecondDeck);//shuffle the deck
            //deck.PrintDeck(); Debug

            Card firstCard = deck.DrawCard();//draw a card from the deck and tell the player
            Console.WriteLine($"The card is a {firstCard.Suit}");
            Console.WriteLine("will the next suit be the same or different?");
            Console.WriteLine("1)  Hearts\n2) Spades");//ask the player what they want to do
            switch (Console.ReadLine())
            {
                case "1"://option 1 is hearts
                    choice = "Hearts";
                    break;

                case "2"://option 2 is spades
                    choice = "Spades";
                    break;

                default://never trust the player
                    Console.WriteLine("input not valid");
                    Console.ReadLine();
                    GamePlayLoop();
                    break;

            }
            Card secondCard = deck.DrawCard();
            if (secondCard != null && secondCard.Suit == choice)
            {
                Console.WriteLine("You were correct!");
                player.Score++;//reward the player for getting the 50/50 right
            }
            else
            {
                Console.WriteLine("You were Incorrect.");
                Console.ReadLine();
            }
            Console.WriteLine($"Your score is {player.Score}");//tell the player what their score is
            Console.WriteLine("1)  Play again\n2) Quit");
            switch (Console.ReadLine())
            {
                case "1":
                    GamePlayLoop();
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
