using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Engine
    {
        public string Model { get; set; } 
        public string Brand { get; set; }


        public Engine(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }

        public Engine() { }

        public override string ToString()
        {
            return $"\nEngine: \nModel: {Model} \nBrand: {Brand} ";
        }

    }
}
