using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Repositories
{
    public class MemberRepository : IUserRepository
    {
        //Instance field
        private List<User> _members; 
        
        
        //Constructor 
        public MemberRepository()
        {
            _members = new List<User>(); 
        }

        //Interface methods
        public string Add(User user)
        {
            _members.Add(user);
            return $"{user} has been registered."; 
        }

        public void PrintAll()
        {
          foreach(User user in _members)
            {
                Console.WriteLine(user.Name);
            }
        }

        public void Update(User user, string name, int age, int phoneNumber, string email)
        {
            user.Name = name;
            user.Age = age;
            user.PhoneNumber = phoneNumber;
            user.Email = email;

        }

        public string Delete(User user)
        {
            _members.Remove(user);
            return $"{user} has been removed."; 
        }

        public User GetByName(string name)
        {
            foreach (User user in _members)
            {
                if (user.Name == name)
                {
                    return user;
                }
            }

            return null;

            //Hvad skal der ske, hvis useren ikke er fundet i listen?
        }

        public int Count()
        {
            return _members.Count(); 
        }

        
      // IKKE EN DEL AF INTERFACE.. ENDNU? 


        public User GetMemberById(int id)
        {
            string idString = id.ToString();

            foreach (User user in _members)
            {
                if (user.MemberId.ToString() == idString)
                {
                    return user;
                }
            }

            return null;
        }

       
    }
}
