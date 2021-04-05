using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads3.strategy
{
    interface IStrategy
    {
        bool isInitializeByIndex(int id);
    }
}
