using Microsoft.AspNetCore.Mvc;

namespace CentalWebsiteFrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
