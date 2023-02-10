using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class MonedasTypeConfig : IEntityTypeConfiguration<MonedasDomain>
    {
        public void Configure(EntityTypeBuilder<MonedasDomain> builder)
        {
            builder.ToTable("Monedas");

            builder.HasKey(x => x.Moneda);

            builder.Property(x => x.ID_Pais)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Simbolo)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Estado)
                .IsRequired();

            builder.HasOne(x => x.Pais)
                .WithMany(x => x.Moneda)
                .HasForeignKey(x => x.ID_Pais);
        }
    }
}
