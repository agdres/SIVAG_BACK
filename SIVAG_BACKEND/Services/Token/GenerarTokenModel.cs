using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using SIVAG_BACKEND.Models.API_Response.Public;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace SIVAG_BACKEND.Services.Token
{
    public static class GenerarTokenModel
    {
        public static string GenerarJwtToken(string Key, LoginDTO info)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("data_gen_x", EncryptGeneral(key,info.isUserx_res)),
                    new Claim("data_disp_m",EncryptPermisos(key,info.isUsery_m))
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


        private static string EncryptPermisos(byte[] Key, List<LoginPermisos> data)
        {
            string jsonString = JsonConvert.SerializeObject(data);

            using var algorithm = Aes.Create();
            algorithm.Key = Key;

            var encryptedData = ProtectedData.Protect(Encoding.UTF8.GetBytes(jsonString), null, DataProtectionScope.LocalMachine);
            return Convert.ToBase64String(encryptedData);
        }

        private static string EncryptGeneral(byte[] Key, List<string> data)
        {
            string jsonString = JsonConvert.SerializeObject(data);

            using var algorithm = Aes.Create();
            algorithm.Key = Key;

            var encryptedData = ProtectedData.Protect(Encoding.UTF8.GetBytes(jsonString), null, DataProtectionScope.LocalMachine);
            return Convert.ToBase64String(encryptedData);
        }

        // Función para desencriptar los datos utilizando Data Protection API
        /*     private static string Unprotect(string data, byte[] key)
             {
                 var encryptedData = Convert.FromBase64String(data);
                 var unprotectedData = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.LocalMachine);

                 return Encoding.UTF8.GetString(unprotectedData);
             }*/
    }
}
