using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads
{
    class ComputeUnit
    {
        static public int Sum_finished_tasks { get; private set; } = 0;
        public int Sum_unit_finished_tasks { get; private set; } = 0;

        static public int Sum_finished_operations { get; private set; } = 0;
        public int Sum_unit_finished_operations { get; private set; } = 0;

        private const int lower_performance = 1;
        private const int maximum_performance = 5;

        private int performance = new Random().Next(lower_performance, maximum_performance + 1);

        public int Performance {
            get => performance;
            set {
                if (value >= lower_performance && value <= maximum_performance)
                    performance = value;
            }
        }

        private List<int> tasks_list = new List<int>();

        public void Tick() 
        {
            if (!tasks_list.Any())
                return;
            tasks_list[0] -= performance;
            Sum_unit_finished_operations += performance;
            Sum_finished_operations += performance;
            if (tasks_list[0] <= 0) {
                Sum_unit_finished_tasks++;
                Sum_finished_tasks++;
                tasks_list.RemoveAt(0);
            }
        }

        public bool AddTaskFIFO(int complexity)
        {
            if (tasks_list.Count <= 1)
            {
                tasks_list.Add(complexity);
                return true;
            }
            return false;
        }

        public void CleanUnitSum() 
        {
            Sum_unit_finished_tasks = 0;
            Sum_unit_finished_operations = 0;
        }

        static public void CleanStaticSum()
        {
            Sum_finished_tasks = 0;
            Sum_finished_operations = 0;
        }

        public void RecreateUnit()
        {
            CleanUnitSum();
            tasks_list = new List<int>();
        }
    }
}
