using Microsoft.AspNetCore.Identity;
using SimplesSaborMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SimplesSaborMVC.Data;
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Categorias
        List<Categoria> categorias = new()
        {
            new Categoria() {
                Id = 1,
                Nome = "Café da Manhã",
                Foto = "/img/categorias/1.jpg",
                ExibirHome = true
            },
            new Categoria() {
                Id = 2,
                Nome = "Almoço",
                Foto = "/img/categorias/2.jpg"
            },
            new Categoria() {
                Id = 3,
                Nome = "Jantar ",
                Foto = "/img/categorias/3.jpg",
                ExibirHome = true
            },
            new Categoria() {
                Id = 4,
                Nome = "Bebidas",
                Foto = "/img/categorias/1.jpg",
                ExibirHome = true
            },
        };

        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Populate Ingredientes
        List<Ingrediente> ingredientes = new() {
            new Ingrediente() {
                Id = 1,
                Nome = "Ovo"
            },
        };
        builder.Entity<Ingrediente>().HasData(ingredientes);
        #endregion

        #region Populate Receita
        List<Receita> receitas = new() {
            new Receita() {
                Id = 1,
                Nome = "Omelete de Legumes",
                Descricao = "Prato perfeito para um lanche rápido ou mesmo uma refeição picante. Carne moída, pimentões, temperos e muito queijooooo",
                CategoriaId = 1,
                Rendimento = 1,
                Calorias = 282,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\omelete_de_legumes.png",
                Preparo = "Comece pela preparação dos ingredientes, pique os pimentões e a cebola em pequenos cubos, se preferir você também pode usar um processador de alimentos."
                        + "Coloque a carne moída para fritar em uma panela com um pouco de azeite."
                        + "Quando a carne moída já não estiver mais crua, adicione os pimentões e a cebola, mexendo bem para misturar todos os ingredientes."
                        + "Aguarde alguns instante e adicione os temperos, mexendo novamente para misturar."
                        + "Frite por mais alguns minutos a carne com os demais ingredientes."
                        + "Adicione o Cream Cheese e o Queijo Cheddar, mexendo bem para evitar que queime o fundo e ajudar os queijos a derreterem."
                        + "Quando os queijos já estiverem bem derretidos e misturados com os demais ingredientes, sirva acompanhado do Pão Sirio ou de Doritos."
            
            },
        };
        builder.Entity<Receita>().HasData(receitas);
        #endregion

        #region Populate ReceitaIngrediente
        List<ReceitaIngrediente> receitaIngredientes = new() {
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 1, // Ovo
                Quantidade = "2 unidades"
            },
        };
        builder.Entity<ReceitaIngrediente>().HasData(receitaIngredientes);
        #endregion
    }
}