using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App
{
    internal class Shared_Content
    {
        public static string Login_User = "";
        public static int User_Id = 0;
        public static double Capacity = 0.0;
        public static string UserName = "";
        public static string User_Role = "";

        public static int Purchase_ID = 0;
        public static int Lot_Number = 0;
        

        public static int flag = 0;

        public static void Only_Numeric(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        public static void Only_Numeric_Float(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        public static void Only_Text(KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        public static void Alpha_Numeric(KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))))
            {
                e.Handled = true;
            }
        }
        public static int AutoIncr(string TableName, string ColName, int Spt)
        {
            int No = 0;
            Connection.S_Con_Open();
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Connection.DBCon;
            Cmd.CommandText = "Select Count(*) From " + TableName;

            No = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (No > 0)
            {
                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Select Max(" + ColName + ") From " + TableName;

                No = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                No = Spt;
            }
            Connection.S_Con_Close();
            return No;
        }

       public static void bind_ComboBox(ComboBox cmbObj,string colnm,string Query)
        {
            Connection.S_Con_Open();

            SqlCommand Cmd = new SqlCommand(Query, Connection.DBCon);
            
            SqlDataReader Dr = Cmd.ExecuteReader();

            cmbObj.Items.Clear();

            while (Dr.Read())
            {
                cmbObj.Items.Add(Dr.GetString(Dr.GetOrdinal(colnm)));
            }
            Connection.S_Con_Close();
        }
        public static void Bind_Grid(DataGridView dgv, string Query)
        {
            Connection.S_Con_Open();

            //dgv.Rows.Clear();

            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection.DBCon);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv.DataSource = dt;

            Connection.S_Con_Close();
        }

        public static void Generate_Id()
        {
            Connection.S_Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select User_Id from Login_Details where User_Name = @UName";
            cmd.Connection = Connection.DBCon;

            cmd.Parameters.Add("UName", SqlDbType.NVarChar).Value = Shared_Content.Login_User;
            User_Id = Convert.ToInt32(cmd.ExecuteScalar());

            Connection.S_Con_Close();
        }
    }
}
