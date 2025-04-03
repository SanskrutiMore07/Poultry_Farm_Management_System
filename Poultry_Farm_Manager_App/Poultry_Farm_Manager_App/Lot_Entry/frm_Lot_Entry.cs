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

namespace Poultry_Farm_Manager_App.Lot_Entry
{
    public partial class frm_Lot_Entry : Form
    {
        public frm_Lot_Entry()
        {
            InitializeComponent();
        }

        int Mortality = 0;
        int Lifted_Birds = 0;
        int Lifted_Birds_Kg = 0;
        int Balance_Bird = 0;

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
        private void ONF(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric_Float(e);
        }

        void Clear_Controls()
        {
            tb_Mortality_Of_Birds.Clear();
            tb_Lifted_Birds.Clear();
            tb_Lifted_Birds_KG.Clear();
        }

        void Total_Mortality()
        {
            if (tb_Mortality_Of_Birds.Text != "" )
            {
                int Total = Convert.ToInt32(tb_Mortality_Of_Birds.Text) + Convert.ToInt32(tb_Total_Mortality_Birds.Text);
                tb_Total_Mortality_Birds.Text = Convert.ToString(Total);
            }
        }

        void Total_Lifted_Birds()
        {
            if (tb_Lifted_Birds.Text != "")
            {
                int Total = Convert.ToInt32(tb_Lifted_Birds.Text) + Convert.ToInt32(tb_Total_Lifted_Birds.Text);
                tb_Total_Lifted_Birds.Text = Convert.ToString(Total);
            }
        }

        void Lifted_Birds_KG()
        {
            if (tb_Lifted_Birds_KG.Text != "")
            {
                double TotalL = Convert.ToDouble(tb_Lifted_Birds_KG.Text) + Convert.ToDouble(tb_Total_Lifted_Birds_Kg.Text);
                tb_Total_Lifted_Birds_Kg.Text = Convert.ToString(TotalL);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        void Calc_Age()
        {
            DateTime HDt = dtp_Hach_Date.Value;
            DateTime RDt = dtp_Running_Date.Value;

            TimeSpan tspan = RDt - HDt;

            int Age = tspan.Days;
            tb_Running_Age.Text = Convert.ToString(Age);
        }

        private bool IsYesterdaysEntryPending(int lotNo)
        {
            int count = 0;
            DateTime yesterday = DateTime.Today.AddDays(-1);
            if(Shared_Content.flag != 5)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "SELECT COUNT(*) FROM Lot_Details WHERE Lot_No = @LotNo AND Running_Date = @Yesterday";
                cmd.Parameters.AddWithValue("@LotNo", lotNo);
                cmd.Parameters.AddWithValue("@Yesterday", yesterday);

                count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

            }
            else
            {
                lbl_Lot_Data_Entry_Status.Visible = false;
                tb_Lot_Data_Entry_Status.Visible = false;
            }
            Shared_Content.flag = 0;

            return count == 0; // If count is 0, it means yesterday's entry is pending
        }

        private void frm_Lot_Entry_Load(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.DBCon;
            cmd.CommandText = "Select Count(*) from New_Lot_Entry_Details Where Current_Stock > 0";

            int LiveLotCount = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            if (LiveLotCount > 0)
            {
                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Select Lot_No from New_Lot_Entry_Details Where Current_Stock > 0";

                int CLotNo = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();

                // Check if yesterday's entry is pending
                if (IsYesterdaysEntryPending(CLotNo))
                {
                    tb_Lot_Data_Entry_Status.Text = "Yesterday's entry is pending";
                }
                else
                {
                    tb_Lot_Data_Entry_Status.Text = "All entries are completed.";
                }

                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Select Lot_No,Hach_Date,No_Of_Chicks_Placed from New_Lot_Entry_Details where Lot_No = " + CLotNo + "";
                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Lot_No.Text = (Dr["Lot_No"].ToString());
                    dtp_Hach_Date.Text = (Dr["Hach_Date"].ToString());
                    tb_No_Of_Chicks_Placed.Text = (Dr["No_Of_Chicks_Placed"].ToString());
                }
                cmd.Dispose();
                Dr.Close();

                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = Connection.DBCon;
                cmd1.CommandText = "Select Farms_Chicks_Capacity from Poultry_Farm_Details";

                tb_Farms_Chicks_Capacity.Text = Convert.ToString(cmd1.ExecuteScalar());
                cmd1.Dispose();

                cmd1.Connection = Connection.DBCon;
                cmd1.CommandText = "Select Count(*) from Lot_Details where Lot_No = " + CLotNo + "";

                int LCnt = Convert.ToInt32(cmd1.ExecuteScalar());
                cmd1.Dispose();

                if (LCnt > 0)
                {
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = Connection.DBCon;
                    cmd2.CommandText = "Select Total_Mortality_Birds, Total_Lifted_Birds, Total_Lifted_Birds_Kg, Balance_Birds, Last_Reported_Body_Weight from Lot_Details where Lot_No = " + CLotNo + " And Running_Date = (Select Max(Running_Date) From Lot_Details Where Lot_No = " + CLotNo + ")";

                    SqlDataReader Dr1 = cmd2.ExecuteReader();

                    if (Dr1.Read())
                    {
                        tb_Total_Mortality_Birds.Text = (Dr1["Total_Mortality_Birds"].ToString());
                        tb_Total_Lifted_Birds.Text = (Dr1["Total_Lifted_Birds"].ToString());
                        Lifted_Birds = Convert.ToInt32(Dr1["Total_Lifted_Birds"].ToString());

                        string Val = (Dr1["Total_Lifted_Birds_Kg"].ToString());
                        tb_Total_Lifted_Birds_Kg.Text = Val;
                     
                        tb_Balance_Birds.Text = (Dr1["Balance_Birds"].ToString());
                        Balance_Bird = Convert.ToInt32(Dr1["Balance_Birds"].ToString());
                        tb_Last_Reorted_Body_Weight.Text = (Dr1["Last_Reported_Body_Weight"].ToString());
                        Mortality = Convert.ToInt32(Dr1["Total_Mortality_Birds"].ToString());
                    }

                    Dr1.Close();
                }
                else
                {
                    tb_Total_Mortality_Birds.Text = "0";
                    tb_Total_Lifted_Birds.Text = "0";
                    tb_Total_Lifted_Birds_Kg.Text = "0";
                    tb_Balance_Birds.Text = "0";
                    tb_Last_Reorted_Body_Weight.Text = "0";
                }

                Connection.S_Con_Close();
                Calc_Age();
            }
            else
            {
                MessageBox.Show("No Live Lot Available", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtp_Running_Date_ValueChanged(object sender, EventArgs e)
        {
            Calc_Age();
        }

        private void tb_Mortality_Of_Birds_TextChanged(object sender, EventArgs e)
        {
            if(tb_Mortality_Of_Birds.Text != "")
            {

                int Balance_Bird = Convert.ToInt32(tb_Balance_Birds.Text) - Convert.ToInt32(tb_Mortality_Of_Birds.Text);
                //  int Balance_Birds = Convert.ToInt32(tb_No_Of_Chicks_Placed.Text) - Convert.ToInt32(tb_Total_Mortality_Birds.Text) - Convert.ToInt32(tb_Total_Lifted_Birds.Text);
                tb_Balance_Birds.Text = Convert.ToString(Balance_Bird);
                Total_Mortality();
            }
        }

        private void tb_Total_Lifted_Birds_TextChanged(object sender, EventArgs e)
        {
            if ( tb_Total_Lifted_Birds.Text != "")
            {
                int Balance_Birds = Convert.ToInt32(tb_No_Of_Chicks_Placed.Text) - Convert.ToInt32(tb_Total_Mortality_Birds.Text) - Convert.ToInt32(tb_Total_Lifted_Birds.Text); 
                tb_Balance_Birds.Text = Convert.ToString(Balance_Birds);
            }
        }

        private void tb_Lifted_Birds_TextChanged(object sender, EventArgs e)
        {
            Total_Lifted_Birds();
        }

        private void tb_Lifted_Birds_KG_TextChanged(object sender, EventArgs e)
        {
            Lifted_Birds_KG();
        }
        private void tb_Total_Mortality_Birds_TextChanged(object sender, EventArgs e)
        {
            if (tb_Total_Mortality_Birds.Text != "")
            {
                
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();
            if (tb_Lot_No.Text != "" && tb_Running_Age.Text != "" && tb_Mortality_Of_Birds.Text != "" && tb_Total_Lifted_Birds.Text != "" && tb_Lifted_Birds_KG.Text != "" && tb_Last_Reorted_Body_Weight.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Insert Into Lot_Details Values(@LNo,@HDate,@RDate,@RAge,@FChicksCap,@NOChicksPlaced,@MOBirds,@TMBirds,@LBirds,@LBirdsKg,@TLBirds,@TLBirdsKg,@BalBirds,@LRBWeight,@EntryBy)";
                cmd.Parameters.Add("LNo", SqlDbType.Int).Value = tb_Lot_No.Text;
                cmd.Parameters.Add("HDate", SqlDbType.Date).Value = dtp_Hach_Date.Text;
                cmd.Parameters.Add("RDate", SqlDbType.Date).Value = dtp_Running_Date.Text;
                cmd.Parameters.Add("RAge", SqlDbType.Int).Value = tb_Running_Age.Text;
                cmd.Parameters.Add("FChicksCap", SqlDbType.Int).Value = tb_Farms_Chicks_Capacity.Text;
                cmd.Parameters.Add("NOChicksPlaced", SqlDbType.Int).Value = tb_No_Of_Chicks_Placed.Text;
                cmd.Parameters.Add("MOBirds", SqlDbType.Int).Value = tb_Mortality_Of_Birds.Text;
                cmd.Parameters.Add("TMBirds", SqlDbType.Int).Value = tb_Total_Mortality_Birds.Text;
                cmd.Parameters.Add("LBirds", SqlDbType.Int).Value = tb_Lifted_Birds.Text;
                cmd.Parameters.Add("LBirdsKg", SqlDbType.Float).Value = tb_Lifted_Birds_KG.Text;
                cmd.Parameters.Add("TLBirds", SqlDbType.Int).Value = tb_Total_Lifted_Birds.Text;
                cmd.Parameters.Add("TLBirdsKg", SqlDbType.Float).Value = tb_Total_Lifted_Birds_Kg.Text;
                cmd.Parameters.Add("BalBirds", SqlDbType.Int).Value = tb_Balance_Birds.Text;
                cmd.Parameters.Add("LRBWeight", SqlDbType.Float).Value = tb_Last_Reorted_Body_Weight.Text;
                cmd.Parameters.Add("EntryBy", SqlDbType.VarChar).Value = Shared_Content.Login_User;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Entry Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Connection.S_Con_Close();
        }

        private void tb_Mortality_Of_Birds_DoubleClick(object sender, EventArgs e)
        {
            tb_Mortality_Of_Birds.Text = "";
            tb_Total_Mortality_Birds.Text = Mortality.ToString();
            tb_Balance_Birds.Text = Balance_Bird.ToString();
        }

        private void tb_Lifted_Birds_DoubleClick(object sender, EventArgs e)
        {
            tb_Lifted_Birds.Text = "";
            tb_Total_Lifted_Birds.Text = Lifted_Birds.ToString();
            tb_Total_Lifted_Birds.Text = Lifted_Birds.ToString();
        }

        private void tb_Lifted_Birds_KG_DoubleClick(object sender, EventArgs e)
        {
            tb_Lifted_Birds_KG.Text = "";
            tb_Total_Lifted_Birds_Kg.Text = Lifted_Birds_Kg.ToString();
            tb_Total_Lifted_Birds_Kg.Text = Lifted_Birds_Kg.ToString();
        }
    }
}