using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Responsabilidades_FiscalesTypeConfig : IEntityTypeConfiguration<Responsabilidades_FiscalesDomain>
    {
        public void Configure(EntityTypeBuilder<Responsabilidades_FiscalesDomain> builder)
        {
            builder.ToTable("Responsabilidades_Fiscales");
            builder.HasKey(x => x.Responsabilidad_Fiscal);
            builder.Property(x => x.Responsabilidad_Fiscal).HasColumnName("Responsabilidad_Fiscal").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("Descripcion").HasMaxLength(10);
            builder.Property(x => x.Codigo).HasColumnName("Codigo").HasMaxLength(200);
            builder.Property(x => x.Estado).HasColumnName("Estado");
        }
    
    }
}
