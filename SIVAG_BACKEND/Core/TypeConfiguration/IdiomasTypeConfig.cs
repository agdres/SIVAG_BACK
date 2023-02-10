using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class IdiomasTypeConfig : IEntityTypeConfiguration<IdiomasDomain>
    {
        public void Configure(EntityTypeBuilder<IdiomasDomain> builder)
        {
            builder.ToTable("Idiomas");


            builder.HasKey(e => e.Idioma)
                   .HasName("PK__Idiomas__5E5EDE4B69B4080F");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);


            builder.Property(e => e.ISO_639_1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ISO_639_1");

            builder.Property(e => e.ISO_639_2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ISO_639_2");

            builder.Property(e => e.Estado)
                .HasColumnName("Estado");

        }
    }
}
