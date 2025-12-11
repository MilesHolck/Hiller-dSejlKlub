using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class DamageReport
    {
        public DateTime Date { get; set; }

        public string Description { get; set; }


        public User ReportedBy { get; set; }


        public string Status { get; set; } = "Indberettet";


        public DamageReport(string description, User reportedBy)
        {
            Date = DateTime.Now;
            Description = description;
            ReportedBy = reportedBy;
            Status = "Indberettet";
        }
        public override string ToString()
        {
            return $"Skadesrapport:\nDato: {Date}\nBeskrivelse: {Description}\nIndberettet af: {ReportedBy.Name}\nStatus: {Status}";
        }
        public void AddDamageReport(Boat boat, string description, User reportedBy)
        {
            if (boat == null)
            {
                Console.WriteLine("Boat not found.");
                return;
            }

            boat.AddDamage(description, reportedBy);
            Console.WriteLine("Damage report added to boat " + boat.BoatName);
        }
        public string GetBoatStatus(Boat boat)
        {
            if (boat == null)
                return "Båden blev ikke fundet.";

            return boat.Skadesrapport();
        }


    }


}
