using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class PermisosMapper
    {
        public static PermisosDTO ToPermisosDTO(this PermisosDomain permisos)
        {
            return new PermisosDTO
            {
                Permiso = permisos.Permiso,
                ID_Rol = permisos.ID_Rol,
                ID_Componente = permisos.ID_Componente,
                Crear = permisos.Crear,
                Listar = permisos.Listar,
                Actualizar = permisos.Actualizar,
                Deshabilitar = permisos.Deshabilitar,
                Enviar_MsgBod = permisos.Enviar_MsgBod,
                Recibir_MsgBod = permisos.Recibir_MsgBod,
                S_Enviar_MsgBod = permisos.S_Enviar_MsgBod,
                S_Recibir_MsgBod = permisos.S_Recibir_MsgBod,
                Estado = permisos.Estado
            };
        }

        public static PermisosDomain ToPermisosDomain(this PermisosDTO permisos)
        {
            return new PermisosDomain
            {
                Permiso = permisos.Permiso,
                ID_Rol = permisos.ID_Rol,
                ID_Componente = permisos.ID_Componente,
                Crear = permisos.Crear,
                Listar = permisos.Listar,
                Actualizar = permisos.Actualizar,
                Deshabilitar = permisos.Deshabilitar,
                Enviar_MsgBod = permisos.Enviar_MsgBod,
                Recibir_MsgBod = permisos.Recibir_MsgBod,
                S_Enviar_MsgBod = permisos.S_Enviar_MsgBod,
                S_Recibir_MsgBod = permisos.S_Recibir_MsgBod,
                Estado = permisos.Estado
            };
        }
    }
}
