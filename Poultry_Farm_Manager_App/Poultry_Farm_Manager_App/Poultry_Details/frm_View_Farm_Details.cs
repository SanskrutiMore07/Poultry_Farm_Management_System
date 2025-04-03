using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App.Poultry_Details
{
    public partial class frm_View_Farm_Details : Form
    {
        public frm_View_Farm_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Farm_Details_Load(object sender, EventArgs e)
        {
            Shared_Content.Bind_Grid(dgv_Farm_Details, "select * from Poultry_Farm_Details");
        }
    }
}
