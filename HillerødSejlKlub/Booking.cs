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
       
        private static List<Booking> _bookings = new List<Booking>();
        private static int _idcounter = 0;

        public int Id { get; private set; }
        public Boat Boat { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public User User { get; set; }
        public int NrParticipant { get; set; }
        public string Destination { get; set; }


        public Booking(Boat boat, DateTime startTime, DateTime endTime, User user, int nrParticipant, string destination)
        {
            _idcounter++;
            Id = _idcounter;
            Boat = boat;
            StartTime = startTime;
            EndTime = endTime;
            User = user;
            NrParticipant = nrParticipant;
            Destination = destination;
            if (CheckBookingDate(startTime, endTime, boat))
            {
                Console.WriteLine($"Bookingen er registreret. Din Booking ID is: {Id}");
                _bookings.Add(this);
            }
            else
            {
                Console.WriteLine("Båden er ikke tilgængelig");
            }
        }
     

        private bool CheckBookingDate(DateTime start, DateTime end, Boat boat)
        {
            foreach (Booking booking in _bookings)
            {
                if (booking.Boat == boat)
                {
                    if (start < booking.EndTime && end > booking.StartTime)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        public void GetAll()
        {
            foreach (Booking booking in _bookings)
            {
                Console.WriteLine($"Booking id: {booking.Id}\nBoat: {booking.Boat.BoatName}\nStart: {booking.StartTime}, End: {booking.EndTime}\nUser: {booking.User.Name}\nParticipants: {booking.NrParticipant}\nDestination: {booking.Destination}");
            }
        }
        public void SafeReturn(int id)
        {
            foreach (Booking booking in _bookings)
            {
                if (booking.Id == id)
                {
                    _bookings.Remove(booking);
                    Console.WriteLine("Båden er tilbage");
                    return;
                }
            }
            Console.WriteLine("Bookingen kunne ikke findes.");
        }
        public void BoatInTheWater(DateTime start, DateTime end)
        {
            foreach (Booking booking in _bookings)
            {
                if (start < booking.EndTime && end > booking.StartTime)
                {
                    Console.WriteLine($"{booking.Boat.BoatName} er ude og sejle. Time slot {booking.StartTime} - {booking.EndTime}");
                }
            }
        }   

        public override string ToString()
        {
            return $"\nDestination: {Destination} \nStart Hour: {StartTime} \nEnd Hour: {EndTime}";
        }

    }
}