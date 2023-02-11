using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class MunicipiosTypeConfig : IEntityTypeConfiguration<MunicipiosDomain>
    {
        public void Configure(EntityTypeBuilder<MunicipiosDomain> builder)
        {
            builder.ToTable("Municipios");

            builder.HasKey(e => e.Municipio)
                    .HasName("PK__Municipi__C023EB10EFABB625");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.ID_Departamento).HasColumnName("ID_Departamento");

            builder.Property(e => e.Zonapostal)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdDepartamentoNavigation)
                .WithMany(p => p.Municipios)
                .HasForeignKey(d => d.ID_Departamento)
                .HasConstraintName("FK__Municipio__Estad__46E78A0C");
        }
    }
}
