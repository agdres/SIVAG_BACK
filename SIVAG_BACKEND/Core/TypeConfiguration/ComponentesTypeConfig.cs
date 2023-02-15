using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class ComponentesTypeConfig : IEntityTypeConfiguration<ComponentesDomain>
    {
        public void Configure(EntityTypeBuilder<ComponentesDomain> builder)
        {
            builder.ToTable("Componentes");

            builder.HasKey(e => e.Componente);

            builder.Property(e => e.Componente)
                .ValueGeneratedNever()
                .HasColumnName("Componente");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Estado);
        }
    }
}
