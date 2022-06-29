using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Dictionary.Football
{
    class Program
    {
        static void Main()
        {
            var champions = new Dictionary<string, int>();
            //добавить файл в папку?
            using(var file = new StringReader("football.txt",Encoder.Default))
            {
                while(!file.EndOfStream)
                {
                    var key = file.ReadLine().Split("\t")[1];

                    if (champions.ContainsKey(key)) 
                        champions[key]++;
                    else
                        champions[key] = 1;

                }
            }
            foreach (var team in champions.Keys)
                Console.WriteLine($"{team} - {champions[team]}");

            Console.ReadKey();
        }
    }
}
