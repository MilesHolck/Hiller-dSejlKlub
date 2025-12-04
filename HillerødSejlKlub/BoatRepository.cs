using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public class BoatRepository 
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

        public Boat Add(Boat boat)
        {
            _boatRepository.Add(boat);
            return boat; 
        }

        public void GetAll()
        {
            foreach(Boat boat in _boatRepository)
            {
                Console.WriteLine(boat);
            }
        }

        public void Remove(Boat boat)
        {
            _boatRepository.Remove(boat);
        }



    }
}
