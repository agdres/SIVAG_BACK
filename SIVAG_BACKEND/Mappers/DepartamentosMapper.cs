using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class DepartamentosMapper
    {
        public static DepartamentosDTO ToDepartamentosDTO(this DepartamentosDomain departamentos)
        {
            return new DepartamentosDTO
            {
                Departamento = departamentos.Departamento,
                ID_Pais = departamentos.ID_Pais,
                Descripcion = departamentos.Descripcion,
                Codigo_ISO = departamentos.Codigo_ISO,
                Codigo = departamentos.Codigo,
                Estado = departamentos.Estado
            };
        }       
        public static DepartamentosDomain ToDepartamentosDomain(this DepartamentosDTO departamentos)
        {
            return new DepartamentosDomain
            {
                Departamento = departamentos.Departamento,
                ID_Pais = departamentos.ID_Pais,
                Descripcion = departamentos.Descripcion,
                Codigo_ISO = departamentos.Codigo_ISO,
                Codigo = departamentos.Codigo,
                Estado = departamentos.Estado
            };
        }
    }
}
