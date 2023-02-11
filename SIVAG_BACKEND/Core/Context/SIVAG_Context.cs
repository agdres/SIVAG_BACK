using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using SIVAG_BACKEND.Core.TypeConfiguration;
using System.Reflection;
using SIVAG_BACKEND.Core.Domain;

namespace SIVAG_BACKEND.Core.Context
{
    public partial class SIVAG_Context : DbContext
    {

        public SIVAG_Context()
        {
        }

        public SIVAG_Context(DbContextOptions<SIVAG_Context> options)
        : base(options)
        {
        }

        public virtual DbSet<BodegasTypeConfig> Bodegas { get; set; }
        public virtual DbSet<ComponentesTypeConfig> Componentes { get; set; }
        public virtual DbSet<Configuraciones_CorreosTypeConfig> ConfiguracionesCorreos { get; set; }
        public virtual DbSet<Configuraciones_DIANTypeConfig> ConfiguracionesDians { get; set; }
        public virtual DbSet<Configuraciones_EmpresasTypeConfig> ConfiguracionesEmpresas { get; set; }
        public virtual DbSet<DepartamentosTypeConfig> Departamentos { get; set; }
        public virtual DbSet<EmpleadosTypeConfig> Empleados { get; set; }
        public virtual DbSet<EmpresasTypeConfig> Empresas { get; set; }
        public virtual DbSet<ErroresTypeConfig> Errores { get; set; }
        public virtual DbSet<EventosTypeConfig> Eventos { get; set; }
        public virtual DbSet<GenerosTypeConfig> Generos { get; set; }
        public virtual DbSet<IdiomasTypeConfig> Idiomas { get; set; }
        public virtual DbSet<ImpuestosTypeConfig> Impuestos { get; set; }
        public virtual DbSet<MensajesTypeConfig> Mensajes { get; set; }
        public virtual DbSet<MonedasTypeConfig> Monedas { get; set; }
        public virtual DbSet<MunicipiosTypeConfig> Municipios { get; set; }
        public virtual DbSet<Paises_IdiomasTypeConfig> PaisesIdiosmas { get; set; }
        public virtual DbSet<PaisesTypeConfig> Paises { get; set; }
        public virtual DbSet<Parametrizaciones_BodegasTypeConfig> ParametrizacionesBodegas { get; set; }
        public virtual DbSet<Parametrizaciones_SucursalesTypeConfig> ParametrizacionesSucursales { get; set; }
        public virtual DbSet<PermisosTypeConfig> Permisos { get; set; }
        public virtual DbSet<PersonasTypeConfig> Personas { get; set; }
        public virtual DbSet<Personas_ResponsabilidadesTypeConfig> PersonasResponsabilidades { get; set; }
        public virtual DbSet<Regimen_FiscalesTypeConfig> RegimenFiscales { get; set; }
        public virtual DbSet<RegistrosTypeConfig> Registros { get; set; }
        public virtual DbSet<ResolucionesTypeConfig> Resoluciones { get; set; }
        public virtual DbSet<Responsabilidades_FiscalesTypeConfig> ResponsabilidadesFiscales { get; set; }
        public virtual DbSet<RolesTypeConfig> Roles { get; set; }
        public virtual DbSet<SucursalesTypeConfig> Sucursales { get; set; }
        public virtual DbSet<Sucursales_PersonasTypeConfig> SucursalesPersonas { get; set; }
        public virtual DbSet<Tarifas_ImpuestosTypeConfig> TarifasImpuestos { get; set; }
        public virtual DbSet<Tipos_DocumentosTypeConfig> TiposDocumentos { get; set; }
        public virtual DbSet<UsuariosTypeConfig> Usuarios { get; set; }
        public virtual DbSet<Usuarios_ClientesTypeConfig> UsuariosClientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.ApplyConfiguration(new BodegasTypeConfig());
            modelBuilder.ApplyConfiguration(new ComponentesTypeConfig());
            modelBuilder.ApplyConfiguration(new Configuraciones_CorreosTypeConfig());
            modelBuilder.ApplyConfiguration(new Configuraciones_DIANTypeConfig());
            modelBuilder.ApplyConfiguration(new Configuraciones_EmpresasTypeConfig());
            modelBuilder.ApplyConfiguration(new DepartamentosTypeConfig());
            modelBuilder.ApplyConfiguration(new EmpleadosTypeConfig());
            modelBuilder.ApplyConfiguration(new EmpresasTypeConfig());
            modelBuilder.ApplyConfiguration(new ErroresTypeConfig());
            modelBuilder.ApplyConfiguration(new EventosTypeConfig());
            modelBuilder.ApplyConfiguration(new GenerosTypeConfig());
            modelBuilder.ApplyConfiguration(new IdiomasTypeConfig());
            modelBuilder.ApplyConfiguration(new ImpuestosTypeConfig());
            modelBuilder.ApplyConfiguration(new MensajesTypeConfig());
            modelBuilder.ApplyConfiguration(new MonedasTypeConfig());
            modelBuilder.ApplyConfiguration(new MunicipiosTypeConfig());
            modelBuilder.ApplyConfiguration(new Paises_IdiomasTypeConfig());
            modelBuilder.ApplyConfiguration(new PaisesTypeConfig());
            modelBuilder.ApplyConfiguration(new Parametrizaciones_BodegasTypeConfig());
            modelBuilder.ApplyConfiguration(new Parametrizaciones_SucursalesTypeConfig());
            modelBuilder.ApplyConfiguration(new PermisosTypeConfig());
            modelBuilder.ApplyConfiguration(new PersonasTypeConfig());
            modelBuilder.ApplyConfiguration(new Personas_ResponsabilidadesTypeConfig());
            modelBuilder.ApplyConfiguration(new Regimen_FiscalesTypeConfig());
            modelBuilder.ApplyConfiguration(new RegistrosTypeConfig());
            modelBuilder.ApplyConfiguration(new ResolucionesTypeConfig());
            modelBuilder.ApplyConfiguration(new Responsabilidades_FiscalesTypeConfig());
            modelBuilder.ApplyConfiguration(new RolesTypeConfig());
            modelBuilder.ApplyConfiguration(new SucursalesTypeConfig());
            modelBuilder.ApplyConfiguration(new Sucursales_PersonasTypeConfig());
            modelBuilder.ApplyConfiguration(new Tarifas_ImpuestosTypeConfig());
            modelBuilder.ApplyConfiguration(new Tipos_DocumentosTypeConfig());
            modelBuilder.ApplyConfiguration(new UsuariosTypeConfig());
            modelBuilder.ApplyConfiguration(new Usuarios_ClientesTypeConfig());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

    }

}
