using Nova.Data;
using Nova.Data.Models;
using Nova.Services.Model;
using System.Threading.Tasks;

namespace Nova.Services.Areas.User.Units
{
    public class UnitServices : IUnitServices
    {
        private NovaDbContext db = new NovaDbContext();
        public UnitServices(NovaDbContext db)
        {
            this.db = db;   
        }
        public async Task CreateAsync(string name)
        {
            var unit = new Unit
            {
                Name = name
            };
            this.db.Units.Add(unit);
            await this.db.SaveChangesAsync(); 
        }
    }
}
