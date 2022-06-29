using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    interface IDriveble
    {
        double Velocity { get; set; }
        void Start();
        void Drive(double delta);
        void Stop();
    }
}
