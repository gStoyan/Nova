
using Nova.Data.Models;
using System.Linq;

namespace Nova.Data.Initialisers
{
    public class OptionsInitialiser: IIsInitialiser
    {
        private NovaDbContext db;
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
                    Content = "Frag was ist sein Name.",
                    TextId = this.db.Texts.Where(t => t.Title == "Die ersten Morgen").FirstOrDefault().Id
                });
                this.db.Options.Add(new Option
                {
                    Content = "Frag, ob er mit dir kämpfen will.",
                    TextId = this.db.Texts.Where(t => t.Title == "Die ersten Morgen").FirstOrDefault().Id
                });
                this.db.SaveChanges();
            }
        }
    }
}
