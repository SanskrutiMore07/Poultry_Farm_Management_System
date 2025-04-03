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
    public partial class frm_Feed_Purchase_List : Form
    {
        public frm_Feed_Purchase_List()
        {
            InitializeComponent();
        }

        private void frm_Feed_Purchase_List_Load(object sender, EventArgs e)
        {
            if(Shared_Content.User_Role =="Admin")
            {
                Shared_Content.Bind_Grid(dgv_Feed_Purchase_list, "SELECT pd.FP_ID as 'ID',pd.Date,pd.Mob_No as 'Mobile',pd.Sup_Name as 'Supplier',fpe.Feed,fpe.Bag_Kg as 'Bag Kg',fpe.Bag_Qty as 'Bag Qty',fpe.Price,fpe.Total,pd.Total_Bill as 'Total Bill',pd.Receive From Purchase_Details As pd Inner Join  Feed_Purchase_Entry As fpe on pd.FP_ID  = fpe.FP_ID");
            }
            else
            {
                Shared_Content.Bind_Grid(dgv_Feed_Purchase_list, "SELECT * From Purchase_Details");

            }
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Feed_Purchase_list, "SELECT pd.FP_ID,pd.Date,pd.Mob_No,pd.Sup_Name,fpe.Feed,fpe.Bag_Kg,fpe.Bag_Qty,fpe.Price,fpe.Total,pd.Total_Bill From Purchase_Details As pd Inner Join  Feed_Purchase_Entry As fpe on pd.FP_ID  = fpe.FP_ID where MONTH(Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "'");
        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Feed_Purchase_list, "SELECT pd.FP_ID,pd.Date,pd.Mob_No,pd.Sup_Name,fpe.Feed,fpe.Bag_Kg,fpe.Bag_Qty,fpe.Price,fpe.Total,pd.Total_Bill,pd.Receive From Purchase_Details As pd Inner Join  Feed_Purchase_Entry As fpe on pd.FP_ID  = fpe.FP_ID where MONTH(Date)='" + Convert.ToInt32((cmb_Month.SelectedIndex) + 1) + "' and Year(Date) = '"+Convert.ToInt32(cmb_Year.Text)+"'");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (Shared_Content.User_Role == "Admin")
            {
                Shared_Content.Bind_Grid(dgv_Feed_Purchase_list, "SELECT pd.FP_ID,pd.Date,pd.Mob_No,pd.Sup_Name,fpe.Feed,fpe.Bag_Kg,fpe.Bag_Qty,fpe.Price,fpe.Total,pd.Total_Bill,pd.Receive From Purchase_Details As pd Inner Join  Feed_Purchase_Entry As fpe on pd.FP_ID  = fpe.FP_ID");
            }
            else
            {
                Shared_Content.Bind_Grid(dgv_Feed_Purchase_list, "SELECT * From Purchase_Details");

            }
        }

        
    }
}
