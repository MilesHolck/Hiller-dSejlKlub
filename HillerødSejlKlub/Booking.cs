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
        public int BookingId { get; } 
        public DateTime DateTime { get; set; }

        private User _user;
        private Boat _boat;
        public User user
        {
            get { return _user; }
            set { _user = value; }
        }

        public Boat Boat
        {
            get { return _boat; }
            set { _boat = value; }
        }
        public bool IsReturned { get; set; }

        public string Destination { get; set; }

        public int StartHour { get; set; }
        public int EndHour { get; set; }


        public Booking(User user, Boat boat, bool bookedTime)
        {
            _user = user;
            _boat = boat;
         }

        //ændret IsReturn til en void metode der printer status i stedet for at returnere en bool
        public void IsReturn(int currentHour)
        {
            if (IsReturned) 
            { 
                Console.WriteLine("Båden er afleveret.");
            }
            else
            {
                if (currentHour > EndHour && !IsReturned)
                {
                    Console.WriteLine("eftersøgning sat igang");
                }
                else
                {
                    Console.WriteLine("Båden er ude på vandet :3");
                }
            }
        }

       
        //_________________________________________________________
        public override string ToString()
        {
            return $"\nBooking: \nMember: {_user} \nBoat: {_boat} \nIs Returned: {IsReturned} \nDestination: {Destination} \nStart Hour: {StartHour} \nEnd Hour: {EndHour}";
        }

    }
}