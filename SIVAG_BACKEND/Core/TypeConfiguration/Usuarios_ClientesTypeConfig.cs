using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Usuarios_ClientesTypeConfig : IEntityTypeConfiguration<Usuarios_ClientesDomain>
    {
        public void Configure(EntityTypeBuilder<Usuarios_ClientesDomain> builder)
        {
            builder.ToTable("Usuarios_Clientes");

            builder.HasKey(e => e.Usuario_Cliente)
                   .HasName("PK__Usuarios__92CD01594239E3C7");

            builder.Property(e => e.Clave)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Clave_Temporal)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Clave_Temporal");

            builder.Property(e => e.Fecha_Creacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Creacion");

            builder.Property(e => e.ID_Persona).HasColumnName("ID_Persona");

            builder.Property(e => e.ID_Rol).HasColumnName("ID_Rol");

            builder.Property(e => e.ID_Sucursal).HasColumnName("ID_Sucursal");

            builder.Property(e => e.Nombre_Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nombre_Usuario");

            builder.Property(e => e.Tiempo_Recupera).HasColumnName("Tiempo_Recupera");

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdPersonaNavigation)
                .WithMany(p => p.UsuariosClientes)
                .HasForeignKey(d => d.ID_Persona)
                .HasConstraintName("FK__Usuarios___ID_Pe__1332DBDC");

            builder.HasOne(d => d.IdRolNavigation)
                .WithMany(p => p.UsuariosClientes)
                .HasForeignKey(d => d.ID_Rol)
                .HasConstraintName("FK__Usuarios___ID_Ro__14270015");

            builder.HasOne(d => d.IdSucursalNavigation)
                .WithMany(p => p.UsuariosClientes)
                .HasForeignKey(d => d.ID_Sucursal)
                .HasConstraintName("FK__Usuarios___Estad__123EB7A3");
        }
    }
}
