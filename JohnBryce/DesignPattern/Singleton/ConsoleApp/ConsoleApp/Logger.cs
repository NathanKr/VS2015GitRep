using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Logger
    {
        public enum Level
        {
            Verbose,
            Warning,
            Error,
            Fatal
        }

        public static Logger GetInstance()
        {
            if(m_instance == null)
            {
                m_instance = new Logger();
            }

            return m_instance;
        }

        public void Write(string strMsg , Level level)
        {
            Console.WriteLine("{0} : {1}" , level , strMsg);
        }

        private Logger()
        {
        }

        static private Logger m_instance;
    }
}
