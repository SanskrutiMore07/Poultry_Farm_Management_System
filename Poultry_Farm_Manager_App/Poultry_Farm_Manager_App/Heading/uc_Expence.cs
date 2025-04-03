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
    public partial class uc_Expence : UserControl
    {
        public uc_Expence()
        {
            InitializeComponent();
        }

        private void btn_Add_Expence_Click(object sender, EventArgs e)
        {
            Expence.frm_Expence Obj = new Expence.frm_Expence (){ TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Expence_List_Click(object sender, EventArgs e)
        {
            Expence.frm_Expence_List Obj = new Expence.frm_Expence_List () { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Payment_Receipt_Click(object sender, EventArgs e)
        {
            Expence.frm_Bill_Image Obj = new Expence.frm_Bill_Image() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
