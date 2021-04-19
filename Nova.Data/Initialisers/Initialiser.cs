using Nova.Data.Models;
using System;
using System.Linq;
using System.Reflection;

namespace Nova.Data
{
    public  class Initialiser 
    {
        private NovaDbContext db;

        public Initialiser(NovaDbContext db)
        {
            this.db = db;
        }

        public void Initialise()
        {
            foreach (Type mytype in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                .Where(mytype => mytype.GetInterfaces().Contains(typeof(IIsInitialiser)) &&
                                 mytype.Name != "Initialiser"))
            {
                
                var instance = Activator.CreateInstance(mytype, this.db);
                MethodInfo method = mytype.GetMethod("Initialise", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                method.Invoke(instance, null);
            }
        
        //{
           
           
        //    if (!this.db.Weapons.Any())
        //    {
        //        this.db.Add(new Weapon
        //        {
        //            Name = "Sniper AWP",
        //            Description = "Groß Rang und Schaden. Wenn du nur ein Ziel töten muss.",
        //            Damage = 10
        //        });
        //    }
        }
    }
}
