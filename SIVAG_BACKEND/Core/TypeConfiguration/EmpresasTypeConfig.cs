using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class EmpresasTypeConfig : IEntityTypeConfiguration<EmpresasDomain>
    {
        public void Configure(EntityTypeBuilder<EmpresasDomain> builder)
        {
            builder.ToTable("Empresas");

            builder.HasKey(e => e.Empresa)
                    .HasName("PK__Empresas__7FE34B72A7165102");

            builder.Property(e => e.Correo)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Fecha_Registro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Registro");

            builder.Property(e => e.ID_Persona).HasColumnName("ID_Persona");

            builder.Property(e => e.Movil)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Tipo_Persona).HasColumnName("Tipo_Persona");

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdPersonaNavigation)
                .WithMany(p => p.Empresas)
                .HasForeignKey(d => d.ID_Persona)
                .HasConstraintName("FK__Empresas__Estado__5441852A");
        }
    }
}
