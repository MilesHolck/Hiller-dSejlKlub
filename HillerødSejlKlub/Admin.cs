using HillerødSejlKlub.HillerødSejlKlub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Admin : User
    {
        

        public Admin(int memberId, string name, int age, int phoneNumber, string email) : base(memberId, name, age, phoneNumber, email)
        {
            MemberId = memberId;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void CreateEvent(string name, string description, DateTime date, bool requiresSignup, EventRepository eventRepository) 
        { 
            Event eventName = new Event(name, description, date, requiresSignup);
            eventRepository.AddEvent(eventName);
        }

        public void DeleteEvent(Event eventToDelete, EventRepository eventRepository) 
        { 
            eventRepository.RemoveEvent(eventToDelete);
        } 
        public void UpdateEvent(Event eventToUpdate, string name, string description, DateTime date, bool requiresSignup) 
        { 
            eventToUpdate.Name = name;
            eventToUpdate.Description = description;
            eventToUpdate.Date = date;
            eventToUpdate.RequiresSignup = requiresSignup;
        }  
        public void AddEventParticipant(Event availableEvent, Member member) 
        { 
            availableEvent.Participants.Add(member);
        } 
    }

}
