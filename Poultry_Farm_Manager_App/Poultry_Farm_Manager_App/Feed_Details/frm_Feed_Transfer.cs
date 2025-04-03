using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Poultry_Farm_Manager_App.Feed_Details
{
    public partial class frm_Feed_Transfer : Form
    {
        public frm_Feed_Transfer()
        {
            InitializeComponent();
        }

        int Staff_ID = 0;
        private void ON(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void OT(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        void Clear_Controls()
        {
            tb_Feed_Transfer_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Feed_Transfer_Details", "FT_ID", 1001));
            cmb_Feed.SelectedIndex = -1;
            cmb_Bag_KG.SelectedIndex = -1;
            tb_Bag_Quantity.Clear();
            dtp_Transfer_Date.ResetText();
            cmb_Staff.SelectedIndex = -1;
            tb_Total_Feed_Transfer.Clear();
            tb_Note.Clear();
        }
        private void frm_Feed_Transfer_Load(object sender, EventArgs e)
        {
            tb_Feed_Transfer_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Feed_Transfer_Details", "FT_ID", 1001));
            Shared_Content.bind_ComboBox(cmb_Staff, "Staff_Name", "select distinct(Staff_Name)from Staff_Details");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
         /*   if (dtp_Transfer_Date.Text != "" && cmb_Feed.Text != "" && cmb_Bag_KG.Text != "" && tb_Bag_Quantity.Text != "" && cmb_Staff.Text != "" && tb_Total_Feed_Transfer.Text != "")
            {
                int Staff_C_Stock = 0;

                Connection.S_Con_Open();
                int Total_C_Stock = 0, BagQty = 0;

                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = Connection.DBCon;
                cmd1.CommandText = "Select Bag_Qty, Current_Stock from Feed_Stock_Details where Feed = @Fid And Bag_Kg = @b_kg";

                cmd1.Parameters.Add("Fid", SqlDbType.VarChar).Value = cmb_Feed.Text;
                cmd1.Parameters.Add("b_kg", SqlDbType.Int).Value = cmb_Bag_KG.Text;

                SqlDataReader Dr1 = cmd1.ExecuteReader();

                if (Dr1.Read())
                {
                    Total_C_Stock = Convert.ToInt32((Dr1["Current_Stock"].ToString()));
                    BagQty = Convert.ToInt32((Dr1["Bag_Qty"].ToString()));
                }

                Dr1.Close();
                cmd1.Dispose();

                if (BagQty >= Convert.ToInt32(tb_Bag_Quantity.Text))
                {
                    int Total = Convert.ToInt32(cmb_Bag_KG.Text) * Convert.ToInt32(tb_Bag_Quantity.Text);

                    SqlCommand cmd2 = new SqlCommand();

                    cmd2.CommandText = "Insert Into Feed_Transfer_Details values (@FT_ID,@T_Date,@Feed,@Bag_Kg,@Bag_Qty,@Staff,@TF_Transfer,@Note,@SID)";
                    cmd2.Connection = Connection.DBCon;

                    cmd2.Parameters.Add("FT_ID", SqlDbType.Int).Value = tb_Feed_Transfer_ID.Text;
                    cmd2.Parameters.Add("T_Date", SqlDbType.Date).Value = dtp_Transfer_Date.Text;
                    cmd2.Parameters.Add("Feed", SqlDbType.VarChar).Value = cmb_Feed.Text;
                    cmd2.Parameters.Add("Bag_Kg", SqlDbType.Int).Value = cmb_Bag_KG.Text;
                    cmd2.Parameters.Add("Bag_Qty", SqlDbType.Int).Value = tb_Bag_Quantity.Text;
                    cmd2.Parameters.Add("Staff", SqlDbType.VarChar).Value = cmb_Staff.Text;
                    cmd2.Parameters.Add("TF_Transfer", SqlDbType.Int).Value = tb_Total_Feed_Transfer.Text;
                    cmd2.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;
                    cmd2.Parameters.Add("SID", SqlDbType.Int).Value = Staff_ID;

                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();

                    SqlCommand cmd3 = new SqlCommand();

                    cmd3.CommandText = "Update Feed_Stock_Details Set Bag_Qty = @BaggQt, Current_Stock = @Stook Where Feed = @Fdd And Bag_Kg = @bggkg";
                    cmd3.Connection = Connection.DBCon;

                    cmd3.Parameters.Add("bggkg", SqlDbType.Int).Value = cmb_Bag_KG.Text;
                    cmd3.Parameters.Add("Fdd", SqlDbType.VarChar).Value = cmb_Feed.Text;
                    cmd3.Parameters.Add("BaggQt", SqlDbType.Int).Value = BagQty - Convert.ToInt32(tb_Bag_Quantity.Text);
                    cmd3.Parameters.Add("Stook", SqlDbType.Int).Value = Total_C_Stock - Total;

                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();
                }*/
            }
        }
    }

