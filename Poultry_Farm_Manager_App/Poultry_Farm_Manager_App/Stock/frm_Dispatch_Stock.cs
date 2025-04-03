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

namespace Poultry_Farm_Manager_App.Stock
{
    public partial class frm_Dispatch_Stock : Form
    {
        public frm_Dispatch_Stock()
        {
            InitializeComponent();
        }
        private void ONF(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric_Float(e);
        }
        private void frm_Dispatch_Stock_Load(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = Connection.DBCon;
           // cmd.CommandText = "Select Lot_No from New_Lot_Entry_Details";

           // SqlDataReader Dr = cmd.ExecuteReader();

           // if (Dr.Read())
            //{
               /// tb_Lot_Number.Text = (Dr["Lot_No"].ToString());
            //}

            //   Connection.S_Con_Close();

            //cmd.Connection = Connection.DBCon;
            cmd1.CommandText = "Select Count(*) from New_Lot_Entry_Details Where Current_Stock > 0";

            int LiveLotCount = Convert.ToInt32(cmd1.ExecuteScalar());

            cmd1.Dispose();

            if (LiveLotCount > 0)
            {
                cmd1.Connection = Connection.DBCon;
                cmd1.CommandText = "Select Lot_No from New_Lot_Entry_Details Where Current_Stock > 0";

                int CLotNo = Convert.ToInt32(cmd1.ExecuteScalar());

                cmd1.Dispose();

                cmd1.Connection = Connection.DBCon;
                cmd1.CommandText = "Select Lot_No from New_Lot_Entry_Details  where Lot_No = " + CLotNo + "";
                SqlDataReader Dr1 = cmd1.ExecuteReader();

                if (Dr1.Read())
                {
                    tb_Lot_Number.Text = (Dr1["Lot_No"].ToString());
                }
                cmd1.Dispose();
                Dr1.Close();

                Connection.S_Con_Close();
                tb_Dispatch_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Dispatch_Details", "Dispatch_ID", 1001));
                Shared_Content.bind_ComboBox(cmb_Trader, "Trader_Name", "select distinct(Trader_Name)from Trader_Details");
            }
        
        }

        private void cmb_Trader_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection.DBCon;
            cmd.CommandText = "Select  Mob_No,PAN_No from Trader_Details where Trader_Name = '"+ cmb_Trader.Text+"' " ;

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Mobile_No.Text = (Dr["Mob_No"].ToString());
                tb_Pan_No.Text = (Dr["PAN_No"].ToString());
            }
            
            Connection.S_Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();
            if (tb_Mobile_No.Text != "" && dtp_Date.Text != "" && tb_Total_Weight_KG.Text != "" && tb_Average_B_Weight.Text != "" && tb_Total_Lifted_Birds.Text != "" && tb_Chicks_Price.Text != "" && tb_Total_Bill.Text != "" )
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Insert Into Dispatch_Details Values(@LNo,@DID,@MobNo,@pan_No,@Trader,@Date,@TWK,@ABW,@TLF,@ChicksP,@TBill)";
                cmd.Connection = Connection.DBCon;
                cmd.Parameters.Add("LNo", SqlDbType.Int).Value = tb_Lot_Number.Text;
                cmd.Parameters.Add("DID", SqlDbType.Int).Value = tb_Dispatch_ID.Text;
                cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("pan_No", SqlDbType.NVarChar).Value = tb_Pan_No.Text;
                cmd.Parameters.Add("Trader", SqlDbType.VarChar).Value = cmb_Trader.Text;
                cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                cmd.Parameters.Add("TWK", SqlDbType.Float).Value = tb_Total_Weight_KG.Text;
                cmd.Parameters.Add("ABW", SqlDbType.Float).Value = tb_Average_B_Weight.Text;
                cmd.Parameters.Add("TLF", SqlDbType.Int).Value = tb_Total_Lifted_Birds.Text;
                cmd.Parameters.Add("ChicksP", SqlDbType.Money).Value = tb_Chicks_Price.Text;
                cmd.Parameters.Add("TBill", SqlDbType.Money).Value = tb_Total_Bill.Text;
              
  
                cmd.ExecuteNonQuery();

                MessageBox.Show("Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
                SqlDataAdapter SDA = new SqlDataAdapter("Update New_Lot_Entry_Details Set Current_Stock = 0 Where Lot_No = '" + tb_Lot_Number.Text + "'",Connection.DBCon);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                MessageBox.Show("Stock Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tb_Chicks_Price_TextChanged(object sender, EventArgs e)
        {
            if (tb_Total_Lifted_Birds.Text != "" && tb_Chicks_Price.Text !="")
            {
                double Total = Convert.ToDouble(tb_Total_Lifted_Birds.Text) * Convert.ToDouble(tb_Chicks_Price.Text);

                tb_Total_Bill.Text = Convert.ToString(Total);
            }
            else
            {
                tb_Total_Bill.Text = "0";
            }
        }

        private void tb_Total_Lifted_Birds_TextChanged(object sender, EventArgs e)
        {
            if (tb_Average_B_Weight.Text != "" && tb_Total_Lifted_Birds.Text != "")
            {
                double Total = Convert.ToDouble(tb_Average_B_Weight.Text) * Convert.ToDouble(tb_Total_Lifted_Birds.Text);

                tb_Total_Weight_KG.Text = Convert.ToString(Total);
            }
            else
            {
                tb_Total_Weight_KG.Text = "0";
            }
        }
    }
}
