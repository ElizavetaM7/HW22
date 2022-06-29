using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Numerics;

namespace Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequenc = new Sequenc();
            Console.WriteLine("Последовательность Фибоначи");
            PrintSequenc(sequenc.Fibonachi());

            Console.WriteLine("\nФакториал");
            PrintSequenc(sequenc.Factorial());
        }
        static void PrintSequenc(IEquatable<BigInteger> s)
        {
            foreach(var elem in s)
            {
                Thread.Sleep(300);
                Console.WriteLine(elem);

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Escape || key.Key == ConsoleKey.Enter)
                        break;
                }
            }
        }
    }
}
