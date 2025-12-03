using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Admin : IUser
    {
        public string MemberId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public Admin(string memberId, string name, int age, int phoneNumber, string email)         
        { 
            Name = name;
            MemberId = memberId;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

}
