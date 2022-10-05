using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_OpenIDConnect_DotNet.Models;
using System.Security.Claims;
using Graph = Microsoft.Graph;
using Microsoft.Extensions.Configuration;

namespace WebApp_OpenIDConnect_DotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _Scope = string.Empty;
        public IActionResult Index()
        {
            //var user = HttpContext.User.Identity.Name;
            //var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            //var myValue = config["AzureAdB2C:Scope"];
           
            if (User.Identity.IsAuthenticated)
            {
                return View("Detalle");
            }

            return View();
        }

        [Authorize]
        public IActionResult Detalle()
        {
            return View();
        }

        [Authorize]
        public IActionResult Claims()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }



    }
}