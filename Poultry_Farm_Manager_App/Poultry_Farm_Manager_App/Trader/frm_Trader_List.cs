using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App.Trader
{
    public partial class frm_Trader_List : Form
    {
        public frm_Trader_List()
        {
            InitializeComponent();
        }
        private void frm_Trader_List_Load(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Trader, " Select * From Trader_Details");
        }
    }
}
