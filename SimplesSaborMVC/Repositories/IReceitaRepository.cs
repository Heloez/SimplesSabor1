using SimplesSaborMVC.Models;
using System.Collections.Generic;

namespace SimplesSaborMVC.Repositories
{
    public interface IReceitaRepository
    {
        IEnumerable<Receita> GetReceitasComCategoriaEIngredientes();
        Receita GetReceitaPorId(int id);
    }
}
