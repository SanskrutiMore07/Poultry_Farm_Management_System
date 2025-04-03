using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App.Expence
{
    public partial class frm_Expence_List : Form
    {
        public frm_Expence_List()
        {
            InitializeComponent();
        }

        private void frm_Expence_List_Load(object sender, EventArgs e)
        {
            if (Shared_Content.Login_User == "Admin")
            {
                Shared_Content.Bind_Grid(dgv_Expence_List, "Select * From Expence_Details");
            }
            else
            {
                Shared_Content.Bind_Grid(dgv_Expence_List, "Select Exp_Id,Exp_date,Exp_Details,Amount_paid,Status From Expence_Details");
            }
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Expence_List, "SELECT Exp_Id,Exp_date,Exp_Details,Amount_paid,Status From Expence_Details  where MONTH(Exp_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "'");

        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Expence_List, "SELECT Exp_Id,Exp_date,Exp_Details,Amount_paid,Status From Expence_Details  where MONTH(Exp_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "' and Year(Exp_Date) = '" + Convert.ToInt32(cmb_Year.Text) + "'");

        }
    }
}
