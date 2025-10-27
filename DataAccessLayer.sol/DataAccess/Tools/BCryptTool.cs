using bcryptPackage = BCrypt.Net;

namespace DataAccess.Tools
{
    public class BCryptTool
    {
        public static string HashPassword(string password) =>
            bcryptPackage.BCrypt.HashPassword(password);

        public static bool ValidatePassword(string password, string correctHas) =>
            bcryptPackage.BCrypt.Verify(password, correctHas);

        private static string GetRandomSalt() =>
            bcryptPackage.BCrypt.GenerateSalt();
    }
}
