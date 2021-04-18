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
    public class NovaModelsController : ControllerBase
    {
        private readonly NovaDbContext db;
        private INovaModelServices novaServices;

        public NovaModelsController(NovaDbContext context, INovaModelServices novaServices)
        {
            this.novaServices = novaServices;
            db = context;
        }

        // GET: api/NovaModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NovaModel>>> GetNovaModelsAsync()
        {
            var novaModels = await this.novaServices.GetNovaModelsAsync();
            return Ok(novaModels);
        }

        // GET: api/NovaModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NovaModel>> GetNovaModelAsync(int id)
        {
            var novaModel = await this.novaServices.GetNovaModelAsync(id);

            return Ok(novaModel);
        }

        // PUT: api/NovaModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNovaModel(int id, NovaModel novaModel)
        {
            if (id != novaModel.Id)
            {
                return BadRequest();
            }

            db.Entry(novaModel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NovaModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/NovaModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NovaModel>> PostNovaModel(NovaModel novaModel)
        {
            db.NovaModels.Add(novaModel);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetNovaModel", new { id = novaModel.Id }, novaModel);
        }

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
