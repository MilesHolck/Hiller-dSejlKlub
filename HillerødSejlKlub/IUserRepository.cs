using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public interface IUserRepository
    {

        public string Add(User user);

        public void GetAll();

        public void Update(User user, string name, int age, int phoneNumber, string email);

        public string Delete(User user);

        public User GetByName(string name);

        public int Count(); 
    }
}
