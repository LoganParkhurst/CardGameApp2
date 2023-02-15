using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp2
{
    public class Card
    {
        private string name;
        private int number;
        private string suit;
        private string color;

        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }
        public string Suit { get => suit; set => suit = value; }
        public string Color { get => color; set => color = value; }
    }
}
