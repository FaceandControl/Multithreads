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
        public int AllTimeConsumed() 
        {
            int thread1TimeConsumed = thread1.AllTimeConsumed();
            int thread2TimeConsumed = thread2.AllTimeConsumed();
            if (thread1TimeConsumed >= thread2TimeConsumed) { return thread1TimeConsumed; }
            return thread2TimeConsumed;
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
