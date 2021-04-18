
using Microsoft.AspNetCore.Mvc;
using Nova.Models;
using Nova.Services.Areas.User;
using Nova.Web.Areas.User.Model;
using Nova.Web.Areas.User.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Nova.Web.Areas.User.Controllers.Home
{
    [Area("Users")]
    public class NovaModelController : Controller
    {
        private INovaModelServices novaServices;
        public NovaModelController( INovaModelServices novaServices)
        {
            this.novaServices = novaServices;
        }

        public async Task<IActionResult> List()
        {
            return View(new NovaModelViewModel
            {
                NovaModel = await this.novaServices.GetLastNovaModel()
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
