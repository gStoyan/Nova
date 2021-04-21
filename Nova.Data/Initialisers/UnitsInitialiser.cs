using Nova.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.Data.Initialisers
{
    public class UnitsInitialiser : IIsInitialiser
    {
        private int armyAdminId = 6;
        private readonly NovaDbContext db;

        public UnitsInitialiser(NovaDbContext db)
        {
            this.db = db;
        }
        public void Initialise()
        {
            if (!this.db.Units.Any())
            {
                this.db.Units.Add(new Unit
                {
                    ArmyId = armyAdminId,
                    Name = "Marine",
                    AttackPoints = 1,
                    HealthPoints = 20,
                    Description = "Ein Man und ein Gewehr in seine Hände. Was kann schlecht gehen?",
                    Range = 3
                });

            }
        }
    }
}
