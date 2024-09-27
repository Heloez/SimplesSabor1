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
        new Ingrediente() {
            Id = 2,
            Nome = "cenoura"
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
            Nome = "Frutas"
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
            Nome = "Alface"
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
            Nome = "Carne moída"
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
        new Ingrediente() {
            Id = 50,
            Nome = "Lombo de porco"
        },
        new Ingrediente() {
            Id = 51,
            Nome = "Cebola"
        },
        new Ingrediente() {
            Id = 52,
            Nome = "Alho picado"
        },
        new Ingrediente() {
            Id = 53,
            Nome = "Batata doce"
        },
        new Ingrediente() {
            Id = 57,
            Nome = "Tomilho seco"
        },
        new Ingrediente() {
        Id = 58,
        Nome = "Peito de frango"
        },
        new Ingrediente() {
            Id = 59,
            Nome = "Quinoa"
        },
        new Ingrediente() {
            Id = 60,
            Nome = "Água"
        },
        new Ingrediente() {
            Id = 61,
            Nome = "Abóbrinha"
        },
        new Ingrediente() {
            Id = 62,
            Nome = "Pimentão verde"
        },
        new Ingrediente() {
            Id = 63,
            Nome = "Suco de limão"
        },
        new Ingrediente() {
            Id = 64,
            Nome = "Carne de boi (patinho ou coxão mole), cortada em cubos"
        },
        new Ingrediente() {
            Id = 65,
            Nome = "molho de soja"
        },
        new Ingrediente() {
            Id = 66,
            Nome = "Folha de alface"
        },
        new Ingrediente() {
            Id = 67,
            Nome = "Berinjela"
        },
        new Ingrediente() {
            Id = 68,
            Nome = "Vinho tinto"
        },
        new Ingrediente() {
            Id = 69,
            Nome = "Tomate pelado"
        },
        new Ingrediente() {
            Id = 70,
            Nome = "Caldo de carne"
        },
        new Ingrediente() {
            Id = 71,
            Nome = "Azeite de oliva"
        },
        new Ingrediente() {
            Id = 72,
            Nome = "Folha de louro"
        },
        new Ingrediente() {
            Id = 73,
            Nome = "Filé de salmão"
        },
        new Ingrediente() {
            Id = 74,
            Nome = "Suco de laranja"
        },
        new Ingrediente() {
            Id = 75,
            Nome = "Mel"
        },
        new Ingrediente() {
            Id = 76,
            Nome = "Gengibre fresco ralado"
        },
        new Ingrediente() {
            Id = 77,
            Nome = "Amido de milho"
        },
        new Ingrediente() {
            Id = 78,
            Nome = "Leite"
        },
        new Ingrediente() {
            Id = 79,
            Nome = "Manteiga"
        },
        new Ingrediente() {
            Id = 80,
            Nome = "Macarrão integral"
        },
        new Ingrediente() {
            Id = 81,
            Nome = "Molho de tomate"
        },
        new Ingrediente() {
            Id = 82,
            Nome = "Queijo parmesão"
        },
        new Ingrediente() {
            Id = 83,
            Nome = "Arroz integral"
        },
        new Ingrediente() {
            Id = 84,
            Nome = "Leite de amêndoas"
        },
        new Ingrediente() {
            Id = 85,
            Nome = "Papaia pequena"
        },
        new Ingrediente() {
            Id = 86,
            Nome = "Granola"
        },
        new Ingrediente() {
            Id = 87,
            Nome = "Canela em pó"
        },
        new Ingrediente() {
            Id = 88,
            Nome = "Maçã"
        },
        new Ingrediente() {
            Id = 89,
            Nome = "massa de torta integral"
        },
         new Ingrediente() {
            Id = 90,
            Nome = "tomate"
        },
        new Ingrediente() {
            Id = 91,
            Nome = "mostarda"
        },
        new Ingrediente() {
            Id = 92,
            Nome = "wrap integral"
        },
        new Ingrediente() {
            Id = 93,
            Nome = "coentro"
        },
         new Ingrediente() {
            Id = 94,
            Nome = "polvilho doce"
        },
        new Ingrediente() {
            Id = 95,
            Nome = "páprica"
        },
        new Ingrediente() {
            Id = 96,
            Nome = "pimenta dedo de moça"
        },
        new Ingrediente() {
            Id = 97,
            Nome = "Peru"
        },
         new Ingrediente() {
            Id = 98,
            Nome = "farinha integral"
        },
        new Ingrediente() {
            Id = 99,
            Nome = "óregano"
        },
        new Ingrediente() {
            Id = 100,
            Nome = "alho em pó"
        },
        new Ingrediente() {
            Id = 101,
            Nome = "purê de abóbora"
        },
        new Ingrediente() {
            Id = 102,
            Nome = "gengibre"
        },
         new Ingrediente() {
            Id = 103,
            Nome = "caldo de frango"
        },
         new Ingrediente() {
            Id = 104,
            Nome = "macarrão de arroz cozido"
        },
        new Ingrediente() {
            Id = 105,
            Nome = "atum"
        },
        new Ingrediente() {
            Id = 106,
            Nome = "azeitonas pretas "
        },
        new Ingrediente() {
            Id = 107,
            Nome = "vinagre balsâmico"
        },
         new Ingrediente() {
            Id = 108,
            Nome = "hortelã"
        },
        new Ingrediente() {
            Id = 109,
            Nome = "ervilha"
        },
        new Ingrediente() {
            Id = 110,
            Nome = "milho"
        },
         new Ingrediente() {
            Id = 111,
            Nome = "lasanha integral"
        },
        new Ingrediente() {
            Id = 112,
            Nome = "farinha de trigo"
        }
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
           new Receita() {
                Id = 2,
                Nome = "Aveia com Frutas",
                Descricao = "Uma opção saudável e nutritiva para começar o dia.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 127,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\aveia_com_frutas.png",
                Preparo = "Em uma tigela, misture a aveia com o leite e o mel."
                        + "Deixe descansar por alguns minutos para a aveia absorver o líquido."
                        + "Adicione as frutas picadas por cima e sirva."
        },

            new Receita() {
                Id = 3,
                Nome = "Smoothie de Proteína",
                Descricao = "Uma bebida energética perfeita para o ganho de massa.",
                CategoriaId = 4, 
                Rendimento = 1,
                Calorias = 162,
                TempoPreparo = "5 minutos",
                Foto = "\\img\\receitas\\smoothie_de_proteina.png",
                Preparo = "Coloque todos os ingredientes no liquidificador e bata até obter uma mistura homogênea."
                        + "Sirva em um copo grande."
        },
           new Receita() {
                Id = 4,
                Nome = "Torrada de Abacate",
                Descricao = "Uma torrada saudável e nutritiva para ganho de massa.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 310,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\torrada_de_abacate.png",
                Preparo = "Torre as fatias de pão."
                        +" Amasse o abacate com sal, pimenta e suco de limão."
                        +"Cozinhe os ovos como desejar (mexido ou pochê) e coloque sobre as torradas com abacate."
        },
            new Receita() {
                Id = 5,
                Nome = "Panquecas de Banana",
                Descricao = "Deliciosas panquecas saudáveis para ganho de massa.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 250,
                TempoPreparo = "20 minutos",
                Foto = "\\img\\receitas\\panquecas_de_banana.png",
                Preparo = "Amasse a banana e misture com os ovos."
                        +"Adicione a aveia e o fermento."
                        +"Cozinhe em uma frigideira quente até dourar dos dois lados."
                        +"Sirva com mel ou xarope."
        },
             new Receita() {
                Id = 6,
                Nome = "Pão com Ovos Mexidos",
                Descricao = "Simples e nutritivo, ideal para ganho de massa.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 210,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\pao_com_ovos_mexidos.png",
                Preparo = "Aqueça a manteiga em uma frigideira, adicione os ovos e mexa até cozinhar."
                         +"Tempere com sal e pimenta e sirva sobre as fatias de pão torrado."
        },
            new Receita() {
                Id = 7,
                Nome = "Muffin de Banana",
                Descricao = "Muffins saudáveis e deliciosos, ótimos para ganho de massa.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 151,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\muffin_de_banana.png",
                Preparo = "Amasse a banana e misture com o ovo, a farinha de aveia e o fermento."
                        +"Divida a massa em forminhas de muffin e asse a 180°C por 15-20 minutos."
        },   
            new Receita() {
                Id = 8,
                Nome = "Batido de Proteína de Chocolate",
                Descricao = "Um batido delicioso e rápido para ganho de massa.",
                CategoriaId = 4, 
                Rendimento = 1,
                Calorias = 114,
                TempoPreparo = "5 minutos",
                Foto = "\\img\\receitas\\batido_de_proteina_de_chocolate.png",
                Preparo = "Bata todos os ingredientes no liquidificador até obter uma textura cremosa." 
                        +"Sirva imediatamente."
        },
            new Receita() {
                Id = 9,
                Nome = "Salada de Frutas",
                Descricao = "Uma salada fresca e saudável para ganho de massa.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 219,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\salada_de_frutas.png",
                Preparo = "Misture todas as frutas em uma tigela e adicione o queijo cottage por cima."
                        +"Sirva gelado."
        },
            new Receita() {
                Id = 10,
                Nome = "Wrap de Frango",
                Descricao = "Um wrap saboroso e nutritivo, ideal para ganho de massa.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 393,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\wrap_de_frango.png",
                Preparo = "Aqueça o pão wrap, coloque o frango grelhado e os vegetais."
                        +"Adicione a maionese e enrole o wrap." 
                        +"Corte ao meio e sirva."
        },
             new Receita() {
                Id = 11,
                Nome = "Smoothie Verde",
                Descricao = "Um smoothie saudável e refrescante para ganho de massa.",
                CategoriaId = 4, 
                Rendimento = 1,
                Calorias = 198,
                TempoPreparo = "5 minutos",
                Foto = "\\img\\receitas\\smoothie_verde.png",
                Preparo = "Coloque todos os ingredientes no liquidificador e bata até obter uma mistura homogênea."
                        +"Sirva imediatamente."
        },
            new Receita() {
                Id = 12,
                Nome = "Quinoa com Legumes Assados",
                Descricao = "Uma refeição rica em nutrientes e sabor, perfeita para ganho de massa.",
                CategoriaId = 2, 
                Rendimento = 1,
                Calorias = 300,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\quinoa_com_legumes_assados.png",
                Preparo = "Cozinhe a quinoa conforme as instruções da embalagem."
                        +"Enquanto isso, asse os legumes no forno a 200°C com azeite, sal e pimenta até estarem macios."
                        +"Misture os legumes assados com a quinoa e sirva."
        },
            new Receita() {
                Id = 13,
                Nome = "Frango Grelhado com Batata Doce",
                Descricao = "Frango grelhado com batata doce, uma combinação clássica para ganho de massa.",
                CategoriaId = 2, 
                Rendimento = 1,
                Calorias = 224,
                TempoPreparo = "25 minutos",
                Foto = "\\img\\receitas\\frango_grelhado_com_batata_doce.png",
                Preparo = "Tempere o peito de frango com sal, pimenta e ervas finas."
                        +"Grelhe o frango até estar bem cozido."
                        +"Cozinhe a batata doce até ficar macia e depois corte em rodelas."
                        +"Aqueça o azeite em uma frigideira e doure as rodelas de batata doce."
        },
            new Receita() {
                Id = 14,
                Nome = "Salmão Assado",
                Descricao = "Um prato delicioso e saudável de salmão assado, ideal para ganho de massa.",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 200,
                TempoPreparo = "20 minutos",
                Foto = "\\img\\receitas\\salmão_assado.png",
                Preparo = "Tempere o salmão com azeite, suco de limão, sal, pimenta e ervas frescas."
                        +"Asse em forno pré-aquecido a 180°C por cerca de 15 minutos ou até o salmão estar completamente cozido."
        },
            new Receita() {
                Id = 15,
                Nome = "Carne Bovina com Arroz Integral",
                Descricao = "Um prato nutritivo de carne bovina com arroz integral para ganho de massa.",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 350,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\carne_bovina_com_arroz_integral.png",
            Preparo = "Cozinhe o arroz integral conforme as instruções da embalagem."
                    +"Enquanto isso, aqueça o azeite em uma frigideira e refogue a cebola e o alho até ficarem macios."
                    +"Adicione a carne picada e cozinhe até dourar."
                    +"Tempere com sal e pimenta e sirva com o arroz."
        },
            new Receita() {
                Id = 16,
                Nome = "Sopa de Lentilha com Legumes",
                Descricao = "Uma sopa nutritiva de lentilha com legumes, perfeita para ganho de massa.",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 84,
                TempoPreparo = "40 minutos",
                Foto = "\\img\\receitas\\sopa_de_lentilha.png",
                Preparo = "Aqueça o azeite em uma panela grande e refogue a cebola e o alho até ficarem macios."
                        +"Adicione a cenoura, batata, lentilhas e o caldo de legumes."
                        +"Cozinhe por cerca de 30 minutos ou até que as lentilhas e legumes estejam macios."
                        +"Tempere com sal, pimenta e a folha de louro. Sirva quente."
        },
            new Receita() {
                Id = 17,
                Nome = "Tofu Mexido com Legumes",
                Descricao = "Um prato saudável e saboroso de tofu mexido com legumes, perfeito para ganho de massa.",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 127,
                TempoPreparo = "20 minutos",
                Foto = "\\img\\receitas\\tofu_mexido_com_legumes.png",
                Preparo = "Aqueça o azeite em uma frigideira grande e refogue a cebola e o alho até ficarem macios."
                        +"Adicione o pimentão e cozinhe por mais alguns minutos."
                        +"Esfarele o tofu e adicione à frigideira, misturando bem."
                        +"Tempere com sal, pimenta e açafrão. Cozinhe por 10-15 minutos, mexendo ocasionalmente, até o tofu estar levemente dourado."
                        +"Adicione o espinafre e cozinhe até murchar."
        },
            new Receita() {
                Id = 18,
                Nome = "Salada de Grão de Bico",
                Descricao = "Uma salada fresca e nutritiva de grão de bico, ideal para ganho de massa.",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 42,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\salada_de_grao_de_bico.png",
                Preparo = "Em uma tigela grande, misture o grão de bico, tomate, pepino e cebola"
                        +"Em uma pequena tigela, combine o azeite, suco de limão, sal e pimenta."
                        +"Despeje o molho sobre a salada e misture bem." 
                        +"Polvilhe com salsinha picada antes de servir."
        },
            new Receita() {
                Id = 19,
                Nome = "Carne Moída com Abóbora",
                Descricao = "Uma combinação deliciosa e nutritiva de carne moída com abóbora, perfeita para ganho de massa.",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 135,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\carne_moida_com_abobora.png",
                Preparo = "Aqueça o azeite em uma frigideira grande e refogue a cebola e o alho até ficarem macios."
                        +"Adicione a carne moída e cozinhe até dourar."
                        +"Adicione a abóbora, sal, pimenta e cominho."
                        +"Cozinhe até que a abóbora esteja macia e a carne completamente cozida, cerca de 20 minutos."
        },
            new Receita() {
                Id = 20,
                Nome = "Filé de Peixe Cremoso",
                Descricao = "Um prato cremoso e delicioso de filé de peixe, ideal para ganho de massa.",
                CategoriaId = 2,
                Rendimento = 1,
                Calorias = 249,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\file_de_peixe_cremoso.png",
                Preparo = "Tempere o filé de peixe com suco de limão, sal e pimenta."
                +"Aqueça o azeite em uma frigideira e cozinhe o peixe até dourar e estar completamente cozido."
                +"Adicione o creme de leite e cozinhe por mais 2-3 minutos, até o molho estar quente e levemente espesso."
                +"Sirva imediatamente."
        },
            new Receita(){
                Id = 21,
                Nome = "Lombo na Panela",
                Descricao = "Lombo de porco cozido lentamente com cebola, alho e caldo de carne.",
                CategoriaId = 2, 
                Rendimento = 2,
                Calorias = 136,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\lombo_na_panela.png",
                Preparo = "Aqueça o azeite em uma panela grande e refogue a cebola e o alho até ficarem macios. "
                        + "Adicione o lombo e cozinhe até dourar por todos os lados. "
                        + "Adicione o caldo de carne, sal, pimenta e tomilho. Reduza o fogo e cozinhe por cerca de 20 minutos, ou até o lombo estar bem cozido e macio."
        },
            new Receita(){
                Id = 22,
                Nome = "Ragu de Carne",
                Descricao = "Carne de boi cozida lentamente com tomate, vinho tinto e especiarias, resultando em um molho encorpado.",
                CategoriaId = 2,
                Rendimento = 3,
                Calorias = 405,
                TempoPreparo = "1h 30min",
                Foto = "\\img\\receitas\\ragu_de_carne.png",
                Preparo = "Aqueça o azeite em uma panela grande e refogue a cebola e o alho até ficarem macios. "
                        + "Adicione a carne e cozinhe até dourar. Adicione a cenoura e cozinhe por mais alguns minutos. "
                        + "Deglace a panela com o vinho tinto e deixe reduzir. Adicione o tomate pelado, o caldo de carne, sal, pimenta e a folha de louro. "
                        + "Cozinhe em fogo baixo por cerca de 1 hora, ou até a carne estar bem macia e o molho espesso."
        },
            new Receita(){
                Id = 23,
                Nome = "Peito de Frango Grelhado com Quinoa",
                Descricao = "Peito de frango grelhado acompanhado de quinoa e legumes refogados.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 404,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\peito_de_frango_grelhado_com_quinoa.png",
                Preparo = "Tempere o peito de frango com sal, pimenta e suco de limão. Aqueça o azeite em uma frigideira e grelhe o frango até estar completamente cozido. "
                        + "Cozinhe a quinoa em água conforme as instruções da embalagem. Em uma panela separada, refogue a cebola e o pimentão até amolecer. "
                        + "Misture a quinoa cozida com os legumes refogados. Sirva o peito de frango fatiado sobre a quinoa."
        },
            new Receita(){
                        Id = 24,
                        Nome = "Salmão ao Molho de Laranja",
                        Descricao = "Filé de salmão grelhado servido com um molho agridoce de laranja e gengibre.",
                        CategoriaId = 3, 
                        Rendimento = 2,
                        Calorias = 295,
                        TempoPreparo = "20 minutos",
                        Foto = "\\img\\receitas\\salmão_ao_molho_de_laranja.png",
                    Preparo = "Tempere o filé de salmão com sal e pimenta."
                            +"Aqueça o azeite em uma frigideira e cozinhe o salmão por 4-5 minutos de cada lado, ou até estar completamente cozido"
        },
            new Receita(){
                Id = 25,
                Nome = "Carne Bovina com Purê de Batata",
                Descricao = "Cubos de carne bovina servidos com um cremoso purê de batata.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 146,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\carne_bovina_com_pure_de_batata.png",
                Preparo = "Cozinhe as batatas em água salgada até ficarem macias."
                        +"Escorra e passe as batatas pelo espremedor. Misture a manteiga e o leite até obter um purê liso. "
                    + "Tempere com sal e pimenta. Em uma frigideira, cozinhe a carne até dourar e estar completamente cozida."
                    +"Sirva a carne com o purê de batata."
        },
            new Receita(){
                Id = 26,
                Nome = "Macarrão Integral com Frango Desfiado",
                Descricao = "Macarrão integral com frango desfiado e molho de tomate.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 219,
                TempoPreparo = "25 minutos",
                Foto = "\\img\\receitas\\macarrao_integral_com_frango_desfiado.png",
                Preparo = "Cozinhe o macarrão integral conforme as instruções da embalagem."
                        +"Em uma panela, aqueça o azeite e refogue a cebola e o alho até ficarem macios. "
                        + "Adicione o frango desfiado e o molho de tomate. Cozinhe por alguns minutos até que tudo esteja bem misturado e aquecido. "
                        + "Misture o macarrão cozido com o frango e decore com salsinha."
        },
            new Receita(){
                Id = 27,
                Nome = "Iscas de Frango com Legumes",
                Descricao = "Iscas de frango refogadas com pimentões e cenoura.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 153,
                TempoPreparo = "20 minutos",
                Foto = "\\img\\receitas\\iscas_de_frango_com_legumes.png",
                Preparo = "Aqueça o azeite em uma frigideira e refogue as iscas de frango até dourar."
                +"Adicione os pimentões e a cenoura e continue refogando até os legumes estarem macios. "
                + "Tempere com molho de soja, sal e pimenta a gosto."
        },
            new Receita(){
                Id = 28,
                Nome = "Salada Colorida de Legumes",
                Descricao = "Uma salada leve e refrescante com legumes variados.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 70,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\salada_colorida_de_legumes.png",
                Preparo = "Misture todos os legumes em uma tigela. Em uma pequena tigela separada, combine o azeite, suco de limão, sal e pimenta. "
                        + "Regue a salada com o molho e misture bem. Decore com salsinha antes de servir."
        },
            new Receita(){
                Id = 29,
                Nome = "Espaguete de Abobrinha",
                Descricao = "Espaguete saudável feito com abobrinhas frescas.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 255,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\espaguete_de_abobrinha.png",
                Preparo = "Use um espiralizador para transformar as abobrinhas em espaguete. Aqueça o azeite em uma frigideira e refogue o alho até dourar. "
                        + "Adicione o espaguete de abobrinha e cozinhe por 2-3 minutos. Adicione o molho de tomate e cozinhe por mais 2 minutos. "
                        + "Tempere com sal e pimenta a gosto. Sirva com queijo parmesão ralado, se desejar."
        },
            new Receita(){
                Id = 30,
                Nome = "Peixe Grelhado com Arroz Integral",
                Descricao = "Filé de peixe grelhado servido com arroz integral.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 179,
                TempoPreparo = "25 minutos",
                Foto = "\\img\\receitas\\peixe_grelhado_com_arroz_integral.png",
                Preparo = "Tempere o filé de peixe com sal, pimenta e suco de limão."
                        +"Aqueça o azeite em uma frigideira e grelhe o peixe até estar completamente cozido. "
                        + "Cozinhe o arroz integral em água conforme as instruções da embalagem."
                        +"Sirva o peixe grelhado sobre o arroz integral e decore com ervas finas, se desejar."
        },
            new Receita(){
                Id = 31,
                Nome = "Hambúrguer de Carne com Batata Doce Assada",
                Descricao = "Hambúrguer suculento acompanhado de batata doce assada.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 138,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\hamburguer_de_carne_com_batata_doce_assada.png",
                Preparo = "Tempere a carne moída com sal e pimenta e modele em formato de hambúrguer."
                        +"Grelhe em uma frigideira antiaderente até atingir o ponto desejado. "
                        + "Para as batatas, misture com azeite, alho, sal e pimenta e asse em forno pré-aquecido a 200°C por cerca de 20 minutos, ou até ficarem crocantes. "
                        + "Sirva o hambúrguer com a batata doce assada, alface e tomate."
        },
            new Receita(){
                Id = 32,
                Nome = "Omelete de Legumes",
                Descricao = "Uma omelete nutritiva recheada com legumes frescos.",
                CategoriaId = 1, 
                Rendimento = 2,
                Calorias = 282,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\omelete_de_legumes.png",
                Preparo = "Bata os ovos e adicione os legumes picados."
                        +"Aqueça o azeite em uma frigideira antiaderente e despeje a mistura de ovos e legumes. "
                        + "Cozinhe em fogo médio até que os ovos estejam firmes e os legumes cozidos. Tempere com sal e pimenta a gosto."
        },
            new Receita(){
                Id = 33,
                Nome = "Iogurte Natural",
                Descricao = "Uma opção saudável e rápida para um lanche.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 118,
                TempoPreparo = "5 minutos",
                Foto = "\\img\\receitas\\iogurte_natural.png",
                Preparo = "Sirva o iogurte em um pote. Se desejar, adicione mel para adoçar."
                +"Acompanhe com frutas frescas de sua escolha."
        },
            new Receita(){
                Id = 34,
                Nome = "Torrada Integral com Abacate",
                Descricao = "Uma torrada nutritiva e deliciosa com abacate.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 240,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\torrada_integral_com_abacate.png",
                Preparo = "Torre o pão integral."
                +"Amasse o abacate e misture com suco de limão, sal e pimenta."
                +"Espalhe a mistura de abacate sobre a torrada e, se desejar, adicione uma pitada de pimenta vermelha."
        },
            new Receita(){
                Id = 35,
                Nome = "Creme de Papaia com Granola",
                Descricao = "Uma sobremesa refrescante e leve.",
                CategoriaId = 1, 
                Rendimento = 2,
                Calorias = 189,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\creme_de_papaia_com_granola.png",
            Preparo = "Retire a polpa da papaia e bata no liquidificador até obter um creme."
                    +"Adicione suco de limão e mel se desejar."
                    +"Sirva o creme com granola por cima."
        },
            new Receita(){
                Id = 36,
                Nome = "Torta de Maçã",
                Descricao = "Uma torta de maçã saudável e saborosa.",
                CategoriaId = 1, 
                Rendimento = 8,
                Calorias = 237,
                TempoPreparo = "45 minutos",
                Foto = "\\img\\receitas\\torta_de_maca.png",
            Preparo = "Preaqueça o forno a 180°C. Coloque a massa de torta em uma forma."
            +"Misture as maçãs fatiadas com o mel, canela e farinha de aveia."
            +"Coloque a mistura sobre a massa e asse por 30-35 minutos, ou até que a torta esteja dourada e as maçãs macias."
        },  
            new Receita(){
                Id = 37,
                Nome = "Shake Proteico de Banana",
                Descricao = "Uma bebida refrescante e rica em proteínas.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 113,
                TempoPreparo = "5 minutos",
                Foto = "\\img\\receitas\\shake_proteico_de_banana.png",
                Preparo = "Coloque todos os ingredientes no liquidificador e bata até obter uma mistura homogênea. Sirva imediatamente."
        },
            new Receita(){
                Id = 38,
                Nome = "Taco de Frango com Wrap",
                Descricao = "Um taco saudável e saboroso com frango desfiado.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 142,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\taco_de_frango_com_wrap.png",
                Preparo = "Misture o frango desfiado com cominho, sal e pimenta."
                        +"Aqueça o wrap em uma frigideira."
                        +" Coloque o frango, alface, tomate e uma colher de sopa de iogurte grego no wrap. Enrole e sirva."
        },
            new Receita(){
                Id = 39,
                Nome = "Banana Assada na Airfryer",
                Descricao = "Uma sobremesa saudável e simples de fazer.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 108,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\banana_assada_na_airfryer.png",
                Preparo = "Preaqueça a airfryer a 180°C."
                        +"Corte a banana em rodelas e coloque na cesta da airfryer. Polvilhe com canela."
                        +"Asse por 8-10 minutos ou até que a banana esteja caramelizada e macia."
        },
            new Receita(){
                Id = 40,
                Nome = "Toast de Aveia com Ovo e Espinafre",
                Descricao = "Um toast nutritivo e delicioso com aveia e ovos.",
                CategoriaId = 1, 
                Rendimento = 2,
                Calorias = 323,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\toast_de_aveia_com_ovo_e_espinafre.png",
                Preparo = "Torre o pão integral."
                        +"Em uma frigideira, aqueça o azeite e refogue o espinafre até murchar."
                        +"Bata os ovos e despeje na frigideira, mexendo até cozinhar."
                        +" Cozinhe a aveia em água até ficar macia."
                        +"Monte o toast com a aveia, o ovo e o espinafre sobre o pão."
        },
            new Receita(){
                Id = 41,
                Nome = "Sanduíche de Frango e Cottage",
                Descricao = "Um sanduíche leve e saboroso, perfeito para emagrecimento.",
                CategoriaId = 1, 
                Rendimento = 1,
                Calorias = 302,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\sandwich_de_frango_e_cottage.png",
                Preparo = "Toste o pão integral. Misture o frango desfiado com o queijo cottage."
                        +"Coloque a mistura no pão, adicione a alface, o tomate e a mostarda. Feche o sanduíche e sirva."
        },
            new Receita(){
                Id = 42,
                Nome = "Snack de Grão-de-Bico",
                Descricao = "Um lanche crocante e saudável para petiscar.",
                CategoriaId = 1, 
                Rendimento = 2,
                Calorias = 115,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\snack_de_grao_de_bico.png",
                Preparo = "Preaqueça o forno a 200°C. Misture o grão-de-bico com azeite, cominho, páprica, sal e pimenta."
                        +"Espalhe em uma assadeira e asse por 20-25 minutos, ou até que esteja crocante."
        },
            new Receita(){
                Id = 43,
                Nome = "Pão de Queijo Fit",
                Descricao = "Uma versão saudável do tradicional pão de queijo.",
                CategoriaId = 1, 
                Rendimento = 10,
                Calorias = 42,
                TempoPreparo = "20 minutos",
                Foto = "\\img\\receitas\\pao_de_queijo_fit.png",
                Preparo = "Preaqueça o forno a 180°C. Misture todos os ingredientes até formar uma massa homogênea."
                        +" Modele pequenas bolinhas e coloque em uma assadeira."
                        +"Asse por 15-20 minutos, ou até que estejam dourados."
         },
            new Receita(){
                Id = 44,
                Nome = "Ceviche de Salmão",
                Descricao = "Um ceviche fresco e saboroso, ideal para emagrecimento.",
                CategoriaId = 2, 
                Rendimento = 2,
                Calorias = 381,
                TempoPreparo = "20 minutos",
                Foto = "\\img\\receitas\\ceviche_de_salmao.png",
                Preparo = "Misture o salmão com o suco de limão e deixe marinar por 15-20 minutos."
                        +"Adicione a cebola, coentro e pimenta. Tempere com sal e pimenta. Sirva imediatamente."
        },
            new Receita(){
                Id = 45,
                Nome = "Carne Moída com Abóbora",
                Descricao = "Um prato nutritivo e leve, com carne e abóbora.",
                CategoriaId = 2, 
                Rendimento = 2,
                Calorias = 223,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\carne_moida_com_abobora.png",
                Preparo = "Aqueça o azeite em uma panela. Refogue a cebola e o alho até ficarem macios."
                        +"Adicione a carne moída e cozinhe até dourar."
                        +" Acrescente a abóbora, sal e pimenta, e cozinhe por 15-20 minutos, ou até que a abóbora esteja macia."
        },
            new Receita(){
                Id = 46,
                Nome = "Cestinha de Peito de Peru com Ovo",
                Descricao = "Cestinhas leves de peito de peru, perfeitas para um lanche saudável.",
                CategoriaId = 2, 
                Rendimento = 1,
                Calorias = 95,
                TempoPreparo = "20 minutos",
                Foto = "\\img\\receitas\\cestinha_de_peito_de_peru_com_ovo.png",
                Preparo = "Coloque as fatias de peito de peru em uma forma de muffin, formando uma cestinha."
                        +"Quebre um ovo dentro de cada cestinha e tempere com sal e pimenta."
                        +"Asse a 180°C por 15-20 minutos, até que o ovo esteja cozido."
        },
            new Receita(){
                Id = 47,
                Nome = "Ratatouille de Forno Simples",
                Descricao = "Uma receita de ratatouille fácil e saudável, perfeita como acompanhamento.",
                CategoriaId = 2, 
                Rendimento = 4,
                Calorias = 60,
                TempoPreparo = "35 minutos",
                Foto = "\\img\\receitas\\ratatouille_de_forno_simples.png",
                Preparo = "Preaqueça o forno a 200°C. Misture todos os vegetais com azeite, sal, pimenta e tomilho."
                       +"Coloque em uma assadeira e asse por 25-30 minutos, mexendo ocasionalmente, até que os vegetais estejam macios e levemente dourados."
        },
             new Receita(){
                Id = 48,
                Nome = "Frango ao Molho de Laranja",
                Descricao = "Frango suculento servido com um molho de laranja refrescante.",
                CategoriaId = 2, 
                Rendimento = 2,
                Calorias = 139,
                TempoPreparo = "20 minutos",
                Foto = "\\img\\receitas\\frango_ao_molho_de_laranja.png",
                Preparo = "Tempere o frango com sal e pimenta e cozinhe em uma frigideira com um pouco de óleo até que esteja dourado e cozido por completo."
                        +"Em uma panela pequena, misture o suco de laranja, molho de soja, mel e alho."
                        +" Cozinhe em fogo baixo até que o molho reduza e engrosse. "
                        +"Sirva o frango com o molho por cima."
        },
             new Receita(){
                Id = 49,
                Nome = "Panqueca Integral",
                Descricao = "Panquecas saudáveis e leves, perfeitas para o café da manhã.",
                CategoriaId = 2, 
                Rendimento = 2,
                Calorias = 45,
                TempoPreparo = "10 minutos",
                Foto = "\\img\\receitas\\panqueca_integral.png",
                Preparo = "Misture todos os ingredientes até formar uma massa homogênea."
                        +"Aqueça uma frigideira antiaderente e despeje a massa formando pequenas panquecas."
                        +"Cozinhe por 2-3 minutos de cada lado, ou até que estejam douradas."
        },
            new Receita(){
                Id = 50,
                Nome = "Berinjela no Forno",
                Descricao = "Berinjela assada, leve e cheia de sabor.",
                CategoriaId = 2, 
                Rendimento = 2,
                Calorias = 60,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\berinjela_no_forno.png",
                Preparo = "Preaqueça o forno a 200°C. Coloque as rodelas de berinjela em uma assadeira e regue com azeite."
                        +"Tempere com orégano, alho em pó, sal e pimenta."
                        +"Asse por 20-25 minutos, virando as rodelas na metade do tempo, até que estejam macias e levemente douradas."
        },
            new Receita(){
                Id = 51,
                Nome = "Carne Moída com Legumes e Purê de Abóbora",
                Descricao = "Uma refeição equilibrada com carne e purê de abóbora.",
                CategoriaId = 2, 
                Rendimento = 2,
                Calorias = 152,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\carne_moida_com_legumes_com_pure_de_abobora.png",
                Preparo = "Em uma frigideira, aqueça o azeite e refogue o alho até dourar."
                        +"Adicione a carne moída e cozinhe até que esteja bem dourada."
                        +" Acrescente os legumes e cozinhe até que estejam macios."
                        + "Sirva com o purê de abóbora por cima.",
        },
            new Receita(){
                Id = 52,
                Nome = "Creme de Abóbora",
                Descricao = "Um creme leve e saboroso, ideal para aquecer o corpo.",
                CategoriaId = 3, 
                Rendimento = 4,
                Calorias = 60,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\creme_de_abobora.png",
                Preparo = "Aqueça o azeite em uma panela e refogue a cebola e o alho até que fiquem macios."
                        +"Adicione a abóbora e o caldo de legumes. Cozinhe até que a abóbora esteja macia."
                        +"Bata a mistura no liquidificador até obter um creme liso. Ajuste o sal e a pimenta."
        },
            new Receita(){
                Id = 53,
                Nome = "Creme de Cenoura e Gengibre com Frango",
                Descricao = "Um creme nutritivo e saboroso, com um toque de gengibre.",
                CategoriaId = 3, 
                Rendimento = 4,
                Calorias = 157,
                TempoPreparo = "40 minutos",
                Foto = "\\img\\receitas\\creme_de_cenoura_e_gengibre_com_frango.png",
                Preparo = "Refogue a cebola e o gengibre no azeite até que fiquem macios."
                        +" Adicione a cenoura e o caldo de frango. Cozinhe até que a cenoura esteja macia."
                        +"Cozinhe o peito de frango em outra panela e depois desfie."
                        +" Bata o creme de cenoura e gengibre no liquidificador. Adicione o frango desfiado ao creme e sirva."
        },
            new Receita(){
                Id = 54,
                Nome = "Salada de Macarrão de Arroz",
                Descricao = "Uma salada refrescante e leve, perfeita para o verão.",
                CategoriaId = 3, 
                Rendimento = 4,
                Calorias = 214,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\salada_de_macarrao_de_arroz.png",
                Preparo = "Misture todos os ingredientes em uma tigela grande. Tempere com azeite, vinagre, sal e pimenta. Misture bem e sirva."
        },
            new Receita(){
                Id = 55,
                Nome = "Espaguete de Abobrinha",
                Descricao = "Uma alternativa saudável e deliciosa ao espaguete tradicional.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 310,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\espaguete_de_abobrinha.png",
                Preparo = "Aqueça o azeite em uma frigideira grande e refogue o alho até que fique aromático."
                        +"Adicione o espaguete de abobrinha e cozinhe por 5-7 minutos até que esteja al dente."
                        +"Adicione o molho de tomate e cozinhe por mais 2 minutos. Sirva com queijo parmesão, se desejar."
        },
            new Receita(){
                Id = 56,
                Nome = "Lasanha com Recheio de Legumes",
                Descricao = "Uma lasanha leve e cheia de nutrientes, perfeita para um jantar saudável.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 192,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\lasanha_com_recheio_de_legumes.png",
                Preparo = "Pré-aqueça o forno a 180°C. Cozinhe as folhas de lasanha conforme as instruções da embalagem."
                        +" Em uma travessa, coloque uma camada de lasanha, seguida de uma camada de legumes e queijo cottage."
                        +" Repita as camadas e finalize com molho de tomate. Leve ao forno por 20 minutos."
        },
            new Receita(){
                Id = 57,
                Nome = "Arroz de Forno Integral com Frango",
                Descricao = "Um prato saboroso e saudável, perfeito para aproveitar sobras de frango.",
                CategoriaId = 3, 
                Rendimento = 4,
                Calorias = 200,
                TempoPreparo = "30 minutos",
                Foto = "\\img\\receitas\\arroz_de_forno_integral_com_frango.png",
                Preparo = "Pré-aqueça o forno a 180°C. Em uma tigela, misture o arroz, frango, milho, ervilha e cenoura."
                        +" Tempere com sal e pimenta. Transfira para uma assadeira e cubra com queijo ralado."
                        +" Leve ao forno por 20 minutos."
        },
            new Receita(){
                Id = 58,
                Nome = "Kibe de Carne",
                Descricao = "Uma receita prática e nutritiva, ideal como lanche ou entrada.",
                CategoriaId = 3, 
                Rendimento = 4,
                Calorias = 77,
                TempoPreparo = "45 minutos",
                Foto = "\\img\\receitas\\kibe_de_carne.png",
                Preparo = "Hidrate o trigo em água por 30 minutos. Misture a carne moída, trigo, cebola e hortelã."
                        + "Tempere com sal e pimenta. Modele em formato de kibe e coloque em uma assadeira untada com azeite."
                        +" Asse a 180°C por 20 minutos ou até dourar."
        },
            new Receita(){
                Id = 59,
                Nome = "Pizza Fit de Frigideira",
                Descricao = "Uma pizza leve e rápida, ideal para quem busca uma opção saudável.",
                CategoriaId = 3, 
                Rendimento = 2,
                Calorias = 116,
                TempoPreparo = "15 minutos",
                Foto = "\\img\\receitas\\pizza_fit_de_frigideira.png",
                Preparo = "Misture a farinha e o ovo até formar uma massa."
                        +" Aqueça uma frigideira antiaderente e coloque a massa, formando um disco."
                        +"Cozinhe por 2-3 minutos de cada lado. Adicione o molho de tomate, queijo, tomate, azeitonas e orégano."
                        +" Tampe e cozinhe por mais 5 minutos."
        },
            new Receita(){
                Id = 60,
                Nome = "Lasanha de Berinjela",
                Descricao = "Uma alternativa saudável à lasanha tradicional, cheia de sabor.",
                CategoriaId = 3, 
                Rendimento = 4,
                Calorias = 135,
                TempoPreparo = "40 minutos",
                Foto = "\\img\\receitas\\lasanha_de_berinjela.png",
                Preparo = "Pré-aqueça o forno a 180°C. Grelhe as fatias de berinjela até que estejam macias."
                +" Em uma travessa, coloque uma camada de berinjela, uma camada de molho de tomate e uma camada de queijo cottage."
                +" Repita as camadas e finalize com queijo parmesão. Leve ao forno por 25 minutos."
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
        
        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole() {
               Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
               Id = "bec71b05-8f3d-4849-88bb-0e8d518d2de8",
               Name = "Usuário",
               NormalizedName = "USUÁRIO"
            },
            new IdentityRole() {
               Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
               Name = "Moderador",
               NormalizedName = "MODERADOR"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new() {
            new IdentityUser(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Email = "admin@gcook.com",
                NormalizedEmail = "ADMIN@GCOOK.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "Priscila",
                DataNascimento = DateTime.Parse("20/12/2006"),
                Foto = "/img/usuarios/avatar.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}