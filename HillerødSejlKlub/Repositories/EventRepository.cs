using HillerødSejlKlub.HillerødSejlKlub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Repositories
{
    public class EventRepository : IEventRepository 
    { 
        //Instance field 
        private static List<Event> _eventRepository;

        //Constructor
        public EventRepository() 
        {
            _eventRepository = new List<Event>(); 
        }

        //Methods


        public void AddEvent(Event eventToAdd)
        {
            _eventRepository.Add(eventToAdd); 
        }

        public void RemoveEvent(Event eventToRemove)
        {
            _eventRepository.Remove(eventToRemove);

            //Hvad skal der ske, hvis eventet ikke kan findes i listen? 
        }

        public void PrintAll()
        {
         foreach(Event events in _eventRepository)
            {
                Console.WriteLine(events); 
            }
        }

        public void UpdateEvent(Event eventToUpdate, string name, string description, DateTime date, bool requiresSignup)
        {
            eventToUpdate.Name = name;
            eventToUpdate.Description = description;
            eventToUpdate.Date = date;
            eventToUpdate.RequiresSignup = requiresSignup;

            Console.WriteLine($"Event information has been updated. \nName: {eventToUpdate.Name} \nDescription: {eventToUpdate.Description} \nDate: {eventToUpdate.Date} \nRequires signup: {eventToUpdate.RequiresSignup}"); 
        }

        public void Delete(Event eventToDelete)
        {
         foreach(Event events in _eventRepository)
            {
                if(events.Name == eventToDelete.Name)
                {
                    _eventRepository.Remove(eventToDelete); 
                } else
                {
                    Console.WriteLine("Event not found"); 
                }
                //Test denne. Printer den "event not found" uanset om et event er blevet fjernet eller ej?
            }

        }

        public Event GetByName(string name)
        {
            foreach (Event events in _eventRepository)
            {
                if (events.Name == name)
                {
                    return events;

                }
            }
            return null; 

            //Hvad skal der ske her? Hvis eventet ikke er fundet, bør der komme en besked op om dette. 
        }


        public int Count()
        {
            return _eventRepository.Count(); 
        }

        public override string ToString()
        {
            string result = "Her er en oversigt over dine events:\n";

            foreach (var events in _eventRepository)
            {
                result = result + $"{events.ToString()}" + "\n";
            }

            return result;
        }

    }
}
