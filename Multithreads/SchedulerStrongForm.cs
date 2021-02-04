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
    public partial class SchedulerStrongForm : Form
    {
        private StartForm startForm;
        public SchedulerStrongForm(StartForm _startForm)
        {
            InitializeComponent();
            startForm = _startForm;
        }

        private void SchedulerStrongForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            startForm.Show();
        }
    }
}
