using SimplesSaborMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
                Imagem: "\\img\\receitas\\omelete_de_legumes.png"
                ExibirHome = true
            },
            new Categoria() {
                Id = 2,
                Nome = "Amoço",
                Foto = "/img/categorias/2.jpg"
            },
            new Categoria() {
                Id = 3,
                Nome = "Jantar",
                Foto = "/img/categorias/3.jpg",
                ExibirHome = true
            },
            // Outras categorias...
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Populate Tipo
        List<Tipo> tipos = new()
        {
            new Tipo() {
                Id = 1,
                Nome = "Ganho de Massa"
            },
                new Tipo() {
                Id = 2,
                Nome = "Emagrecimento"
            },
            // Outros tipos...
        };
        builder.Entity<Tipo>().HasData(tipos);
        #endregion

        #region Populate Ingredientes
        List<Ingrediente> ingredientes = new()
        {
            new Ingrediente() { Id = 1, Nome = "Ovos" },
            new Ingrediente() { Id = 2, Nome = "Legumes Variados" },
            new Ingrediente() { Id = 3, Nome = "Azeite de Oliva" },
            new Ingrediente() { Id = 4, Nome = "Sal" },
            new Ingrediente() { Id = 5, Nome = "Pimenta" },
            new Ingrediente() { Id = 6, Nome = "Aveia" },
            new Ingrediente() { Id = 7, Nome = "Leite Desnatado" },
            new Ingrediente() { Id = 8, Nome = "Mel" },
            new Ingrediente() { Id = 9, Nome = "Frutas Picadas" },
            new Ingrediente() { Id = 10, Nome = "Banana" },
            new Ingrediente() { Id = 11, Nome = "Manteiga de Amendoim" },
            new Ingrediente() { Id = 12, Nome = "Proteína em Pó" },
            new Ingrediente() { Id = 13, Nome = "Gelo" },
            new Ingrediente() { Id = 14, Nome = "Pão Integral" },
            new Ingrediente() { Id = 15, Nome = "Abacate" },
            new Ingrediente() { Id = 16, Nome = "Fermento em Pó" },
            new Ingrediente() { Id = 17, Nome = "Mel ou Xarope de Bordo" },
            new Ingrediente() { Id = 18, Nome = "Farinha de Aveia" },
            new Ingrediente() { Id = 19, Nome = "Queijo Cottage" },
            new Ingrediente() { Id = 20, Nome = "Pão Tipo Wrap" },
            new Ingrediente() { Id = 21, Nome = "Peito de Frango" },
            new Ingrediente() { Id = 22, Nome = "Vegetais Variados" },
            new Ingrediente() { Id = 23, Nome = "Maionese Light" },
            new Ingrediente() { Id = 24, Nome = "Cacau em Pó" },
            new Ingrediente() { Id = 25, Nome = "Morangos" },
            new Ingrediente() { Id = 26, Nome = "Uvas" },
            new Ingrediente() { Id = 27, Nome = "Melão" }
        };
        builder.Entity<Ingrediente>().HasData(ingredientes);

        // Receitas
        List<Receita> receitas = new()
        {
            new Receita() {
                Id = 1,
                Nome = "Omelete de Legumes",
                Descricao = "Omelete saudável e nutritiva, ideal para o café da manhã.",
                CategoriaId = 1,
                TipoId = 1,
                Calorias= 282,
                TempoPreparo = "15 minutos",
                Foto = "/img/receitas/omelete_de_legumes.png",
                Preparo = "Bata os ovos em uma tigela, adicione os legumes picados, tempere com sal e pimenta. Aqueça o azeite em uma frigideira, despeje a mistura e cozinhe em fogo médio até dourar dos dois lados."
            },
            new Receita() {
                Id = 2,
                Nome = "Aveia com Frutas",
                Descricao = "Café da manhã rápido e nutritivo.",
                CategoriaId = 1,
                TipoId = 1,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 1,
                TempoPreparo = "10 minutos",
                Foto = "/img/receitas/aveia_com_frutas.png",
                Preparo = "Em uma tigela, misture a aveia com o leite e o mel. Deixe descansar por alguns minutos para a aveia absorver o líquido. Adicione as frutas picadas por cima e sirva."
            },
            new Receita() {
                Id = 3,
                Nome = "Smoothie de Proteína",
                Descricao = "Smoothie rápido e energético.",
                CategoriaId = 1,
                TipoId = 1,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 1,
                TempoPreparo = "5 minutos",
                Foto = "/img/receitas/smoothie_de_proteina.png",
                Preparo = "Coloque todos os ingredientes no liquidificador e bata até obter uma mistura homogênea. Sirva em um copo grande."
            },
            new Receita() {
                Id = 4,
                Nome = "Torrada de Abacate",
                Descricao = "Torrada nutritiva e saborosa.",
                CategoriaId = 1,
                TipoId = 1,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 2,
                TempoPreparo = "15 minutos",
                Foto = "/img/receitas/torrada_de_abacate.png",
                Preparo = "Torre as fatias de pão. Amasse o abacate com sal, pimenta e suco de limão. Cozinhe os ovos como desejar (mexido ou pochê) e coloque sobre as torradas com abacate."
            },
            new Receita() {
                Id = 5,
                Nome = "Panquecas de Banana",
                Descricao = "Panquecas saudáveis e deliciosas.",
                CategoriaId = 1,
                TipoId = 1,
                Dificuldade = Dificuldade.Médio,
                Rendimento = 2,
                TempoPreparo = "20 minutos",
                Foto = "/img/receitas/panquecas_de_banana.png",
                Preparo = "Amasse a banana e misture com os ovos. Adicione a aveia e o fermento. Cozinhe em uma frigideira quente até dourar dos dois lados. Sirva com mel ou xarope."
            },
            new Receita() {
                Id = 6,
                Nome = "Pão com Ovos Mexidos",
                Descricao = "Prato simples e rápido para o café da manhã.",
                CategoriaId = 1,
                TipoId = 1,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 2,
                TempoPreparo = "10 minutos",
                Foto = "/img/receitas/pao_com_ovos_mexidos.png",
                Preparo = "Aqueça a manteiga em uma frigideira, adicione os ovos e mexa até cozinhar. Tempere com sal e pimenta e sirva sobre as fatias de pão torrado."
            },
            new Receita() {
                Id = 7,
                Nome = "Muffin de Banana",
                Descricao = "Muffin saudável e delicioso para um lanche.",
                CategoriaId = 1,
                TipoId = 1,
                Dificuldade = Dificuldade.Médio,
                Rendimento = 6,
                TempoPreparo = "30 minutos",
                Foto = "/img/receitas/muffin_de_banana.png",
                Preparo = "Amasse a banana e misture com o ovo, a farinha de aveia e o fermento. Divida a massa em forminhas de muffin e asse a 180°C por 15-20 minutos."
            },
            new Receita() {
                Id = 8,
                Nome = "Batido de Proteína de Chocolate",
                Descricao = "Batido saboroso e nutritivo.",
                CategoriaId = 1,
                TipoId = 1,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 1,
                TempoPreparo = "5 minutos",
                Foto = "/img/receitas/batido_de_proteina_de_chocolate.png",
                Preparo = "Bata todos os ingredientes no liquidificador até obter uma textura cremosa. Sirva imediatamente."
            },
            new Receita() {
                Id = 9,
                Nome = "Salada de Frutas",
                Descricao = "Salada fresca e nutritiva.",
                CategoriaId = 1,
                TipoId = 1,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 1,
                TempoPreparo = "10 minutos",
                Foto = "/img/receitas/salada_de_frutas.png",
                Preparo = "Misture todas as frutas em uma tigela e adicione o queijo cottage por cima. Sirva gelado."
            },
            new Receita() {
                Id = 10,
                Nome = "Wrap de Frango",
                Descricao = "Wrap prático e saudável.",
                CategoriaId = 1,
                TipoId = 1,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 1,
                TempoPreparo = "15 minutos",
                Foto = "/img/receitas/wrap_de_frango.png",
                Preparo = "Aqueça o pão wrap, coloque o frango grelhado e os vegetais. Adicione a maionese e enrole o wrap. Corte ao meio e sirva."
            }
        };
        builder.Entity<Receita>().HasData(receitas);

        // ReceitaIngrediente
        List<ReceitaIngrediente> receitaIngredientes = new()
        {
            // Omelete de Legumes
            new ReceitaIngrediente() { ReceitaId = 1, IngredienteId = 1, Quantidade = "2 unidades" },
            new ReceitaIngrediente() { ReceitaId = 1, IngredienteId = 2, Quantidade = "1/2 xícara" },
            new ReceitaIngrediente() { ReceitaId = 1, IngredienteId = 3, Quantidade = "1 colher de sopa" },
            new ReceitaIngrediente() { ReceitaId = 1, IngredienteId = 4, Quantidade = "A gosto" },
            new ReceitaIngrediente() { ReceitaId = 1, IngredienteId = 5, Quantidade = "A gosto" },

            // Aveia com Frutas
            new ReceitaIngrediente() { ReceitaId = 2, IngredienteId = 6, Quantidade = "1/2 xícara" },
            new ReceitaIngrediente() { ReceitaId = 2, IngredienteId = 7, Quantidade = "1 xícara" },
            new ReceitaIngrediente() { ReceitaId = 2, IngredienteId = 8, Quantidade = "1 colher de chá" },
            new ReceitaIngrediente() { ReceitaId = 2, IngredienteId = 9, Quantidade = "1/2 xícara" },

            // Smoothie de Proteína
            new ReceitaIngrediente() { ReceitaId = 3, IngredienteId = 10, Quantidade = "1 unidade" },
            new ReceitaIngrediente() { ReceitaId = 3, IngredienteId = 11, Quantidade = "1 colher de sopa" },
            new ReceitaIngrediente() { ReceitaId = 3, IngredienteId = 8, Quantidade = "1 colher de chá" },
            new ReceitaIngrediente() { ReceitaId = 3, IngredienteId = 12, Quantidade = "1 scoop" },
            new ReceitaIngrediente() { ReceitaId = 3, IngredienteId = 7, Quantidade = "1 xícara" },
            new ReceitaIngrediente() { ReceitaId = 3, IngredienteId = 13, Quantidade = "A gosto" },

            // Torrada de Abacate
            new ReceitaIngrediente() { ReceitaId = 4, IngredienteId = 14, Quantidade = "2 fatias" },
            new ReceitaIngrediente() { ReceitaId = 4, IngredienteId = 15, Quantidade = "1 unidade" },
            new ReceitaIngrediente() { ReceitaId = 4, IngredienteId = 1, Quantidade = "2 unidades" },
            new ReceitaIngrediente() { ReceitaId = 4, IngredienteId = 4, Quantidade = "A gosto" },
            new ReceitaIngrediente() { ReceitaId = 4, IngredienteId = 5, Quantidade = "A gosto" },
            new ReceitaIngrediente() { ReceitaId = 4, IngredienteId = 4, Quantidade = "A gosto" },

            // Panquecas de Banana
            new ReceitaIngrediente() { ReceitaId = 5, IngredienteId = 10, Quantidade = "1 unidade" },
            new ReceitaIngrediente() { ReceitaId = 5, IngredienteId = 1, Quantidade = "2 unidades" },
            new ReceitaIngrediente() { ReceitaId = 5, IngredienteId = 6, Quantidade = "1/2 xícara" },
            new ReceitaIngrediente() { ReceitaId = 5, IngredienteId = 16, Quantidade = "1 colher de chá" },
            new ReceitaIngrediente() { ReceitaId = 5, IngredienteId = 17, Quantidade = "A gosto" },

            // Pão com Ovos Mexidos
            new ReceitaIngrediente() { ReceitaId = 6, IngredienteId = 14, Quantidade = "2 fatias" },
            new ReceitaIngrediente() { ReceitaId = 6, IngredienteId = 1, Quantidade = "2 unidades" },
            new ReceitaIngrediente() { ReceitaId = 6, IngredienteId = 11, Quantidade = "1 colher de sopa" },
            new ReceitaIngrediente() { ReceitaId = 6, IngredienteId = 4, Quantidade = "A gosto" },
            new ReceitaIngrediente() { ReceitaId = 6, IngredienteId = 5, Quantidade = "A gosto" },

            // Muffin de Banana
            new ReceitaIngrediente() { ReceitaId = 7, IngredienteId = 10, Quantidade = "1 unidade" },
            new ReceitaIngrediente() { ReceitaId = 7, IngredienteId = 1, Quantidade = "1 unidade" },
            new ReceitaIngrediente() { ReceitaId = 7, IngredienteId = 18, Quantidade = "1/2 xícara" },
            new ReceitaIngrediente() { ReceitaId = 7, IngredienteId = 16, Quantidade = "1 colher de chá" },
            new ReceitaIngrediente() { ReceitaId = 7, IngredienteId = 17, Quantidade = "A gosto" },

            // Batido de Proteína de Chocolate
            new ReceitaIngrediente() { ReceitaId = 8, IngredienteId = 12, Quantidade = "1 scoop" },
            new ReceitaIngrediente() { ReceitaId = 8, IngredienteId = 7, Quantidade = "1 xícara" },
            new ReceitaIngrediente() { ReceitaId = 8, IngredienteId = 24, Quantidade = "1 colher de chá" },
            new ReceitaIngrediente() { ReceitaId = 8, IngredienteId = 13, Quantidade = "A gosto" },

            // Salada de Frutas
            new ReceitaIngrediente() { ReceitaId = 9, IngredienteId = 25, Quantidade = "1/2 xícara" },
            new ReceitaIngrediente() { ReceitaId = 9, IngredienteId = 26, Quantidade = "1/2 xícara" },
            new ReceitaIngrediente() { ReceitaId = 9, IngredienteId = 27, Quantidade = "1/2 xícara" },
            new ReceitaIngrediente() { ReceitaId = 9, IngredienteId = 19, Quantidade = "2 colheres de sopa" },

            // Wrap de Frango
            new ReceitaIngrediente() { ReceitaId = 10, IngredienteId = 20, Quantidade = "1 unidade" },
            new ReceitaIngrediente() { ReceitaId = 10, IngredienteId = 21, Quantidade = "100g" },
            new ReceitaIngrediente() { ReceitaId = 10, IngredienteId = 22, Quantidade = "1/2 xícara" },
            new ReceitaIngrediente() { ReceitaId = 10, IngredienteId = 23, Quantidade = "1 colher de sopa" }
        };
        builder.Entity<ReceitaIngrediente>().HasData(receitaIngredientes);
    }
}