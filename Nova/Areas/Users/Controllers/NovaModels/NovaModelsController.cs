using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nova.Data;
using Nova.Data.Models;
using Nova.Services.Areas.User;
using Nova.Services.Areas.User.Nova;

namespace Nova.Web.Areas.Users.Controllers.NovaModels
{
    [Route("api/[controller]")]
    [ApiController]
    public class NovaModelsController : BaseApiController
    {
        private const string Entity_Name = "product";
        private readonly NovaDbContext db;
        private INovaModelServices novaServices;

        public NovaModelsController(NovaDbContext context, INovaModelServices novaServices)
        {
            this.novaServices = novaServices;
            db = context;
        }

        // GET: api/NovaModels
        [HttpGet]
        public async Task<IActionResult> GetNovaModelsAsync()
        {
            IActionResult result = null;
            try
            {
                var novaModels = await this.novaServices.GetNovaModelsAsync();
                result =  Ok(novaModels);
            }
            catch (Exception ex)
            {
                result = HandleException(ex, "Exception trying to get all " 
                                            + Entity_Name + "s");
            }
            return result;
        }

        // GET: api/NovaModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NovaModel>> GetNovaModelAsync(int id)
        {
            var novaModel = await this.novaServices.GetNovaModelAsync(id);
            return Ok(novaModel);
        }

        

        // POST: api/NovaModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task PostNovaModelAsync(NovaModel novaModel) =>
            await novaServices.CreateAsync(novaModel);

        // DELETE: api/NovaModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNovaModel(int id)
        {
            var novaModel = await db.NovaModels.FindAsync(id);
            if (novaModel == null)
            {
                return NotFound();
            }

            db.NovaModels.Remove(novaModel);
            await db.SaveChangesAsync();

            return NoContent();
        }

        private bool NovaModelExists(int id)
        {
            return db.NovaModels.Any(e => e.Id == id);
        }
    }
}
