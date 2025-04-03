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
    public partial class uc_Poultry_Details : UserControl
    {
        public uc_Poultry_Details()
        {
            InitializeComponent();
        }

        private void btn_Poultry_Details_Click(object sender, EventArgs e)
        {
            Poultry_Details.frm_Farm_Details Obj = new Poultry_Details.frm_Farm_Details () { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_View_Poultry_Details_Click(object sender, EventArgs e)
        {
            Poultry_Details.frm_View_Farm_Details Obj = new Poultry_Details.frm_View_Farm_Details () { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
