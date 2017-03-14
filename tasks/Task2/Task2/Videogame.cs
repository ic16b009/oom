using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Videogame : Game
    {

        public double SizeInGB { get; }
       


        public Videogame(string name, string genre, decimal price, double sizeingb) : base(name,genre,price)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Title must not be empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(genre)) throw new ArgumentException("ISBN must not be empty.", nameof(genre));

            //Name = name;
            //Genre = genre;
            //UpdatePrice(price);
        }



        
    }
}
