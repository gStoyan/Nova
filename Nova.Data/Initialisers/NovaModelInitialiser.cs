using Nova.Data.Models;
using System.Linq;

namespace Nova.Data.Initialisers
{
    public class NovaModelInitialiser : IIsInitialiser
    {
        private readonly NovaDbContext db;

        public NovaModelInitialiser(NovaDbContext db)
        {
            this.db = db;
        }
        public void Initialise()
        {
                this.db.NovaModels.Add(new NovaModel
                {
                    ArmorPoints = 5,
                    AttackPoints = 3,
                    HealthPoints = 10,
                    Name = "Stoyan"
                });
                this.db.SaveChanges();
        }
    }
}
