
namespace Poultry_Farm_Manager_App.Reports.ReportForms
{
    partial class frm_Feed_Purchase_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crpt_Feed_Purchase = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpt_Feed_Purchase
            // 
            this.crpt_Feed_Purchase.ActiveViewIndex = -1;
            this.crpt_Feed_Purchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt_Feed_Purchase.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpt_Feed_Purchase.DisplayStatusBar = false;
            this.crpt_Feed_Purchase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crpt_Feed_Purchase.Location = new System.Drawing.Point(0, -2);
            this.crpt_Feed_Purchase.Name = "crpt_Feed_Purchase";
            this.crpt_Feed_Purchase.Size = new System.Drawing.Size(1262, 782);
            this.crpt_Feed_Purchase.TabIndex = 0;
            this.crpt_Feed_Purchase.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Feed_Purchase_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 780);
            this.Controls.Add(this.crpt_Feed_Purchase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Feed_Purchase_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feed Purchase Report";
            this.Load += new System.EventHandler(this.frm_Feed_Purchase_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt_Feed_Purchase;
    }
}