using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimplesSaborMVC.Models;
using SimplesSaborMVC.Services;
using SimplesSaborMVC.ViewModels;

namespace SimplesSaborMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeService _homeService;

        public HomeController(ILogger<HomeController> logger, IHomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            var home = _homeService.GetHomeViewModel();
            return View(home);
        }

        public IActionResult Receita(int id)
        {
            var receita = _homeService.GetReceitaPorId(id);
            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }

        public IActionResult Privacy()
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
