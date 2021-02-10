using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads
{
    class GeneratePossibility
    {
        Random random;
        public int possibility;

        public GeneratePossibility()
        {
            random = new Random();
            possibility = random.Next(11);
        }

        public bool yesOrNo()
        {
            return possibility != 0 ? random.Next(11) <= possibility : false;
        }
    }
}
