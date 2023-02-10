
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
            builder.HasKey(x => x.Mensaje);

            builder.Property(x => x.Mensaje)
                .HasColumnName("Mensaje")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Titulo)
                .HasColumnName("Titulo")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasColumnName("Descripción")
                .HasMaxLength(int.MaxValue)
                .IsRequired();

            builder.Property(x => x.Estado)
                .HasColumnName("Estado")
                .IsRequired();
        }
    }
}
