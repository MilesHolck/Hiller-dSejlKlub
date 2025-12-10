using HillerødSejlKlub.HillerødSejlKlub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class BookingReopsitory
    {
        private List<Booking> _bookedBoats { get; }

        public BookingReopsitory()
        {
            _bookedBoats = new List<Booking>();

        }

        public void GetAll()
        {
            foreach (Booking booking in _bookedBoats)
            {
                Console.WriteLine(booking);
            }
        }


        public void GetAllActiveBookings()
        {
            foreach (Booking booking in _bookedBoats)
            {
                if (booking.IsActive)
                {
                    Console.WriteLine($"Båden: {booking.Boat.BoatName} kaptajn: {booking.User.Name}");
                }

            }
        }

        public void AddBooking(Booking booking)
        {
            foreach (Booking bookedBoat in _bookedBoats)
            {
                if (booking.Boat.SailNumber == bookedBoat.Boat.SailNumber) //er det den samme båd? ⛵ 
                {   
                    //overlapper starttiden med den allerede eksisternde booking?
                    if (booking.StartTime >= bookedBoat.StartTime && booking.StartTime <= bookedBoat.EndTime) 
                    {
                        throw new Exception("Båden er allerede booket i det ønskede tidsrum.");
                    }
                    if (booking.EndTime >= bookedBoat.StartTime && booking.EndTime <= bookedBoat.EndTime) //same men flippet 
                    {
                        throw new Exception("Båden er allerede booket i det ønskede tidsrum.");
                    }
                }
            }
            //hvis der ikke er nogen konflikter, tilføj bookingen
            _bookedBoats.Add(booking);
        }

        public void RemoveBooking(Booking booking)
        {
            _bookedBoats.Remove(booking);

        }

        public void UpdateBooking(int bookingId, Booking updatedBooking)
        {
            int index = -1;
            foreach (Booking booking in _bookedBoats)
            {
                if (booking.Id == bookingId)
                {
                    index = _bookedBoats.IndexOf(booking);
                    break;
                }
            }

            if (index > -1)
            {
                _bookedBoats[index] = updatedBooking;
            }



        }


    }



}
