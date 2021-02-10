using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads
{
    class Task3
    {
        Random random;
        public List<int> queues;
        public int task;
        public int min = 10;
        public int max = 40;

        public Task3()
        {
            random = new Random();
            task = random.Next(min, max + 1);
            queues = new List<int>();
        }

        public void generator()
        {
            for (int num = random.Next(1, 6), curr = random.Next(5), i = 0; i < num; i++)
            {
                while (queues.Contains(curr))
                {
                    curr = random.Next(5);
                }
                queues.Add(curr);
            }
            queues.Sort();
        }
    }
}
