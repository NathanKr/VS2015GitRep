using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSymmetricEncryption
{
    class Program
    {
        private static byte[] EncryptText(SymmetricAlgorithm symmetricAlgo, string strClearText)
        {
            ICryptoTransform encrypt = symmetricAlgo.CreateEncryptor(symmetricAlgo.Key, symmetricAlgo.IV);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encrypt,CryptoStreamMode.Write))
                {
                    using (StreamWriter writer = new StreamWriter(cryptoStream))
                    {
                        writer.Write(strClearText);
                    }
                    return memoryStream.ToArray();
                }
            }
        }

        private static string DecryptText(SymmetricAlgorithm symmetricAlgo, byte[] arEncrypted)
        {
            ICryptoTransform decryptor = symmetricAlgo.CreateDecryptor(symmetricAlgo.Key, symmetricAlgo.IV);
            using (MemoryStream memoryStream = new MemoryStream(arEncrypted))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(cryptoStream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string strPassword = "123Xa_", strTextDecrypted;
            using (SymmetricAlgorithm symAlgo = new AesManaged())
            {
                byte[] arEncrypted = EncryptText(symAlgo, strPassword);
                strTextDecrypted = DecryptText(symAlgo, arEncrypted);
            }
            Console.WriteLine("text original : {0}", strPassword);
            Console.WriteLine("text decrypted: {0}", strTextDecrypted);

            Console.ReadKey();
        }

        
    }
}
