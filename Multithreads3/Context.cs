using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Multithreads3.strategy;

namespace Multithreads3
{
    class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy) { this.strategy = strategy; }

        public void setStrategy(IStrategy strategy) { this.strategy = strategy; }

        public bool executeStrategyIsInitById(int id) { return strategy.isInitializeByIndex(id); }
    }
}
