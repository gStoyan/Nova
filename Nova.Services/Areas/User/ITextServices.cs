using Nova.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nova.Services.Areas.User
{
    public interface ITextServices
    {
        Task<IEnumerable<TextListingModel>> ListAllAsync();
    }
}
