using Microsoft.AspNetCore.Mvc;

namespace ElearnTemplate.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
