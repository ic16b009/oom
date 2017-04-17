using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Taskulus
    {
        public static void Run() //how many games
        {
            //### Zwischentask  "Downloading Games"
            var random = new Random();

            var xs = new[] { 1, 2, 3, 4, 5, 6 };
            var tasks = new List<Task<int>>();

            foreach (var x in xs)
            {
                var task = Task.Run(() =>
                {
                    Console.WriteLine($"Downloading Game: {x}");
                    Task.Delay(TimeSpan.FromSeconds(5.0 + random.Next(10))).Wait();
                    Console.WriteLine($"Download Complete for Game: {x}");
                    return x * x;
                });

                tasks.Add(task);
            }
        }
    //### Zwischentask ende
}
}
