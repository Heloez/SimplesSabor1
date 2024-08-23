using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimplesSaborMVC.Models;

namespace SimplesSaborMVC.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tipo> Tipos { get; set; }
    public DbSet<Ingrediente> Ingredientes { get; set; }
    public DbSet<Receita> Receitas { get; set; }
    public DbSet<ReceitaIngrediente> ReceitaIngredientes { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Configura a chave primária composta para ReceitaIngrediente
        builder.Entity<ReceitaIngrediente>()
            .HasKey(ri => new { ri.ReceitaId, ri.IngredienteId });

        // Configura relacionamentos entre Receita e Ingrediente
        builder.Entity<Receita>()
            .HasMany(r => r.Ingredientes)
            .WithOne()
            .HasForeignKey(ri => ri.ReceitaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Ingrediente>()
            .HasMany(i => i.Receitas)
            .WithOne()
            .HasForeignKey(ri => ri.IngredienteId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configura a relação entre Receita e Categoria
        builder.Entity<Receita>()
            .HasOne(r => r.Categoria)
            .WithMany()
            .HasForeignKey(r => r.CategoriaId);

        // Configura a relação entre Receita e Tipo (se necessário)
        // Se a propriedade Tipo em Receita não for um relacionamento, remova a configuração abaixo
        builder.Entity<Receita>()
            .HasOne(r => r.Tipo)
            .WithMany()
            .HasForeignKey(r => r.TipoId);
    }
}