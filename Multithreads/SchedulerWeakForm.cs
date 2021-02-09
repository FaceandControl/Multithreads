using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreads
{
    public partial class SchedulerWeakForm : Form
    {
        private StartForm startForm;

        private List<ComputeUnit> computeUnits = new List<ComputeUnit>();
        private ProbabilityGenerator probabilityGenerator = new ProbabilityGenerator();
        private bool wasTaskTaken = true;
        private int timeCounter;
        Task taskToDo;
        Task ScheduleTask;
        private int allPerformance;
        private int maxOperationsCouldBeDone;
        private List<int> AbleUnits;
        private int SchedUnitPos;

        public SchedulerWeakForm(StartForm _startForm)
        {
            InitializeComponent();
            startForm = _startForm;
            for (int i = 0; i < 5; i++)
            {
                computeUnits.Add(new ComputeUnit());
            }
            SetSchedUnitPos();
        }

        private void SchedulerWeakForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            startForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeCounter--;
            SecondsLeftlabel.Text = "Seconds left: " + timeCounter;
            if (timeCounter == 0)
                StopButton_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unitListView1.Items.Clear();
            unitListView2.Items.Clear();
            unitListView3.Items.Clear();
            unitListView4.Items.Clear();
            unitListView5.Items.Clear();
            TasksListView.Items.Clear();

            EfficiencyLabel.Text = "Efficiency:";
            OperationsDoneLabel.Text = "Operations done:";
            TasksDoneLabel.Text = "Tasks done:";
            SecondsLeftlabel.Text = "Seconds left: 10";

            timeCounter = 10;

            try
            {
                probabilityGenerator = new ProbabilityGenerator(Convert.ToInt32(ProbabilityBox.Text));
            }
            catch
            {
                ProbabilityBox.Text = Convert.ToString(probabilityGenerator.Rand_coef);
            }

            try
            {
                computeUnits[0].Performance = Convert.ToInt32(Unit1Box.Text);
            }
            catch
            {
                Unit1Box.Text = Convert.ToString(computeUnits[0].Performance);
            }
            try
            {
                computeUnits[1].Performance = Convert.ToInt32(Unit2Box.Text);
            }
            catch
            {
                Unit2Box.Text = Convert.ToString(computeUnits[1].Performance);
            }
            try
            {
                computeUnits[2].Performance = Convert.ToInt32(Unit3Box.Text);
            }
            catch
            {
                Unit3Box.Text = Convert.ToString(computeUnits[2].Performance);
            }
            try
            {
                computeUnits[3].Performance = Convert.ToInt32(Unit4Box.Text);
            }
            catch
            {
                Unit4Box.Text = Convert.ToString(computeUnits[3].Performance);
            }
            try
            {
                computeUnits[4].Performance = Convert.ToInt32(Unit5Box.Text);
            }
            catch
            {
                Unit5Box.Text = Convert.ToString(computeUnits[4].Performance);
            }

            maxOperationsCouldBeDone = 0;
            allPerformance = 0;
            foreach (ComputeUnit computeUnit in computeUnits)
                allPerformance += computeUnit.Performance;

            TickTimer.Start();
            OneSecondTimer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            TickTimer.Stop();
            OneSecondTimer.Stop();
            EfficiencyLabel.Text = "Efficiency: " + (ComputeUnit.Sum_finished_operations / (double)maxOperationsCouldBeDone).ToString("0.##%");
            OperationsDoneLabel.Text = "Operations done: " + ComputeUnit.Sum_finished_operations.ToString();
            TasksDoneLabel.Text = "Tasks done: " + ComputeUnit.Sum_finished_tasks.ToString();
            ComputeUnit.CleanStaticSum();
        }

        private void SetSchedUnitPos()
        {
            int weakest_unit_pos = 0;
            for (int i = 0; i < computeUnits.Count; i++)
            {
                if (computeUnits[i].GetPerformance() < computeUnits[weakest_unit_pos].GetPerformance())
                {
                    weakest_unit_pos = i;
                }
            }
            SchedUnitPos = weakest_unit_pos;
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            maxOperationsCouldBeDone += allPerformance;
            for (int i = 0; i < computeUnits.Count; i++)
            {
                computeUnits[i].Tick();
            }

            if (wasTaskTaken && probabilityGenerator.Generate())
            {
                taskToDo = new Task();
                AbleUnits = new List<int>(taskToDo.GetUnitsFit());
                ListViewItem taskListViewItem = new ListViewItem(new string[] {
                    taskToDo.Task_id.ToString(),
                    taskToDo.Complexity.ToString(),
                    String.Join(", ", taskToDo.GetUnitsFit())
                });
                TasksListView.Items.Add(taskListViewItem);
                
                wasTaskTaken = false;
            }
           if (!wasTaskTaken)
            {
                List<int> Schedule_unit_num = new List<int>() { SchedUnitPos + 1 };
                ScheduleTask = new Task(0, Schedule_unit_num);

                computeUnits[SchedUnitPos].AddTaskSchedWeak(ScheduleTask.Complexity);

                ListViewItem unitListViewItem1 = new ListViewItem(new string[] {
                            ScheduleTask.Task_id.ToString(),
                            ScheduleTask.Complexity.ToString(),
                            String.Join(", ", ScheduleTask.GetUnitsFit())
                        });

                switch (SchedUnitPos + 1)
                {
                    case 1:
                        unitListView1.Items.Add(unitListViewItem1);
                        break;
                    case 2:
                        unitListView2.Items.Add(unitListViewItem1);
                        break;
                    case 3:
                        unitListView3.Items.Add(unitListViewItem1);
                        break;
                    case 4:
                        unitListView4.Items.Add(unitListViewItem1);
                        break;
                    case 5:
                        unitListView5.Items.Add(unitListViewItem1);
                        break;
                }

                int freest_unit_pos = 0;
                for (int i = 0; i < AbleUnits.Count; i++)
                {
                    if(computeUnits[AbleUnits[i] - 1].GetWorkload() <
                        computeUnits[freest_unit_pos].GetWorkload() &&
                        i != SchedUnitPos)
                    {
                        freest_unit_pos = i;
                    }
                }

                if(freest_unit_pos == SchedUnitPos)
                {
                    wasTaskTaken = false;
                    return;
                }

                computeUnits[freest_unit_pos].AddTaskSchedWeak(taskToDo.Complexity);

                ListViewItem unitListViewItem2 = new ListViewItem(new string[] {
                            taskToDo.Task_id.ToString(),
                            taskToDo.Complexity.ToString(),
                            String.Join(", ", taskToDo.GetUnitsFit())
                        });

                switch (freest_unit_pos + 1)
                {
                            case 1:
                                unitListView1.Items.Add(unitListViewItem2);
                                break;
                            case 2:
                                unitListView2.Items.Add(unitListViewItem2);
                                break;
                            case 3:
                                unitListView3.Items.Add(unitListViewItem2);
                                break;
                            case 4:
                                unitListView4.Items.Add(unitListViewItem2);
                                break;
                            case 5:
                                unitListView5.Items.Add(unitListViewItem2);
                                break;
                }
           wasTaskTaken = true;
           return;
           }
        }
    }
}
