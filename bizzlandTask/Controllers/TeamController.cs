using Microsoft.AspNetCore.Mvc;

namespace bizzlandTask.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
