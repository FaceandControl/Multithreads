using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads2
{
    class Cluster
    {
        public Thread thread1;
        public Thread thread2;
        public Memory memory;
        public int taskAmount;
        public Cluster(int _taskAmount, TimeConsumeSettings timeConsumeSettings1, TimeConsumeSettings timeConsumeSettings2) 
        {
            thread1 = new Thread(timeConsumeSettings1);
            thread2 = new Thread(timeConsumeSettings2);
            memory = new Memory();
            taskAmount = _taskAmount;
        }

        public Cluster(Cluster cluster)
        {
            thread1 = new Thread(cluster.thread1);
            thread2 = new Thread(cluster.thread2);
            memory = new Memory();
            taskAmount = cluster.taskAmount;
        }
    }
}
