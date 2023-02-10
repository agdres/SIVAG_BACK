using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Regimen_FiscalesTypeConfig : IEntityTypeConfiguration<Regimen_FiscalesDomain>
    {
        public void Configure(EntityTypeBuilder<Regimen_FiscalesDomain> builder)
        {
            builder.ToTable("Regimen_Fiscales");
            builder.HasKey(e => e.RegimenFiscal)
                .HasName("PK__Regimen___39F389C1F51CF7FB");

            builder.Property(e => e.RegimenFiscal).ValueGeneratedNever();

            builder.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Estado);
        }
    }
}
