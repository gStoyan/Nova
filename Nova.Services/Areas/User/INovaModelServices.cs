
using Nova.Services.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nova.Services.Areas.User
{
    public interface INovaModelServices
    {
        Task<NovaModelListingModel> GetLastNovaModel();
    }
}
