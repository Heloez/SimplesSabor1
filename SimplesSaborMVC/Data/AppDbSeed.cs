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
                Foto = "/img/categorias/1.png",
                ExibirHome = true
            },
            new Categoria() {
                Id = 2,
                Nome = "Almoço",
                Foto = "/img/categorias/2.png",
                ExibirHome = true
            },
            new Categoria() {
                Id = 3,
                Nome = "Jantar ",
                Foto = "/img/categorias/3.png",
                ExibirHome = true
            },
            new Categoria() {
                Id = 4,
                Nome = "Bebidas",
                Foto = "/img/categorias/4.png",
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
                Nome = "Brócolis"
            },
            new Ingrediente() {
                Id = 3,
                Nome = "Sal"
            },
            new Ingrediente() {
                Id = 4,
                Nome = "Queijo "
            },
            new Ingrediente() {
                Id = 5,
                Nome = "Azeite"
            },
            new Ingrediente() {
                Id = 6,
                Nome = "Batata "
            },
            new Ingrediente() {
                Id = 7,
                Nome = "rabanete"
            },
              new Ingrediente() {
                Id = 8,
                Nome = "Tomate "
            },
            new Ingrediente() {
                Id = 9,
                Nome = "Orégano "
            },
 /////////////////////////////////////////////////////////////////////////////////
             new Ingrediente() {
                Id = 10,
                Nome = "Aveia"
            },
            new Ingrediente() {
                Id = 11,
                Nome = "Linhaça "
            },
            new Ingrediente() {
                Id = 12,
                Nome = "Coco em Flocos"
            },
            new Ingrediente() {
                Id = 13,
                Nome = "Açúcar Mascavo "
            },
            new Ingrediente() {
                Id = 14,
                Nome = "Cacau em Pó"
            },
            new Ingrediente() {
                Id = 15,
                Nome = " Leite Desnatado "
            },
            new Ingrediente() {
                Id = 16,
                Nome = "Morangos "
            },
              new Ingrediente() {
                Id = 17,
                Nome = "Amêndoas"
            },
            new Ingrediente() {
                Id = 18,
                Nome = "Cacau "
            },
///////////////////////////////////////////////////////////////////////////////////////////
            new Ingrediente() {
                Id = 19,
                Nome = "Água "
            },
            new Ingrediente() {
                Id = 20,
                Nome = "Espinafre"
            },
            new Ingrediente() {
                Id = 21,
                Nome = "Frutas Vermelhas "
            },
            new Ingrediente() {
                Id = 22,
                Nome = "Iogurte"
            },
              new Ingrediente() {
                Id = 23,
                Nome = "Whey"
            },
            new Ingrediente() {
                Id = 24,
                Nome = " Castanhas"
            },
    ///////////////////////////////////////////////
             new Ingrediente() {
                Id = 25,
                Nome = "Pão "
            },
            new Ingrediente() {
                Id = 26,
                Nome = "Abacate "
            },
            new Ingrediente() {
                Id = 27,
                Nome = "Manteiga"
            },
            new Ingrediente() {
                Id = 28,
                Nome = "Chia "
            },
            new Ingrediente() {
                Id = 29,
                Nome = "Pimenta  "
            },
     ///////////////////////////////////////////////////////////////////////
            new Ingrediente() {
                Id = 30,
                Nome = "Banana"
            },
              new Ingrediente() {
                Id = 31,
                Nome = "Canela "
            },
            new Ingrediente() {
                Id = 32,
                Nome = "Baunilha "
            },     
    ///////////////////////////////////////////////
            new Ingrediente() {
                Id = 33,
                Nome = "Requeijão "
            },
     ///////////////////////////////////////////////////
            new Ingrediente() {
                Id = 34,
                Nome = "Carne"
            },
            new Ingrediente() {
                Id = 35,
                Nome = "Arroz"
            },
            new Ingrediente() {
                Id = 36,
                Nome = "Cebola "
            },
           //////////////////////// 
            new Ingrediente() {
                Id = 37,
                Nome = "Frango"
            },
            new Ingrediente() {
                Id = 38,
                Nome = "Batata Doce"
            },
          ///////////////////////////  
            new Ingrediente() {
                Id = 39,
                Nome = "Salmão"
            },
            new Ingrediente() {
                Id = 40,
                Nome = "Limão"
            },
         /////////////////////////////////  
             new Ingrediente() {
                Id = 41,
                Nome = "macarrão"
            },
            new Ingrediente() {
                Id = 42,
                Nome = "Alho"
            },
            new Ingrediente() {
                Id = 43,
                Nome = "Molho de Tomate"
            },
           ///////////////////////////// 
              new Ingrediente() {
                Id = 44,
                Nome = "Pimentões"
            },
            new Ingrediente() {
                Id = 45,
                Nome = "Cenoura"
            },
            ///////////////////////
            new Ingrediente() {
                Id = 46,
                Nome = "Salada"
            },
            new Ingrediente() {
                Id = 47,
                Nome = "salsinha"
            },
            /////////////////////
            new Ingrediente() {
                Id = 48,
                Nome = "Laranja"
            },
            new Ingrediente() {
                Id = 49,
                Nome = "Mel"
            },
           ///////////////////
           new Ingrediente() {
                Id = 50,
                Nome = "Panqueca"
            },
           ///////////////////////////
           new Ingrediente() {
                Id = 51,
                Nome = "Berinjela"
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
                Foto = "/assets/images/dish/omelete_de_legumes.png",
                Tipo = "Ganho de Massa",
                Preparo = "Comece pela preparação dos ingredientes, pique os pimentões e a cebola em pequenos cubos, se preferir você também pode usar um processador de alimentos."
                        + "Coloque a carne moída para fritar em uma panela com um pouco de azeite."
                        + "Quando a carne moída já não estiver mais crua, adicione os pimentões e a cebola, mexendo bem para misturar todos os ingredientes."
                        + "Aguarde alguns instante e adicione os temperos, mexendo novamente para misturar."
                        + "Frite por mais alguns minutos a carne com os demais ingredientes."
                        + "Adicione o Cream Cheese e o Queijo Cheddar, mexendo bem para evitar que queime o fundo e ajudar os queijos a derreterem."
                        + "Quando os queijos já estiverem bem derretidos e misturados com os demais ingredientes, sirva acompanhado do Pão Sirio ou de Doritos."

            },
             new Receita() {
                Id = 2,
                Nome = "Aveia com Frutas",
                CategoriaId = 1,
                Rendimento = 1,
                Calorias = 127,
                TempoPreparo = "10 minutos",
                Foto = "/assets/images/dish/aveia_com_frutas.png",
                Preparo = "Em uma tigela, misture a aveia, a linhaça, o coco em flocos, o açúcar mascavo, o cacau em pó e o leite."
                    + " Reserve na geladeira de um dia para o outro."
                    + " No momento de servir, coloque uma porção em uma tigela e finalize com os morangos picados, a amêndoa laminada e os nibs de cacau."
            },
             new Receita() {
                Id = 3,
                Nome = "Smoothie de Proteína",
                CategoriaId = 4,
                Rendimento = 1,
                Calorias = 162,
                TempoPreparo = "5 minutos",
                Foto = "/assets/images/dish/smoothie_de_proteina.png",
                Preparo = "Coloque todos os ingredientes no liquidificador e bata até obter uma mistura homogênea."
                    + "Sirva em um copo grande."
        },
            new Receita() {
                Id = 4,
                Nome = "Torrada de Abacate",
                CategoriaId = 1,
                Rendimento = 1,
                Calorias = 310,
                TempoPreparo = "15 minutos",
                Foto = "/assets/images/dish/torrada_de_abacate.png",
               Preparo = "Coloque a manteiga em uma frigideira antiaderente. Quando derreter, quebre os dois ovos, adicione uma pitada de sal e mexa até cozinhar. Reserve."
                    + " Pique metade do avocado e amasse-o em uma tigela pequena. Adicione ½ limão taiti espremido, sal, pimenta e chia (opcional). Misture bem e reserve."
                    + " Coloque as duas fatias de pão 7 grãos na torradeira e toste até ficarem crocantes."
                    + " Para servir, espalhe o avocado no pão torrado e, em seguida, adicione os ovos mexidos. Tempere com pimenta preta e sal a gosto, ajustando conforme seu paladar. Sirva em seguida."
        },
            new Receita() {
                Id = 5,
                Nome = "Panquecas de Banana",
                CategoriaId = 1,
                Rendimento = 1,
                Calorias = 250,
                TempoPreparo = "20 minutos",
                Foto = "/assets/images/dish/panquecas_de_banana.png",
               Preparo = "Amasse as bananas em uma travessa funda."
                    + " Adicione os ovos inteiros e misture bem."
                    + " Acrescente a baunilha, a aveia e a canela (ou o chocolate em pó ou a manteiga de amendoim)."
                    + " Unte uma frigideira com um pouco de óleo e leve ao fogo até aquecer."
                    + " Coloque uma colherada grande (ou uma concha) da massa na frigideira."
                    + " Cozinhe por 2 a 3 minutos."
                    + " Quando a massa começar a soltar bolhinhas, vire e deixe cozinhar por mais 1 a 2 minutos."
                    + " Repita o processo de cozimento para as demais porções."
        },
            new Receita() {
                Id = 6,
                Nome = "Pão com Ovos Mexidos",
                CategoriaId = 1,
                Rendimento = 1,
                Calorias = 210,
                TempoPreparo = "10 minutos",
                Foto = "/assets/images/dish/pao_com_ovos_mexidos.png",
               Preparo = "Em uma tigela, coloque os ovos e bata com um garfo até obter uma mistura homogênea. Reserve."
                    + " Em uma frigideira grande, aqueça a manteiga em fogo alto e adicione o ovo batido."
                    + " Cozinhe, mexendo sem parar, por 3 minutos ou até mudar de consistência e estar totalmente cozido."
                    + " Retire do fogo, acrescente o requeijão e misture bem."
                    + " Disponha sobre as fatias de pão e sirva logo em seguida."
        },
            new Receita() {
                Id = 7,
                Nome = "Carne Bovina com Arroz Integral",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 350,
                TempoPreparo = "30 minutos",
                Foto = "/assets/images/dish/carne_bovina_com_arroz_integral.png",
                Preparo = "Cozinhe o arroz integral conforme as instruções da embalagem."
                    +"Enquanto isso, aqueça o azeite em uma frigideira e refogue a cebola e o alho até ficarem macios."
                    +"Adicione a carne picada e cozinhe até dourar."
                    +"Tempere com sal e pimenta e sirva com o arroz."
        },
            new Receita() {
                Id = 8,
                Nome = "Frango Grelhado com Batata Doce",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 224,
                TempoPreparo = "25 minutos",
                Foto = "/assets/images/dish/frango_grelhado_com_batata_doce.png",
                Preparo = "Tempere o peito de frango com sal, pimenta e ervas finas."
                        +"Grelhe o frango até estar bem cozido."
                        +"Cozinhe a batata doce até ficar macia e depois corte em rodelas."
                        +"Aqueça o azeite em uma frigideira e doure as rodelas de batata doce."
        },
            new Receita() {
                Id = 9,
                Nome = "Salmão Assado",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 200,
                TempoPreparo = "20 minutos",
                Foto = "/assets/images/dish/salmão_assado.png",
                Preparo = "Tempere o salmão com azeite, suco de limão, sal, pimenta e ervas frescas."
                        +"Asse em forno pré-aquecido a 180°C por cerca de 15 minutos ou até o salmão estar completamente cozido."
        },
            new Receita(){
                Id = 10,
                Nome = "Macarrão Integral com Frango Desfiado",
                CategoriaId = 3,
                Rendimento = 2,
                Calorias = 219,
                TempoPreparo = "25 minutos",
                Foto = "/assets/images/dish/macarrao_integral_com_frango_desfiado.png",
                Preparo = "Cozinhe o macarrão integral conforme as instruções da embalagem."
                        +"Em uma panela, aqueça o azeite e refogue a cebola e o alho até ficarem macios. "
                        + "Adicione o frango desfiado e o molho de tomate. Cozinhe por alguns minutos até que tudo esteja bem misturado e aquecido. "
                        + "Misture o macarrão cozido com o frango e decore com salsinha."
        },
            new Receita(){
                Id = 11,
                Nome = "Iscas de Frango com Legumes",
                CategoriaId = 3,
                Rendimento = 2,
                Calorias = 153,
                TempoPreparo = "20 minutos",
                Foto = "/assets/images/dish/iscas_de_frango_com_legumes.png",
                Preparo = "Aqueça o azeite em uma frigideira e refogue as iscas de frango até dourar."
                +"Adicione os pimentões e a cenoura e continue refogando até os legumes estarem macios. "
                + "Tempere com molho de soja, sal e pimenta a gosto."
        },
            new Receita(){
                Id = 12,
                Nome = "Salada",
                CategoriaId = 3,
                Rendimento = 2,
                Calorias = 70,
                TempoPreparo = "10 minutos",
                Foto ="/assets/images/dish/isalada_colorida_de_legumes.png",
                Preparo = "Misture todos os legumes em uma tigela. Em uma pequena tigela separada, combine o azeite, suco de limão, sal e pimenta. "
                        + "Regue a salada com o molho e misture bem. Decore com salsinha antes de servir."
        },
            new Receita(){
                Id = 13,
                Nome = "Frango ao Molho de Laranja",
                CategoriaId = 2,
                Rendimento = 2,
                Calorias = 139,
                TempoPreparo = "20 minutos",
                Foto ="/assets/images/dish/frangoaomolho.png",
                Preparo = "Tempere o frango com sal e pimenta e cozinhe em uma frigideira com um pouco de óleo até que esteja dourado e cozido por completo."
                        +"Em uma panela pequena, misture o suco de laranja, molho de soja, mel e alho."
                        +" Cozinhe em fogo baixo até que o molho reduza e engrosse. "
                        +"Sirva o frango com o molho por cima."
        },
             new Receita(){
                Id = 14,
                Nome = "Panqueca Integral",
                CategoriaId = 2,
                Rendimento = 2,
                Calorias = 45,
                TempoPreparo = "10 minutos",
                Foto ="/assets/images/dish/panquecaintegral.png",
                Preparo = "Misture todos os ingredientes até formar uma massa homogênea."
                        +"Aqueça uma frigideira antiaderente e despeje a massa formando pequenas panquecas."
                        +"Cozinhe por 2-3 minutos de cada lado, ou até que estejam douradas."
        },
            new Receita(){
                Id = 15,
                Nome = "Berinjela no Forno",
                CategoriaId = 2,
                Rendimento = 2,
                Calorias = 60,
                TempoPreparo = "30 minutos",
                Foto ="/assets/images/dish/berinjelanoforno.png",
                Preparo = "Preaqueça o forno a 200°C. Coloque as rodelas de berinjela em uma assadeira e regue com azeite."
                        +"Tempere com orégano, alho em pó, sal e pimenta."
                        +"Asse por 20-25 minutos, virando as rodelas na metade do tempo, até que estejam macias e levemente douradas."
        },

        };
        builder.Entity<Receita>().HasData(receitas);
        #endregion

        #region Populate ReceitaIngrediente
        List<ReceitaIngrediente> receitaIngredientes = new() {
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 1,
                Quantidade = "3 unidades"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 2,
                Quantidade = "5 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 3,
                Quantidade = "a gosto"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 4,
                Quantidade = "1 colher"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 5,
                Quantidade = "a gosto"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 6,
                Quantidade = "1 unidade"
            },
               new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 7,
                Quantidade = "4 unidades"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 8,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 9,
                Quantidade = "a gosto"
            },
 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
               new ReceitaIngrediente() {
                ReceitaId = 2,
                IngredienteId = 10,
                Quantidade = "1 xícara"
            },
            new ReceitaIngrediente() {
                ReceitaId = 2,
                IngredienteId = 11,
                Quantidade = "¼ xícara"
            },
            new ReceitaIngrediente() {
                ReceitaId = 2,
                IngredienteId = 12,
                Quantidade = "2 colheres "
            },
            new ReceitaIngrediente() {
                ReceitaId = 2,
                IngredienteId = 13,
                Quantidade = "1 colher de sopa "
            },
            new ReceitaIngrediente() {
                ReceitaId = 2,
                IngredienteId = 14,
                Quantidade = "2 colheres de chá"
            },
            new ReceitaIngrediente() {
                ReceitaId = 2,
                IngredienteId = 15,
                Quantidade = "1 ¼ xícara "
            },
               new ReceitaIngrediente() {
                ReceitaId = 2,
                IngredienteId = 16,
                Quantidade = "½ xícara "
            },
            new ReceitaIngrediente() {
                ReceitaId = 2,
                IngredienteId = 17,
                Quantidade = "2 colheres de sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 2,
                IngredienteId = 18,
                Quantidade = "1 colher de sopa "
            },
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            new ReceitaIngrediente() {
                ReceitaId = 3,
                IngredienteId = 19,
                Quantidade = "350 ml "
            },
            new ReceitaIngrediente() {
                ReceitaId = 3,
                IngredienteId = 20,
                Quantidade = "1 xícara"
            },
            new ReceitaIngrediente() {
                ReceitaId = 3,
                IngredienteId = 21,
                Quantidade = "2 xícaras "
            },
               new ReceitaIngrediente() {
                ReceitaId = 3,
                IngredienteId = 22,
                Quantidade = "½ xícara "
            },
            new ReceitaIngrediente() {
                ReceitaId = 3,
                IngredienteId = 23,
                Quantidade = "2 doses"
            },
            new ReceitaIngrediente() {
                ReceitaId = 3,
                IngredienteId = 24,
                Quantidade = "1 colher de sopa "
            },
             new ReceitaIngrediente() {
                ReceitaId = 3,
                IngredienteId = 11,
                Quantidade = "1 colher de sopa "
            },
////////////////////////////////////////////////////////////////////////////////////////////////
            new ReceitaIngrediente() {
                ReceitaId = 4,
                IngredienteId = 25,
                Quantidade = "2 fatias "
            },
            new ReceitaIngrediente() {
                ReceitaId = 4,
                IngredienteId = 26,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 4,
                IngredienteId = 27,
                Quantidade = "2 colheres de chá "
            },
               new ReceitaIngrediente() {
                ReceitaId = 4,
                IngredienteId = 1,
                Quantidade = "4 unidades"
            },
            new ReceitaIngrediente() {
                ReceitaId = 4,
                IngredienteId = 29,
                Quantidade = "1 colher de chá"
            },
             new ReceitaIngrediente() {
                ReceitaId = 4,
                IngredienteId = 3,
                Quantidade = "a gosto "
            },
//////////////////////////////////////////////////////////////////////////////////////
              new ReceitaIngrediente() {
                ReceitaId = 5,
                IngredienteId = 30,
                Quantidade = "2 unidades "
            },
               new ReceitaIngrediente() {
                ReceitaId = 5,
                IngredienteId = 10,
                Quantidade = "½ xícara "
            },
            new ReceitaIngrediente() {
                ReceitaId = 5,
                IngredienteId = 31,
                Quantidade = "1 colher de sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 5,
                IngredienteId = 1,
                Quantidade = "2 unidade "
            },
             new ReceitaIngrediente() {
                ReceitaId = 5,
                IngredienteId = 32,
                Quantidade = "1 colher de sopa"
            },
     //////////////////////////////////////////////////////////////       
            new ReceitaIngrediente() {
                ReceitaId = 6,
                IngredienteId = 1,
                Quantidade = "5 unidade "
            },
            new ReceitaIngrediente() {
                ReceitaId = 6,
                IngredienteId = 27,
                Quantidade = "1 colher de sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 6,
                IngredienteId = 33,
                Quantidade = "3 colheres de sopa  "
            },
             new ReceitaIngrediente() {
                ReceitaId = 6,
                IngredienteId = 25,
                Quantidade = "5 fatias "
            },
//////////////////////////////////////////////////////////////////////////////////////
             new ReceitaIngrediente() {
                ReceitaId = 7,
                IngredienteId = 34,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 7,
                IngredienteId = 35,
                Quantidade = "1 xicara"
            },
            new ReceitaIngrediente() {
                ReceitaId = 7,
                IngredienteId = 5,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 7,
                IngredienteId = 36,
                Quantidade = "1 unidade"
            },
         /////////////////////////////////////  
            new ReceitaIngrediente() {
                ReceitaId = 8,
                IngredienteId = 37,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 8,
                IngredienteId = 38,
                Quantidade = "2 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 8,
                IngredienteId = 3,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 8,
                IngredienteId = 29,
                Quantidade = "1 unidade"
            },
         ////////////////////////////////////
            new ReceitaIngrediente() {
                ReceitaId = 9,
                IngredienteId = 38,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 9,
                IngredienteId = 3,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 9,
                IngredienteId = 29,
                Quantidade = "1 unidade"
            },
           ////////////////////////////////////
            new ReceitaIngrediente() {
                ReceitaId = 10,
                IngredienteId = 41,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 10,
                IngredienteId = 37,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 10,
                IngredienteId = 5,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 10,
                IngredienteId = 36,
                Quantidade = "2 unidade"
            },
             new ReceitaIngrediente() {
                ReceitaId = 10,
                IngredienteId = 42,
                Quantidade = "1 unidade"
            },
             new ReceitaIngrediente() {
                ReceitaId = 10,
                IngredienteId = 43,
                Quantidade = "1 unidade"
            },
          /////////////////////////////  
             new ReceitaIngrediente() {
                ReceitaId = 11,
                IngredienteId = 37,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 11,
                IngredienteId = 44,
                Quantidade = "2 unidade"
            },
             new ReceitaIngrediente() {
                ReceitaId = 11,
                IngredienteId = 45,
                Quantidade = "2 unidade"
            },
             new ReceitaIngrediente() {
                ReceitaId = 11,
                IngredienteId = 3,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 11,
                IngredienteId = 29,
                Quantidade = "a gosto"
            },
           /////////////////////////////// 
            new ReceitaIngrediente() {
                ReceitaId = 12,
                IngredienteId = 46,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 12,
                IngredienteId = 5,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 12,
                IngredienteId = 40,
                Quantidade = "2 unidade"
            },
             new ReceitaIngrediente() {
                ReceitaId = 12,
                IngredienteId = 3,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 12,
                IngredienteId = 29,
                Quantidade = "a gosto"
            },
              new ReceitaIngrediente() {
                ReceitaId = 12,
                IngredienteId = 47,
                Quantidade = "a gosto"
            },
        ///////////////////////////////////
            new ReceitaIngrediente() {
                ReceitaId = 13,
                IngredienteId = 48,
                Quantidade = "1 unidade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 13,
                IngredienteId = 37,
                Quantidade = "1 unidade"
            },
             new ReceitaIngrediente() {
                ReceitaId = 13,
                IngredienteId = 3,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 13,
                IngredienteId = 29,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 13,
                IngredienteId = 49,
                Quantidade = "1 colher"
            },
              new ReceitaIngrediente() {
                ReceitaId = 13,
                IngredienteId = 42,
                Quantidade = "2 unidades"
            },
          //////////////////////////////  
              new ReceitaIngrediente() {
                ReceitaId = 14,
                IngredienteId = 50 ,
                Quantidade = "5 unidades"
            },
           ///////////////////////////// 
           new ReceitaIngrediente() {
                ReceitaId = 15,
                IngredienteId = 51,
                Quantidade = "3 unidade"
            },
             new ReceitaIngrediente() {
                ReceitaId = 15,
                IngredienteId = 5,
                Quantidade = "a gosto"
            },
             new ReceitaIngrediente() {
                ReceitaId = 15,
                IngredienteId = 42,
                Quantidade = "1 unidade"
            },
             new ReceitaIngrediente() {
                ReceitaId = 15,
                IngredienteId = 3,
                Quantidade = "a gosto"
            },
              new ReceitaIngrediente() {
                ReceitaId = 15,
                IngredienteId = 29,
                Quantidade = "a gosto"
            }

        };
        builder.Entity<ReceitaIngrediente>().HasData(receitaIngredientes);
        #endregion
    }
}