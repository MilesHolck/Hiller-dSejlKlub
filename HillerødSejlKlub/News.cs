using HillerødSejlKlub.HillerødSejlKlub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class News
    {
        public string Title { get; set; }
        public string Description { get; set; }
        DateTime CreatedDate { get; set; }
        Event Event { get; set; }


        public News(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            CreatedDate = DateTime.Now;
        }

        public News(string title, string description, Event eventInfo)
        {
            Title = title;
            Description = description;

            CreatedDate = DateTime.Now;
                    
            Event = eventInfo; 
            
        }

        public string ShowNews() 
        {
            if (Event != null)
            {
                return $"NYT EVENT!!\n" +
                    $"{Title}\n" +
                    $"{Description}\n" +
                    $"Du kan læse mere om eventet nedenfor: \n" +
                    $"{Event.Name} \n" +
                    $"{Event.Description} \n" +
                    $"{Event.Date} \n";
            }
            return $"BREAKING!!\nNyheder fra Hillerød Sejlklub\n" +
                    $"{Title}\n" +
                    $"{Description}\n"; 
        }
       
    }
}
