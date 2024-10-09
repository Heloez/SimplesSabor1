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
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preparo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
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
                    { 2, "cenoura" },
                    { 3, "Azeite de Oliva" },
                    { 4, "Sal" },
                    { 5, "Pimenta" },
                    { 6, "Aveia" },
                    { 7, "Leite Desnatado ou Vegetal" },
                    { 8, "Mel" },
                    { 9, "Frutas" },
                    { 10, "Manteiga de Amendoim" },
                    { 11, "Proteína em Pó" },
                    { 12, "Gelo" },
                    { 13, "Pão Integral" },
                    { 14, "Abacate" },
                    { 15, "Suco de Limão" },
                    { 16, "Farinha de Aveia" },
                    { 17, "Fermento em Pó" },
                    { 18, "Xarope de Bordo" },
                    { 19, "Queijo Cottage" },
                    { 20, "Morangos" },
                    { 21, "Uvas" },
                    { 22, "Melão" },
                    { 23, "Pão Tipo Wrap" },
                    { 24, "Peito de Frango Grelhado" },
                    { 25, "Alface" },
                    { 26, "Maionese Light" },
                    { 27, "Banana" },
                    { 28, "Cacau em Pó" },
                    { 29, "Espinafre" },
                    { 30, "Maçã Verde" },
                    { 31, "Iogurte Natural" },
                    { 32, "Água de Coco" },
                    { 33, "Carne moída" },
                    { 34, "Abóbora" },
                    { 35, "Brócolis" },
                    { 36, "Ervas Finas" },
                    { 37, "Lentilhas" },
                    { 38, "Batata" },
                    { 39, "Caldo de Legumes" },
                    { 40, "Folha de Louro" },
                    { 41, "Pimentão Vermelho" },
                    { 42, "Açafrão" },
                    { 43, "Grão de Bico Cozido" },
                    { 44, "Tomate Cereja" },
                    { 45, "Pepino" },
                    { 46, "Cebola Roxa" },
                    { 47, "Salsinha" },
                    { 48, "Cominho" },
                    { 49, "Filé de Peixe" },
                    { 50, "Lombo de porco" },
                    { 51, "Cebola" },
                    { 52, "Alho picado" },
                    { 53, "Batata doce" },
                    { 57, "Tomilho seco" },
                    { 58, "Peito de frango" },
                    { 59, "Quinoa" },
                    { 60, "Água" },
                    { 61, "Abóbrinha" },
                    { 62, "Pimentão verde" },
                    { 63, "Suco de limão" },
                    { 64, "Carne de boi (patinho ou coxão mole), cortada em cubos" },
                    { 65, "molho de soja" },
                    { 66, "Folha de alface" },
                    { 67, "Berinjela" },
                    { 68, "Vinho tinto" },
                    { 69, "Tomate pelado" },
                    { 70, "Caldo de carne" },
                    { 71, "Azeite de oliva" },
                    { 72, "Folha de louro" },
                    { 73, "Filé de salmão" },
                    { 74, "Suco de laranja" },
                    { 75, "Mel" },
                    { 76, "Gengibre fresco ralado" },
                    { 77, "Amido de milho" },
                    { 78, "Leite" },
                    { 79, "Manteiga" },
                    { 80, "Macarrão integral" },
                    { 81, "Molho de tomate" },
                    { 82, "Queijo parmesão" },
                    { 83, "Arroz integral" },
                    { 84, "Leite de amêndoas" },
                    { 85, "Papaia pequena" },
                    { 86, "Granola" },
                    { 87, "Canela em pó" },
                    { 88, "Maçã" },
                    { 89, "massa de torta integral" },
                    { 90, "tomate" },
                    { 91, "mostarda" },
                    { 92, "wrap integral" },
                    { 93, "coentro" },
                    { 94, "polvilho doce" },
                    { 95, "páprica" },
                    { 96, "pimenta dedo de moça" },
                    { 97, "Peru" },
                    { 98, "farinha integral" },
                    { 99, "óregano" },
                    { 100, "alho em pó" },
                    { 101, "purê de abóbora" },
                    { 102, "gengibre" },
                    { 103, "caldo de frango" },
                    { 104, "macarrão de arroz cozido" },
                    { 105, "atum" },
                    { 106, "azeitonas pretas " },
                    { 107, "vinagre balsâmico" },
                    { 108, "hortelã" },
                    { 109, "ervilha" },
                    { 110, "milho" },
                    { 111, "lasanha integral" },
                    { 112, "farinha de trigo" }
                });

            migrationBuilder.InsertData(
                table: "Receita",
                columns: new[] { "Id", "Calorias", "CategoriaId", "Descricao", "Foto", "Nome", "Preparo", "Rendimento", "TempoPreparo" },
                values: new object[,]
                {
                    { 1, 282, 1, "Prato perfeito para um lanche rápido ou mesmo uma refeição picante. Carne moída, pimentões, temperos e muito queijooooo", "\\img\\receitas\\omelete_de_legumes.png", "Omelete de Legumes", "Comece pela preparação dos ingredientes, pique os pimentões e a cebola em pequenos cubos, se preferir você também pode usar um processador de alimentos.Coloque a carne moída para fritar em uma panela com um pouco de azeite.Quando a carne moída já não estiver mais crua, adicione os pimentões e a cebola, mexendo bem para misturar todos os ingredientes.Aguarde alguns instante e adicione os temperos, mexendo novamente para misturar.Frite por mais alguns minutos a carne com os demais ingredientes.Adicione o Cream Cheese e o Queijo Cheddar, mexendo bem para evitar que queime o fundo e ajudar os queijos a derreterem.Quando os queijos já estiverem bem derretidos e misturados com os demais ingredientes, sirva acompanhado do Pão Sirio ou de Doritos.", 1, "15 minutos" },
                    { 2, 127, 1, "Uma opção saudável e nutritiva para começar o dia.", "\\img\\receitas\\aveia_com_frutas.png", "Aveia com Frutas", "Em uma tigela, misture a aveia com o leite e o mel.Deixe descansar por alguns minutos para a aveia absorver o líquido.Adicione as frutas picadas por cima e sirva.", 1, "10 minutos" },
                    { 3, 162, 4, "Uma bebida energética perfeita para o ganho de massa.", "\\img\\receitas\\smoothie_de_proteina.png", "Smoothie de Proteína", "Coloque todos os ingredientes no liquidificador e bata até obter uma mistura homogênea.Sirva em um copo grande.", 1, "5 minutos" },
                    { 4, 310, 1, "Uma torrada saudável e nutritiva para ganho de massa.", "\\img\\receitas\\torrada_de_abacate.png", "Torrada de Abacate", "Torre as fatias de pão. Amasse o abacate com sal, pimenta e suco de limão.Cozinhe os ovos como desejar (mexido ou pochê) e coloque sobre as torradas com abacate.", 1, "15 minutos" },
                    { 5, 250, 1, "Deliciosas panquecas saudáveis para ganho de massa.", "\\img\\receitas\\panquecas_de_banana.png", "Panquecas de Banana", "Amasse a banana e misture com os ovos.Adicione a aveia e o fermento.Cozinhe em uma frigideira quente até dourar dos dois lados.Sirva com mel ou xarope.", 1, "20 minutos" },
                    { 6, 210, 1, "Simples e nutritivo, ideal para ganho de massa.", "\\img\\receitas\\pao_com_ovos_mexidos.png", "Pão com Ovos Mexidos", "Aqueça a manteiga em uma frigideira, adicione os ovos e mexa até cozinhar.Tempere com sal e pimenta e sirva sobre as fatias de pão torrado.", 1, "10 minutos" },
                    { 7, 151, 1, "Muffins saudáveis e deliciosos, ótimos para ganho de massa.", "\\img\\receitas\\muffin_de_banana.png", "Muffin de Banana", "Amasse a banana e misture com o ovo, a farinha de aveia e o fermento.Divida a massa em forminhas de muffin e asse a 180°C por 15-20 minutos.", 1, "30 minutos" },
                    { 8, 114, 4, "Um batido delicioso e rápido para ganho de massa.", "\\img\\receitas\\batido_de_proteina_de_chocolate.png", "Batido de Proteína de Chocolate", "Bata todos os ingredientes no liquidificador até obter uma textura cremosa.Sirva imediatamente.", 1, "5 minutos" },
                    { 9, 219, 1, "Uma salada fresca e saudável para ganho de massa.", "\\img\\receitas\\salada_de_frutas.png", "Salada de Frutas", "Misture todas as frutas em uma tigela e adicione o queijo cottage por cima.Sirva gelado.", 1, "10 minutos" },
                    { 10, 393, 1, "Um wrap saboroso e nutritivo, ideal para ganho de massa.", "\\img\\receitas\\wrap_de_frango.png", "Wrap de Frango", "Aqueça o pão wrap, coloque o frango grelhado e os vegetais.Adicione a maionese e enrole o wrap.Corte ao meio e sirva.", 1, "15 minutos" },
                    { 11, 198, 4, "Um smoothie saudável e refrescante para ganho de massa.", "\\img\\receitas\\smoothie_verde.png", "Smoothie Verde", "Coloque todos os ingredientes no liquidificador e bata até obter uma mistura homogênea.Sirva imediatamente.", 1, "5 minutos" },
                    { 12, 300, 2, "Uma refeição rica em nutrientes e sabor, perfeita para ganho de massa.", "\\img\\receitas\\quinoa_com_legumes_assados.png", "Quinoa com Legumes Assados", "Cozinhe a quinoa conforme as instruções da embalagem.Enquanto isso, asse os legumes no forno a 200°C com azeite, sal e pimenta até estarem macios.Misture os legumes assados com a quinoa e sirva.", 1, "30 minutos" },
                    { 13, 224, 2, "Frango grelhado com batata doce, uma combinação clássica para ganho de massa.", "\\img\\receitas\\frango_grelhado_com_batata_doce.png", "Frango Grelhado com Batata Doce", "Tempere o peito de frango com sal, pimenta e ervas finas.Grelhe o frango até estar bem cozido.Cozinhe a batata doce até ficar macia e depois corte em rodelas.Aqueça o azeite em uma frigideira e doure as rodelas de batata doce.", 1, "25 minutos" },
                    { 14, 200, 2, "Um prato delicioso e saudável de salmão assado, ideal para ganho de massa.", "\\img\\receitas\\salmão_assado.png", "Salmão Assado", "Tempere o salmão com azeite, suco de limão, sal, pimenta e ervas frescas.Asse em forno pré-aquecido a 180°C por cerca de 15 minutos ou até o salmão estar completamente cozido.", 1, "20 minutos" },
                    { 15, 350, 2, "Um prato nutritivo de carne bovina com arroz integral para ganho de massa.", "\\img\\receitas\\carne_bovina_com_arroz_integral.png", "Carne Bovina com Arroz Integral", "Cozinhe o arroz integral conforme as instruções da embalagem.Enquanto isso, aqueça o azeite em uma frigideira e refogue a cebola e o alho até ficarem macios.Adicione a carne picada e cozinhe até dourar.Tempere com sal e pimenta e sirva com o arroz.", 1, "30 minutos" },
                    { 16, 84, 2, "Uma sopa nutritiva de lentilha com legumes, perfeita para ganho de massa.", "\\img\\receitas\\sopa_de_lentilha.png", "Sopa de Lentilha com Legumes", "Aqueça o azeite em uma panela grande e refogue a cebola e o alho até ficarem macios.Adicione a cenoura, batata, lentilhas e o caldo de legumes.Cozinhe por cerca de 30 minutos ou até que as lentilhas e legumes estejam macios.Tempere com sal, pimenta e a folha de louro. Sirva quente.", 1, "40 minutos" },
                    { 17, 127, 2, "Um prato saudável e saboroso de tofu mexido com legumes, perfeito para ganho de massa.", "\\img\\receitas\\tofu_mexido_com_legumes.png", "Tofu Mexido com Legumes", "Aqueça o azeite em uma frigideira grande e refogue a cebola e o alho até ficarem macios.Adicione o pimentão e cozinhe por mais alguns minutos.Esfarele o tofu e adicione à frigideira, misturando bem.Tempere com sal, pimenta e açafrão. Cozinhe por 10-15 minutos, mexendo ocasionalmente, até o tofu estar levemente dourado.Adicione o espinafre e cozinhe até murchar.", 1, "20 minutos" },
                    { 18, 42, 2, "Uma salada fresca e nutritiva de grão de bico, ideal para ganho de massa.", "\\img\\receitas\\salada_de_grao_de_bico.png", "Salada de Grão de Bico", "Em uma tigela grande, misture o grão de bico, tomate, pepino e cebolaEm uma pequena tigela, combine o azeite, suco de limão, sal e pimenta.Despeje o molho sobre a salada e misture bem.Polvilhe com salsinha picada antes de servir.", 1, "10 minutos" },
                    { 19, 135, 2, "Uma combinação deliciosa e nutritiva de carne moída com abóbora, perfeita para ganho de massa.", "\\img\\receitas\\carne_moida_com_abobora.png", "Carne Moída com Abóbora", "Aqueça o azeite em uma frigideira grande e refogue a cebola e o alho até ficarem macios.Adicione a carne moída e cozinhe até dourar.Adicione a abóbora, sal, pimenta e cominho.Cozinhe até que a abóbora esteja macia e a carne completamente cozida, cerca de 20 minutos.", 1, "30 minutos" },
                    { 20, 249, 2, "Um prato cremoso e delicioso de filé de peixe, ideal para ganho de massa.", "\\img\\receitas\\file_de_peixe_cremoso.png", "Filé de Peixe Cremoso", "Tempere o filé de peixe com suco de limão, sal e pimenta.Aqueça o azeite em uma frigideira e cozinhe o peixe até dourar e estar completamente cozido.Adicione o creme de leite e cozinhe por mais 2-3 minutos, até o molho estar quente e levemente espesso.Sirva imediatamente.", 1, "15 minutos" },
                    { 21, 136, 2, "Lombo de porco cozido lentamente com cebola, alho e caldo de carne.", "\\img\\receitas\\lombo_na_panela.png", "Lombo na Panela", "Aqueça o azeite em uma panela grande e refogue a cebola e o alho até ficarem macios. Adicione o lombo e cozinhe até dourar por todos os lados. Adicione o caldo de carne, sal, pimenta e tomilho. Reduza o fogo e cozinhe por cerca de 20 minutos, ou até o lombo estar bem cozido e macio.", 2, "30 minutos" },
                    { 22, 405, 2, "Carne de boi cozida lentamente com tomate, vinho tinto e especiarias, resultando em um molho encorpado.", "\\img\\receitas\\ragu_de_carne.png", "Ragu de Carne", "Aqueça o azeite em uma panela grande e refogue a cebola e o alho até ficarem macios. Adicione a carne e cozinhe até dourar. Adicione a cenoura e cozinhe por mais alguns minutos. Deglace a panela com o vinho tinto e deixe reduzir. Adicione o tomate pelado, o caldo de carne, sal, pimenta e a folha de louro. Cozinhe em fogo baixo por cerca de 1 hora, ou até a carne estar bem macia e o molho espesso.", 3, "1h 30min" },
                    { 23, 404, 3, "Peito de frango grelhado acompanhado de quinoa e legumes refogados.", "\\img\\receitas\\peito_de_frango_grelhado_com_quinoa.png", "Peito de Frango Grelhado com Quinoa", "Tempere o peito de frango com sal, pimenta e suco de limão. Aqueça o azeite em uma frigideira e grelhe o frango até estar completamente cozido. Cozinhe a quinoa em água conforme as instruções da embalagem. Em uma panela separada, refogue a cebola e o pimentão até amolecer. Misture a quinoa cozida com os legumes refogados. Sirva o peito de frango fatiado sobre a quinoa.", 2, "30 minutos" },
                    { 24, 295, 3, "Filé de salmão grelhado servido com um molho agridoce de laranja e gengibre.", "\\img\\receitas\\salmão_ao_molho_de_laranja.png", "Salmão ao Molho de Laranja", "Tempere o filé de salmão com sal e pimenta.Aqueça o azeite em uma frigideira e cozinhe o salmão por 4-5 minutos de cada lado, ou até estar completamente cozido", 2, "20 minutos" },
                    { 25, 146, 3, "Cubos de carne bovina servidos com um cremoso purê de batata.", "\\img\\receitas\\carne_bovina_com_pure_de_batata.png", "Carne Bovina com Purê de Batata", "Cozinhe as batatas em água salgada até ficarem macias.Escorra e passe as batatas pelo espremedor. Misture a manteiga e o leite até obter um purê liso. Tempere com sal e pimenta. Em uma frigideira, cozinhe a carne até dourar e estar completamente cozida.Sirva a carne com o purê de batata.", 2, "30 minutos" },
                    { 26, 219, 3, "Macarrão integral com frango desfiado e molho de tomate.", "\\img\\receitas\\macarrao_integral_com_frango_desfiado.png", "Macarrão Integral com Frango Desfiado", "Cozinhe o macarrão integral conforme as instruções da embalagem.Em uma panela, aqueça o azeite e refogue a cebola e o alho até ficarem macios. Adicione o frango desfiado e o molho de tomate. Cozinhe por alguns minutos até que tudo esteja bem misturado e aquecido. Misture o macarrão cozido com o frango e decore com salsinha.", 2, "25 minutos" },
                    { 27, 153, 3, "Iscas de frango refogadas com pimentões e cenoura.", "\\img\\receitas\\iscas_de_frango_com_legumes.png", "Iscas de Frango com Legumes", "Aqueça o azeite em uma frigideira e refogue as iscas de frango até dourar.Adicione os pimentões e a cenoura e continue refogando até os legumes estarem macios. Tempere com molho de soja, sal e pimenta a gosto.", 2, "20 minutos" },
                    { 28, 70, 3, "Uma salada leve e refrescante com legumes variados.", "\\img\\receitas\\salada_colorida_de_legumes.png", "Salada Colorida de Legumes", "Misture todos os legumes em uma tigela. Em uma pequena tigela separada, combine o azeite, suco de limão, sal e pimenta. Regue a salada com o molho e misture bem. Decore com salsinha antes de servir.", 2, "10 minutos" },
                    { 29, 255, 3, "Espaguete saudável feito com abobrinhas frescas.", "\\img\\receitas\\espaguete_de_abobrinha.png", "Espaguete de Abobrinha", "Use um espiralizador para transformar as abobrinhas em espaguete. Aqueça o azeite em uma frigideira e refogue o alho até dourar. Adicione o espaguete de abobrinha e cozinhe por 2-3 minutos. Adicione o molho de tomate e cozinhe por mais 2 minutos. Tempere com sal e pimenta a gosto. Sirva com queijo parmesão ralado, se desejar.", 2, "15 minutos" },
                    { 30, 179, 3, "Filé de peixe grelhado servido com arroz integral.", "\\img\\receitas\\peixe_grelhado_com_arroz_integral.png", "Peixe Grelhado com Arroz Integral", "Tempere o filé de peixe com sal, pimenta e suco de limão.Aqueça o azeite em uma frigideira e grelhe o peixe até estar completamente cozido. Cozinhe o arroz integral em água conforme as instruções da embalagem.Sirva o peixe grelhado sobre o arroz integral e decore com ervas finas, se desejar.", 2, "25 minutos" },
                    { 31, 138, 3, "Hambúrguer suculento acompanhado de batata doce assada.", "\\img\\receitas\\hamburguer_de_carne_com_batata_doce_assada.png", "Hambúrguer de Carne com Batata Doce Assada", "Tempere a carne moída com sal e pimenta e modele em formato de hambúrguer.Grelhe em uma frigideira antiaderente até atingir o ponto desejado. Para as batatas, misture com azeite, alho, sal e pimenta e asse em forno pré-aquecido a 200°C por cerca de 20 minutos, ou até ficarem crocantes. Sirva o hambúrguer com a batata doce assada, alface e tomate.", 2, "30 minutos" },
                    { 32, 282, 1, "Uma omelete nutritiva recheada com legumes frescos.", "\\img\\receitas\\omelete_de_legumes.png", "Omelete de Legumes", "Bata os ovos e adicione os legumes picados.Aqueça o azeite em uma frigideira antiaderente e despeje a mistura de ovos e legumes. Cozinhe em fogo médio até que os ovos estejam firmes e os legumes cozidos. Tempere com sal e pimenta a gosto.", 2, "15 minutos" },
                    { 33, 118, 1, "Uma opção saudável e rápida para um lanche.", "\\img\\receitas\\iogurte_natural.png", "Iogurte Natural", "Sirva o iogurte em um pote. Se desejar, adicione mel para adoçar.Acompanhe com frutas frescas de sua escolha.", 1, "5 minutos" },
                    { 34, 240, 1, "Uma torrada nutritiva e deliciosa com abacate.", "\\img\\receitas\\torrada_integral_com_abacate.png", "Torrada Integral com Abacate", "Torre o pão integral.Amasse o abacate e misture com suco de limão, sal e pimenta.Espalhe a mistura de abacate sobre a torrada e, se desejar, adicione uma pitada de pimenta vermelha.", 1, "10 minutos" },
                    { 35, 189, 1, "Uma sobremesa refrescante e leve.", "\\img\\receitas\\creme_de_papaia_com_granola.png", "Creme de Papaia com Granola", "Retire a polpa da papaia e bata no liquidificador até obter um creme.Adicione suco de limão e mel se desejar.Sirva o creme com granola por cima.", 2, "10 minutos" },
                    { 36, 237, 1, "Uma torta de maçã saudável e saborosa.", "\\img\\receitas\\torta_de_maca.png", "Torta de Maçã", "Preaqueça o forno a 180°C. Coloque a massa de torta em uma forma.Misture as maçãs fatiadas com o mel, canela e farinha de aveia.Coloque a mistura sobre a massa e asse por 30-35 minutos, ou até que a torta esteja dourada e as maçãs macias.", 8, "45 minutos" },
                    { 37, 113, 1, "Uma bebida refrescante e rica em proteínas.", "\\img\\receitas\\shake_proteico_de_banana.png", "Shake Proteico de Banana", "Coloque todos os ingredientes no liquidificador e bata até obter uma mistura homogênea. Sirva imediatamente.", 1, "5 minutos" },
                    { 38, 142, 1, "Um taco saudável e saboroso com frango desfiado.", "\\img\\receitas\\taco_de_frango_com_wrap.png", "Taco de Frango com Wrap", "Misture o frango desfiado com cominho, sal e pimenta.Aqueça o wrap em uma frigideira. Coloque o frango, alface, tomate e uma colher de sopa de iogurte grego no wrap. Enrole e sirva.", 1, "10 minutos" },
                    { 39, 108, 1, "Uma sobremesa saudável e simples de fazer.", "\\img\\receitas\\banana_assada_na_airfryer.png", "Banana Assada na Airfryer", "Preaqueça a airfryer a 180°C.Corte a banana em rodelas e coloque na cesta da airfryer. Polvilhe com canela.Asse por 8-10 minutos ou até que a banana esteja caramelizada e macia.", 1, "10 minutos" },
                    { 40, 323, 1, "Um toast nutritivo e delicioso com aveia e ovos.", "\\img\\receitas\\toast_de_aveia_com_ovo_e_espinafre.png", "Toast de Aveia com Ovo e Espinafre", "Torre o pão integral.Em uma frigideira, aqueça o azeite e refogue o espinafre até murchar.Bata os ovos e despeje na frigideira, mexendo até cozinhar. Cozinhe a aveia em água até ficar macia.Monte o toast com a aveia, o ovo e o espinafre sobre o pão.", 2, "15 minutos" },
                    { 41, 302, 1, "Um sanduíche leve e saboroso, perfeito para emagrecimento.", "\\img\\receitas\\sandwich_de_frango_e_cottage.png", "Sanduíche de Frango e Cottage", "Toste o pão integral. Misture o frango desfiado com o queijo cottage.Coloque a mistura no pão, adicione a alface, o tomate e a mostarda. Feche o sanduíche e sirva.", 1, "10 minutos" },
                    { 42, 115, 1, "Um lanche crocante e saudável para petiscar.", "\\img\\receitas\\snack_de_grao_de_bico.png", "Snack de Grão-de-Bico", "Preaqueça o forno a 200°C. Misture o grão-de-bico com azeite, cominho, páprica, sal e pimenta.Espalhe em uma assadeira e asse por 20-25 minutos, ou até que esteja crocante.", 2, "30 minutos" },
                    { 43, 42, 1, "Uma versão saudável do tradicional pão de queijo.", "\\img\\receitas\\pao_de_queijo_fit.png", "Pão de Queijo Fit", "Preaqueça o forno a 180°C. Misture todos os ingredientes até formar uma massa homogênea. Modele pequenas bolinhas e coloque em uma assadeira.Asse por 15-20 minutos, ou até que estejam dourados.", 10, "20 minutos" },
                    { 44, 381, 2, "Um ceviche fresco e saboroso, ideal para emagrecimento.", "\\img\\receitas\\ceviche_de_salmao.png", "Ceviche de Salmão", "Misture o salmão com o suco de limão e deixe marinar por 15-20 minutos.Adicione a cebola, coentro e pimenta. Tempere com sal e pimenta. Sirva imediatamente.", 2, "20 minutos" },
                    { 45, 223, 2, "Um prato nutritivo e leve, com carne e abóbora.", "\\img\\receitas\\carne_moida_com_abobora.png", "Carne Moída com Abóbora", "Aqueça o azeite em uma panela. Refogue a cebola e o alho até ficarem macios.Adicione a carne moída e cozinhe até dourar. Acrescente a abóbora, sal e pimenta, e cozinhe por 15-20 minutos, ou até que a abóbora esteja macia.", 2, "30 minutos" },
                    { 46, 95, 2, "Cestinhas leves de peito de peru, perfeitas para um lanche saudável.", "\\img\\receitas\\cestinha_de_peito_de_peru_com_ovo.png", "Cestinha de Peito de Peru com Ovo", "Coloque as fatias de peito de peru em uma forma de muffin, formando uma cestinha.Quebre um ovo dentro de cada cestinha e tempere com sal e pimenta.Asse a 180°C por 15-20 minutos, até que o ovo esteja cozido.", 1, "20 minutos" },
                    { 47, 60, 2, "Uma receita de ratatouille fácil e saudável, perfeita como acompanhamento.", "\\img\\receitas\\ratatouille_de_forno_simples.png", "Ratatouille de Forno Simples", "Preaqueça o forno a 200°C. Misture todos os vegetais com azeite, sal, pimenta e tomilho.Coloque em uma assadeira e asse por 25-30 minutos, mexendo ocasionalmente, até que os vegetais estejam macios e levemente dourados.", 4, "35 minutos" },
                    { 48, 139, 2, "Frango suculento servido com um molho de laranja refrescante.", "\\img\\receitas\\frango_ao_molho_de_laranja.png", "Frango ao Molho de Laranja", "Tempere o frango com sal e pimenta e cozinhe em uma frigideira com um pouco de óleo até que esteja dourado e cozido por completo.Em uma panela pequena, misture o suco de laranja, molho de soja, mel e alho. Cozinhe em fogo baixo até que o molho reduza e engrosse. Sirva o frango com o molho por cima.", 2, "20 minutos" },
                    { 49, 45, 2, "Panquecas saudáveis e leves, perfeitas para o café da manhã.", "\\img\\receitas\\panqueca_integral.png", "Panqueca Integral", "Misture todos os ingredientes até formar uma massa homogênea.Aqueça uma frigideira antiaderente e despeje a massa formando pequenas panquecas.Cozinhe por 2-3 minutos de cada lado, ou até que estejam douradas.", 2, "10 minutos" },
                    { 50, 60, 2, "Berinjela assada, leve e cheia de sabor.", "\\img\\receitas\\berinjela_no_forno.png", "Berinjela no Forno", "Preaqueça o forno a 200°C. Coloque as rodelas de berinjela em uma assadeira e regue com azeite.Tempere com orégano, alho em pó, sal e pimenta.Asse por 20-25 minutos, virando as rodelas na metade do tempo, até que estejam macias e levemente douradas.", 2, "30 minutos" },
                    { 51, 152, 2, "Uma refeição equilibrada com carne e purê de abóbora.", "\\img\\receitas\\carne_moida_com_legumes_com_pure_de_abobora.png", "Carne Moída com Legumes e Purê de Abóbora", "Em uma frigideira, aqueça o azeite e refogue o alho até dourar.Adicione a carne moída e cozinhe até que esteja bem dourada. Acrescente os legumes e cozinhe até que estejam macios.Sirva com o purê de abóbora por cima.", 2, "30 minutos" },
                    { 52, 60, 3, "Um creme leve e saboroso, ideal para aquecer o corpo.", "\\img\\receitas\\creme_de_abobora.png", "Creme de Abóbora", "Aqueça o azeite em uma panela e refogue a cebola e o alho até que fiquem macios.Adicione a abóbora e o caldo de legumes. Cozinhe até que a abóbora esteja macia.Bata a mistura no liquidificador até obter um creme liso. Ajuste o sal e a pimenta.", 4, "30 minutos" },
                    { 53, 157, 3, "Um creme nutritivo e saboroso, com um toque de gengibre.", "\\img\\receitas\\creme_de_cenoura_e_gengibre_com_frango.png", "Creme de Cenoura e Gengibre com Frango", "Refogue a cebola e o gengibre no azeite até que fiquem macios. Adicione a cenoura e o caldo de frango. Cozinhe até que a cenoura esteja macia.Cozinhe o peito de frango em outra panela e depois desfie. Bata o creme de cenoura e gengibre no liquidificador. Adicione o frango desfiado ao creme e sirva.", 4, "40 minutos" },
                    { 54, 214, 3, "Uma salada refrescante e leve, perfeita para o verão.", "\\img\\receitas\\salada_de_macarrao_de_arroz.png", "Salada de Macarrão de Arroz", "Misture todos os ingredientes em uma tigela grande. Tempere com azeite, vinagre, sal e pimenta. Misture bem e sirva.", 4, "15 minutos" },
                    { 55, 310, 3, "Uma alternativa saudável e deliciosa ao espaguete tradicional.", "\\img\\receitas\\espaguete_de_abobrinha.png", "Espaguete de Abobrinha", "Aqueça o azeite em uma frigideira grande e refogue o alho até que fique aromático.Adicione o espaguete de abobrinha e cozinhe por 5-7 minutos até que esteja al dente.Adicione o molho de tomate e cozinhe por mais 2 minutos. Sirva com queijo parmesão, se desejar.", 2, "15 minutos" },
                    { 56, 192, 3, "Uma lasanha leve e cheia de nutrientes, perfeita para um jantar saudável.", "\\img\\receitas\\lasanha_com_recheio_de_legumes.png", "Lasanha com Recheio de Legumes", "Pré-aqueça o forno a 180°C. Cozinhe as folhas de lasanha conforme as instruções da embalagem. Em uma travessa, coloque uma camada de lasanha, seguida de uma camada de legumes e queijo cottage. Repita as camadas e finalize com molho de tomate. Leve ao forno por 20 minutos.", 2, "30 minutos" },
                    { 57, 200, 3, "Um prato saboroso e saudável, perfeito para aproveitar sobras de frango.", "\\img\\receitas\\arroz_de_forno_integral_com_frango.png", "Arroz de Forno Integral com Frango", "Pré-aqueça o forno a 180°C. Em uma tigela, misture o arroz, frango, milho, ervilha e cenoura. Tempere com sal e pimenta. Transfira para uma assadeira e cubra com queijo ralado. Leve ao forno por 20 minutos.", 4, "30 minutos" },
                    { 58, 77, 3, "Uma receita prática e nutritiva, ideal como lanche ou entrada.", "\\img\\receitas\\kibe_de_carne.png", "Kibe de Carne", "Hidrate o trigo em água por 30 minutos. Misture a carne moída, trigo, cebola e hortelã.Tempere com sal e pimenta. Modele em formato de kibe e coloque em uma assadeira untada com azeite. Asse a 180°C por 20 minutos ou até dourar.", 4, "45 minutos" },
                    { 59, 116, 3, "Uma pizza leve e rápida, ideal para quem busca uma opção saudável.", "\\img\\receitas\\pizza_fit_de_frigideira.png", "Pizza Fit de Frigideira", "Misture a farinha e o ovo até formar uma massa. Aqueça uma frigideira antiaderente e coloque a massa, formando um disco.Cozinhe por 2-3 minutos de cada lado. Adicione o molho de tomate, queijo, tomate, azeitonas e orégano. Tampe e cozinhe por mais 5 minutos.", 2, "15 minutos" },
                    { 60, 135, 3, "Uma alternativa saudável à lasanha tradicional, cheia de sabor.", "\\img\\receitas\\lasanha_de_berinjela.png", "Lasanha de Berinjela", "Pré-aqueça o forno a 180°C. Grelhe as fatias de berinjela até que estejam macias. Em uma travessa, coloque uma camada de berinjela, uma camada de molho de tomate e uma camada de queijo cottage. Repita as camadas e finalize com queijo parmesão. Leve ao forno por 25 minutos.", 4, "40 minutos" }
                });

            migrationBuilder.InsertData(
                table: "ReceitaIngrediente",
                columns: new[] { "IngredienteId", "ReceitaId", "Preparo", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, null, "2 unidades" },
                    { 2, 1, null, "1 unidade ralada" },
                    { 4, 1, null, "A gosto" },
                    { 5, 1, null, "A gosto" },
                    { 6, 1, null, "2 colheres de sopa" },
                    { 7, 1, null, "100ml" },
                    { 71, 1, null, "1 colher de sopa" },
                    { 6, 2, null, "2 colheres de sopa" },
                    { 7, 2, null, "100ml" },
                    { 8, 2, null, "1 colher de chá" },
                    { 9, 2, null, "A gosto" },
                    { 7, 3, null, "200ml" },
                    { 11, 3, null, "1 scoop" },
                    { 12, 3, null, "A gosto" },
                    { 20, 3, null, "5 unidades" },
                    { 75, 3, null, "1 colher de chá" },
                    { 1, 4, null, "2 unidades" },
                    { 4, 4, null, "A gosto" },
                    { 5, 4, null, "A gosto" },
                    { 13, 4, null, "2 fatias" },
                    { 14, 4, null, "1/2 unidade" },
                    { 15, 4, null, "1 colher de chá" },
                    { 1, 5, null, "2 unidades" },
                    { 6, 5, null, "2 colheres de sopa" },
                    { 17, 5, null, "1 colher de chá" },
                    { 18, 5, null, "A gosto" },
                    { 27, 5, null, "1 unidade" },
                    { 1, 6, null, "2 unidades" },
                    { 4, 6, null, "A gosto" },
                    { 5, 6, null, "A gosto" },
                    { 13, 6, null, "2 fatias" },
                    { 79, 6, null, "1 colher de chá" },
                    { 1, 7, null, "1 unidade" },
                    { 16, 7, null, "1/2 xícara" },
                    { 17, 7, null, "1 colher de chá" },
                    { 27, 7, null, "1 unidade" },
                    { 19, 8, null, "200ml" },
                    { 20, 8, null, "A gosto" },
                    { 30, 8, null, "1 scoop" },
                    { 21, 9, null, "1/2 xícara" },
                    { 22, 9, null, "1 unidade" },
                    { 23, 9, null, "1/2 unidade" },
                    { 24, 9, null, "2 colheres de sopa" },
                    { 25, 10, null, "1 unidade" },
                    { 26, 10, null, "100g" },
                    { 27, 10, null, "2 folhas" },
                    { 28, 10, null, "1/2 unidade" },
                    { 29, 10, null, "1 colher de sopa" },
                    { 19, 11, null, "200ml" },
                    { 20, 11, null, "A gosto" },
                    { 31, 11, null, "1 xícara" },
                    { 32, 11, null, "1 unidade" },
                    { 4, 12, null, "A gosto" },
                    { 5, 12, null, "A gosto" },
                    { 33, 12, null, "1/2 xícara" },
                    { 34, 12, null, "1 unidade" },
                    { 35, 12, null, "1/2 unidade" },
                    { 36, 12, null, "1 colher de sopa" },
                    { 4, 13, null, "A gosto" },
                    { 5, 13, null, "A gosto" },
                    { 26, 13, null, "150g" },
                    { 36, 13, null, "1 colher de sopa" },
                    { 37, 13, null, "100g" },
                    { 4, 14, null, "A gosto" },
                    { 5, 14, null, "A gosto" },
                    { 36, 14, null, "1 colher de sopa" },
                    { 38, 14, null, "150g" },
                    { 39, 14, null, "1 colher de sopa" },
                    { 36, 15, null, "1 colher de sopa" },
                    { 40, 15, null, "100g" },
                    { 41, 15, null, "1/2 xícara" },
                    { 42, 15, null, "1/2 unidade" },
                    { 43, 15, null, "1 dente" },
                    { 34, 16, null, "1 unidade" },
                    { 42, 16, null, "1/2 unidade" },
                    { 43, 16, null, "1 dente" },
                    { 44, 16, null, "1/2 xícara" },
                    { 45, 16, null, "1 unidade" },
                    { 46, 16, null, "2 xícaras" },
                    { 5, 17, null, "A gosto" },
                    { 31, 17, null, "1/2 xícara" },
                    { 47, 17, null, "200g" },
                    { 48, 17, null, "1/2 unidade" },
                    { 49, 17, null, "1 colher de chá" },
                    { 28, 18, null, "1 unidade" },
                    { 42, 18, null, "1/4 unidade" },
                    { 50, 18, null, "1/2 xícara" },
                    { 51, 18, null, "1 unidade" },
                    { 40, 19, null, "150g" },
                    { 52, 19, null, "100g" },
                    { 53, 19, null, "1 colher de chá" },
                    { 36, 20, null, "1 colher de sopa" },
                    { 54, 20, null, "150g" },
                    { 55, 20, null, "2 colheres de sopa" },
                    { 4, 21, null, "A gosto" },
                    { 5, 21, null, "A gosto" },
                    { 42, 21, null, "1 unidade" },
                    { 43, 21, null, "2 dentes" },
                    { 56, 21, null, "300g" },
                    { 57, 21, null, "1/2 xícara" },
                    { 58, 21, null, "1 colher de chá" },
                    { 34, 22, null, "1 unidade" },
                    { 40, 22, null, "400g" },
                    { 42, 22, null, "1 unidade" },
                    { 43, 22, null, "2 dentes" },
                    { 57, 22, null, "1 xícara" },
                    { 59, 22, null, "1/2 xícara" },
                    { 60, 22, null, "1 lata" },
                    { 61, 22, null, "1 folha" },
                    { 4, 23, null, "A gosto" },
                    { 5, 23, null, "A gosto" },
                    { 26, 23, null, "200g" },
                    { 39, 23, null, "1 colher de sopa" },
                    { 41, 23, null, "1/2 xícara" },
                    { 42, 23, null, "1/2 unidade" },
                    { 48, 23, null, "1/2 unidade" },
                    { 4, 24, null, "A gosto" },
                    { 5, 24, null, "A gosto" },
                    { 36, 24, null, "1 colher de sopa" },
                    { 38, 24, null, "200g" },
                    { 62, 24, null, "1/4 xícara" },
                    { 63, 24, null, "1 colher de chá" },
                    { 4, 25, null, "A gosto" },
                    { 5, 25, null, "A gosto" },
                    { 40, 25, null, "200g" },
                    { 45, 25, null, "2 unidades" },
                    { 64, 25, null, "2 colheres de sopa" },
                    { 65, 25, null, "1/4 xícara" },
                    { 26, 26, null, "150g" },
                    { 36, 26, null, "1 colher de sopa" },
                    { 42, 26, null, "1 unidade" },
                    { 43, 26, null, "2 dentes" },
                    { 60, 26, null, "1/2 xícara" },
                    { 66, 26, null, "200g" },
                    { 67, 26, null, "A gosto" },
                    { 26, 27, null, "200g" },
                    { 34, 27, null, "1 unidade" },
                    { 36, 27, null, "1 colher de sopa" },
                    { 48, 27, null, "1 unidade" },
                    { 68, 27, null, "1 colher de sopa" },
                    { 34, 28, null, "1 unidade" },
                    { 36, 28, null, "2 colheres de sopa" },
                    { 39, 28, null, "1 colher de sopa" },
                    { 42, 28, null, "1/2 unidade" },
                    { 48, 28, null, "1 unidade" },
                    { 67, 28, null, "A gosto" },
                    { 36, 29, null, "1 colher de sopa" },
                    { 43, 29, null, "2 dentes" },
                    { 49, 29, null, "2 unidades" },
                    { 60, 29, null, "1/2 xícara" },
                    { 69, 29, null, "A gosto" },
                    { 4, 30, null, "A gosto" },
                    { 5, 30, null, "A gosto" },
                    { 36, 30, null, "1 colher de sopa" },
                    { 39, 30, null, "1 colher de sopa" },
                    { 41, 30, null, "1/2 xícara" },
                    { 70, 30, null, "200g" },
                    { 36, 31, null, "1 colher de sopa" },
                    { 40, 31, null, "200g" },
                    { 43, 31, null, "2 dentes" },
                    { 71, 31, null, "2 unidades" },
                    { 72, 31, null, "A gosto" },
                    { 34, 32, null, "1/2 unidade" },
                    { 36, 32, null, "1 colher de sopa" },
                    { 48, 32, null, "1/2 unidade" },
                    { 73, 32, null, "4 unidades" },
                    { 74, 32, null, "1/2 xícara" },
                    { 55, 33, null, "A gosto" },
                    { 75, 33, null, "1 pote" },
                    { 76, 33, null, "A gosto" },
                    { 4, 34, null, "A gosto" },
                    { 5, 34, null, "A gosto" },
                    { 39, 34, null, "1 colher de chá" },
                    { 77, 34, null, "1 fatia" },
                    { 78, 34, null, "1/2 unidade" },
                    { 39, 35, null, "1 colher de sopa" },
                    { 55, 35, null, "A gosto" },
                    { 79, 35, null, "1 unidade" },
                    { 80, 35, null, "2 colheres de sopa" },
                    { 55, 36, null, "2 colheres de sopa" },
                    { 81, 36, null, "1 unidade" },
                    { 82, 36, null, "3 unidades" },
                    { 83, 36, null, "1 colher de chá" },
                    { 84, 36, null, "2 colheres de sopa" },
                    { 85, 37, null, "1 unidade" },
                    { 86, 37, null, "1 scoop" },
                    { 87, 37, null, "200ml" },
                    { 26, 38, null, "100g" },
                    { 72, 38, null, "A gosto" },
                    { 75, 38, null, "1 colher de sopa" },
                    { 88, 38, null, "1 unidade" },
                    { 89, 38, null, "1 colher de chá" },
                    { 83, 39, null, "A gosto" },
                    { 85, 39, null, "1 unidade" },
                    { 36, 40, null, "1 colher de sopa" },
                    { 73, 40, null, "2 unidades" },
                    { 77, 40, null, "2 fatias" },
                    { 90, 40, null, "1 xícara" },
                    { 91, 40, null, "1/4 xícara" },
                    { 26, 41, null, "100g" },
                    { 72, 41, null, "A gosto" },
                    { 77, 41, null, "2 fatias" },
                    { 92, 41, null, "2 colheres de sopa" },
                    { 93, 41, null, "1 fatia" },
                    { 94, 41, null, "A gosto" },
                    { 4, 42, null, "A gosto" },
                    { 5, 42, null, "A gosto" },
                    { 36, 42, null, "2 colheres de sopa" },
                    { 95, 42, null, "1 lata" },
                    { 96, 42, null, "1 colher de chá" },
                    { 97, 42, null, "1 colher de chá" },
                    { 98, 43, null, "100g" },
                    { 99, 43, null, "1 xícara" },
                    { 100, 43, null, "1 unidade" },
                    { 101, 43, null, "1 colher de chá" },
                    { 4, 44, null, "A gosto" },
                    { 5, 44, null, "A gosto" },
                    { 39, 44, null, "1/2 xícara" },
                    { 102, 44, null, "200g" },
                    { 103, 44, null, "1/2 unidade" },
                    { 104, 44, null, "A gosto" },
                    { 4, 45, null, "A gosto" },
                    { 5, 45, null, "A gosto" },
                    { 36, 45, null, "1 colher de sopa" },
                    { 105, 45, null, "300g" },
                    { 106, 45, null, "200g" },
                    { 107, 45, null, "1 unidade" },
                    { 108, 45, null, "2 dentes" },
                    { 4, 46, null, "A gosto" },
                    { 5, 46, null, "A gosto" },
                    { 100, 46, null, "1 unidade" },
                    { 109, 46, null, "4 fatias" },
                    { 4, 47, null, "A gosto" },
                    { 5, 47, null, "A gosto" },
                    { 36, 47, null, "2 colheres de sopa" },
                    { 54, 47, null, "1 unidade" },
                    { 55, 47, null, "1 unidade" },
                    { 56, 47, null, "1 unidade" },
                    { 57, 47, null, "1 unidade" },
                    { 58, 47, null, "A gosto" },
                    { 26, 48, null, "300g" },
                    { 36, 48, null, "1 colher de sopa" },
                    { 39, 48, null, "1/2 xícara" },
                    { 59, 48, null, "2 colheres de sopa" },
                    { 60, 48, null, "1 colher de sopa" },
                    { 61, 48, null, "1 dente" },
                    { 4, 49, null, "1 pitada" },
                    { 62, 49, null, "1 xícara" },
                    { 63, 49, null, "1 xícara" },
                    { 100, 49, null, "1 unidade" },
                    { 4, 50, null, "A gosto" },
                    { 5, 50, null, "A gosto" },
                    { 36, 50, null, "2 colheres de sopa" },
                    { 55, 50, null, "1 unidade" },
                    { 64, 50, null, "1 colher de chá" },
                    { 65, 50, null, "1 colher de chá" },
                    { 4, 51, null, "A gosto" },
                    { 5, 51, null, "A gosto" },
                    { 36, 51, null, "1 colher de sopa" },
                    { 61, 51, null, "1 dente" },
                    { 66, 51, null, "1 xícara" },
                    { 67, 51, null, "1 xícara" },
                    { 105, 51, null, "300g" },
                    { 4, 52, null, "A gosto" },
                    { 5, 52, null, "A gosto" },
                    { 36, 52, null, "1 colher de sopa" },
                    { 61, 52, null, "1 dente" },
                    { 68, 52, null, "300g" },
                    { 69, 52, null, "500ml" },
                    { 70, 52, null, "1 unidade" },
                    { 4, 53, null, "A gosto" },
                    { 5, 53, null, "A gosto" },
                    { 26, 53, null, "200g" },
                    { 36, 53, null, "1 colher de sopa" },
                    { 61, 53, null, "1 dente" },
                    { 69, 53, null, "500ml" },
                    { 70, 53, null, "1 unidade" },
                    { 71, 53, null, "300g" },
                    { 72, 53, null, "1 colher de sopa" },
                    { 1, 54, null, "2 unidades" },
                    { 8, 54, null, "1 colher de sopa" },
                    { 13, 54, null, "100g" },
                    { 32, 54, null, "200ml" },
                    { 60, 54, null, "A gosto" },
                    { 2, 55, null, "2 unidades" },
                    { 12, 55, null, "2 dentes picados" },
                    { 71, 55, null, "1 colher de sopa" },
                    { 81, 55, null, "1/2 xícara" },
                    { 82, 55, null, "A gosto" },
                    { 19, 56, null, "1 xícara" },
                    { 25, 56, null, "1 xícara picada" },
                    { 44, 56, null, "1 xícara" },
                    { 112, 56, null, "2 xícaras (para as folhas de lasanha)" },
                    { 4, 57, null, "A gosto" },
                    { 24, 57, null, "1 xícara desfiado" },
                    { 29, 57, null, "1/2 xícara" },
                    { 83, 57, null, "2 xícaras" },
                    { 110, 57, null, "1/2 xícara" },
                    { 33, 58, null, "500g" },
                    { 37, 58, null, "1/2 xícara" },
                    { 46, 58, null, "1 unidade picada" },
                    { 93, 58, null, "A gosto" },
                    { 21, 59, null, "A gosto" },
                    { 80, 59, null, "1 xícara (massa)" },
                    { 81, 59, null, "1/2 xícara" },
                    { 82, 59, null, "50g" },
                    { 19, 60, null, "1 xícara" },
                    { 67, 60, null, "2 unidades" },
                    { 81, 60, null, "1 xícara" },
                    { 82, 60, null, "50g" }
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
                name: "Usuarios");

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
