using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Multithreads3.GlobalConstant;

using Multithreads3.strategy;

namespace Multithreads3
{
    public partial class MemoryForm : Form
    {
        private UsageTable usageTable;
        private Context context;
        private List<Dictionary<int, int>> listTableXY;
        private List<int> previousInitilizeId;
        private bool isRunByStep;

        public MemoryForm()
        {
            context = new Context(new OptimalStrategyImpl());
            listTableXY = new List<Dictionary<int, int>>();
            previousInitilizeId = new List<int>();
            usageTable = new UsageTable();
            isRunByStep = false;
            InitializeComponent();
            setInitializationTact();
        }

        private void lightButtonInTableById(int id)
        {
            switch (id)
            {
                case 0:
                    this.buttonTact0.BackColor = Color.FromArgb(230, 230, 0);
                    break;
                case 1:
                    this.buttonTact1.BackColor = Color.FromArgb(230, 230, 0);
                    break;
                case 2:
                    this.buttonTact2.BackColor = Color.FromArgb(230, 230, 0);
                    break;
                case 3:
                    this.buttonTact3.BackColor = Color.FromArgb(230, 230, 0);
                    break;
                case 4:
                    this.buttonTact4.BackColor = Color.FromArgb(230, 230, 0);
                    break;
                case 5:
                    this.buttonTact5.BackColor = Color.FromArgb(230, 230, 0);
                    break;
                case 6:
                    this.buttonTact6.BackColor = Color.FromArgb(230, 230, 0);
                    break;
                case 7:
                    this.buttonTact7.BackColor = Color.FromArgb(230, 230, 0);
                    break;
            }
        }

        private void setInitializationTact ()
        {
            string str = "Initialization tact (allow max=2): \n";
            for (int i = 0; i < TACT; i++)
            {
                if (this.context.executeStrategyIsInitById(i) == true)
                {
                    str += i.ToString() + "  ";
                }
            }
            this.ilabelInit.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (isRunByStep == false)
            {
                //string str = "";
                listTableXY = new List<Dictionary<int, int>>();
                int[] arrayOfIndex = new int[ALLOW_MAX];
                for (int elem = 0; elem < ALLOW_MAX; elem++)
                {
                    arrayOfIndex[elem] = -1;
                }
                int countInit = 0, countTact = 0;
                bool continueWhile = true;
                while (continueWhile == true)
                {
                    if (countInit > ALLOW_MAX)
                    {
                        errorMessega.Text = "ERROR: Cannot run new process";
                        break;
                    }
                    for (int i = 0; i < ALLOW_MAX; i++)
                    {
                        if (arrayOfIndex[i] != -1)
                        {
                            if (!listTableXY[i].ContainsKey(arrayOfIndex[i])
                                & arrayOfIndex[i] < TACT)
                            {
                                listTableXY[i].Add(arrayOfIndex[i],
                                   usageTable.getTableElementById(arrayOfIndex[i]));
                            }
                            arrayOfIndex[i]++;
                        }
                    }
                    if (countTact < TACT)
                    {
                        if (context.executeStrategyIsInitById(countTact) == true)
                        {
                            if (countInit > ALLOW_MAX - 1)
                            {
                                errorMessega.Text = "ERROR: Cannot run new process";
                                break;
                            }
                            if (countInit > 0)
                            {
                                previousInitilizeId.Add(arrayOfIndex[countInit - 1]);
                            }
                            arrayOfIndex[countInit]++;
                            listTableXY.Add(new Dictionary<int, int>());
                            listTableXY[countInit].Add(arrayOfIndex[countInit],
                                usageTable.getTableElementById(arrayOfIndex[countInit]));
                            countInit++;
                        }
                    }
                    continueWhile = false;
                    for (int elem = 0; elem < ALLOW_MAX; elem++)
                    {
                        if (arrayOfIndex[elem] < TACT)
                        {
                            lightButtonInTableById(arrayOfIndex[elem]);
                            continueWhile = true;
                        }
                    }
                    countTact++;
                }
                /*foreach (Dictionary<int, int> value in listTableXY)
                {
                    str += "Dictionary\n";
                    for (int i = 0; i < TACT; i++)
                    {
                        if (value.ContainsKey(i))
                        {
                            str += i.ToString() + " " + value[i].ToString() + "\n";
                        }
                    }
                   // str += "\n";
                }
                str += "Previouz initilize: ";
                foreach (int value in previousInitilizeId)
                {
                    str += value.ToString() + "  ";
                }
                label10.Text += str;*/
                for (int j = 0, i, toRun, capacityInitilize = previousInitilizeId.Capacity / sizeof(int);
                    j < capacityInitilize; j++)
                {
                    for (i = 0, toRun = previousInitilizeId[j]; i < toRun; i++)
                    {
                        this.tableProcess.Rows.Add(listTableXY[0][i].ToString(), "-");
                    }
                    for (toRun = 0; toRun < TACT; toRun++)
                    {
                        if (i < TACT)
                        {
                            this.tableProcess.Rows.Add(listTableXY[0][i].ToString(),
                                listTableXY[1][toRun].ToString());
                            i++;
                        }
                        else
                        {
                            this.tableProcess.Rows.Add("-",
                                listTableXY[1][toRun].ToString());
                        }
                    }
                }
                //this.columnProcess1.Add
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EfficiencyLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    context = new Context(new OptimalStrategyImpl());
                    this.labelChooseStrategy.Text = "Optimal strategy";
                    
                    break;
                case 1:
                    context = new Context(new AllowLatencyStrategyImpl());
                    this.labelChooseStrategy.Text = "Allow latency strategy";
                    break;
                case 2:
                    context = new Context(new GreedyStrategyImpl());
                    this.labelChooseStrategy.Text = "Greedy strategy";
                    break;
            }
            /*this.tableProcess.Columns.Remove("columnProcess1");
            this.tableProcess.Columns.Remove("columnProcess2");
            this.tableProcess.Columns.Add(this.columnProcess2);
            this.tableProcess.Columns.Add(this.columnProcess1);
            do
            {
                foreach (DataGridViewRow row in this.tableProcess.Rows)
                {
                    try
                    {
                        this.tableProcess.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (this.tableProcess.Rows.Count > 1);
            this.tableProcess.DataSource = null;
            this.tableProcess.Refresh();*/
            setInitializationTact();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRoutine_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isRunByStep = (((ComboBox)sender).SelectedIndex == 1);
        }

        private void tableProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
