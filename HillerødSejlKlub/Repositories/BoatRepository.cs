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
        public void AddDamageReport(Boat boat, string description, User reportedBy)
        {
            if (boat == null)
            {
                Console.WriteLine("Boat not found.");
                return;
            }

            boat.AddDamage(description, reportedBy);
            Console.WriteLine("Damage report added to boat " + boat.BoatName);
        }


        public string GetBoatStatus(string sailNumber)
        {
            Boat boat = GetByNumber(sailNumber);

            if (boat == null)
                return "Båden blev ikke fundet.";

            return boat.ToString() + "\n" + boat.Skadesrapport();
        }
      
    }
}
