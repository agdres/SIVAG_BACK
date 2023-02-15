using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Medios_PagoTypeConfig : IEntityTypeConfiguration<Medios_PagoDomain>
    {
        public void Configure(EntityTypeBuilder<Medios_PagoDomain> builder)
        {
            builder.ToTable("Medios_Pago");

            builder.HasKey(e => e.Medio_Pago);

            builder.Property(e => e.Medio_Pago)
               .ValueGeneratedNever();

            builder.Property(e => e.Descripcion);

            builder.Property(e => e.Estado);
        }
    }
}
