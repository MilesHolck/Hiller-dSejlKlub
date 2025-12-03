using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    class Boat
    {
        public string type { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string SailNumber { get; set; }
        public string MotorOplysninger { get; set; }


        public string Measurements { get; set; }
        public int BuiltYear { get; set; }
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
