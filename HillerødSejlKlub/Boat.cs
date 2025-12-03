using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Boat
    {

        public Engine Engine { get; set; } 
        public string Type { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string SailNumber { get; set; }
        public string Measurements { get; set; }
        public int BuiltYear { get; set; }

        public Boat(Engine engine, string type, string model, string name, string sailNumber, string measurements, int builtYear)
        {
            Engine = engine;
            Type = type;
            Model = model;
            Name = name;
            SailNumber = sailNumber;
            Measurements = measurements;
            BuiltYear = builtYear;
        }

        public Boat(string type, string model, string name, string sailNumber, string measurements, int builtYear)
        {
            Type = type;
            Model = model;
            Name = name;
            SailNumber = sailNumber;
            Measurements = measurements;
            BuiltYear = builtYear; 

        }

        public string VedligeholdelsesLog()
        {
            return "Vedligeholdelseslog for båden ";
        }
        public string Skadesrapport()
        {
            return "Skadesrapport for båden ";
        }
    }
}
