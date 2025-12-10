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
            Console.WriteLine(boat.BoatName + " has been added to the list.");
        }
        public void GetAll()
        {
            foreach (Boat boat in _boatRepository)
            {
                Console.Write(boat);
            }
        }

        public void Update(Boat boat, string type, string model, string boatName, string sailNumber, string measurements, int builtYear)
        {
            boat.Type = type;
            boat.Model = model;
            boat.BoatName = boatName;
            boat.SailNumber = sailNumber;
            boat.Measurements = measurements;
            boat.BuiltYear = builtYear; 

            
        }

        public void DeleteBoat(Boat boat)
        {

            _boatRepository.Remove(boat);
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
            } return null; 
        }
            

                

        public int Count()
        {
            return _boatRepository.Count();
        }



        public void AddDamageReport(int boatIndex, string description, User reportedBy)
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
