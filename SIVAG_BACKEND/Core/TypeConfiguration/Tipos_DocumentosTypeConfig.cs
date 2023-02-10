using Microsoft.EntityFrameworkCore;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Tipos_DocumentosTypeConfig : IEntityTypeConfiguration<Tipos_DocumentosDomain>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tipos_DocumentosDomain> builder)
        {
            builder.ToTable("Tipos_Documentos");

            builder.HasKey(e => e.Tipo_Documento)
                   .HasName("PK__Tipos_Do__D5044915670BA329");


            builder.Property(e => e.Tipo_Documento)
                .ValueGeneratedNever()
                .HasColumnName("Tipo_Documento");

            builder.Property(e => e.Abreviatura)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e=> e.Estado);
        }
    }
}
