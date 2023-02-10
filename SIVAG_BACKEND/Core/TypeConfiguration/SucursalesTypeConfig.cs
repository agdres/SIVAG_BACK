using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class SucursalesTypeConfig : IEntityTypeConfiguration<SucursalesDomain>
    {
        public void Configure(EntityTypeBuilder<SucursalesDomain> builder)
        {
            builder.ToTable("Sucursales");

            builder.HasKey(e => e.Sucursal)
                   .HasName("PK__Sucursal__25B372A064BC9FC6");

            builder.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);

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

            builder.Property(e => e.Foto).HasColumnType("image");

            builder.Property(e => e.ID_Empresa).HasColumnName("ID_Empresa");

            builder.Property(e => e.ID_Municipio).HasColumnName("ID_Municipio");

            builder.Property(e => e.ID_TarifaImpuesto_ICA).HasColumnName("ID_TarifaImpuesto_ICA");

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
                .WithMany(p => p.Sucursales)
                .HasForeignKey(d => d.ID_Empresa)
                .HasConstraintName("FK__Sucursale__Estad__628FA481");

            builder.HasOne(d => d.IdMunicipioNavigation)
                .WithMany(p => p.Sucursales)
                .HasForeignKey(d => d.ID_Municipio)
                .HasConstraintName("FK__Sucursale__ID_Mu__6383C8BA");

            builder.HasOne(d => d.IdTarifaImpuestoIcaNavigation)
                .WithMany(p => p.Sucursales)
                .HasForeignKey(d => d.ID_TarifaImpuesto_ICA)
                .HasConstraintName("FK__Sucursale__ID_Ta__6477ECF3");
        }
    }
}
