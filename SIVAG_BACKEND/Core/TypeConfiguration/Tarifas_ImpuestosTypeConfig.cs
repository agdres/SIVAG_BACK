using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Tarifas_ImpuestosTypeConfig : IEntityTypeConfiguration<Tarifas_ImpuestosDomain>
    {
        public void Configure(EntityTypeBuilder<Tarifas_ImpuestosDomain> builder)
        {
            builder.ToTable("Tarifas_Impuestos");

            builder.HasKey(e => e.Tarifa_Impuesto)
                   .HasName("PK__Tarifas___F2504F4D8E23F405");

            builder.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.ID_Impuesto).HasColumnName("ID_Impuesto");

            builder.Property(e => e.Maximo).HasColumnType("money");

            builder.Property(e => e.Minimo).HasColumnType("money");

            builder.Property(e => e.Valor).HasColumnType("money");

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdImpuestoNavigation)
                .WithMany(p => p.TarifasImpuestos)
                .HasForeignKey(d => d.ID_Impuesto)
                .HasConstraintName("FK__Tarifas_I__Estad__5FB337D6");
        }
    }
}
