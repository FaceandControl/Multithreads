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
            listView1.Items.Clear();
            listView2.Items.Clear();

            int taskAmount = 10;
            TimeConsumeSettings timeConsumeSettings1 = new TimeConsumeSettings(3, 5, 4);
            TimeConsumeSettings timeConsumeSettings2 = new TimeConsumeSettings(6, 3, 2);

            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            
            try
            {
                timeConsumeSettings1.timeReadUnit = Convert.ToInt32(comboBox6.Text);
            }
            catch
            {
                comboBox6.Text = timeConsumeSettings1.timeReadUnit.ToString();
            }
            try
            {
                timeConsumeSettings1.timeComputeUnit = Convert.ToInt32(comboBox1.Text);
            }
            catch
            {
                comboBox1.Text = timeConsumeSettings1.timeComputeUnit.ToString();
            }
            try
            {
                timeConsumeSettings1.timeWriteUnit = Convert.ToInt32(comboBox2.Text);
            }
            catch
            {
                comboBox2.Text = timeConsumeSettings1.timeWriteUnit.ToString();
            }

            try
            {
                timeConsumeSettings2.timeReadUnit = Convert.ToInt32(comboBox3.Text);
            }
            catch
            {
                comboBox3.Text = timeConsumeSettings2.timeReadUnit.ToString();
            }
            try
            {
                timeConsumeSettings2.timeComputeUnit = Convert.ToInt32(comboBox4.Text);
            }
            catch
            {
                comboBox4.Text = timeConsumeSettings2.timeComputeUnit.ToString();
            }
            try
            {
                timeConsumeSettings2.timeWriteUnit = Convert.ToInt32(comboBox5.Text);
            }
            catch
            {
                comboBox5.Text = timeConsumeSettings2.timeWriteUnit.ToString();
            }

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

            int minTimeConsumed = clusters[0].AllTimeConsumed();
            int indexMin = 0;
            for (int i = 1; i < clusters.Count; i++) 
            {
                int timeConsumed = clusters[i].AllTimeConsumed();
                if (minTimeConsumed > timeConsumed) 
                {
                    minTimeConsumed = timeConsumed;
                    indexMin = i;
                }
            }
            List<ListViewItem> listViewItems1 = clusters[indexMin].thread1.Show();
            List<ListViewItem> listViewItems2 = clusters[indexMin].thread2.Show();

            foreach (ListViewItem View in listViewItems1) 
            {
                listView1.Items.Add(View);
            }

            foreach (ListViewItem View in listViewItems2)
            {
                listView2.Items.Add(View);
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MemoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
