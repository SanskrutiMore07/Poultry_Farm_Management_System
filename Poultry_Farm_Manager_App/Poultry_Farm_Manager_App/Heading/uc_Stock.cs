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
    public partial class uc_Stock : UserControl
    {
        public uc_Stock()
        {
            InitializeComponent();
        }

        private void btn_Dispatch_Stock_Click(object sender, EventArgs e)
        {
            Stock.frm_Dispatch_Stock Obj = new Stock.frm_Dispatch_Stock() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_btn_Dispatch_Stock_List_Click(object sender, EventArgs e)
        {
            Stock.frm_Dispatch_Stock_List Obj = new Stock.frm_Dispatch_Stock_List() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
