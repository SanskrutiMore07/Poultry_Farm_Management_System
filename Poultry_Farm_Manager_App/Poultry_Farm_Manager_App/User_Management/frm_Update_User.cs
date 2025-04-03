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
    public partial class frm_Update_User : Form
    {
        public frm_Update_User()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            cmb_User_Role.SelectedIndex = -1;
            cmb_Username.SelectedIndex = -1;
            tb_Password.Clear();
            tb_Confirm_Password.Clear();

        }

        int Check_Pass()
        {
            if (tb_Password.Text != tb_Confirm_Password.Text)
            {
                MessageBox.Show("Mismatch Password!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Confirm_Password.Text = "";
                tb_Confirm_Password.Focus();
                return 0;
            }
            return 1;
        }
        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            int Check = Check_Pass();

            Connection.S_Con_Open();
            if(cmb_User_Role.Text !="" && cmb_Username.Text !="" && tb_Password.Text !=""  )
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Update Login_Details set Password = '"+tb_Password.Text+"' where User_Role = '"+ cmb_User_Role.Text+"' and User_name ='"+cmb_Username.Text+"'";
                cmd.Connection = Connection.DBCon;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Fill All The Fields", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Connection.S_Con_Close();
        }

        private void frm_Update_User_Load(object sender, EventArgs e)
        {
            Shared_Content.bind_ComboBox(cmb_User_Role, "User_Role", "select distinct(User_Role) from Login_Details ");
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.bind_ComboBox(cmb_Username, "User_Name", "select distinct(User_Name) from Login_Details where User_Role='" + cmb_User_Role.Text + "'");
        }
    }
}
