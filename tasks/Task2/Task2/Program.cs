using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new[]
            {
                new Game("CSGO", "Egoshooter", 9.90m),
                new Game("Dirt 2", "Race", 12.90m),
                new Game("Farmsimulator", "Simulation", -20.90m),
                new Game("Flight-X", "Simulation", 29.90m),
                new Game("Trainsimulator", "Simulation", 11.20m),
                new Game("Goatsimulator", "Simulation", 4.30m),
            };


            foreach (var g in games)
            {
                Console.WriteLine("{0},\t{1},\t{2,8:0.00}", g.Name, g.Genre, g.getPrice);
            }




            Console.WriteLine("\n\n----- Genre Filter: -----");
            foreach (var g in games)
            {
                if(g.Genre=="Simulation")
                Console.WriteLine("{0},\t{1},\t{2,8:0.00}", g.Name, g.Genre, g.getPrice);
            }

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }

    }

}
