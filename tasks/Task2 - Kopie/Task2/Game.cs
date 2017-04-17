using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Game : Product
        //public interface Game => zu viele probleme
    {
        private decimal gprice;


        /// <summary>
        /// Creates a new book object.
        /// </summary>
        /// <param name="title">Title must not be empty.</param>
        /// <param name="isbn">International Standard Book Number.</param>
        /// <param name="price">Price must not be negative.</param>
        /// 

        public Game(string name, string genre, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Title must not be empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(genre)) throw new ArgumentException("ISBN must not be empty.", nameof(genre));

            Name = name;
            Genre = genre;
            UpdatePrice(price);
        }

 

        private void UpdatePrice(decimal price)
        {
            try
            {

                if (price > 0 && price < 9999999)
                gprice = price;
            }
            catch
            {
                throw new ArgumentException("Price must be realistic.", nameof(price));
            }

        }

        public string Name { get; } //Videogame name

        public string Genre { get; }

        public decimal getPrice => gprice;
    }
}
