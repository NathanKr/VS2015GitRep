using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInterface
{
    class Excel{
        // caller of Excel pass IPrinter , Excel does not know which printer is used.
        // caller of Excel know which printer to pass but Excel does not care
        public Excel(IPrinter printer){
            m_IPrinter = printer;
        }

        // i am excel . i do not know to print so i use printer which implement IPrint
        public void PrintFile(string strExcelFile){
            m_IPrinter.Print(strExcelFile);
        }

        private IPrinter m_IPrinter;
    }
}
