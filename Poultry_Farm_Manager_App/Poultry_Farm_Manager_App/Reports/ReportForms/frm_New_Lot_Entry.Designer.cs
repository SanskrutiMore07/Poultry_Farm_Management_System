
namespace Poultry_Farm_Manager_App.Reports.ReportForms
{
    partial class frm_New_Lot_Entry
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
            this.crpt_New_Lot_Entry = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tb_Lot_No = new System.Windows.Forms.TextBox();
            this.lbl_Lot_No = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crpt_New_Lot_Entry
            // 
            this.crpt_New_Lot_Entry.ActiveViewIndex = -1;
            this.crpt_New_Lot_Entry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt_New_Lot_Entry.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpt_New_Lot_Entry.DisplayStatusBar = false;
            this.crpt_New_Lot_Entry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crpt_New_Lot_Entry.Location = new System.Drawing.Point(0, 139);
            this.crpt_New_Lot_Entry.Name = "crpt_New_Lot_Entry";
            this.crpt_New_Lot_Entry.Size = new System.Drawing.Size(1262, 641);
            this.crpt_New_Lot_Entry.TabIndex = 0;
            this.crpt_New_Lot_Entry.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tb_Lot_No
            // 
            this.tb_Lot_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lot_No.Location = new System.Drawing.Point(413, 61);
            this.tb_Lot_No.Name = "tb_Lot_No";
            this.tb_Lot_No.Size = new System.Drawing.Size(228, 31);
            this.tb_Lot_No.TabIndex = 1;
            // 
            // lbl_Lot_No
            // 
            this.lbl_Lot_No.AutoSize = true;
            this.lbl_Lot_No.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Lot_No.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lot_No.Location = new System.Drawing.Point(247, 57);
            this.lbl_Lot_No.Name = "lbl_Lot_No";
            this.lbl_Lot_No.Size = new System.Drawing.Size(106, 34);
            this.lbl_Lot_No.TabIndex = 11;
            this.lbl_Lot_No.Text = "Lot No";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Palatino Linotype", 15.02609F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(728, 48);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(147, 54);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_New_Lot_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 780);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Lot_No);
            this.Controls.Add(this.tb_Lot_No);
            this.Controls.Add(this.crpt_New_Lot_Entry);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_New_Lot_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_New_Lot_Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt_New_Lot_Entry;
        private System.Windows.Forms.TextBox tb_Lot_No;
        private System.Windows.Forms.Label lbl_Lot_No;
        private System.Windows.Forms.Button btn_Search;
    }
}