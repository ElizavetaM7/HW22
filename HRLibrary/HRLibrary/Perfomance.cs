using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Perfomance
    {
        public string Title { get; internal set; }
        public string Description { get; internal set; }
        public TimeSpan Start { get; internal set; }
        public readonly TimeSpan Finish;
        public TypePerfomance Type { get; internal set; }

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
                $"Описание:{Description}." +
                $"Дата и время начала:{Start}." +
                $"Время окончания:{Finish}." +
                $"Тип:{Type}." +
                $"Скидка/Надбавка:{Discount}");
        }


    }
}
