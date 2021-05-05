using Nova.Data.Models;
using System.Linq;

namespace Nova.Data.Initialisers
{
    public class TextsInitialiser : IIsInitialiser
    {
        private const int Nova_Admin_Id = 1;
        private readonly NovaDbContext db;
        public TextsInitialiser(NovaDbContext db)
        {
            this.db = db;
        }
        public void Initialise()
        {
            if (!this.db.Texts.Any())
            {
                this.db.Texts.Add(new Text
                {
                    NovaModelId = Nova_Admin_Id,
                    Title = "Einführung",
                    Content = "> Admiral A.Stukov: \n" +
                    "Guten Nacht, Nova. \n Wir haben schon drei Basen gewonnen. Du hast nur ein Mission und nur ein Nuke. Ich glaube du weßt, was du tun musst. " +
                    "Jetzt wissen wir nicht wo genau die Zerg Basen sind, aber du würdest Hilfe von unseren Armeen bekommen. Melde dich, wenn du das Sektor übergenommen hast.\n" +
                    "Viel Glück, Nova!"
                });
                this.db.Texts.Add(new Text
                {
                    NovaModelId = Nova_Admin_Id,
                    Title = "Helfe",
                    Content = "> S.Grancharov Spiel Master \n" +
                    "Befor jede Mission musst du deine Waffen und dein Mannschaft wehlen. Jetzt gebe ich dir nur einige Optionen, aber später werde es " +
                    "nicht so leicht zu entscheiden."
                });
                this.db.Texts.Add(new Text
                {
                    NovaModelId = Nova_Admin_Id,
                    Title = "Die ersten Morgen",
                    Content = "> 05:01 \n" +
                    "Du bist in der Landungsshiff. Das Land unter das Shiff ist trocken und leer. Zuers sollst du, mit der Situation in dem Sektor kennenlernen.\n" +
                    "Glückligerweise, bist du nicht der einzige Geist.\n" +
                    "Es dauert nicht mehr als 1 Minute um alle wichtige Informationen von seinem Gehirn zu lesen. Er erlaubt dir, weil er weiss" +
                    ",dass du kümmerst dich nur um deine Aufgabe.\n" +
                    "Jetzt wenn du alle Deteilen wisst, musst du entscheiden, ob du alein oder mit ein Mannschaft das Mission auszuführen.",
                    Note = "Bevor man sich entschließt, mit dem Rücken zur Wand zu kämpfen, sollte man sich die Wand genau anschauen. \n" +
                    "\t -KarlHeinz Karius (*1935), Urheber, Mensch und Werbeberater"
                });
                this.db.Texts.Add(new Text
                {
                    NovaModelId = Nova_Admin_Id,
                    Title = "Den Geist mit keiner Name",
                    Content = " \"Meine Aufträge waren diese  Base zu übernehmen. Jetzt kann ich, machen was ich wünsche. " +
                    "\n Und ich wünsche dieses Land mit ein Nuke zerstören. Ich komme mit dir. \"",

                });

                this.db.SaveChanges();
            }
        }
    }
}
