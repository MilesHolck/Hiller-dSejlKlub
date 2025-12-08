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

        public void GetAll();

        public void Update(Boat boat);

        public void DeleteBoat(Boat boat);

        public Boat GetByNumber(string sailNumber);

        public int Count();

    }
}
