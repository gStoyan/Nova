using AutoMapper.QueryableExtensions;
using Nova.Data;
using Nova.Services.Models;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Nova.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Nova.Services.Areas.User.Texts
{
    public class TextServices : ITextServices
    {
        private NovaDbContext db;
        public TextServices(NovaDbContext db)
        {
            this.db = db;
        }



        public async Task<ActionResult<Text>> GetNovaLastTextAsync(int novaId) =>
            await this.db.Texts.Where(t => t.NovaModelId == novaId).FirstOrDefaultAsync();
    }
}
