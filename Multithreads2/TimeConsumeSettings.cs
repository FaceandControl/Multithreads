using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads2
{
    struct TimeConsumeSettings
    {
        public readonly int timeReadUnit;
        public readonly int timeWriteUnit;
        public readonly int timeComputeUnit;

        public TimeConsumeSettings(int _timeReadUnit, int _timeWriteUnit, int _timeComputeUnit) 
        {
            timeReadUnit = _timeReadUnit;
            timeWriteUnit = _timeWriteUnit;
            timeComputeUnit = _timeComputeUnit;
        }
    }
}
