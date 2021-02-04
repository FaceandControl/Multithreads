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
    public partial class FIFOForm : Form
    {
        private StartForm startForm;

        private List<ComputeUnit> computeUnits = new List<ComputeUnit>();
        private ProbabilityGenerator probabilityGenerator = new ProbabilityGenerator();
        private bool wasTaskTaken = true;
        private int timeCounter;
        Task taskToDo;
        private List<int> shuffeledAbleUnits;

        public FIFOForm(StartForm _startForm)
        {
            InitializeComponent();
            startForm = _startForm;
            for (int i = 0; i < 5; i++)
            {
                computeUnits.Add(new ComputeUnit());
            }
        }

        private void FIFOForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            startForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            unitListView1.Clear();
            unitListView2.Clear();
            unitListView3.Clear();
            unitListView4.Clear();
            unitListView5.Clear();
            tasksListView.Clear();

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

            TickTimer.Start();
            OneSecondTimer.Start();
            //TenSocondsTimer.Start();
        }

        private void TenSocondsTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {


            TickTimer.Stop();
            OneSecondTimer.Stop();
            //TenSocondsTimer. Stop();
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < computeUnits.Count; i++) {
                computeUnits[i].Tick();
            }

            if (0 < tasksListView.Items.Count)
                tasksListView.EnsureVisible(tasksListView.Items.Count - 1);

            string[] strs = { "fda", "dad", "dasds" };
            ListViewItem item = new ListViewItem(strs);
            tasksListView.Items.Add(item);

            if (wasTaskTaken)
            {
                taskToDo = new Task();
                shuffeledAbleUnits = new List<int>(taskToDo.GetUnitsFit());
                
                
                shuffeledAbleUnits.Shuffle();
            }
            if (!wasTaskTaken || probabilityGenerator.Generate()) {
                wasTaskTaken = false;
                for (int i = 0; i < shuffeledAbleUnits.Count; i++) {
                    if (computeUnits[shuffeledAbleUnits[i] - 1].AddTaskFIFO(taskToDo.Complexity))
                    {
                        wasTaskTaken = true;
                        return;
                    }
                }
            }
        }
    }
}
