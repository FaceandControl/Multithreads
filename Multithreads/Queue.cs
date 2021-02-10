using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreads
{
    class Queue
    {
        public int minPerformance = 1;
        public int maxPerformance = 5;

        public int perf;
        public int queue;
        public int absQueue;
        List<int> tasks;
        public bool planner = false;
        public int plannerTimeRest;
        public int workTimeRest;
        int plannerTime;
        bool wasPlanner;
        int timeDiff;
        public int notPlannerTats;
        public int notPannerTatsWthUeless;

        public Queue(int plannerTime, int timeDiff)
        {
            perf = (new Random()).Next(1, 6);
            queue = 0;
            absQueue = 0;
            tasks = new List<int>();
            this.plannerTime = plannerTime;
            this.timeDiff = timeDiff;
            notPlannerTats = 0;
            notPannerTatsWthUeless = 0;
        }

        public void addTask(int complexity)
        {
            queue += complexity;
            tasks.Add(complexity);
        }

        public float futureTimeFloat(int complexity)
        {
            return (queue + complexity) / perf;
        }

        private void notPlannerOrWorkRestTimeNoZero()
        {
            notPannerTatsWthUeless++;
            queue -= perf;
            if (queue < 0)
                queue = 0;
            if (perf <= queue)
            {
                notPlannerTats++;
                absQueue += perf;
            }
        }

        public void millisecondGone()
        {
            if (planner)
            {
                if (plannerTimeRest == 0)
                {
                    if (workTimeRest != 0)
                    {
                        workTimeRest--;
                        notPlannerOrWorkRestTimeNoZero();
                    }
                    else
                    {
                        if (wasPlanner)
                        {
                            workTimeRest = plannerTime * timeDiff;
                        }
                        else
                        {
                            plannerTimeRest = plannerTime;
                        }
                        wasPlanner = !wasPlanner;
                    }
                }
                else
                {
                    plannerTimeRest--;
                }
            }
            else
            {
                notPlannerOrWorkRestTimeNoZero();
            }
        }

        public int tasks_completed()
        {
            int queue_copy = absQueue;
            int number = 0;
            while (tasks.Count() != 0 && tasks[0] < queue_copy)
            {
                queue_copy -= tasks[0];
                tasks.RemoveAt(0);
                number++;
            }
            return number;
        }

        public void become_planner()
        {
            planner = wasPlanner = true;
            plannerTimeRest = plannerTime;
            workTimeRest = 0;
        }
    }
}
