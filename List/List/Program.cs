using System;
using System.Collections.Generic;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 5, 0 };
            var lines = new List<string>();
            numbers[1] = 7;
            var n = numbers[0] + numbers[1];

            Console.WriteLine($"n={n}");

            lines.Add("Первая строка");
            lines.Add("Вторая строка");

            numbers.Add(9);
            Console.WriteLine($"numbers = {numbers.Capacity}");
            numbers.Add(5);
            Console.WriteLine($"numbers = {numbers.Capacity}");

            numbers.Insert(2, 4);
            //numbers(2)=4;
            numbers.Add(4);
            

            Console.WriteLine($"Первое вхождение четверки\"4\" по индексу {numbers.IndexOf(4)}");
            Console.WriteLine($"Последнее вхождение четверки\"4\" по индексу {numbers.LastIndexOf(4)}");
            Console.WriteLine($"Первое вхождение четверки\"11\" по индексу {numbers.IndexOf(11)}");
            numbers.Remove(6);
            numbers.RemoveAt(4);

            var answer = numbers.Contains(1) ? "Да" : "Нет"; 
            Console.WriteLine($"Есть ли в списке 1? {answer}"); 
            answer = numbers.Contains(11) ? "Да" : "Нет";
            Console.WriteLine($"Есть ли в списке 11? {answer}");


            numbers.Clear();
            Console.ReadKey();
        }
    }
}
