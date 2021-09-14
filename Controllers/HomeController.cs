using C1Control.Models;
using Microsoft.AspNetCore.Mvc;

namespace C1Control.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Country.GetData(10));
        }
    }
}
