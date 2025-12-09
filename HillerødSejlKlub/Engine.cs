using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Engine
    {
        public string Name { get; set; }
        public string Model { get; set; } 
        public string Brand { get; set; }
        public string Fuel  { get; set; }
        public int YearMade { get; set; }   
        public string MotorOplysninger { get; set; }

        public Engine(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }

        public Engine() { }

        public override string ToString()
        {
            return $"\nEngine: {Name} \nModel: {Model} \nBrand: {Brand} \nFuel: {Fuel} \nYear Made: {YearMade} \nMotor Info: {MotorOplysninger}";
        }

    }
}
