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
            Console.WriteLine(boat.Name + " has been added to the list.");
        }
        public void GetAll()
        {
            foreach (Boat boat in _boatRepository)
            {
                Console.Write(boat);
            }
        }

        public void Update(Boat boat)
        {
            throw new NotImplementedException();

            //Hvad stilles der op, ifht. de 2 forskellige constructors i båd? Har båden en engine eller ej?
        }

        public void DeleteBoat(Boat boat)
        {

            _boatRepository.Remove(boat);
            Console.WriteLine(boat + "has been removed from the list.");
            Console.WriteLine(boat + "has been removed from the list."); 

            //Hvad skal der ske, hvis båden ikke findes på listen?
        }



        public Boat GetByNumber(string sailNumber)
        {
            foreach (Boat boat in _boatRepository)
            {
                if (sailNumber == boat.SailNumber)
                {
                    return boat;
                }
            }
            return null;
            return null; //Hvad skal der ske, hvis bådnummeret ikke findes? 
        }

        public int Count()
        {
            return _boatRepository.Count();
        }
        public void AddDamageReport(int boatIndex, string description, string reportedBy)
        {
            if (boatIndex >= 0 && boatIndex < _boatRepository.Count)
            {
                Boat boat = _boatRepository[boatIndex];
                boat.AddDamage(description, reportedBy);
            }
            else
            {
                throw new IndexOutOfRangeException("Båden findes ikke.");
            }
        }
    }
}
