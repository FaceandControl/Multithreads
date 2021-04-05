using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Multithreads3.GlobalConstant;

namespace Multithreads3.strategy
{
    class OptimalStrategyImpl : IStrategy
    {
        private bool[] initialize;

        public OptimalStrategyImpl()
        {
            initialize = new bool[TACT];
            initialize[1] = initialize[2] = initialize[3] = 
                initialize[4] = initialize[6] = initialize[7] = false;
            initialize[0] = initialize[5] = true;
        }

        public bool isInitializeByIndex(int id) { return initialize[id]; }
    }
}
