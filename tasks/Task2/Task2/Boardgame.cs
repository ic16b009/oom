using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Boardgame : Game
    {

        public int Player { get; }
        public Boardgame(string name, string genre, decimal price, int player) : base(name, genre, price)
        {

            Player = player;
        }

    }
}
