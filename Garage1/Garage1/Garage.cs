using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        T[] vehicles;
        int cap, count;

        public Garage(int MaxCapacity)
        {
            cap = MaxCapacity;
            count = 0;
            vehicles = new T[MaxCapacity];
        }


        public void Remove (String input)
        {
            for (int i=0; i < vehicles.Count(); i++)
            {
                if (vehicles[i] == null)
                {

                }
                else
                if(i==vehicles.Count()-1 && vehicles[i].RegNumber==input)
                {
                vehicles[i] = null;
                count -= 1;

                }
                else if(vehicles[i].RegNumber == input)
                {
                    vehicles[i] = null;
                    for (int x = i; x < vehicles.Count(); x++)
                    {
                        if (x == vehicles.Count() - 1)
                        {
                            vehicles[x] = null;
                            count -= 1;
                        }
                        else
                        {
                            vehicles[x] = vehicles[x + 1];
                        }

                    } 
                }
                
            }

        }





        public void Add(T input)
        {
            if (cap > count)
            {
                vehicles[count] = input;
                count += 1;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehicles[i];
            }
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
