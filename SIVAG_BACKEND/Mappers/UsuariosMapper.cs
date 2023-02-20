using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Auth;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class UsuariosMapper
    {
        public static UsuariosDTO ToUsuariosDTO(this UsuariosDomain usuarios)
        {
            return new UsuariosDTO
            {
                Usuario = usuarios.Usuario,
                Nombre_Usuario = usuarios.Nombre_Usuario,
                Fecha_Creacion = usuarios.Fecha_Creacion,
                Principal = usuarios.Principal,
                Estado = usuarios.Estado
            };
        }    
        
        public static UsuariosDTO ToUsuariosAuth_DTO(this UsuariosAuth usuarios)
        {
            return new UsuariosDTO
            {
                Usuario = usuarios.Usuario,
                ID_Empleado = usuarios.ID_Empleado,
                ID_Rol = usuarios.ID_Rol,
                Nombre_Usuario = usuarios.Nombre_Usuario,
                Clave = usuarios.Clave,
                Principal = usuarios.Principal,
                Estado = usuarios.Estado
            };
        }

        public static UsuariosDomain ToUsuariosDomain(this UsuariosDTO usuarios)
        {
            return new UsuariosDomain
            {
                Usuario = usuarios.Usuario,
                ID_Empleado = usuarios.ID_Empleado,
                ID_Rol = usuarios.ID_Rol,
                Nombre_Usuario = usuarios.Nombre_Usuario,
                Clave = usuarios.Clave,
                Clave_Temporal = usuarios.Clave_Temporal,
                Tiempo_Recupera = usuarios.Tiempo_Recupera,
                Fecha_Creacion = usuarios.Fecha_Creacion,
                Principal = usuarios.Principal,
                Estado = usuarios.Estado
            };
        }       
        
        
    }
}
