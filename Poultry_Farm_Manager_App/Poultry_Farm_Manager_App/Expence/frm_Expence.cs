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

namespace Poultry_Farm_Manager_App.Expence
{
    public partial class frm_Expence : Form
    {
        public frm_Expence()
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

        void Clear_Controls()
        {
            tb_Expence_Id.Clear();
            tb_Expence_Details.Clear();
            tb_Amount_Paid.Clear();
            tb_Paid_By.Clear();
            dtp_Expence_Date.ResetText();
            pb_Bill_Image.Image = null;
            
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection.S_Con_Open();

            if(tb_Expence_Details.Text != "" && tb_Amount_Paid.Text != "" && tb_Paid_By.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Insert Into Expence_Details Values(@EID,@EDate,@EDetails,@Bill_Image,@Amount_Paid,@Paid_By,@User_Login_ID,@Status)";

                Cmd.Parameters.Add("EID", SqlDbType.Int).Value = tb_Expence_Id.Text;
                Cmd.Parameters.Add("EDate", SqlDbType.Date).Value = dtp_Expence_Date.Text;
                Cmd.Parameters.Add("EDetails", SqlDbType.NVarChar).Value = tb_Expence_Details.Text;
                Cmd.Parameters.Add("Amount_Paid", SqlDbType.Money).Value = tb_Amount_Paid.Text;
                Cmd.Parameters.Add("Paid_By", SqlDbType.VarChar).Value = tb_Paid_By.Text;
                Cmd.Parameters.Add("User_Login_ID", SqlDbType.Int).Value = Shared_Content.User_Id;
                Cmd.Parameters.Add("Status", SqlDbType.Int).Value = 1;

                ImageConverter IC = new ImageConverter();
                byte[] imgArray = (byte[])IC.ConvertTo(pb_Bill_Image.Image, typeof(byte[]));
                Cmd.Parameters.Add("Bill_Image", SqlDbType.Image).Value = imgArray;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Expence Saved Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Information", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Connection.S_Con_Close();
        }

        private void btn_Browse_Bill_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files(*.jpg; *.png; *.gif; *.ico; *.bmp) | *.jpg; *.png; *.gif; *.ico; *.bmp";

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Bill_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void frm_Expence_Load(object sender, EventArgs e)
        {
            tb_Expence_Id.Text = Convert.ToString(Shared_Content.AutoIncr("Expence_Details", "Exp_Id",2001));
        }
    }
}
