using HillerødSejlKlub.HillerødSejlKlub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class EventRepository 
    {
        public EventRepository() 
        { 
        
        }
        private List<Event> events = new List<Event>();
        public void AddEvent(Event evnt)
        {
            events.Add(evnt);
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void RemoveEvent(Event evnt)
        {
            events.Remove(evnt);
        }
    }
}
