using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    public class Car : Vehicle
    {
        public Car(string vehicleType, string regNumber, string color, int nrfWheels, string fueltype) : base(vehicleType, regNumber, color, nrfWheels)
        {
            Fueltype = fueltype;
        }

        public string Fueltype { get; set; }  

    }
}
