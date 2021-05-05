using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nova.Data;
using Nova.Data.Models;
using Nova.Services.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova.Services.Areas.User.Nova
{
    public class NovaModelServices : INovaModelServices
    {
        private NovaDbContext db;
        private ITextServices textServices;
        public NovaModelServices(NovaDbContext db,ITextServices textServices)
        {
            this.textServices = textServices;
            this.db = db;
        }


        public async Task<ActionResult<IEnumerable<NovaModel>>> GetNovaModelsAsync() =>
            await this.db.NovaModels.Include(n=>n.Texts).ToListAsync();

        public async Task<ActionResult<NovaModel>> GetNovaModelAsync(int id) =>
            await this.db.NovaModels.Where(i => i.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(NovaModel model) {
            var newNova = new NovaModel
            {
                Name = model.Name,
                AttackPoints = model.AttackPoints,
                ArmorPoints = model.ArmorPoints,
                HealthPoints = model.HealthPoints,
                Range = model.Range,
            };
            await this.db.NovaModels.AddAsync(newNova);
            await this.db.SaveChangesAsync();
            var novaId = this.db.NovaModels.Where(n => n.Name == model.Name).First().Id;
            await this.textServices.CreateNewFirstTextAsync(novaId);
        }
    }
}
