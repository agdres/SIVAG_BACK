namespace SIVAG_BACKEND.Models.API_Response
{
    public class RolesDTO
    {
        public int Rol { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Sucursal { get; set; }
        public int ID_Bodega { get; set; }
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
