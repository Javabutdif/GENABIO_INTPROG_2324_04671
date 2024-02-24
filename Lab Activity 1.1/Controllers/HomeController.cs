using Lab_Activity_1._1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab_Activity_1._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult lol() { 
            return View(); 
        }
        public IActionResult paladins()
        {
            return View();
        }
        public IActionResult left4dead()
        {
            return View();
        }
        public IActionResult solo()
        {
            return View();
        }
        public IActionResult slime()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
