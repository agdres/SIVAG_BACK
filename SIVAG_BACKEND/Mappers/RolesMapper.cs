using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class RolesMapper
    {
        public static RolesDTO ToRolesDTO(this RolesDomain roles)
        {
            return new RolesDTO
            {
                Rol = roles.Rol,
                ID_Empresa = roles.ID_Empresa,
                ID_Sucursal = roles.ID_Sucursal,
                ID_Bodega = roles.ID_Bodega,
                Descripcion = roles.Descripcion,
                Estado = roles.Estado
            };
        }

        public static RolesDomain ToRolesDomain(this RolesDTO roles)
        {
            return new RolesDomain
            {
                Rol = roles.Rol,
                ID_Empresa = roles.ID_Empresa,
                ID_Sucursal = roles.ID_Sucursal,
                ID_Bodega = roles.ID_Bodega,
                Descripcion = roles.Descripcion,
                Estado = roles.Estado
            };
        }
    }
}
