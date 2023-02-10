using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Sucursales_PersonasTypeConfig : IEntityTypeConfiguration<Sucursales_PersonasDomain>
    {
        public void Configure(EntityTypeBuilder<Sucursales_PersonasDomain> builder)
        {
            builder.ToTable("Sucursales_Personas");

            builder.HasKey(e => e.Sucursal_Persona)
                   .HasName("PK__Sucursal__4229CFAFABF20C2C");

            builder.Property(e => e.Correo)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Fecha_Registro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Registro");

            builder.Property(e => e.ID_Persona).HasColumnName("ID_Persona");

            builder.Property(e => e.ID_Sucursal).HasColumnName("ID_Sucursal");

            builder.Property(e => e.Movil)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Estado);

            builder.Property(e => e.Cliente);

            builder.Property(e => e.Proveedor);

            builder.Property(e => e.Tipo_Persona).HasColumnName("Tipo_Persona");

            builder.HasOne(d => d.IdPersonaNavigation)
                .WithMany(p => p.SucursalesPersonas)
                .HasForeignKey(d => d.ID_Persona)
                .HasConstraintName("FK__Sucursale__ID_Pe__68487DD7");

            builder.HasOne(d => d.IdSucursalNavigation)
                .WithMany(p => p.SucursalesPersonas)
                .HasForeignKey(d => d.ID_Sucursal)
                .HasConstraintName("FK__Sucursale__Prove__6754599E");
        }
    }
}
