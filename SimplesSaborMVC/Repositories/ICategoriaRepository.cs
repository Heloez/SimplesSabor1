using SimplesSaborMVC.Models;
using System.Collections.Generic;

namespace SimplesSaborMVC.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetCategoriasParaHome();
    }
}
