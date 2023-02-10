using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class Personas_ResponsabilidadesTypeConfig : IEntityTypeConfiguration<Personas_ResponsabilidadesDomain>
    {
        public void Configure(EntityTypeBuilder<Personas_ResponsabilidadesDomain> builder)
        {
            builder.ToTable("Personas_Responsabilidades");

            builder.HasKey(e => e.Persona_Responsabilidad)
                    .HasName("PK__Personas__1FF05B8B55C2B73F");

            builder.Property(e => e.ID_Persona).HasColumnName("ID_Persona");

            builder.Property(e => e.ID_Responsabilidad_Fiscal).HasColumnName("ID_Responsabilidad_Fiscal");

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdPersonaNavigation)
                .WithMany(p => p.PersonasResponsabilidades)
                .HasForeignKey(d => d.ID_Persona)
                .HasConstraintName("FK__Personas___Estad__5070F446");

            builder.HasOne(d => d.IdResponsabilidadFiscalNavigation)
                .WithMany(p => p.PersonasResponsabilidades)
                .HasForeignKey(d => d.ID_Responsabilidad_Fiscal)
                .HasConstraintName("FK__Personas___ID_Re__5165187F");
        }
    }
}
