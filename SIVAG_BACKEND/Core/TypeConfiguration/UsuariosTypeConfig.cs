using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class UsuariosTypeConfig : IEntityTypeConfiguration<UsuariosDomain>
    {
        public void Configure(EntityTypeBuilder<UsuariosDomain> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(e => e.Usuario);

            builder.HasIndex(e => e.Nombre_Usuario).IsUnique();

            builder.Property(e => e.Clave);

            builder.Property(e => e.Clave_Temporal);

            builder.Property(e => e.Fecha_Creacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Creacion");

            builder.Property(e => e.ID_Empleado).HasColumnName("ID_Empleado");

            builder.Property(e => e.ID_Rol).HasColumnName("ID_Rol");

            builder.Property(e => e.Nombre_Usuario);

            builder.Property(e => e.Tiempo_Recupera).HasColumnName("Tiempo_Recupera");

            builder.Property(e => e.Principal);

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdEmpleadoNavigation)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.ID_Empleado);

            builder.HasOne(d => d.IdRolNavigation)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.ID_Rol);
        }
    }
}
