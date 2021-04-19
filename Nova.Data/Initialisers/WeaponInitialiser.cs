using Nova.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.Data.Initialisers
{
    public class WeaponInitialiser : IIsInitialiser
    {
        private readonly NovaDbContext db;

        public WeaponInitialiser(NovaDbContext db)
        {
            this.db = db;
        }
        public void Initialise()
        {
            if(!this.db.Weapons.Any())
            {
                this.db.Weapons.Add(new Weapon
                {
                    NovaModelId = 1,
                    Name = "Scharfschütze AW24P",
                    Description = "Groß Rang und Schaden. Wenn du nur ein Ziel töten muss.",
                    Damage = 10,
                    Armor = 0,
                    Range = 7
                });
                this.db.Weapons.Add(new Weapon
                {
                    NovaModelId = 1,
                    Name = "Schwert Sonnebringer",
                    Description = "Kein Rang, aber große Shaden und hilf dir mit der Verteitigung. " +
                    "Die klassische Methode, um etwas zu töten ist es entzweizuschneiden",
                    Damage = 10,
                    Armor = 0,
                    Range = 7
                });
                this.db.SaveChanges();
            }
        }
    }
}
