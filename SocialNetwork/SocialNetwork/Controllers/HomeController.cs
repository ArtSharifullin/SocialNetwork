using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using SocialNetwork.Models;
using System.Diagnostics;

namespace SocialNetwork.Controllers
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

        public IActionResult Messages() { return View(); }
        public IActionResult Event() { return View(); }
        public IActionResult Groups() { return View(); }
        public IActionResult Pages() { return View(); }
        public IActionResult Market() { return View(); }
        public IActionResult Event2() { return View(); }
        public IActionResult Groups2() { return View(); }
        public IActionResult Settings() { return View(); }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
