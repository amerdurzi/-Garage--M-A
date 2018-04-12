using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    public class Garage <T> where T : Vehicle 
    {

        T[] collection;
        int cap, count;
        public Garage(int GarageCapacity)
        {
            cap = GarageCapacity;
            count = 0;

        }
          

    }
}
