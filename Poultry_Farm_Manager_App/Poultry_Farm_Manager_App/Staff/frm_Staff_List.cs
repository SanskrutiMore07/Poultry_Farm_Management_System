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
    public partial class frm_Staff_List : Form
    {
        public frm_Staff_List()
        {
            InitializeComponent();
        }

        private void frm_Staff_List_Load(object sender, EventArgs e)
        {
            Shared_Content.bind_ComboBox(cmb_Designation, "Designation", "Select Distinct(Designation) From Staff_Details");

            if (Shared_Content.Login_User == "Admin")
            {
                Shared_Content.Bind_Grid(dgv_Staff_List, "Select * From Staff_Details");
            }
            else
            {
                Shared_Content.Bind_Grid(dgv_Staff_List, "Select Staff_ID,Staff_Name,Designation,Mob_No,Alt_Mob_No,Aadhaar_No,Status From Staff_Details");
            }
       }

        private void cmb_Designation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Designation.Text =="Admin")
            {
                Shared_Content.Bind_Grid(dgv_Staff_List, "Select * From Staff_Details Where Designation = '" + cmb_Designation.Text + "'");
            }
            else
            {
                Shared_Content.Bind_Grid(dgv_Staff_List, "Select Staff_ID,Staff_Name,Designation,Mob_No,Alt_Mob_No,Aadhaar_No,Status From Staff_Details  Where Designation = '" + cmb_Designation.Text + "'");

            }
        }
    }
}
