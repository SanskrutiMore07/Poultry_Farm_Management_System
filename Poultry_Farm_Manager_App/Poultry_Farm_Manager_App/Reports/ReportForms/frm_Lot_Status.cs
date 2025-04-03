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
    public partial class frm_Lot_Status : Form
    {
        public frm_Lot_Status()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_Lot_Status", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@sdt", dtp_from.Value.Date);
            sqlDa.SelectCommand.Parameters.AddWithValue("@edt", dtp_to.Value.Date);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.S_Con_Close();

            Reports.CrystalReport.crpt_Lot_Status obj = new CrystalReport.crpt_Lot_Status();
            obj.Database.Tables["sp_Lot_Status"].SetDataSource(dtbl);

            crpt_Lot_Status.ReportSource = null;

            crpt_Lot_Status.ReportSource = obj;
        }
    }
}
