using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Parametrizaciones_SucursalesTypeConfig : IEntityTypeConfiguration<Parametrizaciones_SucursalesDomain>
    {
        public void Configure(EntityTypeBuilder<Parametrizaciones_SucursalesDomain> builder)
        {
            builder.ToTable("Parametrizaciones_Sucursales");

            builder.HasKey(e => e.Parametrizacion_Sucursal)
                    .HasName("PK__Parametr__119889C99FD55017");


            builder.Property(e => e.Consecutivo_Devolucion_E).HasColumnName("Consecutivo_Devolucion_E");

            builder.Property(e => e.Consecutivo_Devolucion_S).HasColumnName("Consecutivo_Devolucion_S");

            builder.Property(e => e.Consecutivo_Entrega).HasColumnName("Consecutivo_Entrega");

            builder.Property(e => e.Consecutivo_Solicitudes).HasColumnName("Consecutivo_Solicitudes");

            builder.Property(e => e.ID_Sucursal).HasColumnName("ID_Sucursal");

            builder.Property(e => e.Inventario_Inicial).HasColumnName("Inventario_Inicial");

            builder.Property(e => e.Prefijo_Devolucion_E)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Prefijo_Devolucion_E");

            builder.Property(e => e.Prefijo_Devolucion_S)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Prefijo_Devolucion_S");

            builder.Property(e => e.Prefijo_Entrega)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Prefijo_Entrega");

            builder.Property(e => e.Prefijo_Solicitudes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Prefijo_Solicitudes");

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdSucursalNavigation)
                .WithMany(p => p.ParametrizacionesSucursales)
                .HasForeignKey(d => d.ID_Sucursal)
                .HasConstraintName("FK__Parametri__Estad__70DDC3D8");
        }
    }
}
