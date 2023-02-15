using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp2
{
    public class Player
    {
        private string name;
        private int numberOfCards;
        private List<Card> hand;
        private int score;

        public string Name { get => name; set => name = value; }
        public int NumberOfCards { get => numberOfCards; set => numberOfCards = value; }
        public int Score { get => score; set => score = value; }
        internal List<Card> Hand { get => hand; set => hand = value; }
    }
}
