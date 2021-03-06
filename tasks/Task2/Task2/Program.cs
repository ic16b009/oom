﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {           
            var vgames = new Game[]
            {
                new Videogame("CSGO", "Egoshooter", 9.90m, 3.2),
                new Videogame("Dirt 3", "Race", 19.90m, 5.4),
                new Videogame("Forza 2", "Race", 19.90m, 5.4),
                new Videogame("Limbo", "Acarde", 2.90m, 1.1),
                new Boardgame("Schach","Strategie",8.30m,2),
                new Boardgame("Activity","Party",12.30m,6)
            };


            foreach (var g in vgames)
            {
                Console.WriteLine("{0},\t{1},\t{2,8:0.00}", g.Name, g.Genre, g.getPrice);
    
            }




            Console.WriteLine("\n\n----- Genre Filter: -----");
            foreach (var g in vgames)
            {
                if(g.Genre=="Race")
                Console.WriteLine("{0},\t{1},\t{2,8:0.00}", g.Name, g.Genre, g.getPrice);

            }

            //int amount = vgames.Length;
            
            
            
            //##### Subject and Theard #####

            var source = new Subject<Game>();

            source
                .Sample(TimeSpan.FromSeconds(1.0))
                .Subscribe(x => Console.WriteLine($"Next-Gametype: {x}"))   //nicht schön aber informativ 
                ;

            var t = new Thread(() =>
            {
                foreach (var g in vgames)
                {
                    Thread.Sleep(250);
                    source.OnNext(g);
                }
            });
            t.Start();

            // a lot of things happening
            Taskulus.Run();
            serialus.Run(vgames);


            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }

    }

}
