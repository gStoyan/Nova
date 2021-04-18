
using Microsoft.AspNetCore.Mvc;
using Nova.Data.Models;
using Nova.Services.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nova.Services.Areas.User
{
    public interface INovaModelServices
    {
        Task<NovaModelListingModel> GetLastNovaModel();
        Task<ActionResult<IEnumerable<NovaModel>>> GetNovaModelsAsync();
        Task<ActionResult<NovaModel>> GetNovaModelAsync(int id);
    }
}
