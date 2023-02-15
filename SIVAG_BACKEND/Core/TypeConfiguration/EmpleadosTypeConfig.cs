using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.TypeConfiguration
{
    public class EmpleadosTypeConfig : IEntityTypeConfiguration<EmpleadosDomain>
    {
        public void Configure(EntityTypeBuilder<EmpleadosDomain> builder)
        {
            builder.ToTable("Empleados");

            builder.HasKey(e => e.Empleado);

            builder.Property(e => e.Correo)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Correo_Empresarial)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Correo_Empresarial");

            builder.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.DV)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DV");

            builder.Property(e => e.Fecha_Expedicion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Expedicion");

            builder.Property(e => e.Fecha_Nacimiento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Nacimiento");

            builder.Property(e => e.Fecha_Registro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fecha_Registro");

            builder.Property(e => e.ID_Bodega).HasColumnName("ID_Bodega");

            builder.Property(e => e.ID_Genero).HasColumnName("ID_Genero");

            builder.Property(e => e.ID_Municipio_Expedicion).HasColumnName("ID_Municipio_Expedicion");

            builder.Property(e => e.ID_Municipio_Nacimiento).HasColumnName("ID_Municipio_Nacimiento");

            builder.Property(e => e.ID_Sucursal).HasColumnName("ID_Sucursal");

            builder.Property(e => e.ID_Tipo_Documento).HasColumnName("ID_Tipo_Documento");

            builder.Property(e => e.Movil)
                .HasMaxLength(30)
                .IsUnicode(false);

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

            builder.Property(e => e.Telefono)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Tipo_Persona).HasColumnName("Tipo_Persona");

            builder.Property(e => e.Estado);

            builder.HasOne(d => d.IdBodegaNavigation).WithMany(p => p.Empleados).HasForeignKey(d => d.ID_Bodega);

            builder.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Empleados).HasForeignKey(d => d.ID_Genero);

            builder.HasOne(d => d.IdMunicipioExpedicionNavigation).WithMany(p => p.EmpleadoIdMunicipioExpedicionNavigations).HasForeignKey(d => d.ID_Municipio_Expedicion);

            builder.HasOne(d => d.IdMunicipioNacimientoNavigation).WithMany(p => p.EmpleadoIdMunicipioNacimientoNavigations).HasForeignKey(d => d.ID_Municipio_Nacimiento);

            builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.Empleados).HasForeignKey(d => d.ID_Sucursal);

            builder.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Empleados).HasForeignKey(d => d.ID_Tipo_Documento);
        }
    }
}
