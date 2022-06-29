using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InterFace
{
    public class Car : IDriveble
    {
        public string Name;
        public double Velocity;

        double IDriveble.Velocity { get; set; }

        public void Drive(double delta)
        {
            Velocity = delta;
        }

        public void Start()
        {
            Console.WriteLine("[Машина] зажигание включено");
            Drive(5);
        }

        public void Stop()
        {
            while (Velocity > 0)
            {
                Drive(-10);
                if (Velocity < 0) Velocity = 0;
            }
        }
    }
}
