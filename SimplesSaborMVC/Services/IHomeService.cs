using SimplesSaborMVC.Models;
using SimplesSaborMVC.ViewModels;
using System.Collections.Generic;

namespace SimplesSaborMVC.Services
{
    public interface IHomeService
    {
        HomeVM GetHomeViewModel();
        Receita GetReceitaPorId(int id);
    }
}
