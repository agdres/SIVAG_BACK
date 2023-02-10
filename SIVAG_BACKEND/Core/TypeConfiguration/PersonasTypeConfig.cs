using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class PersonasTypeConfig : IEntityTypeConfiguration<PersonasDomain>
    {
        public void Configure(EntityTypeBuilder<PersonasDomain> builder)
        {

            builder.ToTable("Personas");

            builder.HasKey(e => e.Persona)
                    .HasName("PK__Personas__BDC5F71CCEE2692B");


            builder.Property(e => e.DV)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DV")
                .IsFixedLength(true);

            builder.Property(e => e.Fecha_Registro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Registro");

            builder.Property(e => e.ID_Municipio).HasColumnName("ID_Municipio");

            builder.Property(e => e.ID_Regimen_Fiscal).HasColumnName("ID_Regimen_Fiscal");

            builder.Property(e => e.ID_Tipo_Documento).HasColumnName("ID_Tipo_Documento");

            builder.Property(e => e.Nombre_Comercial)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Nombre_Comercial");

            builder.Property(e => e.Nombre_Empresa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Nombre_Empresa");

            builder.Property(e => e.Numero_Documento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Numero_Documento");

            builder.Property(e => e.Primer_Apellido)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Primer_Apellido");

            builder.Property(e => e.Primer_Nombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Primer_Nombre");

            builder.Property(e => e.Segundo_Apellido)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Segundo_Apellido");

            builder.Property(e => e.Segundo_Nombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Segundo_Nombre");

            builder.Property(e => e.Cliente);

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdMunicipioNavigation)
                .WithMany(p => p.Personas)
                .HasForeignKey(d => d.ID_Municipio)
                .HasConstraintName("FK__Personas__ID_Mun__4CA06362");

            builder.HasOne(d => d.IdRegimenFiscalNavigation)
                .WithMany(p => p.Personas)
                .HasForeignKey(d => d.ID_Regimen_Fiscal)
                .HasConstraintName("FK__Personas__ID_Reg__4D94879B");

            builder.HasOne(d => d.IdTipoDocumentoNavigation)
                .WithMany(p => p.Personas)
                .HasForeignKey(d => d.ID_Tipo_Documento)
                .HasConstraintName("FK__Personas__Estado__4BAC3F29");
        }
    }
}
