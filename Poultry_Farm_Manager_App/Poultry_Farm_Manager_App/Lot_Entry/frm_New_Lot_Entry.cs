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
    public partial class frm_New_Lot_Entry : Form
    {
        public frm_New_Lot_Entry()
        {
            InitializeComponent();
        }
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

        void Clear_Control()
        {
            tb_Lot_Number.Text = Convert.ToString(Shared_Content.AutoIncr("New_Lot_Entry_Details", "Lot_No", 101));
            tb_Supplier.Clear();
            tb_Mobile_No.Clear();
            tb_Chicks_Price.Clear();
            tb_Chicks_Body_Weight.Clear();
            tb_No_Of_Chicks_Placed.Clear();
            tb_Total_Bill.Clear();

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            if (tb_Lot_Number.Text != "" && tb_Supplier.Text != "" && dtp_Hach_Date.Text != "" && tb_Mobile_No.Text != "" && tb_Chicks_Price.Text != "" && tb_Chicks_Body_Weight.Text != "" && tb_No_Of_Chicks_Placed.Text != "" && tb_Total_Bill.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Connection.DBCon;
                cmd.CommandText = "Insert Into New_Lot_Entry_Details Values(@LotNo,@Sup,@HDate,@MobNo,@CPrice,@CBWeight,@NOChicksPlaced,@TotBill,@CurrentSk)";

                cmd.Parameters.Add("LotNo", SqlDbType.Int).Value = tb_Lot_Number.Text;
                cmd.Parameters.Add("Sup", SqlDbType.VarChar).Value = tb_Supplier.Text;
                cmd.Parameters.Add("HDate", SqlDbType.Date).Value = dtp_Hach_Date.Text;
                cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("CPrice", SqlDbType.Money).Value = tb_Chicks_Price.Text;
                cmd.Parameters.Add("CBWeight", SqlDbType.Float).Value = tb_Chicks_Body_Weight.Text;
                cmd.Parameters.Add("NOChicksPlaced", SqlDbType.VarChar).Value = tb_No_Of_Chicks_Placed.Text;
                cmd.Parameters.Add("TotBill", SqlDbType.Money).Value = tb_Total_Bill.Text;
                cmd.Parameters.Add("CurrentSk", SqlDbType.Int).Value = 1;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Lot Entry Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Shared_Content.flag = 5;
                Clear_Control();

            }
            else
            {
                MessageBox.Show("First Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Connection.S_Con_Close();
        }

        private void frm_New_Lot_Entry_Load(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Connection.DBCon;
            cmd.CommandText = "Select Count(*) from New_Lot_Entry_Details Where Current_Stock > 0";

            int LiveLotCount = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            if (LiveLotCount > 0)
            {
                MessageBox.Show("Clear Last Lot 1st", "Poultry Not Availbale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gb_Chicks_Details.Enabled = false;
                gb_New_Lot_Entry.Enabled = false;
                btn_Save.Enabled = false;
                btn_Refresh.Enabled = false;
            }
            else
            {
                tb_Lot_Number.Text = Convert.ToString(Shared_Content.AutoIncr("Lot_Details", "Lot_No", 101));
                Clear_Control();
            }
        }

        private void tb_No_Of_Chicks_Placed_TextChanged(object sender, EventArgs e)
        {
            if (tb_Chicks_Price.Text != "" && tb_No_Of_Chicks_Placed.Text != "")
            {
                int TotalL = Convert.ToInt32(tb_Chicks_Price.Text) * Convert.ToInt32(tb_No_Of_Chicks_Placed.Text);

                tb_Total_Bill.Text = Convert.ToString(TotalL);
            }
        }
    }
}
