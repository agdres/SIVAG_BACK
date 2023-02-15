using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Configuraciones_DIANTypeConfig : IEntityTypeConfiguration<Configuraciones_DIANDomain>
    {
        public void Configure(EntityTypeBuilder<Configuraciones_DIANDomain> builder)
        {
            builder.ToTable("Configuraciones_DIAN");

            builder.HasKey(e => e.Configuracion_DIAN);

builder.Property(e => e.Clave)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Codigo_Software)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Codigo_Software");

            builder.Property(e => e.ID_Empresa).HasColumnName("ID_Empresa");

            builder.Property(e => e.Pin_Software)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Pin_Software");

            builder.Property(e => e.Pruebas)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.HasOne(d => d.IdEmpresaNavigation)
                .WithMany(p => p.ConfiguracionesDians)
                .HasForeignKey(d => d.ID_Empresa);
        }
    }
}
