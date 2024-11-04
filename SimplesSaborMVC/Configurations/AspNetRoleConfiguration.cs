using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace SimplesSaborMVC.Data.Configurations
{
    public class AspNetRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            // Ajuste o tipo de dados para nvarchar(max)
            builder.Property(r => r.ConcurrencyStamp).HasColumnType("nvarchar(max)");
        }
    }
}
