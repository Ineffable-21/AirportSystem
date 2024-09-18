using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna
{
    internal class PasswordHasher(IConfiguration configuration)
    {
        private readonly string? _pepper = configuration["Security:Pepper"];

        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
        public string HashPassword(string password, string salt)
        {
            string saltedPepperedPassword = password + salt + _pepper;

            return BCrypt.Net.BCrypt.HashPassword(saltedPepperedPassword);
        }
        public bool VerifyPassword(string password, string salt, string storedHash)
        {
            string saltedPepperedPassword = password + salt + _pepper;

            return BCrypt.Net.BCrypt.Verify(saltedPepperedPassword, storedHash);
        }
    }
}
