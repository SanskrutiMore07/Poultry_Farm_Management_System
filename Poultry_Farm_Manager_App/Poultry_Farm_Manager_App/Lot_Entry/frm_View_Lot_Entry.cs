using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App.Lot_Entry
{
    public partial class frm_View_Lot_Entry : Form
    {
        public frm_View_Lot_Entry()
        {
            InitializeComponent();
        }

        private void frm_View_Lot_Entry_Load(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Lot_Entry, "SELECT * From New_Lot_Entry_Details");
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Lot_Entry, "SELECT * From New_Lot_Entry_Details where MONTH(Hach_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "'");

        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Lot_Entry, "SELECT * From New_Lot_Entry_Details where MONTH(Hach_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "' and Year(Hach_Date) = '" + Convert.ToInt32(cmb_Year.Text) + "'");

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Lot_Entry, "SELECT * From New_Lot_Entry_Details");
        }
    }
}
