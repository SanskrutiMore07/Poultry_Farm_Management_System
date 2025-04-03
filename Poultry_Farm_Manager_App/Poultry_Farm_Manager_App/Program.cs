using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poultry_Farm_Manager_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
            //Application.Run(new frm_Main_Poultry_Form());
            //Application.Run(new Reports.ReportForms.frm_Dispatch_Lot_Report());
        }
    }
}
