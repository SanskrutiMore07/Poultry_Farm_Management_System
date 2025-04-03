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

namespace Poultry_Farm_Manager_App.User_Management
{
    public partial class frm_Add_User : Form
    {
        public frm_Add_User()
        {
            InitializeComponent();
        }

         void Clear_Controls()
        {
            
            cmb_User_Role.SelectedIndex = -1;
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Confirm_Password.Clear();
        }
        private void frm_Add_User_Load(object sender, EventArgs e)
        {
            Shared_Content.bind_ComboBox(cmb_User_Role, "Designation", "select distinct(Designation) from Staff_Details");
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Shared_Content.bind_ComboBox(cmb_Username, "User_Name", "select distinct(User_Name) from Login_Details where User_Role='" + cmb_User_Role.Text + "'");
        }
        int check_password()
        {
            if(tb_Password.Text != tb_Confirm_Password.Text)
            {
                MessageBox.Show("Mismatch Password!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Confirm_Password.Text = "";
                tb_Confirm_Password.Focus();
                return 0;
            }
            return 1;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            int check = check_password();

            if (cmb_User_Role.Text != "" && tb_Username.Text != "" && tb_Password.Text != "" && check == 1)
            {
                Connection.S_Con_Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into Login_Details values (@urole,@unm,@pwd,@Status)";
                cmd.Connection = Connection.DBCon;

                cmd.Parameters.Add("urole", SqlDbType.VarChar).Value = cmb_User_Role.Text;
                cmd.Parameters.Add("unm", SqlDbType.NVarChar).Value = tb_Username.Text;
                cmd.Parameters.Add("pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

                cmd.Parameters.Add("Status", SqlDbType.VarChar).Value = true;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Connection.S_Con_Close();

            }
            else
            {
                MessageBox.Show("Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

