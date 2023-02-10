using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class ErroresTypeConfig : IEntityTypeConfiguration<ErroresDomain>
    {
        public void Configure(EntityTypeBuilder<ErroresDomain> builder)
        {
            builder.ToTable("Errores");

            builder.HasKey(e => e.Error)
                                .HasName("PK__Errores__0A2FA2C16A93E9F2");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Fecha_Error)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Error");

            builder.Property(e => e.ID_Componente).HasColumnName("ID_Componente");

            builder.Property(e => e.ID_Usuario).HasColumnName("ID_Usuario");

            builder.Property(e => e.ID_Usuario_Cliente).HasColumnName("ID_Usuario_Cliente");

            builder.Property(e => e.IP)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IP");

            builder.HasOne(d => d.IdComponenteNavigation)
                .WithMany(p => p.Errores)
                .HasForeignKey(d => d.ID_Componente)
                .HasConstraintName("FK__Errores__ID_Comp__208CD6FA");

            builder.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.Errores)
                .HasForeignKey(d => d.ID_Usuario)
                .HasConstraintName("FK__Errores__Fecha_E__1EA48E88");

            builder.HasOne(d => d.IdUsuarioClienteNavigation)
                .WithMany(p => p.Errores)
                .HasForeignKey(d => d.ID_Usuario_Cliente)
                .HasConstraintName("FK__Errores__ID_Usua__1F98B2C1");
        }
    }
}
