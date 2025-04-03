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
    public partial class frm_Feed_Purchase_Entry : Form
    {
        public frm_Feed_Purchase_Entry()
        {
            InitializeComponent();
        }

        int FCnt = 1;
      
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

        void Calc_Total()
        {
            if (cmb_Bag_Kg.Text != "" && tb_Price.Text != "" && tb_Bag_Qty.Text != "")
            {
                double Total = Convert.ToDouble(cmb_Bag_Kg.Text) * Convert.ToDouble(tb_Price.Text) * Convert.ToDouble(tb_Bag_Qty.Text);

                tb_Total.Text = Convert.ToString(Total);
            }
            else
            {
                tb_Total.Text = "0";
            }
        }
        void Clear_Controls()
        {
            FCnt = 1;
            tb_Feed_Purchase_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Purchase_Details", "FP_ID", 1001));
            dtp_Date.ResetText();
            tb_Sup_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Feed.SelectedIndex = -1;
            cmb_Bag_Kg.SelectedIndex = -1;
            tb_Total.Clear();
            tb_Price.Clear();
            tb_Bag_Qty.Clear();
            tb_Total_Bill.Text = "0";
            dgv_Feed_Purchase_Entry.Rows.Clear();
        }
        private void frm_Feed_Purchase_Entry_Load(object sender, EventArgs e)
        {
            FCnt = 1;
            tb_Feed_Purchase_ID.Text = Convert.ToString(Shared_Content.AutoIncr("Purchase_Details", "FP_ID", 1001));
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        /* private void btn_Add_Click(object sender, EventArgs e)
         {
             if (cmb_Feed.Text != "" && cmb_Bag_Kg.Text != "" && tb_Price.Text != "" && tb_Bag_Qty.Text != "" && tb_Total.Text != "") 
             {
                 dgv_Feed_Purchase_Entry.Rows.Add(FCnt, cmb_Feed.Text, cmb_Bag_Kg.Text, tb_Price.Text, tb_Bag_Qty.Text, tb_Total.Text);

                 tb_Total_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Total.Text) + Convert.ToDouble(tb_Total_Bill.Text));

                 cmb_Feed.SelectedIndex = -1;
                 cmb_Bag_Kg.SelectedIndex = -1;
                 tb_Total.Clear();
                 tb_Price.Clear();
                 tb_Bag_Qty.Clear();

                 FCnt++;
             }
             else 
             {
                 MessageBox.Show("Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
         }*/
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Feed.Text != "" && cmb_Bag_Kg.Text != "" && tb_Price.Text != "" && tb_Bag_Qty.Text != "" && tb_Total.Text != "")
            {
                int flag = -1, Qty = Convert.ToInt32(tb_Bag_Qty.Text);

                for (int i = 0; i < dgv_Feed_Purchase_Entry.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgv_Feed_Purchase_Entry.Rows[i].Cells[1].Value) == cmb_Feed.Text && Convert.ToString(dgv_Feed_Purchase_Entry.Rows[i].Cells[2].Value) == cmb_Bag_Kg.Text)
                    {
                        flag = 0;
                        Qty += Convert.ToInt32(dgv_Feed_Purchase_Entry.Rows[i].Cells[4].Value);


                        double Total_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Total.Text);
                        dgv_Feed_Purchase_Entry.Rows[i].Cells[4].Value = Qty;
                        dgv_Feed_Purchase_Entry.Rows[i].Cells[5].Value = Total_Price;
                        tb_Total_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Total.Text) + Convert.ToDouble(tb_Total_Bill.Text));

                    }

                }
                if (flag == -1)
                {
                    dgv_Feed_Purchase_Entry.Rows.Add(FCnt, cmb_Feed.Text, cmb_Bag_Kg.Text, tb_Price.Text, tb_Bag_Qty.Text, tb_Total.Text);
                    tb_Total_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Total.Text) + Convert.ToDouble(tb_Total_Bill.Text));

                    cmb_Feed.SelectedIndex = -1;
                    cmb_Bag_Kg.SelectedIndex = -1;
                    tb_Total.Clear();
                    tb_Price.Clear();
                    tb_Bag_Qty.Clear();

                    FCnt++;

                }
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Sup_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Total_Bill.Text != "")
            {
                int Bqty = 0;
                Connection.S_Con_Open();

                /// Purchase Details Entry
                SqlCommand cmd1 = new SqlCommand("Insert Into Purchase_Details values (@FP_ID,@Date,@S_Nm,@MOB,@Total_Bill,@Receive)", Connection.DBCon);

                cmd1.Parameters.Add("@FP_ID", SqlDbType.Int).Value = tb_Feed_Purchase_ID.Text;
                cmd1.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd1.Parameters.Add("@S_Nm", SqlDbType.VarChar).Value = tb_Sup_Name.Text;
                cmd1.Parameters.Add("@MOB", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd1.Parameters.Add("@Total_Bill", SqlDbType.Money).Value = tb_Total_Bill.Text;
                cmd1.Parameters.Add("@Receive", SqlDbType.VarChar).Value = Shared_Content.Login_User;

                cmd1.ExecuteNonQuery();
                cmd1.Dispose();

                for (int i = 0; i < dgv_Feed_Purchase_Entry.Rows.Count; i++)
                {
                    int C_Stock = Convert.ToInt32(dgv_Feed_Purchase_Entry.Rows[i].Cells[4].Value) * Convert.ToInt32(dgv_Feed_Purchase_Entry.Rows[i].Cells[2].Value);

                    /// Feed_Purchase_Entry
                    SqlCommand cmd2 = new SqlCommand("Insert Into Feed_Purchase_Entry values (@FP_ID,@Feed,@Bag,@Price,@BagQty,@Total)", Connection.DBCon);
                    cmd2.Parameters.Add("@FP_ID", SqlDbType.Int).Value = tb_Feed_Purchase_ID.Text;
                    cmd2.Parameters.Add("@Feed", SqlDbType.VarChar).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[1].Value;
                    cmd2.Parameters.Add("@Bag", SqlDbType.Int).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[2].Value;
                    cmd2.Parameters.Add("@Price", SqlDbType.Money).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[3].Value;
                    cmd2.Parameters.Add("@BagQty", SqlDbType.Int).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[4].Value;
                    cmd2.Parameters.Add("@Total", SqlDbType.Money).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[5].Value;

                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();

                    ///  Stock Details

                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.Connection = Connection.DBCon;
                    cmd3.CommandText = "Select Current_Stock,Bag_Qty from Feed_Stock_Details where Feed = @FD And Bag_Kg = @bkg";

                    cmd3.Parameters.Add("FD", SqlDbType.VarChar).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[1].Value;
                    cmd3.Parameters.Add("bkg", SqlDbType.Int).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[2].Value;

                    SqlDataReader Dr = cmd3.ExecuteReader();
                    cmd3.Dispose();

                    if (Dr.Read())
                    {
                        C_Stock += Convert.ToInt32((Dr["Current_Stock"].ToString()));
                        Bqty += Convert.ToInt32((Dr["Bag_Qty"].ToString()));
                        Dr.Close();
                        SqlCommand cmd4 = new SqlCommand();

                        cmd4.CommandText = "Update Feed_Stock_Details Set Current_Stock = @Stok ,Bag_Qty =@Qty Where Feed = @F And Bag_Kg = @bgkg";
                        cmd4.Connection = Connection.DBCon;

                        cmd4.Parameters.Add("bgkg", SqlDbType.Int).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[2].Value;
                        cmd4.Parameters.Add("F", SqlDbType.VarChar).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[1].Value;

                        cmd4.Parameters.Add("Qty", SqlDbType.Int).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[4].Value;

                        cmd4.Parameters.Add("Stok", SqlDbType.Int).Value = C_Stock;

                        cmd4.ExecuteNonQuery();
                        cmd4.Dispose();
                    }
                    else
                    {
                        Dr.Close();
                        SqlCommand cmd5 = new SqlCommand();

                        cmd5.CommandText = "Insert Into Feed_Stock_Details values (@Fed, @bk, @BgQty, @Stk)";
                        cmd5.Connection = Connection.DBCon;

                        cmd5.Parameters.Add("Fed", SqlDbType.VarChar).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[1].Value;
                        cmd5.Parameters.Add("bk", SqlDbType.Int).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[2].Value;
                        cmd5.Parameters.Add("BgQty", SqlDbType.Int).Value = dgv_Feed_Purchase_Entry.Rows[i].Cells[4].Value;
                        cmd5.Parameters.Add("Stk", SqlDbType.Int).Value = C_Stock;

                      
                        cmd5.ExecuteNonQuery();
                        cmd5.Dispose();
                    }


                }
                MessageBox.Show("Purchase Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Content.Purchase_ID = Convert.ToInt32(tb_Feed_Purchase_ID.Text);

                Connection.S_Con_Close();
                Clear_Controls();
                Reports.ReportForms.frm_Feed_Purchase_Report obj = new Reports.ReportForms.frm_Feed_Purchase_Report();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Fill Purchase Details Properly", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_Bag_Qty_TextChanged(object sender, EventArgs e)
        {
            Calc_Total();
        }

        private void tb_Price_TextChanged(object sender, EventArgs e)
        {
            Calc_Total();
        }

    }
}
