using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Booking
    {
        private Member _member;
        private Boat _boat;


        public Member Member
        {
            get { return _member; }
            set { _member = value; }
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


        public Booking(Member member, Boat boat, bool bookedTime)
        {
            _member = member;
            _boat = boat;

        }

        public void IsReturn(int currentHour)
        {
            if (currentHour > EndHour && !IsReturned)
            {
                Console.WriteLine("eftersøgning sat igang");
            }

            else
            {
                Console.WriteLine("Båden er afleveret.");
            }


        }
        public override string ToString()
        {
            return $"Booking: Member: [{_member}], Boat: [{_boat}], Is Returned: {IsReturned}, Destination: {Destination}, Start Hour: {StartHour}, End Hour: {EndHour}";
        }

    }
}