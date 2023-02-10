using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class RegistrosTypeConfig : IEntityTypeConfiguration<RegistrosDomain>
    {
        public void Configure(EntityTypeBuilder<RegistrosDomain> builder)
        {
            builder.ToTable("Registros");

            builder.HasKey(e => e.Registro)
                   .HasName("PK__Registro__8C26D26B17B350F8");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Fecha_Registro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Registro");

            builder.Property(e => e.ID_Componente).HasColumnName("ID_Componente");

            builder.Property(e => e.ID_Evento).HasColumnName("ID_Evento");

            builder.Property(e => e.ID_Usuario).HasColumnName("ID_Usuario");

            builder.Property(e => e.ID_Usuario_Cliente).HasColumnName("ID_Usuario_Cliente");

            builder.Property(e => e.IP)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IP");

            builder.HasOne(d => d.IdComponenteNavigation)
                .WithMany(p => p.Registros)
                .HasForeignKey(d => d.ID_Componente)
                .HasConstraintName("FK__Registros__ID_Co__1BC821DD");

            builder.HasOne(d => d.IdEventoNavigation)
                .WithMany(p => p.Registros)
                .HasForeignKey(d => d.ID_Evento)
                .HasConstraintName("FK__Registros__Fecha__18EBB532");

            builder.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.Registros)
                .HasForeignKey(d => d.ID_Usuario)
                .HasConstraintName("FK__Registros__ID_Us__19DFD96B");

            builder.HasOne(d => d.IdUsuarioClienteNavigation)
                .WithMany(p => p.Registros)
                .HasForeignKey(d => d.ID_Usuario_Cliente)
                .HasConstraintName("FK__Registros__ID_Us__1AD3FDA4");
        }
    }
}
