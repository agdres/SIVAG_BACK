using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class EmpresasMapper
    {
        public static EmpresasDTO ToEmpresasDTO(this EmpresasDomain empresas)
        {
            return new EmpresasDTO
            {
                Empresa = empresas.Empresa,
                ID_Persona = empresas.ID_Persona,
                Correo = empresas.Correo,
                Direccion = empresas.Direccion,
                Telefono = empresas.Telefono,
                Movil = empresas.Movil,
                Tipo_Persona = empresas.Tipo_Persona,
                Fecha_Registro = empresas.Fecha_Registro,
                Estado = empresas.Estado
            };
        }   
        
        public static EmpresasDomain ToEmpresasDomain(this EmpresasDTO empresas)
        {
            return new EmpresasDomain
            {
                Empresa = empresas.Empresa,
                ID_Persona = empresas.ID_Persona,
                Correo = empresas.Correo,
                Direccion = empresas.Direccion,
                Telefono = empresas.Telefono,
                Movil = empresas.Movil,
                Tipo_Persona = empresas.Tipo_Persona,
                Fecha_Registro = empresas.Fecha_Registro,
                Estado = empresas.Estado
            };
        }
    }
}
