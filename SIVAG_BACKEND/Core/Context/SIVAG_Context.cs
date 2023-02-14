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

        public virtual DbSet<BodegasDomain> Bodegas { get; set; }
        public virtual DbSet<ComponentesDomain> Componentes { get; set; }
        public virtual DbSet<Configuraciones_CorreosDomain> ConfiguracionesCorreos { get; set; }
        public virtual DbSet<Configuraciones_DIANDomain> ConfiguracionesDians { get; set; }
        public virtual DbSet<Configuraciones_EmpresasDomain> ConfiguracionesEmpresas { get; set; }
        public virtual DbSet<DepartamentosDomain> Departamentos { get; set; }
        public virtual DbSet<EmpleadosDomain> Empleados { get; set; }
        public virtual DbSet<EmpresasDomain> Empresas { get; set; }
        public virtual DbSet<ErroresDomain> Errores { get; set; }
        public virtual DbSet<EventosDomain> Eventos { get; set; }
        public virtual DbSet<Formas_PagoDomain> FormasPago { get; set; }
        public virtual DbSet<GenerosDomain> Generos { get; set; }
        public virtual DbSet<IdiomasDomain> Idiomas { get; set; }
        public virtual DbSet<ImpuestosDomain> Impuestos { get; set; }
        public virtual DbSet<Medios_PagoDomain> MediosPago { get; set; }
        public virtual DbSet<MensajesDomain> Mensajes { get; set; }
        public virtual DbSet<Monedas_PaisesDomain> MonedaPais { get; set; }
        public virtual DbSet<MonedasDomain> Monedas { get; set; }
        public virtual DbSet<MunicipiosDomain> Municipios { get; set; }
        public virtual DbSet<Paises_IdiomasDomain> PaisesIdiosmas { get; set; }
        public virtual DbSet<PaisesDomain> Paises { get; set; }
        public virtual DbSet<Parametrizaciones_BodegasDomain> ParametrizacionesBodegas { get; set; }
        public virtual DbSet<Parametrizaciones_SucursalesDomain> ParametrizacionesSucursales { get; set; }
        public virtual DbSet<PermisosDomain> Permisos { get; set; }
        public virtual DbSet<PersonasDomain> Personas { get; set; }
        public virtual DbSet<Personas_ResponsabilidadesDomain> PersonasResponsabilidades { get; set; }
        public virtual DbSet<Regimen_FiscalesDomain> RegimenFiscales { get; set; }
        public virtual DbSet<RegistrosDomain> Registros { get; set; }
        public virtual DbSet<ResolucionesDomain> Resoluciones { get; set; }
        public virtual DbSet<Responsabilidades_FiscalesDomain> ResponsabilidadesFiscales { get; set; }
        public virtual DbSet<RolesDomain> Roles { get; set; }
        public virtual DbSet<SucursalesDomain> Sucursales { get; set; }
        public virtual DbSet<Sucursales_PersonasDomain> SucursalesPersonas { get; set; }
        public virtual DbSet<Tarifas_ImpuestosDomain> TarifasImpuestos { get; set; }
        public virtual DbSet<Tipos_DocumentosDomain> TiposDocumentos { get; set; }
        public virtual DbSet<UsuariosDomain> Usuarios { get; set; }
        public virtual DbSet<Usuarios_ClientesDomain> UsuariosClientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BodegasTypeConfig());
            modelBuilder.ApplyConfiguration(new ComponentesTypeConfig());
            modelBuilder.ApplyConfiguration(new Configuraciones_CorreosTypeConfig());
            modelBuilder.ApplyConfiguration(new Configuraciones_DIANTypeConfig());
            modelBuilder.ApplyConfiguration(new Configuraciones_EmpresasTypeConfig());
            modelBuilder.ApplyConfiguration(new DepartamentosTypeConfig());
            modelBuilder.ApplyConfiguration(new EmpleadosTypeConfig());
            modelBuilder.ApplyConfiguration(new EmpresasTypeConfig());
            modelBuilder.ApplyConfiguration(new ErroresTypeConfig());
            modelBuilder.ApplyConfiguration(new EventosTypeConfig());
            modelBuilder.ApplyConfiguration(new Formas_PagoTypeConfig());
            modelBuilder.ApplyConfiguration(new GenerosTypeConfig());
            modelBuilder.ApplyConfiguration(new IdiomasTypeConfig());
            modelBuilder.ApplyConfiguration(new ImpuestosTypeConfig());
            modelBuilder.ApplyConfiguration(new Medios_PagoTypeConfig());
            modelBuilder.ApplyConfiguration(new MensajesTypeConfig());
            modelBuilder.ApplyConfiguration(new Monedas_PaisesTypeConfig());
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

            OnModelCreatingPartial(modelBuilder);
    
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}
