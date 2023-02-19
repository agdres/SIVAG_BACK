using BCrypt.Net;

namespace SIVAG_BACKEND.Utilities
{
    public static class PasswordCrypt
    {
        public static string Codificacion(string password)
        {
			try
			{
                string paswordCryp = BCrypt.Net.BCrypt.HashPassword(password, workFactor: 13);
                return paswordCryp;
            }
			catch (Exception)
			{
				return "";
			}
        }       
        
        public static bool VerificacionPass(string password,string hashedPass)
        {
			try
			{
                bool Verificacion = BCrypt.Net.BCrypt.Verify(password, hashedPass);
                return Verificacion;
            }
			catch (Exception)
			{
				return false;
			}
        }
    }
}
