using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Multithreads
{
    public partial class SchedulerStrongForm : Form
    {
        private StartForm startForm;

        private double possibility;
        private int complexity;
        private int plannerTime;
        private int plannerPoss;
        private int timeDiff;
        private int sec = 10;
        private int takt = 0;
        private int realPerf = 0;
        private int taskNum;
        private bool ifPossibilityOK;
        private bool ifComplexityOK;
        private List<Queue> queues;
        private GeneratePossibility generatePossibility;

        public SchedulerStrongForm(StartForm startForm, int taskNum)
        {
            this.taskNum = taskNum;
            this.startForm = startForm;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            queues = new List<Queue>();

            plannerTime = 4;
            timeDiff = 5;

            for (int i = 0; i < 5; i++)
            {
                queues.Add(new Queue(plannerTime, timeDiff));
                await System.Threading.Tasks.Task.Delay(10);
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            takt++;
            for (int i = 0; i < queues.Count(); i++)
            {
                queues[i].millisecondGone();
                if (queues[i].queue != 0)
                    realPerf += queues[i].perf;
            }


            string sPoss = Convert.ToString(generatePossibility.possibility / (float)10);
            string sWasG = "no";
            string sUnts = "";
            string sComl = "";

            if (generatePossibility.yesOrNo())
            {
                sWasG = "yes";
                Task3 new_task = new Task3();
                new_task.generator();

                if (ifComplexityOK)
                    new_task.task = complexity;
                sComl = Convert.ToString(new_task.task);

                for (int i = 0; i < new_task.queues.Count(); i++)
                    sUnts += Convert.ToString(new_task.queues[i]) + " ";
                float min;
                int min_pos;
                if (this.taskNum == 3)
                {
                    min = queues[new_task.queues[0]].futureTimeFloat(new_task.task);
                    min_pos = new_task.queues[0];
                }
                else
                {
                    int minTimeIndex = new_task.queues[0];
                    float maxTime = queues[0].futureTimeFloat(new_task.task);
                    for (int i = 0; i < new_task.queues.Count; i++)
                    {
                        if (queues[new_task.queues[i]].futureTimeFloat(new_task.task) < maxTime)
                        {
                            maxTime = queues[new_task.queues[i]].futureTimeFloat(new_task.task);
                            minTimeIndex = new_task.queues[i];
                        }
                    }
                    min = queues[minTimeIndex].futureTimeFloat(new_task.task);
                    min_pos = minTimeIndex;
                }
                if (queues[plannerPoss].plannerTimeRest != 0)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        float curr_val = queues[i].futureTimeFloat(new_task.task);
                        if (curr_val < min && new_task.queues.Contains(i))
                        {
                            min = curr_val;
                            min_pos = i;
                        }
                    }
                    string[] str_planner = { "planner" };
                    ListViewItem item_planner = new ListViewItem(str_planner);
                    switch (plannerPoss)
                    {
                        case 0:
                            listQueue1.Items.Add(item_planner);
                            break;
                        case 1:
                            listQueue2.Items.Add(item_planner);
                            break;
                        case 2:
                            listQueue3.Items.Add(item_planner);
                            break;
                        case 3:
                            listQueue4.Items.Add(item_planner);
                            break;
                        default:
                            listQueue5.Items.Add(item_planner);
                            break;
                    }
                }
                else
                {
                    string[] str_planner = { "working" };
                    ListViewItem item_planner = new ListViewItem(str_planner);
                    switch (plannerPoss)
                    {
                        case 0:
                            listQueue1.Items.Add(item_planner);
                            break;
                        case 1:
                            listQueue2.Items.Add(item_planner);
                            break;
                        case 2:
                            listQueue3.Items.Add(item_planner);
                            break;
                        case 3:
                            listQueue4.Items.Add(item_planner);
                            break;
                        default:
                            listQueue5.Items.Add(item_planner);
                            break;
                    }
                }
                queues[min_pos].addTask(new_task.task);

                switch (min_pos)
                {
                    case 0:
                        string[] strs0 = { sUnts, sComl, Convert.ToString(queues[0].queue) };
                        ListViewItem item0 = new ListViewItem(strs0);
                        listQueue1.Items.Add(item0);
                        break;
                    case 1:
                        string[] strs1 = { sUnts, sComl, Convert.ToString(queues[1].queue) };
                        ListViewItem item1 = new ListViewItem(strs1);
                        listQueue2.Items.Add(item1);
                        break;
                    case 2:
                        string[] strs2 = { sUnts, sComl, Convert.ToString(queues[2].queue) };
                        ListViewItem item2 = new ListViewItem(strs2);
                        listQueue3.Items.Add(item2);
                        break;
                    case 3:
                        string[] strs3 = { sUnts, sComl, Convert.ToString(queues[3].queue) };
                        ListViewItem item3 = new ListViewItem(strs3);
                        listQueue4.Items.Add(item3);
                        break;
                    default:
                        string[] strs4 = { sUnts, Convert.ToString(new_task.task), Convert.ToString(queues[4].queue) };
                        ListViewItem item4 = new ListViewItem(strs4);
                        listQueue5.Items.Add(item4);
                        break;
                }



                if (0 < listQueue1.Items.Count)
                    listQueue1.EnsureVisible(listQueue1.Items.Count - 1);
                if (0 < listQueue2.Items.Count)
                    listQueue2.EnsureVisible(listQueue2.Items.Count - 1);
                if (0 < listQueue3.Items.Count)
                    listQueue3.EnsureVisible(listQueue3.Items.Count - 1);
                if (0 < listQueue4.Items.Count)
                    listQueue4.EnsureVisible(listQueue4.Items.Count - 1);
                if (0 < listQueue5.Items.Count)
                    listQueue5.EnsureVisible(listQueue5.Items.Count - 1);
            }
            if (0 < listPossibility.Items.Count)
                listPossibility.EnsureVisible(listPossibility.Items.Count - 1);

            string[] strs = { sPoss, sWasG, sUnts, sComl };
            ListViewItem item = new ListViewItem(strs);
            listPossibility.Items.Add(item);
        }

        private void buttonStartClick(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;

            possibility = Convert.ToDouble(textBoxPossibility.Text);
            ifPossibilityOK = (0 <= possibility && possibility <= 1) ? true : false;

            try
            {
                complexity = Convert.ToInt32(textBoxComplexity.Text);
                ifComplexityOK = ((new Task3()).min <= complexity && complexity <= (new Task3()).max) ? true : false;
            }
            catch
            { }

            int[] performance = new int[5];
            performance[0] = queues[0].maxPerformance + 1;

            try
            {
                performance[0] = Convert.ToInt32(textBoxQueue1.Text);
            }
            catch
            {
                textBoxQueue1.Text = Convert.ToString(performance[0]);
            }
            if (queues[0].minPerformance <= performance[0] && performance[0] <= queues[0].maxPerformance)
            {
                queues[0].perf = performance[0];
            }
            else
            {
                textBoxQueue1.Text = Convert.ToString(queues[0].perf);
            }

            performance[1] = queues[1].maxPerformance + 1;

            try
            {
                performance[1] = Convert.ToInt32(textBoxQueue2.Text);
            }
            catch
            {
                textBoxQueue2.Text = Convert.ToString(performance[1]);
            }
            if (queues[1].minPerformance <= performance[1] && performance[1] <= queues[1].maxPerformance)
            {
                queues[1].perf = performance[1];
            }
            else
            {
                textBoxQueue2.Text = Convert.ToString(queues[1].perf);
            }

            performance[2] = queues[2].maxPerformance + 1;

            try
            {
                performance[2] = Convert.ToInt32(textBoxQueue3.Text);
            }
            catch
            {
                textBoxQueue3.Text = Convert.ToString(performance[2]);
            }
            if (queues[2].minPerformance <= performance[2] && performance[2] <= queues[2].maxPerformance)
            {
                queues[2].perf = performance[2];
            }
            else
            {
                textBoxQueue3.Text = Convert.ToString(queues[2].perf);
            }
            performance[3] = queues[3].maxPerformance + 1;

            try
            {
                performance[3] = Convert.ToInt32(textBoxQueue4.Text);
            }
            catch
            {
                textBoxQueue4.Text = Convert.ToString(performance[3]);
            }
            if (queues[3].minPerformance <= performance[3] && performance[3] <= queues[3].maxPerformance)
            {
                queues[3].perf = performance[3];
            }
            else
            {
                textBoxQueue1.Text = Convert.ToString(queues[3].perf);
            }

            performance[4] = queues[4].maxPerformance + 1;

            try
            {
                performance[4] = Convert.ToInt32(textBoxQueue5.Text);
            }
            catch
            {
                textBoxQueue5.Text = Convert.ToString(performance[4]);
            }
            if (queues[4].minPerformance <= performance[4] && performance[4] <= queues[4].maxPerformance)
            {
                queues[4].perf = performance[4];
            }
            else
            {
                textBoxQueue5.Text = Convert.ToString(queues[4].perf);
            }
            generatePossibility = new GeneratePossibility();
            if (ifPossibilityOK)
            {
                generatePossibility.possibility = Convert.ToInt32(possibility * 10);
            }
            int max_unit_perf = queues[0].perf;
            plannerPoss = 0;
            for (int i = 1; i < queues.Count(); i++)
            {
                if (max_unit_perf < queues[i].perf)
                {
                    max_unit_perf = queues[i].perf;
                    plannerPoss = i;
                }
            }
            queues[plannerPoss].become_planner();
            queues[plannerPoss].plannerTimeRest++;
            buttonStart.Enabled = true;

            timer1MSec.Start();
            timer10Sec.Start();
            timer1Sec.Start();
        }

        private void buttonStopClick(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
            buttonClear.Enabled = true;

            timer1MSec.Stop();
            timer10Sec.Stop();
            timer1Sec.Stop();
            timer.Text = "Seconds left: 0";

            int can_system_perform = 0;
            int can_system_perform_without_planner_loses = 0;
            int how_many_system_perform = 0;

            int theor_perf = 0;
            int tasks_performed_all = 0;
            int operations_completed = 0;
            double theor_perf_quoted = 0;
            for (int i = 0; i < queues.Count(); i++)
            {
                can_system_perform += queues[i].perf * takt;
                how_many_system_perform += queues[i].perf * queues[i].notPlannerTats;
                can_system_perform_without_planner_loses += queues[i].perf * queues[i].notPannerTatsWthUeless;

                theor_perf += queues[i].perf * takt;
                tasks_performed_all += queues[i].tasks_completed();
                theor_perf_quoted += queues[i].perf * queues[i].notPannerTatsWthUeless;
                operations_completed += queues[i].absQueue;
            }
            lESE.Text = "Efficiency - " + (how_many_system_perform / (double)can_system_perform).ToString("0.####");
            lESEquoted.Text = "Efficiency' - " + (how_many_system_perform / (double)can_system_perform_without_planner_loses).ToString("0.####");
            lTasksNumber.Text = "Tasks done - " + Convert.ToString(tasks_performed_all);
            lOperationsCompleted.Text = "Operations done - " + Convert.ToString(operations_completed);
        }

        private void timerTick1Sec(object sender, EventArgs e)
        {
            sec--;
            timer.Text = "Seconds left: " + Convert.ToString(sec);
        }

        private async void ButtonClearClick(object sender, EventArgs e)
        {
            buttonClear.Enabled = false;

            listQueue1.Items.Clear();
            listQueue2.Items.Clear();
            listQueue3.Items.Clear();
            listQueue4.Items.Clear();
            listQueue5.Items.Clear();
            listPossibility.Items.Clear();
            textBoxQueue1.Text = "";
            textBoxQueue2.Text = "";
            textBoxQueue3.Text = "";
            textBoxQueue4.Text = "";
            textBoxQueue5.Text = "";
            textBoxPossibility.Text = "1";
            textBoxComplexity.Text = "";
            for (int i = 4; 0 <= i; i--)
                queues.RemoveAt(i);

            for (int i = 0; i < 5; i++)
            {
                queues.Add(new Queue(plannerTime, timeDiff));
                await System.Threading.Tasks.Task.Delay(10);
            }

            sec = 10;
            timer.Text = "Seconds left: 10";
            lESE.Text = "";
            lESEquoted.Text = "";
            lTasksNumber.Text = "";
            lOperationsCompleted.Text = "";
            realPerf = 0;
            takt = 0;

            buttonStart.Enabled = true;
        }

        private void buttonMainPageClick(object sender, EventArgs e)
        {
            startForm.Show();
            Close();
        }

        private void textBoxPossibility_TextChanged(object sender, EventArgs e)
        {

        }

        private void listQueue1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPossibility_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
