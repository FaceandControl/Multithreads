using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads2
{
    struct TimeConsumeSettings
    {
        public int timeReadUnit;
        public int timeWriteUnit;
        public int timeComputeUnit;

        public TimeConsumeSettings(int _timeReadUnit, int _timeComputeUnit, int _timeWriteUnit) 
        {
            timeReadUnit = _timeReadUnit;
            timeWriteUnit = _timeWriteUnit;
            timeComputeUnit = _timeComputeUnit;
        }
    }
}
