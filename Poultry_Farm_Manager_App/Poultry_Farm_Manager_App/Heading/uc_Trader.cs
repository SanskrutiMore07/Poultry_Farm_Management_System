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
    public partial class uc_Trader : UserControl
    {
        public uc_Trader()
        {
            InitializeComponent();
        }

        private void btn_Add_Trader_Click(object sender, EventArgs e)
        {
          Trader.frm_Add_Trader Obj = new Trader.frm_Add_Trader() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Update_Trader_Click(object sender, EventArgs e)
        {
           Trader.frm_Update_Trader Obj = new Trader.frm_Update_Trader() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Trader_List_Click(object sender, EventArgs e)
        {
            Trader.frm_Trader_List Obj = new Trader.frm_Trader_List() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
