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

namespace Poultry_Farm_Manager_App.Poultry_Details
{
    public partial class frm_Farm_Details : Form
    {
        public frm_Farm_Details()
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
        private void ONF(object sender, KeyPressEventArgs e)
        {
            Shared_Content.Only_Numeric_Float(e);
        }



        void Clear_Controls()
        {
         
            tb_Farm_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Poultry_Farm_Details", "Farm_ID", 10001));
            dtp_Date.ResetText();
            tb_Farmer_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Address.Clear();
            tb_Poultry_Length.Clear();
            tb_Poultry_Width.Clear();
            tb_Total_Square_Feet.Clear();
            tb_Pre_Bird_Square_Feet.Clear();
            tb_Farms_Chicks_Capacity.Clear();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            if (tb_Farm_ID.Text != "" && dtp_Date.Text != "" && tb_Farmer_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Address.Text != "" && tb_Poultry_Length.Text != "" && tb_Poultry_Width.Text != "" && tb_Total_Square_Feet.Text != "" && tb_Pre_Bird_Square_Feet.Text != "" && tb_Farms_Chicks_Capacity.Text !="")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Insert Into Poultry_Farm_Details (Farm_ID,Date,Plt_Farmer_Name,Mob_No,Alt_Mob_No,Address,Plt_Length,Plt_Width,Total_Sqr_Feet,Per_Bird_Sqr_Feet,Farms_Chicks_Capacity)Values(@FID,@Date,@FName,@MNo,@AltMNo,@Address,@PltLen,@PltWid,@TotalSqFeet,@PerBirdSqFeet,@FarmChicksCap)";
                Cmd.Parameters.Add("FID", SqlDbType.Int).Value = tb_Farm_ID.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("FName", SqlDbType.VarChar).Value = tb_Farmer_Name.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("AltMNo", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("PltLen", SqlDbType.Int).Value = tb_Poultry_Length.Text;
                Cmd.Parameters.Add("PltWid", SqlDbType.Int).Value = tb_Poultry_Width.Text;
                Cmd.Parameters.Add("TotalSqFeet", SqlDbType.Int).Value = tb_Total_Square_Feet.Text;
                Cmd.Parameters.Add("PerBirdSqFeet", SqlDbType.Float).Value = tb_Pre_Bird_Square_Feet.Text;
                Cmd.Parameters.Add("FarmChicksCap", SqlDbType.Float).Value = tb_Farms_Chicks_Capacity.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Poultry Information Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("First Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_Farm_Details_Load(object sender, EventArgs e)
        {
            tb_Farm_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Poultry_Farm_Details", "Farm_ID", 10001));
        }

        private void tb_Poultry_Width_TextChanged(object sender, EventArgs e)
        {
            if(tb_Poultry_Width.Text != "" && Convert.ToInt32(tb_Poultry_Width.Text)>0)
            {
                double Amount = Convert.ToDouble(tb_Poultry_Length.Text) * Convert.ToDouble(tb_Poultry_Width.Text);

                tb_Total_Square_Feet.Text = Convert.ToString(Amount);
            }
            else
            {
                tb_Total_Square_Feet.Clear();
            }
        }

        private void tb_Pre_Bird_Square_Feet_TextChanged(object sender, EventArgs e)
        {
            if (tb_Pre_Bird_Square_Feet.Text != "" && Convert.ToDouble(tb_Pre_Bird_Square_Feet.Text) > 0)
            {
                double Amount = Convert.ToDouble(tb_Total_Square_Feet.Text) / Convert.ToDouble(tb_Pre_Bird_Square_Feet.Text);

                tb_Farms_Chicks_Capacity.Text = Convert.ToString(Amount);
            }
        }

        private void tb_Farms_Chicks_Capacity_TextChanged(object sender, EventArgs e)
        {
            Shared_Content.Capacity = Convert.ToDouble(tb_Farms_Chicks_Capacity.Text);
        }
    }
}
