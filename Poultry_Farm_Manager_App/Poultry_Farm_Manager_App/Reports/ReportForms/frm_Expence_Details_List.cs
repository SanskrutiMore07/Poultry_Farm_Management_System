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
    public partial class frm_Expence_Details_List : Form
    {
        public frm_Expence_Details_List()
        {
            InitializeComponent();
        }

        /*void Bind_Report(DateTime Start, DateTime End)
        {
            Connection.S_Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Expence_List", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@sdt", dtp_From_Date.Value);
            sqlDa.SelectCommand.Parameters.AddWithValue("@edt", dtp_To_Date.Value);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.S_Con_Close();

            Reports.CrystalReport.crpt_Feed_Purchase_Stock fps = new CrystalReport.crpt_Feed_Purchase_Stock();
            fps.Database.Tables["SP_Expence_List"].SetDataSource(dtbl);

            crpt_Expence_List.ReportSource = null;

            crpt_Expence_List.ReportSource = fps;
        }*/
      

        private void btn_Search_Click(object sender, EventArgs e)
        {
            // Bind_Report(dtp_From_Date.Value.Date, dtp_To_Date.Value.Date);
            Connection.S_Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Expence_List", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@sdt", dtp_From_Date.Value);
            sqlDa.SelectCommand.Parameters.AddWithValue("@edt", dtp_To_Date.Value);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.S_Con_Close();

            Reports.CrystalReport.crpt_Expence_Detalis_List fps = new CrystalReport.crpt_Expence_Detalis_List();
            fps.Database.Tables["SP_Expence_List"].SetDataSource(dtbl);

            crpt_Expence_List.ReportSource = null;

            crpt_Expence_List.ReportSource = fps;
        }
    }
}
