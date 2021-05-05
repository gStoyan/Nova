
using Nova.Data.Models;
using System.Linq;

namespace Nova.Data.Initialisers
{
    public class OptionsInitialiser: IIsInitialiser
    {
        private int dieErstenMorgenId = 4;
        private readonly NovaDbContext db;
        public OptionsInitialiser(NovaDbContext db)
        {
            this.db = db;
        }

        public void Initialise()
        {
            if (!this.db.Options.Any())
            {
                this.db.Options.Add(new Option
                {
                    Content = "Sag ihm,dass er soll seine Aufträge weiter folgen.",
                    TextId = dieErstenMorgenId
                });
                this.db.Options.Add(new Option
                {
                    Content = "Frag, ob er mit dir kämpfen will.",
                    TextId = dieErstenMorgenId
                });
                this.db.SaveChanges();
            }
        }
    }
}
