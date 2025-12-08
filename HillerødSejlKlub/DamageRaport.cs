using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class DamageRaport
    {
        public DateTime Date { get; set; }

        public string Description { get; set; }


        public string ReportedBy { get; set; }


        public string Status { get; set; } = "Indberettet";


        public DamageRaport(string description, string reportedBy)
        {
            Date = DateTime.Now;
            Description = description;
            ReportedBy = reportedBy;
            Status = "Indberettet";
        }
        public override string ToString()
        {
            return $"Skadesrapport:\nDato: {Date}\nBeskrivelse: {Description}\nIndberettet af: {ReportedBy}\nStatus: {Status}";
        }

    }


}
