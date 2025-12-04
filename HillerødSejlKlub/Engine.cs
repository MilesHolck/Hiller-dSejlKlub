using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Engine
    {
        public string name { get; set; }
        public string Model { get; set; } 
        public string Brand { get; set; }
        public string fuel  { get; set; }
        public int yearMade { get; set; }   
        public string MotorOplysninger { get; set; }

        public Engine(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }
        public override string ToString()
        {
            return $"Engine: {name}, Model: {Model}, Brand: {Brand}, Fuel: {fuel}, Year Made: {yearMade}, Motor Info: {MotorOplysninger}";
        }

    }
}
