using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{

    public abstract class User
    {

        private static int _nextMemberId = 1;
        private int _memberId;

        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public User(string name, int age, int phoneNumber, string email)
        {
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;

            _memberId = _nextMemberId++;

        }
        public override string ToString()
        {
            return $"\nUser: {Name} \nMember ID: {MemberId} \nAge: {Age} \nPhone Number: {PhoneNumber} \nEmail: {Email}";
        }
    }
}
