using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class MonedasTypeConfig : IEntityTypeConfiguration<MonedasDomain>
    {
        public void Configure(EntityTypeBuilder<MonedasDomain> builder)
        {
            builder.ToTable("Monedas");

            builder.HasKey(e => e.Moneda)
                    .HasName("PK__Monedas__C0B652C77FEA9548");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            //builder.Property(e => e.ID_Pais).HasColumnName("ID_Pais");

            builder.Property(e => e.Simbolo)
                .HasMaxLength(50)
                .IsUnicode(false);            
            
            builder.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Estado).HasColumnName("Estado");


          /*  builder.HasOne(d => d.IdPaisNavigation)
                .WithMany(p => p.Moneda)
                .HasForeignKey(d => d.ID_Pais)
                .HasConstraintName("FK__Monedas__Estado__3E52440B");*/
        }
    }
}
