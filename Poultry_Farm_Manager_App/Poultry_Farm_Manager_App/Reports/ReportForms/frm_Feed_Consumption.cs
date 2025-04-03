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
    public partial class frm_Feed_Consumption : Form
    {
        public frm_Feed_Consumption()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_Feed_Consumption", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@sdt", dtp_from.Value);
            sqlDa.SelectCommand.Parameters.AddWithValue("@edt", dtp_to.Value);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.S_Con_Close();

            Reports.CrystalReport.crpt_Feed_Consumption obj = new CrystalReport.crpt_Feed_Consumption();
            obj.Database.Tables["sp_Feed_Consumption"].SetDataSource(dtbl);

            crpt_Consumption.ReportSource = null;

            crpt_Consumption.ReportSource = obj;
        }

       
    }
}
