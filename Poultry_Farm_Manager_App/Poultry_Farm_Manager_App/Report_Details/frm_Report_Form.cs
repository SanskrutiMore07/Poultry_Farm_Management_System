using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App.Report_Details
{
    public partial class frm_Report_Form : Form
    {
        public frm_Report_Form()
        {
            InitializeComponent();
        }

        private void pb_Feed_Purchase_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Monthly_Feed_Report MFR = new Reports.ReportForms.frm_Monthly_Feed_Report();
            MFR.Show();
        }

        private void pb_Feed_Consumption_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Feed_Consumption FCR = new Reports.ReportForms.frm_Feed_Consumption();
            FCR.Show();
        }

        private void pb_Expence_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Expence_Details_List ER = new Reports.ReportForms.frm_Expence_Details_List();
            ER.Show();
        }

        private void pb_Lot_Status_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Lot_Status LS = new Reports.ReportForms.frm_Lot_Status();
            LS.Show();
        }

        private void pb_Lot_Entry_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_New_Lot_Entry NLE = new Reports.ReportForms.frm_New_Lot_Entry();
            NLE.Show();
        }

        private void pb_Lot_Dispatch_Report_Click(object sender, EventArgs e)
        {
            Reports.ReportForms.frm_Dispatch_Lot_Report DL = new Reports.ReportForms.frm_Dispatch_Lot_Report();
            DL.Show();
        }
    }
}
