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
    public partial class frm_Add_Staff : Form
    {
        public frm_Add_Staff()
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
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }


        private void frm_Add_Staff_Load(object sender, EventArgs e)
        {
            tb_Staff_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Staff_Details", "Staff_ID", 101));
        }

        void  Clear_Controls()
        {
            tb_Staff_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Staff_Details", "Staff_ID", 101));
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();
            if(tb_Staff_ID.Text != "" && tb_Staff_Name.Text != "" && dtp_Joining_Date.Text != "" && cmb_Designation.Text !="" && tb_Mobile_No.Text != "" && tb_Salary.Text != "" && tb_Aadhar_No.Text != "" && tb_Note.Text != "" && tb_Bank_Detail.Text != "" && tb_Account_No.Text != "" )
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Insert Into Staff_Details Values(@SID,@SName,@JDate,@Designation,@MNo,@AltMNo,@Salary,@ANo,@Note,@BankD,@AcNo,@Status,@CreateUser)";
                cmd.Parameters.Add("SID", SqlDbType.Int).Value = tb_Staff_ID.Text;
                cmd.Parameters.Add("SName", SqlDbType.VarChar).Value = tb_Staff_Name.Text;
                cmd.Parameters.Add("JDate", SqlDbType.Date).Value = dtp_Joining_Date.Text;
                cmd.Parameters.Add("Designation", SqlDbType.VarChar).Value = cmb_Designation.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("AltMNo", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                cmd.Parameters.Add("Salary", SqlDbType.Money).Value = tb_Salary.Text;
                cmd.Parameters.Add("ANo", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;
                cmd.Parameters.Add("BankD", SqlDbType.NVarChar).Value = tb_Bank_Detail.Text;
                cmd.Parameters.Add("AcNo", SqlDbType.Decimal).Value = tb_Account_No.Text;
                cmd.Parameters.Add("Status", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("CreateUser", SqlDbType.Int).Value = Shared_Content.User_Id;


                cmd.ExecuteNonQuery();

                MessageBox.Show("Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
    }
}
