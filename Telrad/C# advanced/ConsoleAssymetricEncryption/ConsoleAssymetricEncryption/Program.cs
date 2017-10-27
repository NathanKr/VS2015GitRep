using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssymetricEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string strClearText, strDecrypted, strPublicKey, strPrivateKey;
            UnicodeEncoding unicodeEncoder = new UnicodeEncoding();
            byte[] arData, arDataEncrypted, arDataDeccrypted;

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                strPublicKey = rsa.ToXmlString(false);
                strPrivateKey = rsa.ToXmlString(true);


                strClearText = "this is secret stuff";
                arData = unicodeEncoder.GetBytes(strClearText);
                
                // --- encrypte
                rsa.FromXmlString(strPublicKey);
                arDataEncrypted = rsa.Encrypt(arData,false);

                // --- decrypte
                rsa.FromXmlString(strPrivateKey);
                arDataDeccrypted = rsa.Decrypt(arDataEncrypted, false);
            }

            strDecrypted = unicodeEncoder.GetString(arDataDeccrypted);
            Console.WriteLine("original text : {0}", strClearText);
            Console.WriteLine("decrypted text : {0}", strDecrypted);

            Console.Read();
        }
    }
}
