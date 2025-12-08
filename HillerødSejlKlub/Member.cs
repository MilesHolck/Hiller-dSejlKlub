using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class Member : User
    {


      
        public Member(string name, int age, int phoneNumber, string email) : base(name, age, phoneNumber, email)
        { 
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public override string ToString()
        {
            return $"\nMember: {Name} \nMember ID: {MemberId} \nAge: {Age} \nPhone Number: {PhoneNumber} \nEmail: {Email}";
        }

    } 


}
