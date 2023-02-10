
using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class MensajesTypeConfig : IEntityTypeConfiguration<MensajesDomain>
    {
        public void Configure(EntityTypeBuilder<MensajesDomain> builder)
        {
            builder.ToTable("Mensajes");

            builder.HasKey(e => e.Mensaje)
                .HasName("PK__Mensajes__217DDC4601301B46");

            builder.Property(e => e.Descripcion).HasColumnName("Descripcion").IsUnicode(false);

            builder.Property(e => e.Titulo)
                .HasColumnName("Titulo")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Estado).HasColumnName("Estado");
        }
    }
}
