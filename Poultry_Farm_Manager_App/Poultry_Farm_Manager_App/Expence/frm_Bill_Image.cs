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
using System.IO;

namespace Poultry_Farm_Manager_App.Expence
{
    public partial class frm_Bill_Image : Form
    {
        public frm_Bill_Image()
        {
            InitializeComponent();
        }

        private void frm_Bill_Image_Load(object sender, EventArgs e)
        {
            Bind_Grid_Img("Select Exp_Id,Exp_Details From Expence_Details ", dgv_Bill);
        }

        void Bind_Grid_Img(string Query,DataGridView obj)
        {
            Connection.S_Con_Open();

            obj.DataSource = "";
            SqlDataAdapter SDA = new SqlDataAdapter(Query, Connection.DBCon);

            DataTable DT = new DataTable();

            SDA.Fill(DT);
            obj.DataSource = DT;

            Connection.S_Con_Close();
        }

        void View_Img(string Query,PictureBox pb)
        {
            Connection.S_Con_Open();

            SqlCommand cmd = new SqlCommand(Query, Connection.DBCon);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);

            if(DS.Tables[0].Rows.Count>0)
            {
                MemoryStream ms = new MemoryStream((byte[])DS.Tables[0].Rows[0]["Bill_Image"]);

                pb.Image = new Bitmap(ms);
            }
            else
            {
                MessageBox.Show("Invalid Image Id","incorrect",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }

            Connection.S_Con_Close();
        }

        private void dgv_Bill_SelectionChanged(object sender, EventArgs e)
        {
            Int32 SelectedRowCount = dgv_Bill.Rows.GetRowCount(DataGridViewElementStates.Selected);

           if(SelectedRowCount ==1)
            {
                string value = dgv_Bill.SelectedCells[0].RowIndex.ToString();
                int Index = Convert.ToInt32(value);
                int id = Convert.ToInt32(dgv_Bill.Rows[Index].Cells[0].Value);

                View_Img("Select Bill_Image From Expence_Details where Exp_Id =" + id + "", pb_Bill_Img);
            }

        }
    }
}
