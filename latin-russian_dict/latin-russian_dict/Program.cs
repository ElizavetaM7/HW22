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
        static void Main()
        {
            var dict = new SortedDictionary<string, int>();

            using(var file = new StreamReader("dict.txt", Encoding.Default))
            {
                while (!file.EndOfStream)
                {
                    var key = file.ReadLine().Split('\t')[1];
                    if (dict.ContainsKey(key))
                        dict[key]++;
                    else
                        dict[key] = 1;
                }
                Console.WriteLine(file);
                Console.ReadKey();
            }
            
        }
    }
}
