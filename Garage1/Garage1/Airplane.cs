﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1
{
    public class Airplane : Vehicle
    {
        public Airplane(string vehicleTyp, string regNumber, string color, int nrfWheels) : base(vehicleTyp, regNumber, color, nrfWheels)
        {

        }

        public int NumberOfEngines { get; set; }
    }
}
