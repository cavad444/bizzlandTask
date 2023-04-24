using Microsoft.AspNetCore.Mvc;

namespace bizzlandTask.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
