
namespace Poultry_Farm_Manager_App.Reports.ReportForms
{
    partial class frm_Lot_Status
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
            this.crpt_Lot_Status = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Lot_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crpt_Lot_Status
            // 
            this.crpt_Lot_Status.ActiveViewIndex = -1;
            this.crpt_Lot_Status.AutoScroll = true;
            this.crpt_Lot_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt_Lot_Status.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpt_Lot_Status.DisplayStatusBar = false;
            this.crpt_Lot_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crpt_Lot_Status.Location = new System.Drawing.Point(0, 140);
            this.crpt_Lot_Status.Name = "crpt_Lot_Status";
            this.crpt_Lot_Status.Size = new System.Drawing.Size(1262, 640);
            this.crpt_Lot_Status.TabIndex = 0;
            this.crpt_Lot_Status.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Location = new System.Drawing.Point(734, 62);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 29);
            this.dtp_to.TabIndex = 16;
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Location = new System.Drawing.Point(458, 62);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 29);
            this.dtp_from.TabIndex = 15;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Palatino Linotype", 15.02609F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1030, 44);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(147, 54);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Lot_Status
            // 
            this.lbl_Lot_Status.AutoSize = true;
            this.lbl_Lot_Status.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Lot_Status.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lot_Status.Location = new System.Drawing.Point(91, 64);
            this.lbl_Lot_Status.Name = "lbl_Lot_Status";
            this.lbl_Lot_Status.Size = new System.Drawing.Size(249, 34);
            this.lbl_Lot_Status.TabIndex = 14;
            this.lbl_Lot_Status.Text = "Search Lot Status";
            // 
            // frm_Lot_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 780);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Lot_Status);
            this.Controls.Add(this.crpt_Lot_Status);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Lot_Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Lot_Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt_Lot_Status;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Lot_Status;
    }
}