using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimplesSaborMVC.Models;
using SimplesSaborMVC.Data; // Importando o contexto do banco de dados
using SimplesSaborMVC.ViewModels; // Importando o modelo de visualização
using Microsoft.EntityFrameworkCore; // Importando para o uso do Include

namespace SimplesSaborMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context; // Adicionando o contexto do banco de dados

        public HomeController(ILogger<HomeController> logger, AppDbContext context) // Adicionando o contexto no construtor
        {
            _logger = logger;
            _context = context; // Inicializando o contexto
        }

        public IActionResult Index()
        {
            // Criando uma instância do HomeVM
            var home = new HomeVM
            {
                Categorias = _context.Categorias
                    .Where(c => c.ExibirHome) // Filtrando categorias que devem ser exibidas
                    .AsNoTracking()
                    .ToList(),
                Receitas = _context.Receitas
                    .Include(r => r.Categoria) // Incluindo categoria relacionada
                    .Include(r => r.Ingredientes) // Incluindo ingredientes relacionados
                    .AsNoTracking()
                    .ToList()
            };

            return View(home); // Passando o modelo para a view
        }

        public IActionResult Receita(int id)
        {
            var receita = _context.Receitas
                .Include(r => r.Categoria)
                .Include(r => r.Ingredientes)
                .ThenInclude(ir => ir.Ingrediente) // Incluindo ingrediente relacionado
                .AsNoTracking()
                .FirstOrDefault(r => r.Id == id); // Buscando receita pelo ID

            if (receita == null)
            {
                return NotFound(); // Retornando 404 se a receita não for encontrada
            }

            return View(receita); // Passando a receita para a view
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