using HillerødSejlKlub.HillerødSejlKlub;
using HillerødSejlKlub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Admin : User
    {
        
        public Event SomeEvent { get; set; }

        public User SomeUser { get; set; }

        public Admin(string name, int age, int phoneNumber, string email) : base(name, age, phoneNumber, email)
        {
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
        public void AddEventParticipant(Event availableEvent, User user) 
        {
            SomeEvent = availableEvent; 
            availableEvent.Participants.Add(user); 
        } 
        public override string ToString()
        {
            return $"\nAdmin: {Name} \nMember ID: {MemberId} \nAge: {Age} \nPhone Number: {PhoneNumber} \nEmail: {Email}";
        }

    }

}
