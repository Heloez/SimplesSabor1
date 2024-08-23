using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SimplesSaborMVC.Models;
using SimplesSaborMVC.Data;

public class ImportarReceitas
{
    public static async Task ImportarAsync(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            // Ler o arquivo JSON
            var jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Receitas.json");
            var jsonData = File.ReadAllText(jsonFilePath);

            // Deserializar o JSON
            var receitas = JsonConvert.DeserializeObject<List<ReceitaImportacao>>(jsonData);

            // Verificar se já existem receitas para evitar duplicação
            if (await context.Receitas.AnyAsync())
            {
                Console.WriteLine("Receitas já importadas.");
                return;
            }

            foreach (var receita in receitas)
            {
                // Adicionar a receita ao contexto
                var receitaEntity = new Receita
                {
                    Nome = receita.Nome,
                    CategoriaId = await ObterCategoriaIdAsync(context, receita.Categoria),
                    Tipo = receita.Tipo,
                    Calorias = receita.Calorias,
                    Preparo = receita.ModoPreparo,
                    TempoPreparo = receita.TempoPreparo,
                    Foto = receita.Imagem,
                    Ingredientes = receita.Ingredientes.Select(i => new ReceitaIngrediente
                    {
                        Ingrediente = new Ingrediente { Nome = i }
                    }).ToList()
                };

                await context.Receitas.AddAsync(receitaEntity);
            }

            // Salvar as alterações no banco de dados
            await context.SaveChangesAsync();
        }
    }

    private static async Task<int> ObterCategoriaIdAsync(AppDbContext context, string categoriaNome)
    {
        var categoria = await context.Categorias.FirstOrDefaultAsync(c => c.Nome == categoriaNome);
        if (categoria == null)
        {
            // Crie e adicione a nova categoria se não existir
            categoria = new Categoria { Nome = categoriaNome };
            context.Categorias.Add(categoria);
            await context.SaveChangesAsync();
        }
        return categoria.Id;
    }
}

public class ReceitaImportacao
{
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public string Tipo { get; set; }
    public int Calorias { get; set; }
    public List<string> Ingredientes { get; set; }
    public string ModoPreparo { get; set; }
    public string TempoPreparo { get; set; }
    public string Imagem { get; set; }
}
