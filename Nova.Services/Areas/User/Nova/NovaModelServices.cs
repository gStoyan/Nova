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
        private readonly IMapper _mapper;
        public NovaModelServices(NovaDbContext db, IMapper mapper)
        {
            this.db = db;
            _mapper = mapper;
        }

        public async Task<NovaModelListingModel> GetLastNovaModel() => await this.db.NovaModels
            .ProjectTo<NovaModelListingModel>(_mapper.ConfigurationProvider)
            .OrderByDescending(n => n.Id)
            .LastAsync();

        public async Task<ActionResult<IEnumerable<NovaModel>>> GetNovaModelsAsync() =>
            await this.db.NovaModels.ToListAsync();

        public async Task<ActionResult<NovaModel>> GetNovaModelAsync(int id) =>
            await this.db.NovaModels.Where(i => i.Id == id).FirstOrDefaultAsync();
    }
}
