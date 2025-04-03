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

namespace Poultry_Farm_Manager_App.Trader
{
    public partial class frm_Add_Trader : Form
    {
        public frm_Add_Trader()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Trader_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Trader_Details", "Trader_ID", 1001));
            tb_Trader_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Alternate_Mobile_No.Clear();
            dtp_Joining_Date.ResetText();
            tb_Aadhar_No.Clear();
            tb_Email_ID.Clear();
            tb_PAN_No.Clear();
            tb_Bank_Detail.Clear();
            tb_Account_No.Clear();
            tb_Note.Clear();
        }

        private void ON(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void OT(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void AN(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Alpha_Numeric(e);
        }

        private void frm_Add_Trader_Load(object sender, EventArgs e)
        {
            tb_Trader_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Trader_Details", "Trader_ID", 1001));
        }

       

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();
            if (tb_Trader_ID.Text != "" && tb_Trader_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Alternate_Mobile_No.Text != "" && dtp_Joining_Date.Text != "" && tb_Aadhar_No.Text != "" && tb_Email_ID.Text != "" && tb_PAN_No.Text != "" && tb_Bank_Detail.Text != "" && tb_Account_No.Text != "" && tb_Note.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Insert Into Trader_Details values (@TID,@TName,@MNo,@AltMNo,@Date,@ANo,@EmailID,@PNo,@BankD,@AcNo,@Note)";
                cmd.Parameters.Add("TID", SqlDbType.Int).Value = tb_Trader_ID.Text;
                cmd.Parameters.Add("TName", SqlDbType.VarChar).Value = tb_Trader_Name.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("AltMNo", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Joining_Date.Text;
                cmd.Parameters.Add("ANo", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                cmd.Parameters.Add("EmailID", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                cmd.Parameters.Add("PNo", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                cmd.Parameters.Add("BankD", SqlDbType.NVarChar).Value = tb_Bank_Detail.Text;
                cmd.Parameters.Add("AcNo", SqlDbType.Decimal).Value = tb_Account_No.Text;
                cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Trader Information Is Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Connection.S_Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();

        }
    }
}
