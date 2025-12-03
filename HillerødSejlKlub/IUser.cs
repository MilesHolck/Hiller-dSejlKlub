using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public interface IUser
    {
        string MemberId { get; set; }
        string Name { get; set; }
        string Email { get; set; }       

    }

}
