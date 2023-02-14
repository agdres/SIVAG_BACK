using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Monedas_PaisesTypeConfig : IEntityTypeConfiguration<Monedas_PaisesDomain>
    {
        public void Configure(EntityTypeBuilder<Monedas_PaisesDomain> builder)
        {
            builder.ToTable("Monedas_Paises");

            builder.HasKey(e => e.Moneda_Pais);

            builder.Property(e => e.ID_Pais);

            builder.Property(e => e.ID_Moneda);

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdPaisNavigation)
              .WithMany(p => p.MonedaPais)
              .HasForeignKey(d => d.ID_Pais);

            builder.HasOne(d => d.IdMonedaNavigation)
              .WithMany(p => p.MonedaPais)
              .HasForeignKey(d => d.ID_Moneda);
        }
    }
}
