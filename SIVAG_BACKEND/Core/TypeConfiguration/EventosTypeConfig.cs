using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class EventosTypeConfig : IEntityTypeConfiguration<EventosDomain>
    {
        public void Configure(EntityTypeBuilder<EventosDomain> builder)
        {
            builder.ToTable("Eventos");

            builder.HasKey(e => e.Evento)
                            .HasName("PK__Eventos__C9A92BAF0E24FC05");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Sucursal);

            builder.Property(e => e.Bodega);

            builder.Property(e => e.Estado);
        }
    }
}
