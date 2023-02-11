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


            builder.HasKey(e => e.Pais)
                    .HasName("PK__Paises__A15FFF7CEBE1CF56");

            builder.Property(e => e.Alfa_2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Alfa_2");

            builder.Property(e => e.Alfa_3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Alfa_3");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Estado).HasColumnName("Estado");

        }
    }
}
