using System;
using System.Collections.Generic;
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
            public string Day { get; set; }            
            public DateTime Date { get; set; }         

            public bool RequiresSignup { get; set; }    
            public List<Member> Participants { get; set; } 

            public Event()
            {
                Participants = new List<Member>();
            }
        }
    }

}
