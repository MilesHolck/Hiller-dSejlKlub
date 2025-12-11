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
        public void Add(User user)
        {
            _members.Add(user);
            Console.WriteLine($"{user.Name} has been registered."); 
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

            Console.WriteLine($"Member details have been updated:{user.ToString()} "); 

        }

        public void Delete(User user)
        {
            if (_members.Contains(user))
            {
                _members.Remove(user);
                Console.WriteLine($"{user.Name} has been removed from the list.");
            }else
            { 
                Console.WriteLine($"User not found on list.");
            }

        }

        public string GetByName(string name)
        {
            foreach (User user in _members)
            {
                if (user.Name == name)
                {
                    return user.ToString();
                }
                
            }

           return $"User with name {name} has not been found."; 

            
        }

        public int Count()
        {
            return _members.Count(); 
        }

        public override string ToString()
        {
            string result = "Her er et overblik over alle medlemmer: \n"; 

            foreach(User user in _members)
            {
                result = result + user.ToString() + "\n";
                
            }
            return result; 
        }



        public string GetMemberById(int id)
        {
            string idString = id.ToString();

            foreach (User user in _members)
            {
                if (user.MemberId.ToString() == idString)
                {
                    return user.ToString();
                }
            }

            return $"User with id no. {id} has not been found."; 
        }

       
    }
}
