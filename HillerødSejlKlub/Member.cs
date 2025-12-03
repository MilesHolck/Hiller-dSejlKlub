using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Member : IUser
    {
        public string MemberId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public Member(string memberId, string name, int age, int phoneNumber, string email) 
        { 
            MemberId = memberId;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
        }

    } 


}
