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
        DateTime EventDate { get; set; }
        public Event Event { get; set; }
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
                    
            EventDate = eventInfo.Date; 
            
        }

        public string ShowNews() 
        { 
            return $"BREAKING!!\n Nyheder fra Hillerød Sejlklub\n" +
                $"{Title}\n" +
                $"{Description}\n" +
                $"{Event.Date}";
        }
    }
}
