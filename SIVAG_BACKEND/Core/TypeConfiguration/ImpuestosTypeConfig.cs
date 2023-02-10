using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class ImpuestosTypeConfig : IEntityTypeConfiguration<ImpuestosDomain>
    {
        public void Configure(EntityTypeBuilder<ImpuestosDomain> builder)
        {
            builder.ToTable("Impuestos");

            builder.HasKey(e => e.Impuesto)
                  .HasName("PK__Impuesto__3BE454F25DCBB80E");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Fecha_Implementacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Implementacion");

            builder.Property(e => e.ID_Empresa).HasColumnName("ID_Empresa");

            builder.Property(e => e.Estado).HasColumnName("Estado");


            builder.HasOne(d => d.IdEmpresaNavigation)
                .WithMany(p => p.Impuestos)
                .HasForeignKey(d => d.ID_Empresa)
                .HasConstraintName("FK__Impuestos__Estad__5CD6CB2B");
        }
    }
}
