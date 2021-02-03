using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void task1Click(object sender, EventArgs e)
        {

        }

        private void task2Click(object sender, EventArgs e)
        {

        }

        private void task3Click(object sender, EventArgs e)
        {
            (new FormTask3(this)).Show();
            Hide();
        }

        private void buttonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void creators_Click(object sender, EventArgs e) { }
    }
}
