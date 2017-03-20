using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]

    class Program
    {
        [Test]
        static void Main(string[] args)
        {
            var vgames = new[]
            {
                new Videogame("CSGO", "Egoshooter", 9.90m, 3.2),
                new Videogame("CSGO", "Egoshooter", 9.90m, 3.2)
                 
                //Assert.IsTrue(vgames[1]!=null);

            };


            foreach (var g in vgames)
            {
                Console.WriteLine("{0},\t{1},\t{2,8:0.00}", g.Name, g.Genre, g.getPrice, g.SizeInGB);
            }




            Console.WriteLine("\n\n----- Genre Filter: -----");
            foreach (var g in vgames)
            {
                if(g.Genre=="Simulation")
                Console.WriteLine("{0},\t{1},\t{2,8:0.00}", g.Name, g.Genre, g.getPrice);
            }

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }

    }

}
