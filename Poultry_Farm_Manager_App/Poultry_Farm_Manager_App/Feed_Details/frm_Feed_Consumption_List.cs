using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App.Feed_Details
{
    public partial class frm_Feed_Consumption_List : Form
    {
        public frm_Feed_Consumption_List()
        {
            InitializeComponent();
        }

        private void frm_Feed_Consumption_List_Load(object sender, EventArgs e)
        {
            if (Shared_Content.User_Role == "Admin")
            {
                Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT * From Feed_Consumption_Details");
            }
            else
            {
                Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT FC_ID, Consumption_Date ,Staff,Feed,FC_Kg,Total_FC,FC_In_Bags,Running_FCR From Feed_Consumption_Details");
            }

        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT FC_ID, Consumption_Date ,Lot_No,Staff,Feed,FC_Kg,Total_FC,FC_In_Bags,Running_FCR From Feed_Consumption_Details where MONTH(Consumption_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex)+ 1)+"'");
            if (Shared_Content.User_Role == "Admin")
            {
                Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT * From Feed_Consumption_Details  where MONTH(Consumption_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "'");
            }
            else
            {
                Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT FC_ID,Consumption_Date,Staff,Feed,FC_Kg,Total_FC,FC_In_Bags,Running_FCR From Feed_Consumption_Details where MONTH(Consumption_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "'");
            }
        }

            private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT FC_ID, Consumption_Date ,Lot_No,Staff,Feed,FC_Kg,Total_FC,FC_In_Bags,Running_FCR From Feed_Consumption_Details where MONTH(Consumption_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex)+ 1)+ "' and Year(Consumption_Date) = '" + Convert.ToInt32(cmb_Year.Text)+"'");
            if (Shared_Content.User_Role == "Admin")
            {
                Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT * From Feed_Consumption_Details  where MONTH(Consumption_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "' and Year(Consumption_Date) = '" + Convert.ToInt32(cmb_Year.Text) + "'");
            }
            else
            {
                Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT FC_ID,Consumption_Date,Staff,Feed,FC_Kg,Total_FC,FC_In_Bags,Running_FCR From Feed_Consumption_Details  where MONTH(Consumption_Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "' and Year(Consumption_Date) = '" + Convert.ToInt32(cmb_Year.Text) + "'"); 
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (Shared_Content.User_Role == "Admin")
            {
                Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT * From Feed_Consumption_Details");
            }
            else
            {
                Shared_Content.Bind_Grid(dgv_Feed_Consumption, "SELECT FC_ID,Consumption_Date,Staff,Feed,FC_Kg,Total_FC,FC_In_Bags,Running_FCR From Feed_Consumption_Details");
            }
        }

        
    }
}
