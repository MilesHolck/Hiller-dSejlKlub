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

            //private List<User> _participants = new List<User>(); 

            public string Name { get; set; }          
            public string Description { get; set; }                  
            public DateTime Date { get; set; }         

            public bool RequiresSignup { get; set; }    
            public List<User> Participants { get; set; }

            public Event()
            {
                Participants = new List<User>(); 
            }
            public Event(string name, string description, DateTime date, bool requiresSignup) 
            { 
                Name = name;
                Description = description;
                Date = date;
                RequiresSignup = requiresSignup;
                Participants = new List<User>();

            }

            public override string ToString()
            {
                return $"\nEvent: {Name} \nDescription: {Description}  \nD. {Date.ToString()} \nRequires Signup: {RequiresSignup} \nParticipants Count: {Participants.Count}";
            }

            public string GetParticipantsInfo() 
            {
                string result = "Participants:\n";

                for (int i = 0; i < Participants.Count; i++) 
                {
                    result = result + $"{i + 1}. {Participants[i].Name}\n";

                }
                return result;
            }

            public string GetParticipantsByMemberID(int memberId) 
            { 
            foreach (User user in Participants) 
                {
                    if (user.MemberId == memberId) 
                    {
                        return user.ToString();
                    }
                }
                return "No participant found with the given Member ID.";
            }
        } 
    }

}
