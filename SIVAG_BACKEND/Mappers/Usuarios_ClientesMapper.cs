using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class Usuarios_ClientesMapper
    {
        public static Usuarios_ClientesDTO ToUsuarios_ClientesDTO(this Usuarios_ClientesDomain usuariosClientes)
        {
            return new Usuarios_ClientesDTO
            {
                Usuario_Cliente = usuariosClientes.Usuario_Cliente,
                ID_Sucursal = usuariosClientes.ID_Sucursal,
                ID_Persona = usuariosClientes.ID_Persona,
                ID_Rol = usuariosClientes.ID_Rol,
                Nombre_Usuario = usuariosClientes.Nombre_Usuario,
                Clave = usuariosClientes.Clave,
                Clave_Temporal = usuariosClientes.Clave_Temporal,
                Tiempo_Recupera = usuariosClientes.Tiempo_Recupera,
                Fecha_Creacion = usuariosClientes.Fecha_Creacion,
                Estado = usuariosClientes.Estado
            };
        }
        public static Usuarios_ClientesDomain ToUsuarios_ClientesDomain(this Usuarios_ClientesDTO usuariosClientes)
        {
            return new Usuarios_ClientesDomain
            {
                Usuario_Cliente = usuariosClientes.Usuario_Cliente,
                ID_Sucursal = usuariosClientes.ID_Sucursal,
                ID_Persona = usuariosClientes.ID_Persona,
                ID_Rol = usuariosClientes.ID_Rol,
                Nombre_Usuario = usuariosClientes.Nombre_Usuario,
                Clave = usuariosClientes.Clave,
                Clave_Temporal = usuariosClientes.Clave_Temporal,
                Tiempo_Recupera = usuariosClientes.Tiempo_Recupera,
                Fecha_Creacion = usuariosClientes.Fecha_Creacion,
                Estado = usuariosClientes.Estado
            };
        }
    }
}
