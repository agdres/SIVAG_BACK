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

            builder.HasKey(e => e.Responsabilidad_Fiscal)
                   .HasName("PK__Responsa__2EBF635EF46045D9");


            builder.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Estado);

        }

    }
}
