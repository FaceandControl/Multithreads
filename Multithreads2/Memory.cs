using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads2
{
    class Memory
    {
        private int timeCounter = 0;
        private bool isMemoryOpen = true;

        public bool IsMemoryOpen()
        {
            if (timeCounter == 0)
                isMemoryOpen = true;
            if (isMemoryOpen)
                return true;

            timeCounter--;
            return false;
        }

        public void AddAction(int timeConsume) 
        {
            timeCounter = timeConsume;
            isMemoryOpen = false;
        }
    }
}
