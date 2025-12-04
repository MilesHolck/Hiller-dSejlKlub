using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Member : User
    {


      
        public Member(string memberId, string name, int age, int phoneNumber, string email) : base(memberId, name, age, phoneNumber, email)
        { 
            MemberId = memberId;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
        }

    } 


}
