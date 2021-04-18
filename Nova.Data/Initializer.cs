using Nova.Data.Models;
using System.Linq;

namespace Nova.Data
{
    public  class Initializer
    {
        private NovaDbContext db;

        public Initializer(NovaDbContext db)
        {
            this.db = db;
        }
        public  void InitializeTexts()
        {
            if (!this.db.NovaModels.Any())
            {
                this.db.NovaModels.Add(new NovaModel
                {
                    ArmorPoints = 5,
                    AttackPoints = 3,
                    HealethPoints = 10,
                    Name = "Stoyan"
                });
                this.db.SaveChanges();
            }
            if (!this.db.Texts.Any())
            {
                this.db.Texts.Add(new Text
                {
                    Title = "Einführung",
                    Content = "> Admiral A.Stukov: \n" +
                    "Guten Nacht, Nova. \n Wir haben schon drei Basen gewonnen. Du hast nur ein Mission und nur ein Nuke. Ich glaube du weßt, was du tun musst. " +
                    "Jetzt wissen wir nicht wo die Zerg Basen sind, daswegen bist du für die Job gewählt. Melde dich, wenn du das Sektor übergenommen hat.\n" +
                    "Viel Glück, Nova!"
                });
                this.db.Texts.Add(new Text
                {
                    Title = "Helfe",
                    Content = "> S.Grancharov Spiel Master \n" +
                    "Befor jede Mission musst du deine Waffen und dein Mannschaft wehlen. Jetzt gebe ich dir nur einige Optionen, aber später werde es " +
                    "nicht so leicht zu entscheiden."
                });
                this.db.Texts.Add(new Text
                {
                    Title = "Erster Morgen",
                    Content = "> 05:01 \n" +
                    "Du bist in der Landungsshiff. Das Land unter das Shiff ist trocken und leer. Zuers sollst du, mit der Situation in dem Sektor kennenlernen.\n" +
                    "Glückligerweise, bist du nicht der einzige Geist.\n" +
                    "Es dauert nicht mehr als 1 Minute um alle wichtige Informationen von seinem Gehirn zu lesen. Er erlaubt dir, weil er weiss" +
                    ",dass du kümmerst dich nur um deine Aufgabe.\n" +
                    "Jetzt wenn du alle Deteilen wisst, musst du entscheiden, ob du alein oder mit ein Mannschaft das Mission auszuführen."
                });
                this.db.SaveChanges();
            }
            if (!this.db.Weapons.Any())
            {
                this.db.Add(new Weapon
                {
                    Name = "Sniper AWP",
                    Description = "Groß Rang und Schaden. Wenn du nur ein Ziel töten muss.",
                    Damage = 10
                });
            }
        }
    }
}
