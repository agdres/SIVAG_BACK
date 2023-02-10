using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class GenerosTypeConfig : IEntityTypeConfiguration<GenerosDomain>
    {
        public void Configure(EntityTypeBuilder<GenerosDomain> builder)
        {
            builder.ToTable("Generos");

            builder.HasKey(e => e.Genero)
                .HasName("PK__Generos__8D08175AF85CE42F");

            builder.Property(e => e.Abreviatura)
                .HasMaxLength(5)
                .IsUnicode(false);

            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Estado);
        }
    }
}
