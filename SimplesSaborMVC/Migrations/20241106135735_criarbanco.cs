using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimplesSaborMVC.Migrations
{
    /// <inheritdoc />
    public partial class criarbanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Receita",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TempoPreparo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rendimento = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preparo = table.Column<string>(type: "varchar(8000)", maxLength: 8000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Calorias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receita_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReceitaIngrediente",
                columns: table => new
                {
                    ReceitaId = table.Column<int>(type: "int", nullable: false),
                    IngredienteId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaIngrediente", x => new { x.ReceitaId, x.IngredienteId });
                    table.ForeignKey(
                        name: "FK_ReceitaIngrediente_Ingrediente_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingrediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceitaIngrediente_Receita_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receita",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "ExibirHome", "Foto", "Nome" },
                values: new object[,]
                {
                    { 1, true, "/img/categorias/1.jpg", "Café da Manhã" },
                    { 2, false, "/img/categorias/2.jpg", "Almoço" },
                    { 3, true, "/img/categorias/3.jpg", "Jantar " },
                    { 4, true, "/img/categorias/1.jpg", "Bebidas" }
                });

            migrationBuilder.InsertData(
                table: "Ingrediente",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Ovo" },
                    { 2, "Brócolis" },
                    { 3, "Sal" },
                    { 4, "Queijo " },
                    { 5, "Azeite" },
                    { 6, "Batata " },
                    { 7, "rabanete" },
                    { 8, "Tomate " },
                    { 9, "Orégano " },
                    { 10, "Aveia" },
                    { 11, "Linhaça " },
                    { 12, "Coco em Flocos" },
                    { 13, "Açúcar Mascavo " },
                    { 14, "Cacau em Pó" },
                    { 15, " Leite Desnatado " },
                    { 16, "Morangos " },
                    { 17, "Amêndoas" },
                    { 18, "Cacau " },
                    { 19, "Água " },
                    { 20, "Espinafre" },
                    { 21, "Frutas Vermelhas " },
                    { 22, "Iogurte" },
                    { 23, "Whey" },
                    { 24, " Castanhas" },
                    { 25, "Pão " },
                    { 26, "Abacate " },
                    { 27, "Manteiga" },
                    { 28, "Chia " },
                    { 29, "Pimenta  " },
                    { 30, "Banana" },
                    { 31, "Canela " },
                    { 32, "Baunilha " },
                    { 33, "Requeijão " },
                    { 34, "Carne" },
                    { 35, "Arroz" },
                    { 36, "Cebola " },
                    { 37, "Frango" },
                    { 38, "Batata Doce" },
                    { 39, "Salmão" },
                    { 40, "Limão" },
                    { 41, "macarrão" },
                    { 42, "Alho" },
                    { 43, "Molho de Tomate" },
                    { 44, "Pimentões" },
                    { 45, "Cenoura" },
                    { 46, "Salada" },
                    { 47, "salsinha" },
                    { 48, "Laranja" },
                    { 49, "Mel" },
                    { 50, "Panqueca" },
                    { 51, "Berinjela" }
                });

            migrationBuilder.InsertData(
                table: "Receita",
                columns: new[] { "Id", "Calorias", "CategoriaId", "Descricao", "Foto", "Nome", "Preparo", "Rendimento", "TempoPreparo", "Tipo" },
                values: new object[,]
                {
                    { 1, 282, 1, "Prato perfeito para um lanche rápido ou mesmo uma refeição picante. Carne moída, pimentões, temperos e muito queijooooo", "/assets/images/dish/omelete_de_legumes.png", "Omelete de Legumes", "Comece pela preparação dos ingredientes, pique os pimentões e a cebola em pequenos cubos, se preferir você também pode usar um processador de alimentos.Coloque a carne moída para fritar em uma panela com um pouco de azeite.Quando a carne moída já não estiver mais crua, adicione os pimentões e a cebola, mexendo bem para misturar todos os ingredientes.Aguarde alguns instante e adicione os temperos, mexendo novamente para misturar.Frite por mais alguns minutos a carne com os demais ingredientes.Adicione o Cream Cheese e o Queijo Cheddar, mexendo bem para evitar que queime o fundo e ajudar os queijos a derreterem.Quando os queijos já estiverem bem derretidos e misturados com os demais ingredientes, sirva acompanhado do Pão Sirio ou de Doritos.", 1, "15 minutos", "Ganho de Massa" },
                    { 2, 127, 1, null, "/assets/images/dish/aveia_com_frutas.png", "Aveia com Frutas", "Em uma tigela, misture a aveia, a linhaça, o coco em flocos, o açúcar mascavo, o cacau em pó e o leite. Reserve na geladeira de um dia para o outro. No momento de servir, coloque uma porção em uma tigela e finalize com os morangos picados, a amêndoa laminada e os nibs de cacau.", 1, "10 minutos", null },
                    { 3, 162, 4, null, "/assets/images/dish/smoothie_de_proteina.png", "Smoothie de Proteína", "Coloque todos os ingredientes no liquidificador e bata até obter uma mistura homogênea.Sirva em um copo grande.", 1, "5 minutos", null },
                    { 4, 310, 1, null, "/assets/images/dish/torrada_de_abacate.png", "Torrada de Abacate", "Coloque a manteiga em uma frigideira antiaderente. Quando derreter, quebre os dois ovos, adicione uma pitada de sal e mexa até cozinhar. Reserve. Pique metade do avocado e amasse-o em uma tigela pequena. Adicione ½ limão taiti espremido, sal, pimenta e chia (opcional). Misture bem e reserve. Coloque as duas fatias de pão 7 grãos na torradeira e toste até ficarem crocantes. Para servir, espalhe o avocado no pão torrado e, em seguida, adicione os ovos mexidos. Tempere com pimenta preta e sal a gosto, ajustando conforme seu paladar. Sirva em seguida.", 1, "15 minutos", null },
                    { 5, 250, 1, null, "/assets/images/dish/panquecas_de_banana.png", "Panquecas de Banana", "Amasse as bananas em uma travessa funda. Adicione os ovos inteiros e misture bem. Acrescente a baunilha, a aveia e a canela (ou o chocolate em pó ou a manteiga de amendoim). Unte uma frigideira com um pouco de óleo e leve ao fogo até aquecer. Coloque uma colherada grande (ou uma concha) da massa na frigideira. Cozinhe por 2 a 3 minutos. Quando a massa começar a soltar bolhinhas, vire e deixe cozinhar por mais 1 a 2 minutos. Repita o processo de cozimento para as demais porções.", 1, "20 minutos", null },
                    { 6, 210, 1, null, "/assets/images/dish/pao_com_ovos_mexidos.png", "Pão com Ovos Mexidos", "Em uma tigela, coloque os ovos e bata com um garfo até obter uma mistura homogênea. Reserve. Em uma frigideira grande, aqueça a manteiga em fogo alto e adicione o ovo batido. Cozinhe, mexendo sem parar, por 3 minutos ou até mudar de consistência e estar totalmente cozido. Retire do fogo, acrescente o requeijão e misture bem. Disponha sobre as fatias de pão e sirva logo em seguida.", 1, "10 minutos", null },
                    { 7, 350, 2, null, "/assets/images/dish/carne_bovina_com_arroz_integral.png", "Carne Bovina com Arroz Integral", "Cozinhe o arroz integral conforme as instruções da embalagem.Enquanto isso, aqueça o azeite em uma frigideira e refogue a cebola e o alho até ficarem macios.Adicione a carne picada e cozinhe até dourar.Tempere com sal e pimenta e sirva com o arroz.", 1, "30 minutos", null },
                    { 8, 224, 2, null, "/assets/images/dish/frango_grelhado_com_batata_doce.png", "Frango Grelhado com Batata Doce", "Tempere o peito de frango com sal, pimenta e ervas finas.Grelhe o frango até estar bem cozido.Cozinhe a batata doce até ficar macia e depois corte em rodelas.Aqueça o azeite em uma frigideira e doure as rodelas de batata doce.", 1, "25 minutos", null },
                    { 9, 200, 2, null, "/assets/images/dish/salmão_assado.png", "Salmão Assado", "Tempere o salmão com azeite, suco de limão, sal, pimenta e ervas frescas.Asse em forno pré-aquecido a 180°C por cerca de 15 minutos ou até o salmão estar completamente cozido.", 1, "20 minutos", null },
                    { 10, 219, 3, null, "/assets/images/dish/macarrao_integral_com_frango_desfiado.png", "Macarrão Integral com Frango Desfiado", "Cozinhe o macarrão integral conforme as instruções da embalagem.Em uma panela, aqueça o azeite e refogue a cebola e o alho até ficarem macios. Adicione o frango desfiado e o molho de tomate. Cozinhe por alguns minutos até que tudo esteja bem misturado e aquecido. Misture o macarrão cozido com o frango e decore com salsinha.", 2, "25 minutos", null },
                    { 11, 153, 3, null, "/assets/images/dish/iscas_de_frango_com_legumes.png", "Iscas de Frango com Legumes", "Aqueça o azeite em uma frigideira e refogue as iscas de frango até dourar.Adicione os pimentões e a cenoura e continue refogando até os legumes estarem macios. Tempere com molho de soja, sal e pimenta a gosto.", 2, "20 minutos", null },
                    { 12, 70, 3, null, "/assets/mages/dish/isalada_colorida_de_legumes.png", "Salada Colorida de Legumes", "Misture todos os legumes em uma tigela. Em uma pequena tigela separada, combine o azeite, suco de limão, sal e pimenta. Regue a salada com o molho e misture bem. Decore com salsinha antes de servir.", 2, "10 minutos", null },
                    { 13, 139, 2, null, "/assets/mages/dish/frango_ao_molho_de_laranja.png", "Frango ao Molho de Laranja", "Tempere o frango com sal e pimenta e cozinhe em uma frigideira com um pouco de óleo até que esteja dourado e cozido por completo.Em uma panela pequena, misture o suco de laranja, molho de soja, mel e alho. Cozinhe em fogo baixo até que o molho reduza e engrosse. Sirva o frango com o molho por cima.", 2, "20 minutos", null },
                    { 14, 45, 2, null, "/assets/mages/dish/panqueca_integral.png", "Panqueca Integral", "Misture todos os ingredientes até formar uma massa homogênea.Aqueça uma frigideira antiaderente e despeje a massa formando pequenas panquecas.Cozinhe por 2-3 minutos de cada lado, ou até que estejam douradas.", 2, "10 minutos", null },
                    { 15, 60, 2, null, "/assets/mages/dish/berinjela_no_forno.png", "Berinjela no Forno", "Preaqueça o forno a 200°C. Coloque as rodelas de berinjela em uma assadeira e regue com azeite.Tempere com orégano, alho em pó, sal e pimenta.Asse por 20-25 minutos, virando as rodelas na metade do tempo, até que estejam macias e levemente douradas.", 2, "30 minutos", null }
                });

            migrationBuilder.InsertData(
                table: "ReceitaIngrediente",
                columns: new[] { "IngredienteId", "ReceitaId", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, "3 unidades" },
                    { 2, 1, "5 unidade" },
                    { 3, 1, "a gosto" },
                    { 4, 1, "1 colher" },
                    { 5, 1, "a gosto" },
                    { 6, 1, "1 unidade" },
                    { 7, 1, "4 unidades" },
                    { 8, 1, "1 unidade" },
                    { 9, 1, "a gosto" },
                    { 10, 2, "1 xícara" },
                    { 11, 2, "¼ xícara" },
                    { 12, 2, "2 colheres " },
                    { 13, 2, "1 colher de sopa " },
                    { 14, 2, "2 colheres de chá" },
                    { 15, 2, "1 ¼ xícara " },
                    { 16, 2, "½ xícara " },
                    { 17, 2, "2 colheres de sopa" },
                    { 18, 2, "1 colher de sopa " },
                    { 11, 3, "1 colher de sopa " },
                    { 19, 3, "350 ml " },
                    { 20, 3, "1 xícara" },
                    { 21, 3, "2 xícaras " },
                    { 22, 3, "½ xícara " },
                    { 23, 3, "2 doses" },
                    { 24, 3, "1 colher de sopa " },
                    { 1, 4, "4 unidades" },
                    { 3, 4, "a gosto " },
                    { 25, 4, "2 fatias " },
                    { 26, 4, "1 unidade" },
                    { 27, 4, "2 colheres de chá " },
                    { 29, 4, "1 colher de chá" },
                    { 1, 5, "2 unidade " },
                    { 10, 5, "½ xícara " },
                    { 30, 5, "2 unidades " },
                    { 31, 5, "1 colher de sopa" },
                    { 32, 5, "1 colher de sopa" },
                    { 1, 6, "5 unidade " },
                    { 25, 6, "5 fatias " },
                    { 27, 6, "1 colher de sopa" },
                    { 33, 6, "3 colheres de sopa  " },
                    { 5, 7, "a gosto" },
                    { 34, 7, "1 unidade" },
                    { 35, 7, "1 xicara" },
                    { 36, 7, "1 unidade" },
                    { 3, 8, "a gosto" },
                    { 29, 8, "1 unidade" },
                    { 37, 8, "1 unidade" },
                    { 38, 8, "2 unidade" },
                    { 3, 9, "a gosto" },
                    { 29, 9, "1 unidade" },
                    { 38, 9, "1 unidade" },
                    { 5, 10, "a gosto" },
                    { 36, 10, "2 unidade" },
                    { 37, 10, "1 unidade" },
                    { 41, 10, "1 unidade" },
                    { 42, 10, "1 unidade" },
                    { 43, 10, "1 unidade" },
                    { 3, 11, "a gosto" },
                    { 29, 11, "a gosto" },
                    { 37, 11, "1 unidade" },
                    { 44, 11, "2 unidade" },
                    { 45, 11, "2 unidade" },
                    { 3, 12, "a gosto" },
                    { 5, 12, "a gosto" },
                    { 29, 12, "a gosto" },
                    { 40, 12, "2 unidade" },
                    { 46, 12, "1 unidade" },
                    { 47, 12, "a gosto" },
                    { 3, 13, "a gosto" },
                    { 29, 13, "a gosto" },
                    { 37, 13, "1 unidade" },
                    { 42, 13, "2 unidades" },
                    { 48, 13, "1 unidade" },
                    { 49, 13, "1 colher" },
                    { 50, 14, "5 unidades" },
                    { 3, 15, "a gosto" },
                    { 5, 15, "a gosto" },
                    { 29, 15, "a gosto" },
                    { 42, 15, "1 unidade" },
                    { 51, 15, "3 unidade" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receita_CategoriaId",
                table: "Receita",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngrediente_IngredienteId",
                table: "ReceitaIngrediente",
                column: "IngredienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ReceitaIngrediente");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Ingrediente");

            migrationBuilder.DropTable(
                name: "Receita");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
