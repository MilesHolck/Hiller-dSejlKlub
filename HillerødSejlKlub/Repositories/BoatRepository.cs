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
        public void PrintAll()
        {
            int i = 0; 
            foreach (Boat boat in _boatRepository)
            {
                i++; 
                Console.WriteLine($"{i}. {boat.BoatName}");
            }
        }

        public void Update(Boat boat, string type, string model, string boatName, int sailNumber, string measurements, int builtYear)
        {
            boat.Type = type;
            boat.Model = model;
            boat.BoatName = boatName;
            boat.SailNumber = sailNumber;
            boat.Measurements = measurements;
            boat.BuiltYear = builtYear;

            Console.WriteLine("Boat details have been updated: " + boat); 
        }

        public void DeleteBoat(Boat boat)
        {
            for(int i = 0; i < _boatRepository.Count(); i++) 
            {
                if(_boatRepository.Contains(boat))
                { 

                    _boatRepository.Remove(boat);

                    Console.WriteLine(boat.BoatName + " has been removed from the list.");
                    break;

                } else
                {
                    Console.WriteLine("Boat not found on the list.");
                    break;
                }

            }
        }
        



        public string GetByNumber(int sailNumber)
        {
            foreach (Boat boat in _boatRepository)
            {
                if (sailNumber == boat.SailNumber)
                {
                    return $"Boat number {sailNumber} found: \n{boat}"; 
                }

            }
            return $"Boat with sail number {sailNumber} has not been found.";
        }
            

          
        public int Count()
        {
            return _boatRepository.Count();
        }

       
        public override string ToString()
        {
            string result = $"Her er en oversigt over alle både:\n";

            foreach (Boat boats in _boatRepository)
            {
                result = result + boats.ToString() + "\n";

            }
            return result;

        }

    }
}
