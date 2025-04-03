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
    public partial class frm_Update_Trader : Form
    {
        public frm_Update_Trader()
        {
            InitializeComponent();
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

        void Clear_Controls()
        {
            tb_Trader_ID.Clear();
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
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Disable_Controls();
        }
        void Enable_Controls()
        {
            tb_Trader_ID.Enabled = false;
            tb_Trader_Name.Enabled = false;
            tb_Mobile_No.Enabled = true;
            tb_Alternate_Mobile_No.Enabled = true;
            dtp_Joining_Date.Enabled = false;
            tb_Aadhar_No.Enabled = false;
            tb_Email_ID.Enabled = false;
            tb_PAN_No.Enabled = false;
            tb_Bank_Detail.Enabled = true;
            tb_Account_No.Enabled = true;

        }
        void Disable_Controls()
        {
            tb_Trader_ID.Enabled = true;
            tb_Trader_Name.Enabled = false;
            tb_Mobile_No.Enabled = false;
            tb_Alternate_Mobile_No.Enabled = false;
            dtp_Joining_Date.Enabled = false;
            tb_Aadhar_No.Enabled = false;
            tb_Email_ID.Enabled = false;
            tb_PAN_No.Enabled = false;
            tb_Bank_Detail.Enabled = false;
            tb_Account_No.Enabled = false;
            tb_Note.Enabled = false;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {

            Connection.S_Con_Open();

            if (tb_Trader_ID.Text != "")
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Select * from Trader_Details where Trader_ID = @TID";

                cmd.Parameters.Add("TID", SqlDbType.Int).Value = tb_Trader_ID.Text;

                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Trader_Name.Text = Dr.GetString(Dr.GetOrdinal("Trader_Name"));
                    tb_Mobile_No.Text = (Dr["Mob_No"].ToString());
                    tb_Alternate_Mobile_No.Text = (Dr["Alt_Mob_No"].ToString());
                    dtp_Joining_Date.Text = (Dr["Date"].ToString());
                    tb_Aadhar_No.Text = (Dr["Aadhaar_No"].ToString());
                    tb_Email_ID.Text = (Dr["Email_ID"].ToString());
                    tb_PAN_No.Text = (Dr["PAN_No"].ToString());
                    tb_Bank_Detail.Text = Dr.GetString(Dr.GetOrdinal("Bank_Detail"));
                    tb_Account_No.Text = (Dr["Account_No"].ToString());
                    tb_Note.Text = Dr.GetString(Dr.GetOrdinal("Note"));

                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Trader Found Of This Id", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_Trader_ID.Clear();
                    tb_Trader_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("First Enter Trader Id", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Connection.S_Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            if (tb_Trader_ID.Text != "" && tb_Trader_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Alternate_Mobile_No.Text != "" && dtp_Joining_Date.Text != "" && tb_Aadhar_No.Text != "" && tb_Email_ID.Text != "" && tb_PAN_No.Text != "" && tb_Bank_Detail.Text != "" && tb_Account_No.Text != "" && tb_Note.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Update Trader_Details set Mob_No = '" + tb_Mobile_No.Text + "' , Alt_Mob_No = '" + tb_Alternate_Mobile_No.Text + "', Date = '" + dtp_Joining_Date.Text + "',Aadhaar_No = '" + tb_Aadhar_No.Text + "',Email_ID = '" + tb_Email_ID.Text + "', PAN_No = '" + tb_PAN_No.Text + "' , Note = '" + tb_Note.Text + "' , Bank_Detail = '" + tb_Bank_Detail.Text + "' , Account_No = '" + tb_Account_No.Text + "' where Trader_ID ='" + tb_Trader_ID.Text + "' ";
                cmd.Connection = Connection.DBCon;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
                Disable_Controls();
            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Connection.S_Con_Close();
        }

        private void frm_Update_Trader_Load(object sender, EventArgs e)
        {
            Disable_Controls();
        }
    }
}
