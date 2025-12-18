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

        public void Update(Boat boat, string type, string model, string boatName, int sailNumber, string measurements, int builtYear);

        public void DeleteBoat(Boat boat);

        public string GetByNumber(int sailNumber);

        public int Count();

    }
}
