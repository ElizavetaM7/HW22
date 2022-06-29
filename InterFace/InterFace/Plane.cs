using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    public class Plane :IDriveble
    {
        public string Name;
        public int Capacity;
        public double Height;
        public double Velocity;

        double IDriveble.Velocity 
        {
            get { return Velocity; }
            set 
            {
                if (value < 0)
                    throw new AggregateException();
                else
                    Velocity = value;
            } 
        }

        public void Drive(double delta)
        {
            if (-delta > Velocity)
                Velocity = 0;
            else
                Velocity += delta;

        }

        public void Start()
        {
            Console.WriteLine("[Самолет] Проверка приборов");
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
