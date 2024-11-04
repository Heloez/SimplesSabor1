using SimplesSaborMVC.Models;
using SimplesSaborMVC.Repositories;
using SimplesSaborMVC.ViewModels;

namespace SimplesSaborMVC.Services
{
    public class HomeService : IHomeService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IReceitaRepository _receitaRepository;

        public HomeService(ICategoriaRepository categoriaRepository, IReceitaRepository receitaRepository)
        {
            _categoriaRepository = categoriaRepository;
            _receitaRepository = receitaRepository;
        }

        public HomeVM GetHomeViewModel()
        {
            return new HomeVM
            {
                Categorias = (List<Categoria>)_categoriaRepository.GetCategoriasParaHome(),
                Receitas = (List<Receita>)_receitaRepository.GetReceitasComCategoriaEIngredientes()
            };
        }

        public Receita GetReceitaPorId(int id)
        {
            return _receitaRepository.GetReceitaPorId(id);
        }
    }
}
