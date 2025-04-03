using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Poultry_Farm_Manager_App.Reports.ReportForms
{
    public partial class frm_Monthly_Feed_Report : Form
    {
        public frm_Monthly_Feed_Report()
        {
            InitializeComponent();
        }
        void Bind_Report(int Month, int Year)
        {
           Connection.S_Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_Monthly_Feed_Report", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Month", Month);
            sqlDa.SelectCommand.Parameters.AddWithValue("@Year", Year);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.S_Con_Close();

            Reports.CrystalReport.crpt_Monthly_Feed_Report MFR = new CrystalReport.crpt_Monthly_Feed_Report();
            MFR.Database.Tables["sp_Monthly_Feed_Report"].SetDataSource(dtbl);

            crpt_Monthly_Feed_Report.ReportSource = null;

            crpt_Monthly_Feed_Report.ReportSource = MFR;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            int C_Month = System.DateTime.Today.Month;
            int C_Year = System.DateTime.Today.Year;

            cmb_Year.Text = Convert.ToString(C_Year);
            cmb_Month.SelectedIndex = C_Month - 1;

            Bind_Report(C_Month, C_Year);
        }

        private void frm_Monthly_Feed_Report_Load(object sender, EventArgs e)
        {
            btn_Refresh.PerformClick();
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_Month.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_Year.Text);

            Bind_Report(C_Month, C_Year);
        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_Month.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_Year.Text);

            Bind_Report(C_Month, C_Year);
        }
    }
}
