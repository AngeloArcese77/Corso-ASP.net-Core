using Microsoft.AspNetCore.Mvc;

namespace Corso_ASP.net_Core.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
                return Content("Sono la index della home");
    }

            
    }
}