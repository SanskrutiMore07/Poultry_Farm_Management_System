using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App.Stock
{
    public partial class frm_Dispatch_Stock_List : Form
    {
        public frm_Dispatch_Stock_List()
        {
            InitializeComponent();
        }

        private void frm_Dispatch_Stock_List_Load(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Dispatch_Stock_List, "SELECT * From Dispatch_Details");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Dispatch_Stock_List, "SELECT * From Dispatch_Details");
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Dispatch_Stock_List, "SELECT * From Dispatch_Details where MONTH(Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "'");

        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Dispatch_Stock_List, "SELECT * From Dispatch_Details where MONTH(Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "' and Year(Date) = '" + Convert.ToInt32(cmb_Year.Text) + "'");

        }
    }
}
