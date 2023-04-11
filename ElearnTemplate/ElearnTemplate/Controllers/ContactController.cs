using Microsoft.AspNetCore.Mvc;

namespace ElearnTemplate.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
