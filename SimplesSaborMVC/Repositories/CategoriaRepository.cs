using SimplesSaborMVC.Data;
using SimplesSaborMVC.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SimplesSaborMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> GetCategoriasParaHome()
        {
            return _context.Categorias
                .Where(c => c.ExibirHome)
                .AsNoTracking()
                .ToList();
        }
    }
}
