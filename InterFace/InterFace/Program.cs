using System;

namespace InterFace
{
    class Program
    {
        static void Main()
        {
            var car = new Car();
            var plane = new Plane();

            IDriveble[] vehicles = new IDriveble[] { car, plane };

            foreach (var vehicle in vehicles) ;

            Console.ReadKey();
        }
    }
}
