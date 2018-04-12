using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    public class Vehicle
    {

        public Vehicle(int regNumber , string color , string fuelType , int cylinderVolume , int noOfseat )
        {
            RegNumber = regNumber;
            Color = color;
            FuelType = fuelType;
            CylinderVolume = cylinderVolume;
            NoOfSeat = noOfseat;

        }

        public int RegNumber { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public int CylinderVolume { get; set; }
        public int NoOfSeat { get; set; }

        


    }
}
