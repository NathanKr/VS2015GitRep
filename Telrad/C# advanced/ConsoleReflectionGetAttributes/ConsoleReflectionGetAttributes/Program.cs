using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReflectionGetAttributes
{
    class Program
    {

        static string GetCopyright(object[] arAttributes)
        {
            foreach (object o in arAttributes)
            {
                if (o.GetType() ==
                    typeof(System.Reflection.AssemblyCopyrightAttribute))
                {
                    AssemblyCopyrightAttribute aca = (AssemblyCopyrightAttribute)o;
                    return aca.Copyright;
                }
            }
            return string.Empty;
        }

        static void Main(string[] args)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            /* argument of GetCustomAttributes is ignored for assembly
               check arAttributes in watch and see all the assembly attributes
             */
            object[] arAttributes = asm.GetCustomAttributes(false);
            string strCopyright = GetCopyright(arAttributes);
            Console.WriteLine("assembly copywright : {0}", strCopyright);

            Console.ReadKey();
        }
    }
}
