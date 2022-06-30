using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Perfomance
    {
        public string Title;
        public string Description;
        public TimeSpan Start;
        public readonly TimeSpan Finish;
        public TypePerfomance Type; 

        public TimeSpan Duration
        {
            get
            {
                return Start - Finish;
            }
        }
        public int Discount { get; internal set; }
        public Perfomance(string title, string description)
        {
            Title = title;
            Description = description;

        }
        public override string ToString()
        {
            return $"{Title}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var type = "";
            switch(Type)
            {
                case TypePerfomance.LastSeason:
                    type = "Последний сезон";
                    break;
                case TypePerfomance.Premiere:
                    type = "Премьера";
                    break;
                case TypePerfomance.Usual:
                    type = "Обычный";
                    break;
            }
            Console.WriteLine
                ($"Продолжительность:{Duration}." +
                $"Описание:{Description}.");
        }


    }
}
