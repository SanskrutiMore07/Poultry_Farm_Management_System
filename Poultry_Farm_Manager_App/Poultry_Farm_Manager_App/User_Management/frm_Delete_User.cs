using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App.User_Management
{
    public partial class frm_Delete_User : Form
    {
        public frm_Delete_User()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_User_Role.Clear();
            tb_Username.Clear();
            tb_Admin_Password.Clear();
            btn_Delete_User.Enabled = false;
        }
        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            if (tb_User_Role.Text != "" && tb_Username.Text != "" && tb_Admin_Password.Text == "A123")
            {
                btn_Delete_User.Enabled = true;
                DialogResult DR = MessageBox.Show("Are You Sure To Delete This User !!!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    MessageBox.Show("User Deleted Successfully !!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Shared_Content.Bind_Grid(dgv_User_Details, "select User_Role,User_Name from Login_Details Where User_Name <> '" + tb_Username.Text + "'");

                    Clear_Controls();
                }
                else
                {
                    Clear_Controls();
                }
            }
        }

        private void tb_Admin_Password_TextChanged(object sender, EventArgs e)
        {
            if (tb_User_Role.Text != "" && tb_Username.Text != "" && tb_Admin_Password.Text == "A123")
            {
                btn_Delete_User.Enabled = true;
            }
        }

      

        private void frm_Delete_User_Load(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_User_Details, "select User_Role, User_Name From Login_Details Where Status='true'");
        }

     

        private void dgv_User_Details_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRowCount = dgv_User_Details.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (SelectedRowCount == 1)
            {
                int Row_Index = dgv_User_Details.SelectedCells[0].RowIndex;
                string Role = Convert.ToString(dgv_User_Details.Rows[Row_Index].Cells[0].Value);
                string User_Name = Convert.ToString(dgv_User_Details.Rows[Row_Index].Cells[1].Value);

                tb_User_Role.Text = Role;
                tb_Username.Text = User_Name;
            }
        }
    }
}
