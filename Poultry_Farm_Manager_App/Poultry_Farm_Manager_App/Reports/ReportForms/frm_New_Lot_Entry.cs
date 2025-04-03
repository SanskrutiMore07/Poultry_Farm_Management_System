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
    public partial class frm_New_Lot_Entry : Form
    {
        public frm_New_Lot_Entry()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_New_Lot_Entry_Report", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Lot_id", tb_Lot_No.Text);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.S_Con_Close();

            Reports.CrystalReport.crpt_New_Lot_Entry obj = new CrystalReport.crpt_New_Lot_Entry();
            obj.Database.Tables["sp_New_Lot_Entry_Report"].SetDataSource(dtbl);

            crpt_New_Lot_Entry.ReportSource = null;

            crpt_New_Lot_Entry.ReportSource = obj;
        }
    }
}
