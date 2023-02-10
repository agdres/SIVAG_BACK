using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Parametrizaciones_BodegasTypeConfig : IEntityTypeConfiguration<Parametrizaciones_BodegasDomain>
    {
        public void Configure(EntityTypeBuilder<Parametrizaciones_BodegasDomain> builder)
        {
            builder.ToTable("Parametrizaciones_Bodegas");

            builder.HasKey(e => e.Parametrizacion_Bodega);

            builder.Property(e => e.Consecutivo_Pedido).HasColumnName("Consecutivo_Pedido");

            builder.Property(e => e.ID_Bodega).HasColumnName("ID_Bodega");

            builder.Property(e => e.INV_Inicial).HasColumnName("INV_Inicial");

            builder.Property(e => e.Prefijo_Pedido)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Prefijo_Pedido");

            builder.Property(e => e.Trazlado_Consecutivo).HasColumnName("Trazlado_Consecutivo");

            builder.Property(e => e.Trazlado_Prefijo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Trazlado_Prefijo");

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdBodegaNavigation)
                .WithMany(p => p.ParametrizacionesBodegas)
                .HasForeignKey(d => d.ID_Bodega);
        }
    }
}
