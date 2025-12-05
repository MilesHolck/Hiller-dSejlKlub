using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    namespace HillerødSejlKlub
    {
        public class Event
        {
            public string Name { get; set; }          
            public string Description { get; set; }                  
            public DateTime Date { get; set; }         

            public bool RequiresSignup { get; set; }    
            public List<Member> Participants { get; set; } 

            public Event()
            {
                Participants = new List<Member>(); 
            }
            public Event(string name, string description, DateTime date, bool requiresSignup) 
            { 
                Name = name;
                Description = description;
                Date = date;
                RequiresSignup = requiresSignup;
            }

            public override string ToString()
            {
                return $"Event: {Name}, Description: {Description}, Date: {Date.ToString("d", CultureInfo.InvariantCulture)}, Requires Signup: {RequiresSignup}, Participants Count: {Participants.Count}";
            }
        }
    }

}
