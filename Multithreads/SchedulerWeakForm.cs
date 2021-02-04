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
        public SchedulerWeakForm(StartForm _startForm)
        {
            InitializeComponent();
            startForm = _startForm;
        }

        private void SchedulerWeakForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            startForm.Show();
        }
    }
}
