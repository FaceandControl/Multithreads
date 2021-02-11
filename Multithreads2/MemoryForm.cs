using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreads2
{
    public partial class MemoryForm : Form
    {
        public MemoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taskAmount = 5;
            TimeConsumeSettings timeConsumeSettings1 = new TimeConsumeSettings(3, 2, 2);
            TimeConsumeSettings timeConsumeSettings2 = new TimeConsumeSettings(2, 2, 2);
            bool isAllThreadsFinished = false;

            List<Cluster> clusters = new List<Cluster>() { new Cluster(taskAmount, timeConsumeSettings1, timeConsumeSettings2) };

            while (!isAllThreadsFinished)
            {
                isAllThreadsFinished = true;
                int currentSize = clusters.Count;
                for (int i = 0; i < currentSize; i++)
                {
                    if (clusters[i].taskAmount > 0)
                    {
                        isAllThreadsFinished = false;

                        MemoryStatus memStatus1 = clusters[i].thread1.TickAndCheck();
                        MemoryStatus memStatus2 = clusters[i].thread2.TickAndCheck();

                        if (memStatus1 == MemoryStatus.TaskFinishedAndMemoryNeeded) { clusters[i].taskAmount--; }
                        if (memStatus2 == MemoryStatus.TaskFinishedAndMemoryNeeded) { clusters[i].taskAmount--; }
                            

                        if (memStatus1 == MemoryStatus.MemoryNotNeeded)
                        {
                            clusters[i].thread1.AddAction(true);
                        }
                        if (memStatus2 == MemoryStatus.MemoryNotNeeded)
                        {
                            clusters[i].thread2.AddAction(true);
                        }
                        if ((memStatus1 == MemoryStatus.MemoryNeeded || memStatus1 == MemoryStatus.TaskFinishedAndMemoryNeeded) &&
                            (memStatus2 == MemoryStatus.MemoryNotNeeded || memStatus2 == MemoryStatus.InProgress))
                        {
                            if (clusters[i].memory.IsMemoryOpen())
                            {
                                if (clusters[i].thread1.ReadStatus == ActionStatus.Active)
                                {
                                    clusters[i].memory.AddAction(timeConsumeSettings1.timeReadUnit);
                                }
                                else
                                    clusters[i].memory.AddAction(timeConsumeSettings1.timeWriteUnit);


                                clusters[i].thread1.AddAction(true);
                            }

                            else
                                clusters[i].thread1.AddAction(false);
                        }
                        else if ((memStatus2 == MemoryStatus.MemoryNeeded || memStatus2 == MemoryStatus.TaskFinishedAndMemoryNeeded) &&
                            (memStatus1 == MemoryStatus.MemoryNotNeeded || memStatus1 == MemoryStatus.InProgress))
                        {
                            if (clusters[i].memory.IsMemoryOpen())
                            {
                                if (clusters[i].thread2.ReadStatus == ActionStatus.Active)
                                {
                                    clusters[i].memory.AddAction(timeConsumeSettings2.timeReadUnit);
                                }
                                else
                                    clusters[i].memory.AddAction(timeConsumeSettings2.timeWriteUnit);


                                clusters[i].thread2.AddAction(true);
                            }

                            else
                                clusters[i].thread2.AddAction(false);
                        }
                        else if ((memStatus1 == MemoryStatus.MemoryNeeded || memStatus1 == MemoryStatus.TaskFinishedAndMemoryNeeded) &&
                            (memStatus2 == MemoryStatus.MemoryNeeded || memStatus2 == MemoryStatus.TaskFinishedAndMemoryNeeded)) 
                        {
                            if (!clusters[i].memory.IsMemoryOpen())
                            {
                                clusters[i].thread1.AddAction(false);
                                clusters[i].thread2.AddAction(false);
                            }
                            else 
                            {
                                Cluster copyCluster = new Cluster(clusters[i]);

                                if (clusters[i].thread1.ReadStatus == ActionStatus.Active)
                                {
                                    clusters[i].memory.AddAction(timeConsumeSettings1.timeReadUnit);
                                }
                                else
                                    clusters[i].memory.AddAction(timeConsumeSettings1.timeWriteUnit);

                                clusters[i].thread1.AddAction(false);
                                clusters[i].thread2.AddAction(true);


                                if (copyCluster.thread2.ReadStatus == ActionStatus.Active)
                                {
                                    copyCluster.memory.AddAction(timeConsumeSettings2.timeReadUnit);
                                }
                                else
                                    copyCluster.memory.AddAction(timeConsumeSettings2.timeWriteUnit);

                                copyCluster.thread1.AddAction(true);
                                copyCluster.thread2.AddAction(false);

                                clusters.Add(copyCluster);
                            }
                        }
                    }
                }
            }


            Console.WriteLine(clusters.Count);
        }
    }
}
