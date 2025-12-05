using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{

    public abstract class User
    {

        private static int _nextMemberId = 0;
        private int _memberId; 

        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public User(int memberId, string name, int age, int phoneNumber, string email)
        {
            MemberId = memberId;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;

            _memberId = _nextMemberId++; 

        }
        public override string ToString()
        {
            return $"User: {Name}, Member ID: {MemberId}, Age: {Age}, Phone Number: {PhoneNumber}, Email: {Email}";
        }
    }
}
