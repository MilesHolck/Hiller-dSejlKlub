using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Repositories
{
    public interface IUserRepository
    {

        public void Add(User user);

        public void PrintAll();

        public void Update(User user, string name, int age, int phoneNumber, string email);

        public void Delete(User user);

        public string GetByName(string name);

        public int Count(); 
    }
}
