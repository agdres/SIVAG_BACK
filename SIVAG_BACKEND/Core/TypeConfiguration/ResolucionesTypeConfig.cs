using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class ResolucionesTypeConfig : IEntityTypeConfiguration<ResolucionesDomain>
    {
        public void Configure(EntityTypeBuilder<ResolucionesDomain> builder)
        {
            builder.ToTable("Resoluciones");

            builder.HasKey(e => e.Resolucion)
                   .HasName("PK__Resoluci__BEC38D54FBB27AB2");

            builder.Property(e => e.Autorizacion)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Clave)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Fecha_Creacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Creacion");

            builder.Property(e => e.Fecha_Expiracion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Expiracion");

            builder.Property(e => e.Fecha_Inactivacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Inactivacion");

            builder.Property(e => e.Fecha_Registro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Registro");

            builder.Property(e => e.ID_Sucursal).HasColumnName("ID_Sucursal");

            builder.Property(e => e.Prefijo)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Ran_Maximo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ran_Maximo");

            builder.Property(e => e.Ran_Minimo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ran_Minimo");

            builder.Property(e => e.Consecutivo);

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdSucursalNavigation)
                .WithMany(p => p.Resoluciones)
                .HasForeignKey(d => d.ID_Sucursal)
                .HasConstraintName("FK__Resolucio__Estad__6B24EA82");
        }
    }
}
