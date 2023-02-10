using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class PermisosTypeConfig : IEntityTypeConfiguration<PermisosDomain>
    {
        public void Configure(EntityTypeBuilder<PermisosDomain> builder)
        {
            builder.ToTable("Permisos");

            builder.HasKey(e => e.Permiso)
                     .HasName("PK__Permisos__4DAF40C08A25F0A7");

            builder.Property(e => e.Enviar_MsgBod).HasColumnName("Enviar_MsgBod");

            builder.Property(e => e.ID_Componente).HasColumnName("ID_Componente");

            builder.Property(e => e.ID_Rol).HasColumnName("ID_Rol");

            builder.Property(e => e.Crear);

            builder.Property(e => e.Listar);

            builder.Property(e => e.Actualizar);

            builder.Property(e => e.Deshabilitar);

            builder.Property(e => e.Recibir_MsgBod).HasColumnName("Recibir_MsgBod");

            builder.Property(e => e.S_Enviar_MsgBod).HasColumnName("S_Enviar_MsgBod");

            builder.Property(e => e.S_Recibir_MsgBod).HasColumnName("S_Recibir_MsgBod");

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdComponenteNavigation)
                .WithMany(p => p.Permisos)
                .HasForeignKey(d => d.ID_Componente)
                .HasConstraintName("FK__Permisos__ID_Com__0B91BA14");

            builder.HasOne(d => d.IdRolNavigation)
                .WithMany(p => p.Permisos)
                .HasForeignKey(d => d.ID_Rol)
                .HasConstraintName("FK__Permisos__Estado__0A9D95DB");
        }
    }
}
