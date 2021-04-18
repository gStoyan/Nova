using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nest;
using Nova.Models;
using Nova.Services.Areas.User;
using Nova.Web.Areas.User.Model;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Nova.Controllers
{
    
    public class HomeController : Controller
    {
 
        public HomeController()
        {
      
        }

        public ActionResult Index()
        {
            return View();
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
