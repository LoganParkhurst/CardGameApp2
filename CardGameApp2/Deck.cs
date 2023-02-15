using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp2
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();
        public List<Card> SecondDeck = new List<Card>();
        public List<Card> InPlay = new List<Card>();
        public List<Card> Discard = new List<Card>();


        private static Random rng = new Random();

        Utility utility = new Utility();

        public void SetUpDeck() //preps the first deck
        {
            string[] Suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            int deckSize = 13 * Suits.Length;

            for (int i = 1; i <= deckSize/ Suits.Length; i++)
            {
                for (int j = 0; j < Suits.Length; j++)
                {
                    Cards.Add(new Card()
                    {
                        Number = i,
                        Suit = Suits[j]
                    }
                    );
                }
            }
        }

        public void SetUpCustomDeck(string[] Suits)
        {
            int deckSize = 13 * Suits.Length;
            for (int i = 1; i <= deckSize / Suits.Length; i++)
            {
                for (int j = 0; j < Suits.Length; j++)
                {
                    SecondDeck.Add(new Card()
                    {
                        Number = i,
                        Suit = Suits[j]
                    }
                    );
                }
            }
        }

        public void PickUpCards(int number, Player player) //every game requires the player to pick up cards at some point
        {
           while(number > 0)
           {
                int card = utility.GetRandom(1, Cards.Count);
                player.Hand.Add(Cards[card]);
                Cards.RemoveAt(card);
                InPlay.Add(Cards[card]);
                number--;
           }
        }

        public void RemoveCards(Card card, Player player, int number) //only needed in specific games
        {
            while(number > 0)
            {
                Card removeable = player.Hand.Find(x => x == card);
                player.Hand.Remove(removeable);
                number--;
            }
        }

        public List<Card> Shuffle(List<Card> unshuffled)//we input what deck you want shuffled
        {
            Random rng = new Random(); //make a new random
            return unshuffled.OrderBy(a => rng.Next()).ToList(); //we return the shuffled deck
        }

        public Card DrawCard()
        {
            if(Cards.Count == 0)
            {
                Card card = this.SecondDeck[0];
                InPlay.Add(this.SecondDeck[0]);
                SecondDeck.RemoveAt(0);
                return card;
            }
            else
            {
                Card card = this.Cards[0];
                InPlay.Add(this.Cards[0]);
                Cards.RemoveAt(0);
                return card;
            }
        }

        public void PrintDeck()
        {
            foreach (Card card in this.SecondDeck)
            {
                Console.WriteLine($"{card.Number} of {card.Suit}");
            }
        }
    }
}