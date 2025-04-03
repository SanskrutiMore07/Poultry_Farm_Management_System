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
    public partial class uc_Feed : UserControl
    {
        public uc_Feed()
        {
            InitializeComponent();
        }

        private void btn_Feed_Purchase_Entry_Click(object sender, EventArgs e)
        {

            Feed_Details.frm_Feed_Purchase_Entry Obj = new Feed_Details.frm_Feed_Purchase_Entry () { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

        }

        private void btn_Feed_Consumption_Click(object sender, EventArgs e)
        {
            Feed_Details.frm_Feed_Consumption Obj = new Feed_Details.frm_Feed_Consumption() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Consumption_List_Click(object sender, EventArgs e)
        {
            Feed_Details.frm_Feed_Consumption_List Obj = new Feed_Details.frm_Feed_Consumption_List() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Feed_Allotment_Click(object sender, EventArgs e)
        {
            Feed_Details.frm_Feed_Allotment Obj = new Feed_Details.frm_Feed_Allotment() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Purchase_List_Click(object sender, EventArgs e)
        {
            Feed_Details.frm_Feed_Purchase_List Obj = new Feed_Details.frm_Feed_Purchase_List() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }

        private void btn_Feed_Transfer_Click(object sender, EventArgs e)
        {
            Feed_Details.frm_Feed_Transfer Obj = new Feed_Details.frm_Feed_Transfer() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Clear();
            frm_Main_Poultry_Form.pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();
        }
    }
}
