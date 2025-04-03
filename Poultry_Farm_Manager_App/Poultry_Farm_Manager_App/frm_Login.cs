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

namespace Poultry_Farm_Manager_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
             Connection.S_Con_Open();

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "select count (*) from Login_Details where User_Role = @URole and User_Name = @UName and Password = @Pwd";
             cmd.Connection = Connection.DBCon;

             cmd.Parameters.Add("URole", SqlDbType.VarChar).Value = cmb_User_Role.Text;
             cmd.Parameters.Add("UName", SqlDbType.NVarChar).Value = cmb_User_Name.Text;
             cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

             int cnt = Convert.ToInt32(cmd.ExecuteScalar());

             if (cnt > 0)
             {
                Shared_Content.User_Role = cmb_User_Role.Text;
                Shared_Content.Login_User = cmb_User_Name.Text;
                 Shared_Content.Generate_Id();
                 MessageBox.Show("Login Successfull!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 frm_Main_Poultry_Form main = new frm_Main_Poultry_Form();
                 main.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("Login Failed", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             tb_Password.Clear();
             tb_Password.Focus();
         }

         private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
         {
             Shared_Content.bind_ComboBox(cmb_User_Name, "User_Name", "select distinct(User_Name) from Login_Details where User_Role='" + cmb_User_Role.Text + "'");
         }

         private void frm_Login_Load(object sender, EventArgs e)
         {
            Shared_Content.bind_ComboBox(cmb_User_Role, "User_Role", "select distinct(User_Role) from Login_Details ");

            cmb_User_Role.SelectedIndex = 0;
            cmb_User_Name.SelectedIndex = 0;
            tb_Password.Focus();
         }   
    }
}

