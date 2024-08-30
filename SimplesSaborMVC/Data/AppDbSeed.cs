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
        new Ingrediente() {
            Id = 2,
            Nome = "Legumes Variados (Cenoura, Abobrinha, Pimentão)"
        },
        new Ingrediente() {
            Id = 3,
            Nome = "Azeite de Oliva"
        },
        new Ingrediente() {
            Id = 4,
            Nome = "Sal"
        },
        new Ingrediente() {
            Id = 5,
            Nome = "Pimenta"
        },
        new Ingrediente() {
            Id = 6,
            Nome = "Aveia"
        },
        new Ingrediente() {
            Id = 7,
            Nome = "Leite Desnatado ou Vegetal"
        },
        new Ingrediente() {
            Id = 8,
            Nome = "Mel"
        },
        new Ingrediente() {
            Id = 9,
            Nome = "Frutas Picadas (Morango, Banana, Maçã)"
        },
        new Ingrediente() {
            Id = 10,
            Nome = "Manteiga de Amendoim"
        },
        new Ingrediente() {
            Id = 11,
            Nome = "Proteína em Pó"
        },
        new Ingrediente() {
            Id = 12,
            Nome = "Gelo"
        },
        new Ingrediente() {
            Id = 13,
            Nome = "Pão Integral"
        },
        new Ingrediente() {
            Id = 14,
            Nome = "Abacate"
        },
        new Ingrediente() {
            Id = 15,
            Nome = "Suco de Limão"
        },
        new Ingrediente() {
            Id = 16,
            Nome = "Farinha de Aveia"
        },
        new Ingrediente() {
            Id = 17,
            Nome = "Fermento em Pó"
        },
        new Ingrediente() {
            Id = 18,
            Nome = "Xarope de Bordo"
        },
        new Ingrediente() {
            Id = 19,
            Nome = "Queijo Cottage"
        },
        new Ingrediente() {
            Id = 20,
            Nome = "Morangos"
        },
        new Ingrediente() {
            Id = 21,
            Nome = "Uvas"
        },
        new Ingrediente() {
            Id = 22,
            Nome = "Melão"
        },
        new Ingrediente() {
            Id = 23,
            Nome = "Pão Tipo Wrap"
        },
        new Ingrediente() {
            Id = 24,
            Nome = "Peito de Frango Grelhado"
        },
        new Ingrediente() {
            Id = 25,
            Nome = "Vegetais Variados (Alface, Tomate, Cenoura Ralada)"
        },
        new Ingrediente() {
            Id = 26,
            Nome = "Maionese Light"
        },
        new Ingrediente() {
            Id = 27,
            Nome = "Banana"
        },
        new Ingrediente() {
            Id = 28,
            Nome = "Cacau em Pó"
        }, 
        //10//
        new Ingrediente() {
            Id = 29,
            Nome = "Espinafre"
        },
        new Ingrediente() {
            Id = 30,
            Nome = "Maçã Verde"
        },
        new Ingrediente() {
            Id = 31,
            Nome = "Iogurte Natural"
        },
        new Ingrediente() {
            Id = 32,
            Nome = "Água de Coco"
        },
        new Ingrediente() {
            Id = 33,
            Nome = "Quinoa"
        },
        new Ingrediente() {
            Id = 34,
            Nome = "Abóbora"
        },
        new Ingrediente() {
            Id = 35,
            Nome = "Brócolis"
        },
        new Ingrediente() {
            Id = 36,
            Nome = "Ervas Finas"
        },
        new Ingrediente() {
            Id = 37,
            Nome = "Lentilhas"
        },
        new Ingrediente() {
            Id = 38,
            Nome = "Batata"
        },
        new Ingrediente() {
            Id = 39,
            Nome = "Caldo de Legumes"
        },
        new Ingrediente() {
            Id = 40,
            Nome = "Folha de Louro"
        },
        new Ingrediente() {
            Id = 41,
            Nome = "Pimentão Vermelho"
        },
        new Ingrediente() {
            Id = 42,
            Nome = "Açafrão"
        },
        new Ingrediente() {
            Id = 43,
            Nome = "Grão de Bico Cozido"
        },
        new Ingrediente() {
            Id = 44,
            Nome = "Tomate Cereja"
        },
        new Ingrediente() {
            Id = 45,
            Nome = "Pepino"
        },
        new Ingrediente() {
            Id = 46,
            Nome = "Cebola Roxa"
        },
        new Ingrediente() {
            Id = 47,
            Nome = "Salsinha"
        },
        new Ingrediente() {
            Id = 48,
            Nome = "Cominho"
        },
        new Ingrediente() {
            Id = 49,
            Nome = "Filé de Peixe"
        },
        //20//




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
            }
        };

    

        builder.Entity<Receita>().HasData(receitas);
        #endregion

        #region Populate ReceitaIngrediente
        List<ReceitaIngrediente> receitaIngredientes = new() {
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 1,
                Quantidade = "500g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 3,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 4,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 5,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 6,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 7,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 8,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 9,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 10,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 11,
                Quantidade = "A vontade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 12,
                Quantidade = "200g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 13,
                Quantidade = "200g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 14,
                Quantidade = "Um pouco"
            }
        };
        builder.Entity<ReceitaIngrediente>().HasData(receitaIngredientes);
        #endregion
    }
}