using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class RolesTypeConfig : IEntityTypeConfiguration<RolesDomain>
    {
        public void Configure(EntityTypeBuilder<RolesDomain> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(e => e.Rol)
                    .HasName("PK__Roles__CAF00515DA01DC22");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ID_Bodega).HasColumnName("ID_Bodega");

            builder.Property(e => e.ID_Empresa).HasColumnName("ID_Empresa");

            builder.Property(e => e.ID_Sucursal).HasColumnName("ID_Sucursal");

            builder.Property(e => e.Compartido);

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdBodegaNavigation)
                .WithMany(p => p.Roles)
                .HasForeignKey(d => d.ID_Bodega)
                .HasConstraintName("FK__Roles__ID_Bodega__07C12930");

            builder.HasOne(d => d.IdEmpresaNavigation)
                .WithMany(p => p.Roles)
                .HasForeignKey(d => d.ID_Empresa)
                .HasConstraintName("FK__Roles__Estado__05D8E0BE");

            builder.HasOne(d => d.IdSucursalNavigation)
                .WithMany(p => p.Roles)
                .HasForeignKey(d => d.ID_Sucursal)
                .HasConstraintName("FK__Roles__ID_Sucurs__06CD04F7");
        }
    }
}
