using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Repositories
{
    public interface IBoatRepository
    {
        public void AddBoat(Boat boat);

        public void PrintAll();

        public void Update(Boat boat, string type, string model, string boatName, string sailNumber, string measurements, int builtYear);

        public void DeleteBoat(Boat boat);

        public string GetByNumber(string sailNumber);

        public int Count();

    }
}
