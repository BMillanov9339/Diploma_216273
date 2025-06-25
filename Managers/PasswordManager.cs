using System;
using System.IO;
using System.Security.Cryptography;

namespace diploma_216273.Managers
{
    public static class PasswordManager
    {
        public static byte[] StoredSalt { get; private set; }
        public static byte[] StoredHash { get; private set; }

        private static string PasswordFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "admin", "Password.txt");

        static PasswordManager()
        {
            Load();
        }

        public static void Load()
        {
            if (!File.Exists(PasswordFile))
                throw new FileNotFoundException("Password file not found.");

            string[] lines = File.ReadAllLines(PasswordFile);
            if (lines.Length < 2)
                throw new InvalidDataException("Password file is corrupt.");

            StoredSalt = Convert.FromBase64String(lines[0]);
            StoredHash = Convert.FromBase64String(lines[1]);
        }

        public static bool CheckPassword(string password)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, StoredSalt, 100_000))
            {
                byte[] testHash = pbkdf2.GetBytes(32);
                return AreHashesEqual(testHash, StoredHash);
            }
        }

        public static void SaveNewPassword(string newPassword)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] newSalt = new byte[16];
                rng.GetBytes(newSalt);

                using (var pbkdf2 = new Rfc2898DeriveBytes(newPassword, newSalt, 100_000))
                {
                    byte[] newHash = pbkdf2.GetBytes(32);

                    File.WriteAllLines(PasswordFile, new[]
                    {
                    Convert.ToBase64String(newSalt),
                    Convert.ToBase64String(newHash)
                });


                    StoredSalt = newSalt;
                    StoredHash = newHash;
                }
            }
        }

        private static bool AreHashesEqual(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++)
                diff |= a[i] ^ b[i];
            return diff == 0;
        }
    }
}
