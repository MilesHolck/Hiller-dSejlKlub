using HillerødSejlKlub.HillerødSejlKlub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Repositories
{
    public interface IEventRepository
    {

        public void AddEvent(Event eventToAdd); 

        public void PrintAll();

        public void UpdateEvent(Event eventToUpdate, string name, string description, DateTime date, bool requiresSignup);

        public void DeleteEvent(Event eventToDelete);

        public string GetByName(string name);

        public int Count();
    }
}
