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
            return $"\nEngine: {name} \nModel: {Model} \nBrand: {Brand} \nFuel: {fuel} \nYear Made: {yearMade} \nMotor Info: {MotorOplysninger}";
        }

    }
}
