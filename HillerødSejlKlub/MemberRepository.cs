using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class MemberRepository : IRepository
    {
        //Instance field
        private List<Member> _members; 
        
        
        //Constructor 
        public MemberRepository()
        {
            _members = new List<Member>(); 
        }

        //Methods (Interface) NOT WORKING YET
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        //Methods (working)
        public void AddMember(Member member)
        {
            _members.Add(member);
        }

        public List<Member> GetAll()
        {
            return _members;
        }

        public void RemoveMember(Member member)
        {
            _members.Remove(member);
        }

        public Member GetMemberByName(string name)
        {
            foreach (var member in _members)
            {
                if (member.Name == name)
                {
                    return member;
                }
            }

            return null; 
        }
        public Member GetMemberById(int id)
        {
            string idString = id.ToString();

            foreach (var member in _members)
            {
                if (member.MemberId == idString)
                {
                    return member;
                }
            }

            return null;
        }

        public void UpdateMember(Member member, string name, int age, int phoneNumber, string email)
        {
            member.Name = name;
            member.Age = age;
            member.PhoneNumber = phoneNumber;
            member.Email = email;
        }
    }
}
