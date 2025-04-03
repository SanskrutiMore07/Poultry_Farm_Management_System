using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App.Heading
{
    public partial class uc_Lot_Details : UserControl
    {
        public uc_Lot_Details()
        {
            InitializeComponent();
        }

        private void btn_Lot_List_Click(object sender, EventArgs e)
        {
            Lot_Entry.frm_Lot_List Obj = new Lot_Entry.frm_Lot_List() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_New_Lot_Entry_Click(object sender, EventArgs e)
        {
            Lot_Entry.frm_New_Lot_Entry Obj = new Lot_Entry.frm_New_Lot_Entry() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Current_Lot_Entry_Click(object sender, EventArgs e)
        {
            Lot_Entry.frm_Lot_Entry Obj = new Lot_Entry.frm_Lot_Entry() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_View_Lot_Entry_Click(object sender, EventArgs e)
        {
            Lot_Entry.frm_View_Lot_Entry Obj = new Lot_Entry.frm_View_Lot_Entry() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
