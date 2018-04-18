using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    public class Vehicle
    {
        public Vehicle(string vehicleType, string regNumber, string color, int nrfWheels)
        {
        VehicleType = vehicleType;
        RegNumber = regNumber;
        Color = color;
        NrOfWheels = nrfWheels; 

        }


    public string RegNumber { get; set; }
    public string VehicleType { get; set; }
    public string Color { get; set; }
    public int NrOfWheels { get; set; } 




}

}
