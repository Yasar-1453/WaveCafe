using Microsoft.AspNetCore.Mvc;

namespace WaveCafe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
