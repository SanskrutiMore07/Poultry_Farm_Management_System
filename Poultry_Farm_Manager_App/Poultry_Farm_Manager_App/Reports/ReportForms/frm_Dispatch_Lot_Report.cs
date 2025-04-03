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
    public partial class frm_Dispatch_Lot_Report : Form
    {
        public frm_Dispatch_Lot_Report()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_Lot_Dispatch", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Lot_id", tb_Lot_No.Text);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.S_Con_Close();

            Reports.CrystalReport.crpt_Lot_Dispatch obj = new CrystalReport.crpt_Lot_Dispatch();
            obj.Database.Tables["sp_Lot_Dispatch"].SetDataSource(dtbl);

            crpt_Dispatch_Lot.ReportSource = null;

            crpt_Dispatch_Lot.ReportSource = obj;
        }

      
    }
}
