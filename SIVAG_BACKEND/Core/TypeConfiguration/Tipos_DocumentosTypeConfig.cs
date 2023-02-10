using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Tipos_DocumentosTypeConfig : IEntityTypeConfiguration<Tipos_DocumentosDomain>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tipos_DocumentosDomain> builder)
        {
            builder.ToTable("Tipos_Documentos");
            builder.HasKey(x => x.Tipo_Documento);

            builder.Property(x => x.Tipo_Documento).HasColumnName("Tipo_Documento").ValueGeneratedNever();
            builder.Property(x => x.Descripcion).HasColumnName("Descripcion").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Abreviatura).HasColumnName("Abreviatura").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Estado).HasColumnName("Estado").HasDefaultValue(false).IsRequired();
        }
    }
}
