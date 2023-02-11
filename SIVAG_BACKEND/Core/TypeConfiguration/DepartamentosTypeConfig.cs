using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class DepartamentosTypeConfig : IEntityTypeConfiguration<DepartamentosDomain>
    {
        public void Configure(EntityTypeBuilder<DepartamentosDomain> builder)
        {
            builder.ToTable("Departamentos");

            builder.HasKey(e => e.Departamento)
                   .HasName("PK__Departam__71BEBBD69B66FBE9");

            builder.Property(e => e.Codigo_ISO)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Codigo_ISO");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.ID_Pais).HasColumnName("ID_Pais");

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdPaisNavigation)
                .WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.ID_Pais)
                .HasConstraintName("FK__Departame__Estad__440B1D61");
        }
    }
}
