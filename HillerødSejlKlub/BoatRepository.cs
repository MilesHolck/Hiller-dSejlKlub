using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class BoatRepository : IRepository
    {


        private List<Boat> _boatRepository;
        

        public BoatRepository()
        {
            _boatRepository = new List<Boat>(); 
        }

        public void Create()
        {
          
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
    }
}
