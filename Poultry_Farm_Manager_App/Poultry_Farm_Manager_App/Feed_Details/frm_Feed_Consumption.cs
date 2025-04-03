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
    public partial class frm_Feed_Consumption : Form
    {
        public frm_Feed_Consumption()
        {
            InitializeComponent();
        }

        int Staff_ID = 0;
        double Total_Body_Wt = 0;
        int Feed_Consumption = 0;
        private void ON(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric(e);
        }

        private void OT(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Text(e);
        }

        private void AN(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Alpha_Numeric(e);
        }
        void Clear_Controls()
        {
            tb_FC_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Feed_Consumption_Details", "FC_ID", 101));
            //tb_Lot_Number.Clear();
            dtp_Consumption_Date.ResetText();
            cmb_Staff.SelectedIndex = -1;
            cmb_Feed.SelectedIndex = -1;
            cmb_Fc_Bag_Kg.SelectedIndex = -1;
            tb_Feed_Consumption_In_Bags.Clear();
            tb_Total_Feed_Consumption.Clear();
            tb_Running_FCR.Clear();
            tb_Note.Clear();
        }
       

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Feed_Consumption_Load(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.DBCon;
            cmd.CommandText = "Select Max(Lot_No) from New_Lot_Entry_Details";

            tb_Lot_Number.Text = Convert.ToString(cmd.ExecuteScalar());
            
            cmd.Dispose();

            cmd.Connection = Connection.DBCon;
            cmd.CommandText = "Select Last_Reported_Body_Weight, Balance_Birds from Lot_Details Where Lot_No = @LN And Running_Date = @RD";

            cmd.Parameters.Add("LN",SqlDbType.Int).Value = tb_Lot_Number.Text;
            cmd.Parameters.Add("RD",SqlDbType.Date).Value = dtp_Consumption_Date.Text;

            SqlDataReader Dr1 = cmd.ExecuteReader();

            if (Dr1.Read())
            {
                double Body_Wt = Convert.ToDouble(Dr1["Last_Reported_Body_Weight"].ToString());
                double BCount = Convert.ToDouble(Dr1["Balance_Birds"].ToString());

                Total_Body_Wt = Body_Wt * BCount;
            }
            else
            {
                MessageBox.Show("Todays Lot Entry Status Missing");
                //gb_Feed_Consumption_Details.Enabled = false;
                //gb_Feed_Consumption.Enabled = false;
                btn_Save.Enabled = false;
                
            }

            Dr1.Close();

            Connection.S_Con_Close();

            tb_FC_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Feed_Consumption_Details", "FC_ID", 101));
            Shared_Content.bind_ComboBox(cmb_Staff, "Staff_Name", "select distinct(Staff_Name)from Staff_Details");
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            if (cmb_Staff.Text != "" && cmb_Feed.Text != "" && cmb_Fc_Bag_Kg.Text != "" && tb_Feed_Consumption_In_Bags.Text != "" && tb_Total_Feed_Consumption.Text != "" && tb_Running_FCR.Text != "")
            {
                int Staff_C_Stock = 0;
                int Total = Convert.ToInt32(cmb_Fc_Bag_Kg.Text) * Convert.ToInt32(tb_Feed_Consumption_In_Bags.Text);

                Connection.S_Con_Open();

                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = Connection.DBCon;
                cmd1.CommandText = "Select Stock from Staff_Feed_Stock_Details where Feed = @Fid And Bag_Kg = @b_kg And Staff_ID = @StfID";

                cmd1.Parameters.Add("Fid", SqlDbType.VarChar).Value = cmb_Feed.Text;
                cmd1.Parameters.Add("b_kg", SqlDbType.Int).Value = cmb_Fc_Bag_Kg.Text;
                cmd1.Parameters.Add("StfID", SqlDbType.Int).Value = Staff_ID;

                SqlDataReader Dr1 = cmd1.ExecuteReader();

                if (Dr1.Read())
                {
                    Staff_C_Stock = Convert.ToInt32(Dr1["Stock"].ToString());
                }

                Dr1.Close();
                cmd1.Dispose();

                if (Staff_C_Stock >= Total)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = Connection.DBCon;
                    cmd.CommandText = "Insert Into Feed_Consumption_Details Values(@FC_ID,@CDate,@LNo,@Staff,@SID,@Feed,@FcKg,@TotalFC,@FCBag,@FCR,@Note)";
                    cmd.Parameters.Add("FC_ID", SqlDbType.Int).Value = tb_FC_ID.Text;
                    cmd.Parameters.Add("CDate", SqlDbType.Date).Value = dtp_Consumption_Date.Value.Date;
                    cmd.Parameters.Add("LNo", SqlDbType.Int).Value = tb_Lot_Number.Text;
                    cmd.Parameters.Add("Staff", SqlDbType.VarChar).Value = cmb_Staff.Text;
                    cmd.Parameters.Add("SID", SqlDbType.Int).Value = Staff_ID;
                    cmd.Parameters.Add("Feed", SqlDbType.VarChar).Value = cmb_Feed.Text;
                    cmd.Parameters.Add("FcKg", SqlDbType.Int).Value = cmb_Fc_Bag_Kg.Text;
                    cmd.Parameters.Add("TotalFC", SqlDbType.Int).Value = tb_Total_Feed_Consumption.Text;
                    cmd.Parameters.Add("FCBag", SqlDbType.Int).Value = tb_Feed_Consumption_In_Bags.Text;
                    cmd.Parameters.Add("FCR", SqlDbType.Float).Value = tb_Running_FCR.Text;
                    cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand();

                    cmd3.CommandText = "Update Staff_Feed_Stock_Details Set Stock = @Stok Where Staff_ID = @StffID And Feed = @F And Bag_Kg = @bgkg ";
                    cmd3.Connection = Connection.DBCon;

                    cmd3.Parameters.Add("StffID", SqlDbType.Int).Value = Staff_ID;
                    cmd3.Parameters.Add("bgkg", SqlDbType.Int).Value = cmb_Fc_Bag_Kg.Text;
                    cmd3.Parameters.Add("F", SqlDbType.VarChar).Value = cmb_Feed.Text;
                    cmd3.Parameters.Add("Stok", SqlDbType.Int).Value = Staff_C_Stock - Total;

                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();
                    
                    MessageBox.Show("Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("No Enough Stock Available", "INSUFFICIENT STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void tb_Total_Feed_Consumption_TextChanged(object sender, EventArgs e)
        {
            if (tb_Total_Feed_Consumption.Text != "")
            {
                double FCR = Convert.ToDouble(tb_Total_Feed_Consumption.Text) / Total_Body_Wt;

                tb_Running_FCR.Text = Convert.ToString(FCR);
            }
        }

        private void tb_Feed_Consumption_In_Bags_TextChanged(object sender, EventArgs e)
        {
            if (tb_Feed_Consumption_In_Bags.Text != "" && cmb_Fc_Bag_Kg.Text != "")
            {
                double Total_Cosumption = Convert.ToDouble(cmb_Fc_Bag_Kg.Text) * Convert.ToDouble(tb_Feed_Consumption_In_Bags.Text);

                tb_Total_Feed_Consumption.Text = Convert.ToString(Total_Cosumption);
            }
        }

        private void tb_Feed_Consumption_In_Bags_DoubleClick(object sender, EventArgs e)
        {
            tb_Feed_Consumption_In_Bags.Text = "";
            tb_Total_Feed_Consumption.Text = Feed_Consumption.ToString();
        }
    }
}
