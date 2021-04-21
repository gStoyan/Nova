using Nova.Data.Models;
using System.Linq;

namespace Nova.Data.Initialisers
{
    public class NovaModelsInitialiser : IIsInitialiser
    {
        private readonly NovaDbContext db;

        public NovaModelsInitialiser(NovaDbContext db)
        {
            this.db = db;
        }
        public void Initialise()
        {
            if (!this.db.NovaModels.Any())
            {
                this.db.NovaModels.Add(new NovaModel
                {
                    ArmorPoints = 5,
                    AttackPoints = 3,
                    HealthPoints = 10,
                    Range = 1,
                    Name = "Stoyan"
                });
                this.db.SaveChanges();
            }
        }
    }
}
