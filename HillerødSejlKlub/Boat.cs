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
        public bool IsAvailable { get; set; }
        public DateTime BookedTimeAndDate { get; set; } //proptery for at tjekke bookinger

        //dictionary til bookinger tjekker om der er en liste med actuelle bookinger.
        public Dictionary<string, Booking?> BookingsDictionary { get; }
        //_______________________________________________________________

        // Damagereport liste
        public List<DamageRaport> DamageReports { get; set; } = new List<DamageRaport>();

        public Boat(Engine engine, string type, string model, string name, string sailNumber, string measurements, int builtYear)
        {
            Engine = engine;
            Type = type;
            Model = model;
            Name = name;
            SailNumber = sailNumber;
            Measurements = measurements;
            BuiltYear = builtYear;
            BookingsDictionary = new Dictionary<string, Booking?>();
        }

        public Boat(string type, string model, string name, string sailNumber, string measurements, int builtYear)
        {
            Type = type;
            Model = model;
            Name = name;
            SailNumber = sailNumber;
            Measurements = measurements;
            BuiltYear = builtYear;
            BookingsDictionary = new Dictionary<string, Booking?>();
        }

        public void AddDamage(string description, string reportedBy)
        {
            var report = new DamageRaport(description, reportedBy);
            DamageReports.Add(report);
        }

        public string VedligeholdelsesLog()
        {
            return "Vedligeholdelseslog for båden ";
        }
        public string Skadesrapport()
        {
            return "Skadesrapport for båden ";
        }

        //booking metode:_______________________________________________________

        public void AddBooking(Booking booking)
        {
            string dateKey = booking.DateTime.ToString("yyyy-MM-dd");
            Booking? bookingForTheDay = BookingsDictionary.GetValueOrDefault(dateKey);
            if (bookingForTheDay == null)
            {
                BookingsDictionary[dateKey] = booking;
                Console.WriteLine("Added booking: " + booking.ToString());
            }
            else
            {
                throw new Exception("Båden er allerede booket på denne dato.");
            }

        }

        //metode slut____________________________________________________________



        public override string ToString()
        {
            return $"Boat: {Name}, Type: {Type}, Model: {Model}, Sail Number: {SailNumber}, Measurements: {Measurements}, Built Year: {BuiltYear}, Is Available: {IsAvailable}, Engine: [{Engine}]";
        }
    }
}
