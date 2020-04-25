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
            impact.Cinfected = int.Parse(txtCases.Text) * 10;
            severeImpact.Cinfected = int.Parse(txtCases.Text) * 50;

            int factor = normal(comboPeriod.SelectedItem.ToString(), int.Parse(txtTime.Text));

            impact.infectByRT = impact.Cinfected * (int) Math.Pow(2, factor);
            severeImpact.infectByRT = severeImpact.Cinfected * (int)Math.Pow(2,factor);

            impact.CaseByRT =  Convert.ToInt32(0.15 * impact.infectByRT);
            severeImpact.CaseByRT = Convert.ToInt32(0.15 * severeImpact.infectByRT);

            impact.bedByRT = Convert.ToInt32(0.35 * int.Parse(txtBed.Text)) - impact.CaseByRT;
            severeImpact.bedByRT = Convert.ToInt32(0.35 * int.Parse(txtBed.Text)) - severeImpact.CaseByRT;

            impact.iCUByRT = Convert.ToInt32(0.05 * impact.infectByRT);
            severeImpact.infectByRT = Convert.ToInt32(0.05 * severeImpact.infectByRT);

            impact.ventByRT = Convert.ToInt32(0.02 * impact.infectByRT);
            severeImpact.ventByRT = Convert.ToInt32(0.02 * severeImpact.infectByRT);

            decimal income = decimal.Parse(txtAvglncom.Text) * impact.infectByRT;
            decimal income2 = decimal.Parse(txtAvglncom.Text) * severeImpact.infectByRT;
            float a = elapseTime * int.Parse(txtAvgIncDolar.Text);

            impact.dollarFlt = decimal.Truncate(income * (decimal)(a));
            severeImpact.dollarFlt = decimal.Truncate(income2 * (decimal)(a));
            //Displays Results for Mild Impact Estimations
            mildList.Items.Clear(); // clears the Results List
            mildList.Items.Add("Currently Infected Persons: "+ impact.Cinfected);
            mildList.Items.Add("Infected Persons By Requested Time: " + impact.infectByRT);
            mildList.Items.Add("Severe Cases By Requested Time: " + impact.CaseByRT);
            mildList.Items.Add("Avialable Hospital Beds By Requested Time: " + impact.bedByRT);
            mildList.Items.Add("Cases for Intensive Unit Care By Requested Time: " + impact.iCUByRT);
            mildList.Items.Add("Cases Requiring Ventilators By Requested Time: " + impact.ventByRT);
            mildList.Items.Add("Estimated Economic Loss in Dollar ($USD): " + impact.dollarFlt);
            if(impact.bedByRT < 0)
            {
                string warning;
                warning = "There is likely to be a shortage of Bed space By " + Math.Abs(impact.bedByRT) + "Mild infected Persons";
                mildList.Items.Add(warning);
            }

            //Displaying Result for Severe Impact cases of the Estimation
            severeList.Items.Add("Currently Infected Persons: " + severeImpact.Cinfected);
            severeList.Items.Add("Infected Persons By Requested Time: " + severeImpact.infectByRT);
            severeList.Items.Add("Severe Cases By Requested Time: " + severeImpact.CaseByRT);
            severeList.Items.Add("Available Hospital Beds By Requested Time: " + severeImpact.bedByRT);
            severeList.Items.Add("Cases for Intensive Care Unit By Requested Time: " + severeImpact.iCUByRT);
            severeList.Items.Add("Cases requiring Ventilators By Requested Time: " + severeImpact.ventByRT);
            severeList.Items.Add("Estimated Economic Loss in Dollar ($USD): " + severeImpact.dollarFlt);
            if(severeImpact.bedByRT < 0)
            {
                string warning;
                warning = "There is likely to be a shortage of Bed space by " + Math.Abs(severeImpact.bedByRT) + "for Severe Infected Persons";
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
