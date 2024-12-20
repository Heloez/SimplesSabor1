using SimplesSaborMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SimplesSaborMVC.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
        
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Ingrediente> Ingredientes { get; set; }
    public DbSet<Receita> Receitas { get; set; }
    public DbSet<ReceitaIngrediente> ReceitaIngredientes { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed seed = new(builder);

        builder.Entity<ReceitaIngrediente>()
            .HasKey(ri => new { ri.ReceitaId, ri.IngredienteId });

        builder.Entity<ReceitaIngrediente>()
            .HasOne(ri => ri.Receita)
            .WithMany(r => r.Ingredientes)
            .HasForeignKey(ri => ri.ReceitaId);

        builder.Entity<ReceitaIngrediente>()
            .HasOne(ri => ri.Ingrediente)
            .WithMany(i => i.Receitas)
            .HasForeignKey(ri => ri.IngredienteId);

    }
}