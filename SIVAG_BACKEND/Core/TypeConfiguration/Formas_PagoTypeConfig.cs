using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Formas_PagoTypeConfig : IEntityTypeConfiguration<Formas_PagoDomain>
    {
        public void Configure(EntityTypeBuilder<Formas_PagoDomain> builder)
        {
            builder.ToTable("Formas_Pago");

            builder.HasKey(e => e.Forma_Pago);

            builder.Property(e => e.Forma_Pago)
               .ValueGeneratedNever();

            builder.Property(e => e.Descripcion);

            builder.Property(e => e.Estado);

        }
    }
}
