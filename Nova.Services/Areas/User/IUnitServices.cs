

using System.Threading.Tasks;

namespace Nova.Services.Areas.User
{
    public interface IUnitServices
    {
        Task CreateAsync(string name);
    }
}
