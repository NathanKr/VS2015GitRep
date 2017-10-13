using System.IO;
using System.Text;

namespace ConsoleStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\a.dat";
            using (FileStream fileStream = File.Create(path))
            {
                string strText = "hello file stream unicode";
                byte[] data = Encoding.Unicode.GetBytes(strText);
                string str1 = Encoding.Unicode.GetString(data);
                fileStream.Write(data, 0, data.Length);
            }

        }
    }
}
