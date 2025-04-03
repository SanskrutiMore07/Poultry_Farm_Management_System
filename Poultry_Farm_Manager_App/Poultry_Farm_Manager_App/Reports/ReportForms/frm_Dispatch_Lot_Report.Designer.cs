
namespace Poultry_Farm_Manager_App.Reports.ReportForms
{
    partial class frm_Dispatch_Lot_Report
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Lot_No = new System.Windows.Forms.Label();
            this.tb_Lot_No = new System.Windows.Forms.TextBox();
            this.crpt_Dispatch_Lot = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Palatino Linotype", 15.02609F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(758, 26);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(147, 54);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Lot_No
            // 
            this.lbl_Lot_No.AutoSize = true;
            this.lbl_Lot_No.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Lot_No.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lot_No.Location = new System.Drawing.Point(277, 35);
            this.lbl_Lot_No.Name = "lbl_Lot_No";
            this.lbl_Lot_No.Size = new System.Drawing.Size(106, 34);
            this.lbl_Lot_No.TabIndex = 14;
            this.lbl_Lot_No.Text = "Lot No";
            // 
            // tb_Lot_No
            // 
            this.tb_Lot_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lot_No.Location = new System.Drawing.Point(443, 39);
            this.tb_Lot_No.Name = "tb_Lot_No";
            this.tb_Lot_No.Size = new System.Drawing.Size(228, 31);
            this.tb_Lot_No.TabIndex = 12;
            // 
            // crpt_Dispatch_Lot
            // 
            this.crpt_Dispatch_Lot.ActiveViewIndex = -1;
            this.crpt_Dispatch_Lot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt_Dispatch_Lot.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpt_Dispatch_Lot.DisplayStatusBar = false;
            this.crpt_Dispatch_Lot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crpt_Dispatch_Lot.Location = new System.Drawing.Point(0, 106);
            this.crpt_Dispatch_Lot.Name = "crpt_Dispatch_Lot";
            this.crpt_Dispatch_Lot.Size = new System.Drawing.Size(1187, 629);
            this.crpt_Dispatch_Lot.TabIndex = 15;
            this.crpt_Dispatch_Lot.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Dispatch_Lot_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 735);
            this.Controls.Add(this.crpt_Dispatch_Lot);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Lot_No);
            this.Controls.Add(this.tb_Lot_No);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Dispatch_Lot_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispatch Lot Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Lot_No;
        private System.Windows.Forms.TextBox tb_Lot_No;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt_Dispatch_Lot;
    }
}