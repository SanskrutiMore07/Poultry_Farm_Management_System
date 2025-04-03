
namespace Poultry_Farm_Manager_App.Reports.ReportForms
{
    partial class frm_Feed_Consumption
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
            this.crpt_Consumption = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Consumption_Details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crpt_Consumption
            // 
            this.crpt_Consumption.ActiveViewIndex = -1;
            this.crpt_Consumption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt_Consumption.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpt_Consumption.DisplayStatusBar = false;
            this.crpt_Consumption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crpt_Consumption.Location = new System.Drawing.Point(0, 153);
            this.crpt_Consumption.Name = "crpt_Consumption";
            this.crpt_Consumption.Size = new System.Drawing.Size(1262, 627);
            this.crpt_Consumption.TabIndex = 0;
            this.crpt_Consumption.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Location = new System.Drawing.Point(733, 65);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 29);
            this.dtp_to.TabIndex = 12;
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Location = new System.Drawing.Point(457, 65);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 29);
            this.dtp_from.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Palatino Linotype", 15.02609F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1030, 52);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(147, 54);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Consumption_Details
            // 
            this.lbl_Consumption_Details.AutoSize = true;
            this.lbl_Consumption_Details.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Consumption_Details.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consumption_Details.Location = new System.Drawing.Point(23, 65);
            this.lbl_Consumption_Details.Name = "lbl_Consumption_Details";
            this.lbl_Consumption_Details.Size = new System.Drawing.Size(389, 34);
            this.lbl_Consumption_Details.TabIndex = 10;
            this.lbl_Consumption_Details.Text = "Search Consumption Details";
            // 
            // frm_Feed_Consumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 780);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Consumption_Details);
            this.Controls.Add(this.crpt_Consumption);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Feed_Consumption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Feed_Consumption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt_Consumption;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Consumption_Details;
    }
}