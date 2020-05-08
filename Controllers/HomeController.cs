using Microsoft.AspNetCore.Mvc;

namespace AspNetCore3Webpack4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}