using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    internal class Engine
    {

        public string Model { get; set; } 
        public string Brand { get; set; }
        public string MotorOplysninger { get; set; }

        public Engine(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }

    }
}
