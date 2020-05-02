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
    public partial class estimate : Form
    {
        public estimate()
        {
            InitializeComponent();
            combofill();
        }
        
        impact impact = new impact();
        severeImpact severeImpact = new severeImpact();
        //computation data
        int elapseTime;
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (txtAge.Text != "" && txtAvgIncDolar.Text!="" && txtAvglncom.Text!="" && txtBed.Text!="" && txtCases.Text!="" && txtctry.Text!="" && txtPopulation.Text!="" && txtRegion.Text!="" && txtTime.Text!="" && comboPeriod.Text!= "Choose Period Type")
            {
                impact.Cinfected = int.Parse(txtCases.Text) * 10;
                severeImpact.Cinfected = int.Parse(txtCases.Text) * 50;

                int factor = normal(comboPeriod.SelectedItem.ToString(), int.Parse(txtTime.Text));

                impact.infectByRT = impact.Cinfected * (int)Math.Pow(2, factor);
                severeImpact.infectByRT = severeImpact.Cinfected * (int)Math.Pow(2, factor);

                impact.CaseByRT = Convert.ToInt32(0.15 * impact.infectByRT);
                severeImpact.CaseByRT = Convert.ToInt32(0.15 * severeImpact.infectByRT);

                impact.bedByRT = Convert.ToInt32(0.35 * int.Parse(txtBed.Text)) - impact.CaseByRT;
                severeImpact.bedByRT = Convert.ToInt32(0.35 * int.Parse(txtBed.Text)) - severeImpact.CaseByRT;

                impact.iCUByRT = Convert.ToInt32(0.05 * impact.infectByRT);
                severeImpact.iCUByRT = Convert.ToInt32(0.05 * severeImpact.infectByRT);

                impact.ventByRT = Convert.ToInt32(0.02 * impact.infectByRT);
                severeImpact.ventByRT = Convert.ToInt32(0.02 * severeImpact.infectByRT);

                decimal income = decimal.Parse(txtAvglncom.Text) * impact.infectByRT;
                decimal income2 = decimal.Parse(txtAvglncom.Text) * severeImpact.infectByRT;
                float a = elapseTime * int.Parse(txtAvgIncDolar.Text);

                impact.dollarFlt = decimal.Truncate(income * (decimal)(a));
                severeImpact.dollarFlt = decimal.Truncate(income2 * (decimal)(a));
                //Display Results in table
                DataTable tbl = new DataTable();
                tbl.Columns.AddRange(new DataColumn[3] { new DataColumn(" ", typeof(string)), new DataColumn("Mild Impact", typeof(string)), new DataColumn("Severe Impact", typeof(string)) });
                tbl.Rows.Add("Currently Infected Persons", impact.Cinfected, severeImpact.Cinfected);
                tbl.Rows.Add("Infected Persons By Requested Time", impact.infectByRT, severeImpact.infectByRT);
                tbl.Rows.Add("Severe Cases By Requested Time", impact.CaseByRT, severeImpact.CaseByRT);
                tbl.Rows.Add("Available Hospital Beds By Requested time", impact.bedByRT, severeImpact.bedByRT);
                tbl.Rows.Add("Cases for Intensive Care Unit By Requested Time", impact.iCUByRT, severeImpact.iCUByRT);
                tbl.Rows.Add("Cases requiring Ventilators By Requested Time", impact.ventByRT, severeImpact.ventByRT);
                tbl.Rows.Add("Estimated Economic Loss in Dollar ($USD)", impact.dollarFlt, severeImpact.dollarFlt);

                Result rs = new Result();
                rs.dataG.DataSource = tbl;
                rs.tbl = tbl;
                rs.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all Fields", "Error", MessageBoxButtons.OK);
            }
           
        }

        private void combofill()
        {
            comboPeriod.Items.Add("Days");
            comboPeriod.Items.Add("Weeks");
            comboPeriod.Items.Add("Months");
        }
        public int normal(string periodType, int time)
        {
            int normalized =0;
            if (periodType == "Days")
            {
                elapseTime = time;
                normalized = time / 3;
            }else if(periodType == "Weeks")
            {
                elapseTime = (time * 7);
                normalized = elapseTime / 3;
            }else if (periodType == "Months")
            {
                elapseTime = (time * 30);
                normalized = elapseTime / 3;
            }
            return normalized;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtAvgIncDolar.Clear();
            txtAvglncom.Clear();
            txtBed.Clear();
            txtCases.Clear();
            txtctry.Clear();
            txtPopulation.Clear();
            txtRegion.Clear();
            txtTime.Clear();
            comboPeriod.Text = "Choose Period Type";
        }
    }

    public class impact
    {
        public int Cinfected;
        public int infectByRT;
        public int CaseByRT;
        public int bedByRT;
        public int iCUByRT;
        public int ventByRT;
        public decimal dollarFlt;
    }
    public class severeImpact
    {
        public int Cinfected;
        public int infectByRT;
        public int CaseByRT;
        public int bedByRT;
        public int iCUByRT;
        public int ventByRT;
        public decimal dollarFlt;
    }
}
