using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Configuraciones_EmpresasTypeConfig : IEntityTypeConfiguration<Configuraciones_EmpresasDomain>
    {
        public void Configure(EntityTypeBuilder<Configuraciones_EmpresasDomain> builder)
        {
            builder.ToTable("Configuraciones_Empresas");

            builder.HasKey(e => e.Configuracion_Empresa)
                    .HasName("PK__Configur__FE9242E039C8B39B");

            builder.Property(e => e.Control_Inventario).HasColumnName("Control_Inventario");

            builder.Property(e => e.Fecha_Fin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Fin");

            builder.Property(e => e.Fecha_Inicio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Inicio");

            builder.Property(e => e.ID_Empresa).HasColumnName("ID_Empresa");

            builder.Property(e => e.Licenciamiento).IsUnicode(false);

            builder.Property(e => e.Numero_bodegas).HasColumnName("Numero_bodegas");

            builder.Property(e => e.Numero_Sucursales).HasColumnName("Numero_Sucursales");

            builder.Property(e => e.Facturacion);

            builder.Property(e => e.Control_Inventario);

            builder.Property(e => e.WebServices);

            builder.Property(e => e.Autorretenedor);

            builder.Property(e => e.Activacion);

            builder.HasOne(d => d.IdEmpresaNavigation)
                .WithMany(p => p.ConfiguracionesEmpresas)
                .HasForeignKey(d => d.ID_Empresa)
                .HasConstraintName("FK__Configura__Activ__59FA5E80");
        }
    }
}
