using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class MemberRepository : IRepository
    {


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

        private List<Member> members = new List<Member>();

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public List<Member> GetAll()
        {
            return members;
        }

        public void RemoveMember(Member member)
        {
            members.Remove(member);
        }

        public Member GetMemberByName(string name)
        {
            if (name != null)
            {
                return members.Find(m => m.Name == name);
            }
            else
            {
                return null;
            }
        }
        public Member GetMemberById(int id)
        {
            return members.Find(m => m.MemberId == id.ToString());
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
