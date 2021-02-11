using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads2
{
    interface IAction {
        string GetName();
        int GetTimeConsume();
        bool TickAndCheck();
    }
    public class ReadMemory : IAction
    {
        private const string name = "Read Memory";
        private readonly int timeConsume;
        private int timeCounter = 0;
        
        public ReadMemory(int timeConsume)
        {
            this.timeConsume = timeConsume;
        }
        public string GetName()
        {
            return name;
        }

        public int GetTimeConsume()
        {
            return timeConsume;
        }

        public bool TickAndCheck()
        {
            if (timeCounter < timeConsume)
            {
                timeCounter++;
                return false;
            }
            return true;
        }
    }
    public class WriteMemory : IAction
    {
        private const string name = "Write Memory";
        private readonly int timeConsume;
        private int timeCounter = 0;

        public WriteMemory(int timeConsume)
        {
            this.timeConsume = timeConsume;
        }
        public string GetName()
        {
            return name;
        }

        public int GetTimeConsume()
        {
            return timeConsume;
        }

        public bool TickAndCheck()
        {
            if (timeCounter < timeConsume)
            {
                timeCounter++;
                return false;
            }
            return true;
        }
    }
    public class Compute : IAction
    {
        private const string name = "Operation Compute";
        private readonly int timeConsume;
        private int timeCounter = 0;

        public Compute(int timeConsume)
        {
            this.timeConsume = timeConsume;
        }
        public string GetName()
        {
            return name;
        }

        public int GetTimeConsume()
        {
            return timeConsume;
        }

        public bool TickAndCheck()
        {
            if (timeCounter < timeConsume)
            {
                timeCounter++;
                return false;
            }
            return true;
        }
    }

    public class Lock : IAction
    {
        private const string name = "Bubble Lock";
        private const int timeConsume = 1;
        public Lock()
        {
        }

        public string GetName()
        {
            return name;
        }

        public int GetTimeConsume()
        {
            return timeConsume;
        }

        public bool TickAndCheck()
        {
            return true;
        }
    }
}
