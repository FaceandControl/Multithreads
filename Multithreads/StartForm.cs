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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ShowFormAndHide(Form form)
        {
            form.Show();
            Hide();
        }

        private void FIFOButton_Click(object sender, EventArgs e)
        {
            ShowFormAndHide(new FIFOForm(this));
        }

        private void SchedulerWeakButtom_Click(object sender, EventArgs e)
        {
            ShowFormAndHide(new SchedulerWeakForm(this));
        }

        private void SchedulerStrongButton_Click(object sender, EventArgs e)
        {
            ShowFormAndHide(new SchedulerStrongForm(this));
        }
    }
}
