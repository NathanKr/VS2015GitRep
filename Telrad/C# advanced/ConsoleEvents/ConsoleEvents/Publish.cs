using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEvents
{
    class Publish
    {
        public Action OnChanged { get; set; }

        public void RaiseEvent()
        {
            if(OnChanged != null)
            {
                OnChanged();
            }
        }
    }
}
