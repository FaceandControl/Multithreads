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

namespace lab1
{
    public partial class FormTask3 : Form
    {
        private MainForm mainForm;

        public FormTask3(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void timerTick(object sender, EventArgs e)
        {

        }

        private void buttonStartClick(object sender, EventArgs e)
        {

        }

        private void buttonStopClick(object sender, EventArgs e)
        { }

        private void buttonClearClick(object sender, EventArgs e)
        { }

        private void buttonMainPageClick(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }
    }
}
