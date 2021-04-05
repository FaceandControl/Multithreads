using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Multithreads3.GlobalConstant;

namespace Multithreads3
{
    class UsageTable
    {
        private int[] table;

        public UsageTable()
        {
            table = new int[TACT];
            table[0] = table[4] = table[7] = 1;
            table[1] = table[5] = 2;
            table[2] = table[3] = table[6] = 3;
        }

        public int getTableElementById(int id) { return table[id]; }
    }
}
