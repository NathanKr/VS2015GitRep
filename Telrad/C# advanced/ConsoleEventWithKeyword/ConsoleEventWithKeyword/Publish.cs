using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventWithKeyword
{
    class Publish
    {
        public event Action OnChanged = delegate { };

        public void RaiseEvent()
        {
            OnChanged();
        }
    }
}
