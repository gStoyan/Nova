using Microsoft.AspNetCore.Mvc;
using Nova.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nova.Services.Areas.User
{
    public interface ITextServices
    {
        Task<ActionResult<Text>> GetNovaLastTextAsync(int novaId);
    }
}
