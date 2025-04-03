using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App
{
    public partial class frm_Main_Poultry_Form : Form
    {
        public frm_Main_Poultry_Form()
        {
            InitializeComponent();
        }

        private void btn_Lot_Details_Click(object sender, EventArgs e)
        {
            Lot_Entry.frm_Lot_Entry Obj = new Lot_Entry.frm_Lot_Entry() {TopLevel=false,TopMost=true };
            Obj.FormBorderStyle = FormBorderStyle.None;


            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

            Heading.uc_Lot_Details uc = new Heading.uc_Lot_Details();

            pnl_More_Poultry_Farm.Controls.Clear();
            this.pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();

        }

        private void btn_Poultry_Details_Click(object sender, EventArgs e)
        {
            Poultry_Details.frm_Farm_Details Obj = new Poultry_Details.frm_Farm_Details() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

            Heading.uc_Poultry_Details uc = new Heading.uc_Poultry_Details();

            pnl_More_Poultry_Farm.Controls.Clear();
            this.pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();
        }

        private void btn_Feed_Details_Click(object sender, EventArgs e)
        {
            Feed_Details.frm_Feed_Consumption obj = new Feed_Details.frm_Feed_Consumption() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(obj);
            obj.Show();

            Heading.uc_Feed uc = new Heading.uc_Feed();

            pnl_More_Poultry_Farm.Controls.Clear();
            this.pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            Staff.frm_Add_Staff Obj=new Staff.frm_Add_Staff() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

            Heading.uc_Staff uc = new Heading.uc_Staff();

            pnl_More_Poultry_Farm.Controls.Clear();
            this.pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();
        }

        private void btn_Expence_Click(object sender, EventArgs e)
        {
            Expence.frm_Expence Obj =new Expence.frm_Expence(){ TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

            Heading.uc_Expence uc = new Heading.uc_Expence();

            pnl_More_Poultry_Farm.Controls.Clear();
            this.pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();
        }

        private void btn_User_Management_Click(object sender, EventArgs e)
        {
            User_Management.frm_Add_User Obj =new User_Management.frm_Add_User() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

            Heading.uc_User_Management uc = new Heading.uc_User_Management();

            pnl_More_Poultry_Farm.Controls.Clear();
            this.pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }

       

        private void btn_Trader_Click(object sender, EventArgs e)
        {
            Trader.frm_Add_Trader Obj = new Trader.frm_Add_Trader() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

            Heading.uc_Trader uc = new Heading.uc_Trader();

            pnl_More_Poultry_Farm.Controls.Clear();
            this.pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();
        }

        private void btn_Summary_Click(object sender, EventArgs e)
        {
            Summary.frm_Summary Obj = new Summary.frm_Summary() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

            Heading.uc_Summary uc = new Heading.uc_Summary();

            pnl_More_Poultry_Farm.Controls.Clear();
            this.pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();

        }

        private void bn_Stock_Click(object sender, EventArgs e)
        {
            Stock.frm_Dispatch_Stock Obj = new Stock.frm_Dispatch_Stock() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

            Heading.uc_Stock uc = new Heading.uc_Stock();

            pnl_More_Poultry_Farm.Controls.Clear();
            pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();

        }

        private void frm_Main_Poultry_Form_Load(object sender, EventArgs e)
        {
            lbl_Login_User.Text = "Welcome " + Shared_Content.Login_User; 

            if(Shared_Content.User_Role == "Manager")
            {
                btn_User_Management.Visible = false;
                btn_Reports.Visible = false;
                
            }
            else if(Shared_Content.User_Role == "Cashier")
            {
                btn_Reports.Visible = false;
                btn_User_Management.Visible = false;
               
            }
            else if (Shared_Content.User_Role == "Worker")
            {
                btn_Reports.Visible = false;
                btn_User_Management.Visible = false;
                btn_Trader.Visible = false;
                btn_Staff.Visible = false;
                btn_Stock.Visible = false;
            }
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
             Report_Details.frm_Report_Form Obj = new Report_Details.frm_Report_Form() { TopLevel = false, TopMost = true };
            Obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Main_Panel.Controls.Clear();
            pnl_Main_Panel.Controls.Add(Obj);
            Obj.Show();

            Heading.uc_Report uc = new Heading.uc_Report();

            pnl_More_Poultry_Farm.Controls.Clear();
            pnl_More_Poultry_Farm.Controls.Add(uc);
            uc.Show();
        }

        private void pb_Logo_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }
    }
}
