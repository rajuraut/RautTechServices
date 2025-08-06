using Microsoft.AspNetCore.Mvc;

namespace RautTechServices.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
