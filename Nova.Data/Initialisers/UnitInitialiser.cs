using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.Data.Initialisers
{
    public class UnitInitialiser : IIsInitialiser
    {
        private readonly NovaDbContext db;

        public UnitInitialiser(NovaDbContext db)
        {
            this.db = db;
        }
        public void Initialise()
        {
            if (!this.db.Units.Any())
            {

            }
        }
    }
}
