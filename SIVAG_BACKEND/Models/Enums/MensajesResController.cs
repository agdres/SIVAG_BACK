namespace SIVAG_BACKEND.Models.Enums
{
    public static class MensajesResController
    {
        public static string Result { get; set; } = "Acción Realizada.";
        public static string Error_Get { get; set; } = "No se ha logrado encontrar la información";
        public static string Error_Post { get; set; } = "No se ha logrado registrar la información";
        public static string Error_Put { get; set; } = "No se ha logrado actalizar la información";
        public static string Error { get; set; } = "Rectifique la información";
    }
}
