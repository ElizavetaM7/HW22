using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace latin_russian_dict
{
    class Program
    {
        static async Task Main()
        {
            // Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, List<string>> rusLat = new Dictionary<string, List<string>>();
            // string[] lines = System.IO.File.ReadAllLines(@"../../../../../dictUTF.txt",
            // Encoding.UTF8);
            var fileStream = new FileStream("dict.txt", FileMode.Open, FileAccess.Read);
            var streamReader = new StreamReader(fileStream); 
            //Encoding.GetEncoding("windows - 1251"));
            string[] lines = streamReader.ReadToEnd().Split(System.Environment.NewLine);
            foreach (string line in lines)
            {
                var words = line.Replace(" - ", "-").Replace(", ", ",").Split('-', ',');
                foreach (var key in words.Skip(1))
                {
                    if (!rusLat.ContainsKey(key))
                    {
                        rusLat.Add(key, new List<string>());
                    }
                    rusLat[key].Add(words[0]);
                }
            }

            Console.WriteLine("Словарь: ");
            foreach (var definition in rusLat)
            {
                Console.Write($"{definition.Key} - ");
                var last = definition.Value.Last();
                foreach (var word in definition.Value)
                {
                    Console.Write(word);
                    if (!word.Equals(last))
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }

            string userInput = ("");
            string exitCode = "42";
            do
            {
                Console.WriteLine($"Введите слово для перевода или {exitCode} чтобы выйти: ");
                userInput = Console.ReadLine();
                if (rusLat.ContainsKey(userInput))
                {
                    Console.WriteLine(String.Join(", ", rusLat[userInput].ToArray()));
                }
                else
                {
                    Console.WriteLine("Слово отсутствует в словаре");
                }
            } while (!exitCode.Equals(userInput));
        }
    }
}