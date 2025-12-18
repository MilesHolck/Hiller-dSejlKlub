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
        private static List<Event> _events;

        //Constructor
        public EventRepository() 
        {

            _events = new List<Event>(); 
        }

        //Methods


        public void AddEvent(Event eventToAdd)
        {
            _events.Add(eventToAdd);
            Console.WriteLine($"The event {eventToAdd.Name} has been added to the list."); 
        }

      

        public void PrintAll()
        {
         foreach(Event events in _events)
            {
                Console.WriteLine(events.Name);
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

        public void DeleteEvent(Event eventToDelete)
        {

            if(_events.Contains(eventToDelete))
                {
                 _events.Remove(eventToDelete);
                 Console.WriteLine($"The event {eventToDelete.Name} has been removed from the list."); 

                }else
                {
                    Console.WriteLine("Event not found");
                }
               
            }

        

        public string GetByName(string name)
        {
            foreach (Event events in _events)
            {
                if (events.Name == name)
                {
                    return events.ToString(); 

                }
            }
            return "Event not found"; 

           
        }


        public int Count()
        {
            return _events.Count(); 
        }

        public override string ToString()
        {
            string result = $"Her er en oversigt over dine events:\n";

            foreach (var events in _events)
            {
                result = result + events.ToString() + "\n"; 
                
            } return result; 

        }

    }
}
