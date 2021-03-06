using System;
using System.Security.Cryptography;
using System.Text;

namespace NExtra.Security
{
    /// <summary>
    /// This class can be used to generate MD5 hash values,
    /// using the native MD5CryptoServiceProvider class.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://danielsaidi.github.com/nextra
    /// </remarks>
    public class Md5Generator : IHashValueGenerator
    {
        public string GenerateHashValue(object value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var hashedBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(value.ToString()));
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }
    }
}
