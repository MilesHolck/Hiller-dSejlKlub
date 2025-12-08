using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Repositories
{
    public class BoatRepository : IBoatRepository
    {


        private List<Boat> _boatRepository;
        

        public BoatRepository()
        {
            _boatRepository = new List<Boat>(); 
        }


        public void AddBoat(Boat boat)
        {
            _boatRepository.Add(boat);
            Console.WriteLine(boat + "has been added to the list");
        }
        public void GetAll()
        {
            foreach(Boat boat in _boatRepository)
            {
                Console.Write(boat);
            }
        }

        public void Update(Boat boat)
        {
            throw new NotImplementedException();
        }

        public void DeleteBoat(Boat boat)
        {
            
            _boatRepository.Remove(boat);
            Console.WriteLine(boat + "has been removed from the list."); 
        }

       

        public Boat GetByNumber(string sailNumber)
        {
            foreach(Boat boat in _boatRepository)
            {
                if (sailNumber == boat.SailNumber)
                {
                    return boat;
                }
            }
            return null; 
        }

        public int Count()
        {
            return _boatRepository.Count();
        }

        
    }
}
