using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Paises_IdiomasTypeConfig : IEntityTypeConfiguration<Paises_IdiomasDomain>
    {
        public void Configure(EntityTypeBuilder<Paises_IdiomasDomain> builder)
        {
            builder.ToTable("Paises_Idiomas");

            builder.HasKey(e => e.Pais_Idioma);

            builder.Property(e => e.ID_Pais).HasColumnName("ID_Pais");

            builder.Property(e => e.ID_Idioma).HasColumnName("ID_Idioma");

            builder.Property(e => e.Estado).HasColumnName("Estado");

            builder.HasOne(d => d.IdPaisNavigation)
                .WithMany(p => p.Idiomas_Paises)
                .HasForeignKey(d => d.ID_Pais);

            builder.HasOne(d => d.IdIdiomaNavigation)
                .WithMany(p => p.Idiomas_Paises)
                .HasForeignKey(d => d.ID_Idioma);
        }
    }
}
