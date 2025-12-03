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
            public string Name { get; set; }              // Navn på begivenheden
            public string Description { get; set; }       // Beskrivelse
            public string Day { get; set; }               // Ugedag (fx "Lørdag")
            public DateTime Date { get; set; }            // Dato

            public bool RequiresSignup { get; set; }      // Kræver tilmelding?
            public List<Member> Participants { get; set; } // Liste over tilmeldte

            public Event()
            {
                Participants = new List<Member>();
            }

            // Metode til at tilmelde et medlem
            public void Signup(Member m)
            {
                if (!Participants.Contains(m))
                    Participants.Add(m);
            }
        }
    }

}
