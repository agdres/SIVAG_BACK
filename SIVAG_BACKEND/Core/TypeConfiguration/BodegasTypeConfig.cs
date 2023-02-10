using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class BodegasTypeConfig : IEntityTypeConfiguration<BodegasDomain>
    {
        public void Configure(EntityTypeBuilder<BodegasDomain> builder)
        {
            builder.ToTable("Bodegas");

            builder.HasKey(e => e.Bodega)
                   .HasName("PK__Bodegas__8EC23213C03ED125");

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

            builder.Property(e => e.ID_Empresa).HasColumnName("ID_Empresa");

            builder.Property(e => e.ID_Municipio).HasColumnName("ID_Municipio");

            builder.Property(e => e.Movil)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdEmpresaNavigation)
                .WithMany(p => p.Bodegas)
                .HasForeignKey(d => d.ID_Empresa)
                .HasConstraintName("FK__Bodegas__Estado__75A278F5");

            builder.HasOne(d => d.IdMunicipioNavigation)
                .WithMany(p => p.Bodegas)
                .HasForeignKey(d => d.ID_Municipio)
                .HasConstraintName("FK__Bodegas__ID_Muni__76969D2E");
        }
    }
}
