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
    public partial class frm_Feed_Purchase_Report : Form
    {
        public frm_Feed_Purchase_Report()
        {
            InitializeComponent();
        }

        private void frm_Feed_Purchase_Report_Load(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_Feed_Purchase_Stock", Connection.DBCon);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@PI",Shared_Content.Purchase_ID);

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connection.S_Con_Close();

            Reports.CrystalReport.crpt_Feed_Purchase_Stock obj = new CrystalReport.crpt_Feed_Purchase_Stock();
            obj.Database.Tables["sp_Feed_Purchase_Stock"].SetDataSource(dtbl);

            crpt_Feed_Purchase.ReportSource = null;

            crpt_Feed_Purchase.ReportSource = obj;
        }

    }
}

