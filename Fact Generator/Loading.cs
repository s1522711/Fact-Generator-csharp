using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fact_Generator
{
    public partial class Loading : Form
    {

        public Loading()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LoadingBar.Value != 100)
            {
                LoadingBar.PerformStep();
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Enabled = false;
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
