using AutoMapper.QueryableExtensions;
using Nova.Data;
using Nova.Services.Models;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Nova.Services.Areas.User.Text
{
    public class TextServices : ITextServices
    {
        private NovaDbContext db;
        private readonly IMapper _mapper;
        public TextServices(NovaDbContext db, IMapper mapper)
        {
            this.db = db;
            _mapper = mapper;
        }



        public async Task<IEnumerable<TextListingModel>> ListAllAsync() => await this.db.Texts
            .ProjectTo<TextListingModel>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}
