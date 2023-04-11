using Microsoft.AspNetCore.Mvc;

namespace ElearnTemplate.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
