using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileConsole
{
    public class Tile1
    {
        public Tile1(double fWidth, double fHeight)
        {           // member function constructor - בנאי
            m_fWidth = fWidth;
            m_fHeight = fHeight;
        }
        public double ComputeArea()
        {                              // member function for computing area
            return m_fWidth * m_fHeight;
        }
        private double m_fWidth; 			        // data member
        private double m_fHeight;			        // data member
    }
}
