using bizzlandTask.DataAccess;
using bizzlandTask.Models;
using bizzlandTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace bizzlandTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;

        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            List<Service> services = _dataContext.Services.ToList();
            List<Team> teams = _dataContext.Teams.ToList();
            HomeViewModel vm = new HomeViewModel
            {
                Services = services,
                Teams = teams
            };

            return View(vm);
        }
    }
}
