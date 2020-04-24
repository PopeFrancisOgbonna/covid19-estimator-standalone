using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongDateString();
            timelbl.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            estimate est = new estimate();
            est.ShowDialog();
            this.Close();
            
        }
    }
}
