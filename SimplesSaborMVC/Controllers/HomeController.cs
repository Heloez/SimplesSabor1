using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimplesSaborMVC.Models;
using SimplesSaborMVC.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace SimplesSaborMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context; 

        public HomeController(ILogger<HomeController> logger, AppDbContext context) 
        {
            _logger = logger;
            _context = context; 
        }

        public IActionResult Index()
        {
        
            var home = new HomeVM
            {
                Categorias = _context.Categorias
                    .Where(c => c.ExibirHome) 
                    .AsNoTracking()
                    .ToList(),
                Receitas = _context.Receitas
                    .Include(r => r.Categoria) 
                    .Include(r => r.Ingredientes) 
                    .AsNoTracking()
                    .ToList()
            };

            return View(home); 
        }

        public IActionResult Receita(int id)
        {
            var receita = _context.Receitas
                .Include(r => r.Categoria)
                .Include(r => r.Ingredientes)
                .ThenInclude(ir => ir.Ingrediente) 
                .AsNoTracking()
                .FirstOrDefault(r => r.Id == id); 

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