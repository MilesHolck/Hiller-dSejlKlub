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

        public string Destination { get; set; }

        public Booking(Member member, Boat boat)
        {
            _member = member;
            _boat = boat;
        }

        //booking time system 

        private bool[] bookedTime = new bool[24];


        //Booker
        public bool Book(int startHour, int endHour)
        {
            //tjekker ledighed
            for (int hour = startHour; hour < endHour; hour++)
            {
                if (bookedTime[hour])
                {
                    return false; //ingen ledighed i dette tidsrm

                }


            }
            //marker som bookede 

            for (int hour = startHour; hour < endHour; hour++)
            {
                bookedTime[hour] = true;
            }

            return true;

        }
        //tjekker ledighed i tidsrum 
        public bool IsAvailable(int startHour, int endHour)
        {
            for (int hour = startHour; hour < endHour; hour++)
            {
                if (bookedTime[hour])
                {
                    return false;
                }
            }
            return true;


            //Return of boat
            bool isBoatReturned = true;

            if (isBoatReturned)
            {
                Console.WriteLine("Returned, all is good.");
            }
            else
            {
                Console.WriteLine("Search for boat in progress.");
            }
        }
    }
}