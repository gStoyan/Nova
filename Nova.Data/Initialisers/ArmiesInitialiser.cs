using Nova.Data.Models;
using System.Linq;

namespace Nova.Data.Initialisers
{
    public class ArmiesInitialiser : IIsInitialiser
    {
        private readonly NovaDbContext db;
        public ArmiesInitialiser(NovaDbContext db)
        {
            this.db = db;
        }

        public void Initialise()
        {
            if (!this.db.Armies.Any())
            {
                this.db.Armies.Add(new Army
                {
                    Name = "First",
                    NovaModelId = 1
                });
            }
            this.db.SaveChanges();
        }
    }
}
