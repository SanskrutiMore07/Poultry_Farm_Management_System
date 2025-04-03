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
    public partial class frm_Feed_Allotment : Form
    {
        public frm_Feed_Allotment()
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
            tb_Feed_Allotment_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Feed_Allotment_Details", "FA_ID", 101));
            cmb_Feed.SelectedIndex = -1;
            cmb_Bag_KG.SelectedIndex = -1;
            tb_Bag_Quantity.Clear();
            dtp_Date.ResetText();
            cmb_Staff.SelectedIndex = -1;
            tb_Note.Clear();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Feed_Allotment_Load(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.DBCon;
            cmd.CommandText = "Select Lot_No from New_Lot_Entry_Details where Current_Stock > 0";
            int CLotNo = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            cmd.Connection = Connection.DBCon;
            cmd.CommandText = "Select Lot_No from New_Lot_Entry_Details  where Lot_No = " + CLotNo + "";

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Lot_Number.Text = (Dr["Lot_No"].ToString());
            }
            cmd.Dispose();
            Dr.Close();
            Connection.S_Con_Close();

            tb_Feed_Allotment_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Feed_Allotment_Details", "FA_ID", 101));
            Shared_Content.bind_ComboBox(cmb_Staff, "Staff_Name", "select distinct(Staff_Name)from Staff_Details");

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Feed_Allotment_ID.Text != "" && dtp_Date.Text != "" && cmb_Feed.Text != "" && cmb_Bag_KG.Text != "" && tb_Bag_Quantity.Text != "" && cmb_Staff.Text != "" && tb_Lot_Number.Text != "")   
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

                    cmd2.CommandText = "Insert Into Feed_Allotment_Details values (@FA_ID,@A_Date,@Feed,@Bag_Kg,@Bag_Qty,@Staff,@Note,@Lot_No, @SID)";
                    cmd2.Connection = Connection.DBCon;

                    cmd2.Parameters.Add("FA_ID", SqlDbType.Int).Value = tb_Feed_Allotment_ID.Text;
                    cmd2.Parameters.Add("A_Date", SqlDbType.Date).Value = dtp_Date.Text;
                    cmd2.Parameters.Add("Feed", SqlDbType.VarChar).Value = cmb_Feed.Text;
                    cmd2.Parameters.Add("Bag_Kg", SqlDbType.Int).Value = cmb_Bag_KG.Text;
                    cmd2.Parameters.Add("Bag_Qty", SqlDbType.Int).Value = tb_Bag_Quantity.Text;
                    cmd2.Parameters.Add("Staff", SqlDbType.VarChar).Value = cmb_Staff.Text;
                    cmd2.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;
                    cmd2.Parameters.Add("Lot_No", SqlDbType.Int).Value = tb_Lot_Number.Text;
                    cmd2.Parameters.Add("SID", SqlDbType.Int).Value = Staff_ID;

                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();

                    /// Update Feed_Stock_Details
                    SqlCommand cmd3 = new SqlCommand();

                    cmd3.CommandText = "Update Feed_Stock_Details Set Bag_Qty = @BaggQt, Current_Stock = @Stook Where Feed = @Fdd And Bag_Kg = @bggkg";
                    cmd3.Connection = Connection.DBCon;

                    cmd3.Parameters.Add("bggkg", SqlDbType.Int).Value = cmb_Bag_KG.Text;
                    cmd3.Parameters.Add("Fdd", SqlDbType.VarChar).Value = cmb_Feed.Text;
                    cmd3.Parameters.Add("BaggQt", SqlDbType.Int).Value = BagQty - Convert.ToInt32(tb_Bag_Quantity.Text);
                    cmd3.Parameters.Add("Stook", SqlDbType.Int).Value = Total_C_Stock - Total;

                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();

                    SqlCommand cmd4 = new SqlCommand();
                    cmd4.Connection = Connection.DBCon;
                    cmd4.CommandText = "Select Stock from Staff_Feed_Stock_Details where Staff_ID = @SfID And Feed = @FD And Bag_Kg = @bkg";

                    cmd4.Parameters.Add("SfID", SqlDbType.Int).Value = Staff_ID;
                    cmd4.Parameters.Add("FD", SqlDbType.VarChar).Value = cmb_Feed.Text;
                    cmd4.Parameters.Add("bkg", SqlDbType.Int).Value = cmb_Bag_KG.Text;

                    SqlDataReader Dr2 = cmd4.ExecuteReader();
                    cmd4.Dispose();

                    if (Dr2.Read())
                    {
                        Staff_C_Stock = Convert.ToInt32((Dr2["Stock"].ToString())) + Total;

                        Dr2.Close();
                        SqlCommand cmd5 = new SqlCommand();

                        cmd5.CommandText = "Update Staff_Feed_Stock_Details  Set Stock = @Stok Where Staff_ID = @StffID And Feed = @F And Bag_Kg = @bgkg ";
                        cmd5.Connection = Connection.DBCon;

                        cmd5.Parameters.Add("StffID", SqlDbType.Int).Value = Staff_ID;
                        cmd5.Parameters.Add("bgkg", SqlDbType.Int).Value = cmb_Bag_KG.Text;
                        cmd5.Parameters.Add("F", SqlDbType.VarChar).Value = cmb_Feed.Text;
                        cmd5.Parameters.Add("Stok", SqlDbType.Int).Value = Staff_C_Stock;

                        cmd5.ExecuteNonQuery();
                        cmd5.Dispose();
                    }
                    else
                    {
                        Dr2.Close();
                        SqlCommand cmd6 = new SqlCommand();

                        cmd6.CommandText = "Insert Into Staff_Feed_Stock_Details values (@StfID, @Fed, @bk, @Stk)";
                        cmd6.Connection = Connection.DBCon;

                        cmd6.Parameters.Add("StfID", SqlDbType.Int).Value = Staff_ID;
                        cmd6.Parameters.Add("Fed", SqlDbType.VarChar).Value = cmb_Feed.Text;
                        cmd6.Parameters.Add("bk", SqlDbType.Int).Value = cmb_Bag_KG.Text;
                        cmd6.Parameters.Add("Stk", SqlDbType.Int).Value = Total;

                        cmd6.ExecuteNonQuery();
                        cmd6.Dispose();
                    }

                    MessageBox.Show("Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("No Enough Stock Available", "INSUFFICIENT STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Connection.S_Con_Close();
            }
            else
            {
                MessageBox.Show("First Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmb_Staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.S_Con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.DBCon;
            cmd.CommandText = "Select Staff_ID from Staff_Details where Staff_Name = '" + cmb_Staff.Text + "'";

            Staff_ID = Convert.ToInt32(cmd.ExecuteScalar());

            Connection.S_Con_Close();

        }
    }
}
