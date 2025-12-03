using HillerødSejlKlub.HillerødSejlKlub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Admin : IUser
    {
        public string MemberId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public Admin(string memberId, string name, int age, int phoneNumber, string email)         
        { 
            Name = name;
            MemberId = memberId;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void CreateEvent(string name, string day, string description, DateTime date, bool requiresSignup, EventRepository eventRepository) 
        { 
            Event eventName = new Event(name, day, description, date, requiresSignup);
            eventRepository.AddEvent(eventName);
        }
    }

}
