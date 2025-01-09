using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class HashingUtils
    {
        private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HashingIterationsCount = 10101;

        private static string pepper = ConfigurationManager.AppSettings["pepper"];


        public static byte[] ComputeHash(string password, byte[] salt,int iterations = HashingIterationsCount,int hashByteSize = HashByteSize)
        {
            Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt);
            hashGenerator.IterationCount = iterations;
            return hashGenerator.GetBytes(hashByteSize);
        }

        public static byte[] GenerateSalt(int saltByteSize = SaltByteSize)
        {
            RNGCryptoServiceProvider saltGenerator = new RNGCryptoServiceProvider();

            byte[] salt = new byte[saltByteSize];
            saltGenerator.GetBytes(salt);

            salt = ComputeHash(pepper, salt);

            return salt;
        }
        public static bool VerifyPassword(string password, string salt, string passwordHash)
        {
            try
            {
                byte[] saltByte = salt.Split('-').Select(s => byte.Parse(s, System.Globalization.NumberStyles.HexNumber)).ToArray();
                byte[] computedHash = ComputeHash(password, saltByte);
                string userPasswordHash = BitConverter.ToString(computedHash);
                return passwordHash == userPasswordHash;
            }
            catch (Exception) { return false; }
        }

    }
}
