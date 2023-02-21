using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using SIVAG_BACKEND.Models.API_Response.Public;
using SIVAG_BACKEND.Utilities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace SIVAG_BACKEND.Services.Token
{
    public static class GenerarTokenModel
    {
        public static string GenerarJwtToken(string KeyAPI, LoginDTO info)
        {
            var _KeyAPI = Encoding.ASCII.GetBytes(KeyAPI);

            var _Key = KeyAPI.Substring(32, 32);
            var _Iv = KeyAPI.Substring(64,16);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("data_gen_x", EncryptGeneral(Encoding.UTF8.GetBytes(_Key),Encoding.UTF8.GetBytes(_Iv),info.isUserx_res)),
                    new Claim("data_disp_m",EncryptGeneral(Encoding.UTF8.GetBytes(_Key),Encoding.UTF8.GetBytes(_Iv),info.isUsery_m)),
                    new Claim("profile",info.profile)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(_KeyAPI), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private static string EncryptGeneral(byte[] Key, byte[] Iv, Object data)
        {
            string json = JsonConvert.SerializeObject(data);
            byte[] keyBytes = Key;
            byte[] ivBytes = Iv;

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = ivBytes;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(json);
                        }
                    }
                    byte[] encrypted = ms.ToArray();
                    var c = Convert.ToBase64String(encrypted);
                    return Convert.ToBase64String(encrypted);
                }
            }
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
