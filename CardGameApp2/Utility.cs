using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp2
{
    public class Utility
    {
        public int GetRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
