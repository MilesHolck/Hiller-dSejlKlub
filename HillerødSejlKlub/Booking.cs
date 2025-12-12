using HillerødSejlKlub.HillerødSejlKlub;
using HillerødSejlKlub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Booking
    {


        private static int _idcounter = 0;

        public int Id { get; private set; }
        public Boat Boat { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public User User { get; set; }
        public int NumberParticipant { get; set; }
        public string Destination { get; set; }
        public bool IsActive { get; private set; }


        public Booking(Boat boat, DateTime startTime, DateTime endTime, User user, int NumberParticipant, string destination)
        {
            IsActive = true;
            _idcounter++;
            Id = _idcounter;
            Boat = boat;
            StartTime = startTime;
            EndTime = endTime;
            User = user;
            this.NumberParticipant = NumberParticipant;
            Destination = destination;
        }

        public void StopBooking()
        {
            IsActive = false;
        }


       public void SearchforBoat(DateTime currentTime) //skal refactores pga strid mellem DateTime og Current time. 
{
    if (currentTime > EndTime && IsActive)
    {
        Console.WriteLine($"Båden {Boat.BoatName} er ikke returneret til korrekt tid");
    }
    else if (currentTime < EndTime && IsActive)
    {
        Console.WriteLine($"Båden {Boat.BoatName} er stadig ude og sejle");
    }
    else
    {
        Console.WriteLine($"Båden {Boat.BoatName} er returneret til tiden");
    }
}


        public override string ToString()
        {
            return $"\nDestination: {Destination} \nStart Hour: {StartTime} \nEnd Hour: {EndTime}";
        }

    }
}