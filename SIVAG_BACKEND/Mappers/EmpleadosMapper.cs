using SIVAG_BACKEND.Core.Domain;
using SIVAG_BACKEND.Models.API_Response;

namespace SIVAG_BACKEND.Mappers
{
    public static class EmpleadosMapper
    {
        public static EmpleadosDTO ToEmpleadosDTO(this EmpleadosDomain empleados)
        {
            return new EmpleadosDTO
            {
                Empleado = empleados.Empleado,
                ID_Sucursal = empleados.ID_Sucursal,
                ID_Municipio_Nacimiento = empleados.ID_Municipio_Nacimiento,
                Fecha_Nacimiento = empleados.Fecha_Nacimiento,
                ID_Bodega = empleados.ID_Bodega,
                ID_Genero = empleados.ID_Genero,
                ID_Tipo_Documento = empleados.ID_Tipo_Documento,
                Numero_Documento = empleados.Numero_Documento,
                DV = empleados.DV,
                ID_Municipio_Expedicion = empleados.ID_Municipio_Expedicion,
                Fecha_Expedicion = empleados.Fecha_Expedicion,
                Primer_Nombre = empleados.Primer_Nombre,
                Segundo_Nombre = empleados.Segundo_Nombre,
                Primer_Apellido = empleados.Primer_Apellido,
                Segundo_Apellido = empleados.Segundo_Apellido,
                Correo = empleados.Correo,
                Correo_Empresarial = empleados.Correo_Empresarial,
                Direccion = empleados.Direccion,
                Telefono = empleados.Telefono,
                Movil = empleados.Movil,
                Tipo_Persona = empleados.Tipo_Persona,
                Fecha_Registro = empleados.Fecha_Registro,
                Estado = empleados.Estado
            };
        }      
        
        public static EmpleadosDomain ToEmpleadosDomain(this EmpleadosDTO empleados)
        {
            return new EmpleadosDomain
            {
                Empleado = empleados.Empleado,
                ID_Sucursal = empleados.ID_Sucursal,
                ID_Municipio_Nacimiento = empleados.ID_Municipio_Nacimiento,
                Fecha_Nacimiento = empleados.Fecha_Nacimiento,
                ID_Bodega = empleados.ID_Bodega,
                ID_Genero = empleados.ID_Genero,
                ID_Tipo_Documento = empleados.ID_Tipo_Documento,
                Numero_Documento = empleados.Numero_Documento,
                DV = empleados.DV,
                ID_Municipio_Expedicion = empleados.ID_Municipio_Expedicion,
                Fecha_Expedicion = empleados.Fecha_Expedicion,
                Primer_Nombre = empleados.Primer_Nombre,
                Segundo_Nombre = empleados.Segundo_Nombre,
                Primer_Apellido = empleados.Primer_Apellido,
                Segundo_Apellido = empleados.Segundo_Apellido,
                Correo = empleados.Correo,
                Correo_Empresarial = empleados.Correo_Empresarial,
                Direccion = empleados.Direccion,
                Telefono = empleados.Telefono,
                Movil = empleados.Movil,
                Tipo_Persona = empleados.Tipo_Persona,
                Fecha_Registro = empleados.Fecha_Registro,
                Estado = empleados.Estado
            };
        }
    }
}
