using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace CrystalReports_Startup
{
    public partial class Form1 : Form
    {
        CrystalReport1 CR;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues) 
            Category_cmb.Items.Add(v.Value);
        }
        private void GenerateReport_btn_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, Category_cmb.Text);
            CR.SetParameterValue(1, Convert.ToDateTime(StartDate_txt.Text));
            CR.SetParameterValue(2, Convert.ToDateTime(EndDate_txt.Text));
            crystalReportViewer1.ReportSource = CR;

        }

 

      
    }
}
