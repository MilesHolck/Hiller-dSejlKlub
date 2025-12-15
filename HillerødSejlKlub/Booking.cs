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
            this.NumberParticipant = NumberParticipant; //Vil du forklare this til os? 
            Destination = destination;
        }

        //Man kan booke samme båd i samme tidsrum+dato. 

        public void StopBooking()
        {
            IsActive = false;
        }


       
        public void SearchforBoat(DateTime currentTime)
        {
            if (currentTime > EndTime && IsActive)
            {
                Console.WriteLine($"Båden {Boat.BoatName} er ikke returneret til korrekt tid. Der startes en eftersøgning");
            }
            else if (currentTime < StartTime && IsActive)
            {
                Console.WriteLine($"Båden {Boat.BoatName} er endnu ikke sejlet ud"); //Båden er endnu ikke sejlet ud, hvis currenttime er før starttime.
            }

            else if (currentTime < EndTime && IsActive)
            {
                Console.WriteLine($"Båden {Boat.BoatName} er stadig ude og sejle"); //Båden er stadig ude at sejle inden bookingen går i gang.
            }
            else
            {
                Console.WriteLine($"Båden {Boat.BoatName} er returneret til tiden"); //Båden er stadig aktiv og returneret til tiden, hvis currenttime er = endtime.
            }

        }

        public override string ToString()
        {
            return $"\nDestination: {Destination} \nStart Hour: {StartTime} \nEnd Hour: {EndTime}";
        }

    }
}