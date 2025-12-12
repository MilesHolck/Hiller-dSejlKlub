using HillerødSejlKlub.Repositories;
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
        public string BoatName { get; set; }
        public int SailNumber { get; set; }
        public string Measurements { get; set; }
        public int BuiltYear { get; set; }
        public List<DamageReport> DamageReports { get; set; } = new List<DamageReport>();

        public Boat(Engine engine, string type, string model, string name, int sailNumber, string measurements, int builtYear)
        {
            Engine = engine;
            Type = type;
            Model = model;
            BoatName = name;
            SailNumber = sailNumber;
            Measurements = measurements;
            BuiltYear = builtYear;
            
        }

        public Boat(string type, string model, string name, int sailNumber, string measurements, int builtYear)
        {
            Type = type;
            Model = model;
            BoatName = name;
            SailNumber = sailNumber;
            Measurements = measurements;
            BuiltYear = builtYear;
            
        }

       public string AddDamage(string description, User reportedBy)
        {
          DamageReport report = new DamageReport(description, reportedBy);
          DamageReports.Add(report);
            return $"Damage report added to boat {BoatName}:\n{report.ToString()}";
        }
       

        public string Skadesrapport()
        {
            if (DamageReports.Count == 0)
                return $"Ingen skader på {BoatName}.";

            string result = $"Skadesrapport for {BoatName}:\n";

            foreach (var report in DamageReports)
                result += $"- {report.Date}: {report.Description} (af {report.ReportedBy.Name})\n";

            return result;
        }

        public override string ToString()
        {
            return $"\nBoat: {BoatName} \nType: {Type} \nModel: {Model} \nSail Number: {SailNumber} \nMeasurements: {Measurements} \nBuilt Year: {BuiltYear} \nEngine: {Engine}";
        }
    }
}
