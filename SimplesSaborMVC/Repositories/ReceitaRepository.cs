using SimplesSaborMVC.Data;
using SimplesSaborMVC.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SimplesSaborMVC.Repositories
{
    public class ReceitaRepository : IReceitaRepository
    {
        private readonly AppDbContext _context;

        public ReceitaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Receita> GetReceitasComCategoriaEIngredientes()
        {
            return _context.Receitas
                .Include(r => r.Categoria)
                .Include(r => r.Ingredientes)
                .AsNoTracking()
                .ToList();
        }

        public Receita GetReceitaPorId(int id)
        {
            return _context.Receitas
                .Include(r => r.Categoria)
                .Include(r => r.Ingredientes)
                .ThenInclude(ir => ir.Ingrediente)
                .AsNoTracking()
                .FirstOrDefault(r => r.Id == id);
        }
    }
}
