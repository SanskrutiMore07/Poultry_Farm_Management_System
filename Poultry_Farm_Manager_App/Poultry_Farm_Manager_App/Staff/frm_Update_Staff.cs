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

namespace Poultry_Farm_Manager_App.Staff
{
    public partial class frm_Update_Staff : Form
    {
        public frm_Update_Staff()
        {
            InitializeComponent();
        }

        void Enable_Controls()
        {
            tb_Staff_ID.Enabled = false;
            tb_Staff_Name.Enabled = false;
            dtp_Joining_Date.Enabled = false;
            cmb_Designation.Enabled = true;
            tb_Mobile_No.Enabled = true;
            tb_Alternate_Mobile_No.Enabled = true;
            tb_Salary.Enabled = true;
            tb_Aadhar_No.Enabled = false;
            tb_Note.Enabled = true;
            tb_Bank_Detail.Enabled = true;
            tb_Account_No.Enabled = true;
        }


        void Disable_Controls()
        {
            tb_Staff_ID.Enabled = true;
            tb_Staff_Name.Enabled = false;
            dtp_Joining_Date.Enabled = false;
            cmb_Designation.Enabled = false;
            tb_Mobile_No.Enabled = false;
            tb_Alternate_Mobile_No.Enabled = false;
            tb_Salary.Enabled = false;
            tb_Aadhar_No.Enabled = false;
            tb_Note.Enabled = false;
            tb_Bank_Detail.Enabled = false;
            tb_Account_No.Enabled = false;
        }
        void Clear_Controls()
        {
            tb_Staff_ID.Clear();
            tb_Staff_Name.Clear();
            dtp_Joining_Date.ResetText();
            cmb_Designation.SelectedIndex = -1;
            tb_Mobile_No.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Salary.Clear();
            tb_Aadhar_No.Clear();
            tb_Note.Clear();
            tb_Bank_Detail.Clear();
            tb_Account_No.Clear();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Disable_Controls();
        }

        private void ON(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void OT(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }



        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            if (tb_Staff_ID.Text != "")
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Select * from Staff_Details where Staff_ID  = @SID";

                cmd.Parameters.Add("SID", SqlDbType.Int).Value = tb_Staff_ID.Text;

                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Staff_Name.Text = Dr.GetString(Dr.GetOrdinal("Staff_Name"));
                    dtp_Joining_Date.Text = (Dr["Joining_Date"].ToString());
                    cmb_Designation.Text = Dr.GetString(Dr.GetOrdinal("Designation"));
                    tb_Mobile_No.Text = (Dr["Mob_No"].ToString());
                    tb_Alternate_Mobile_No.Text = (Dr["Alt_Mob_No"].ToString());
                    tb_Salary.Text = (Dr["Salary"].ToString());
                    tb_Aadhar_No.Text = (Dr["Aadhaar_No"].ToString());
                    tb_Note.Text = Dr.GetString(Dr.GetOrdinal("Note"));
                    tb_Bank_Detail.Text = Dr.GetString(Dr.GetOrdinal("Bank_Detail"));
                    tb_Account_No.Text = (Dr["Salary"].ToString());

                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Staff Found Of This Id", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_Staff_ID.Clear();
                    tb_Staff_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("First Enter Staff Id", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Connection.S_Con_Close();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            if (cmb_Designation.Text != "" && tb_Mobile_No.Text != "" && tb_Alternate_Mobile_No.Text != "" && tb_Salary.Text != "" && tb_Note.Text != "" && tb_Bank_Detail.Text != "" && tb_Account_No.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Update Staff_Details set Designation = '" + cmb_Designation.Text + "',Mob_No = '" + tb_Mobile_No.Text + "' , Alt_Mob_No = '" + tb_Alternate_Mobile_No.Text + "' , Salary = '" + tb_Salary.Text + "' , Note = '" + tb_Note.Text + "' , Bank_Detail = '" + tb_Bank_Detail.Text + "' , Account_No = '" + tb_Account_No.Text + "' where Staff_ID ='" + tb_Staff_ID.Text + "' ";
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

        private void frm_Update_Staff_Load(object sender, EventArgs e)
        {
            Disable_Controls();
        }
    }
}
