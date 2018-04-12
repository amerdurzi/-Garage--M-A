using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    class Airplane : Vehicle
    {
        public Airplane(int regNumber, string color, string fuelType, int cylinderVolume, int noOfseat) : base(regNumber, color, fuelType, cylinderVolume, noOfseat)
        {
        }
    }
}
