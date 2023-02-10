using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class PaisesTypeConfig : IEntityTypeConfiguration<PaisesDomain>
    {
        public void Configure(EntityTypeBuilder<PaisesDomain> builder)
        {
            builder.ToTable("Paises");
            builder.HasKey(p => p.Pais);
            builder.Property(p => p.Pais).HasColumnName("Pais").ValueGeneratedOnAdd();
            builder.Property(p => p.Descripcion).HasColumnName("Descripcion").HasMaxLength(50);
            builder.Property(p => p.Alfa_2).HasColumnName("Alfa_2").HasMaxLength(100);
            builder.Property(p => p.Alfa_3).HasColumnName("Alfa_3").HasMaxLength(100);
            builder.Property(p => p.Estado).HasColumnName("Estado");
        }
    }
}
