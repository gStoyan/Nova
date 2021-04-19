using Nova.Data.Models;
using System;
using System.Linq;
using System.Reflection;

namespace Nova.Data
{
    public class Initialiser
    {
        private NovaDbContext db;

        public Initialiser(NovaDbContext db)
        {
            this.db = db;
        }

        public void Initialise()
        {
            if (CheckDbTables(this.db) == true)
            {
                return;
            }
            foreach (Type mytype in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                .Where(mytype => mytype.GetInterfaces().Contains(typeof(IIsInitialiser)) &&
                                 mytype.Name != "Initialiser"))
            {

                var instance = Activator.CreateInstance(mytype, this.db);
                MethodInfo method = mytype.GetMethod("Initialise", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                method.Invoke(instance, null);
            }
        }
        public static bool CheckDbTables(NovaDbContext db) =>
            db.NovaModels.Any() && db.Texts.Any() && db.Units.Any() && db.Weapons.Any();
    }
}
