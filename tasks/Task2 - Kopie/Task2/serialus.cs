using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class serialus
    {
        public static void Run(Game[] vgames)
        {
            var book = vgames[0];
            //Format
            Console.WriteLine(JsonConvert.SerializeObject(book));
            Console.WriteLine(JsonConvert.SerializeObject(book, Formatting.Indented));


            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(vgames, settings));

           //Store - Serialize
            var text = JsonConvert.SerializeObject(vgames, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "gamelist.json");
            File.WriteAllText(filename, text);

            //Print - Deserialize and print out
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<Game[]>(textFromFile, settings);
  
        }
    }
}
