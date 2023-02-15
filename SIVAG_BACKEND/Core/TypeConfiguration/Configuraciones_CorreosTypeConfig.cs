using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Configuraciones_CorreosTypeConfig : IEntityTypeConfiguration<Configuraciones_CorreosDomain>
    {
        public void Configure(EntityTypeBuilder<Configuraciones_CorreosDomain> builder)
        {
            builder.ToTable("Configuraciones_Correos");

            builder.HasKey(e => e.Configuracion_Correo);

            builder.Property(e => e.Cifrado_SSL).HasColumnName("Cifrado_SSL");

            builder.Property(e => e.Clave)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Correo)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.ID_Sucursal).HasColumnName("ID_Sucursal");

            builder.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Servidor)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Puesto);

            builder.HasOne(d => d.IdSucursalNavigation)
                .WithMany(p => p.ConfiguracionesCorreos)
                .HasForeignKey(d => d.ID_Sucursal);
        }
    }
}
