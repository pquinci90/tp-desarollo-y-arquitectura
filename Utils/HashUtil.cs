using BCrypt.Net;

namespace Utils

{
    public static class HashUtil
    {
        public static string HashPassword(string password)
        {
            string hashed = BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12);
            return hashed;
        }
        public static bool VerifyPassword(string passwordPlano, string passwordHasheado)
        {
            return BCrypt.Net.BCrypt.Verify(passwordPlano, passwordHasheado);
        }
    }
}
