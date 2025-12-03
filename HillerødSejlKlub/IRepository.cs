using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public interface IRepository
    {

        public void Create();

        public void Read();

        public void Update();

        public void Delete(); 
    }
}
