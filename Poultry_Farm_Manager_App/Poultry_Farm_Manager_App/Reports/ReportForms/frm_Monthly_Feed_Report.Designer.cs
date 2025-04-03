
namespace Poultry_Farm_Manager_App.Reports.ReportForms
{
    partial class frm_Monthly_Feed_Report
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_EDate = new System.Windows.Forms.Label();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.crpt_Monthly_Feed_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 15.02609F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(974, 46);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(147, 54);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refersh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_EDate
            // 
            this.lbl_EDate.AutoSize = true;
            this.lbl_EDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_EDate.Font = new System.Drawing.Font("Elephant", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EDate.Location = new System.Drawing.Point(579, 47);
            this.lbl_EDate.Name = "lbl_EDate";
            this.lbl_EDate.Size = new System.Drawing.Size(86, 38);
            this.lbl_EDate.TabIndex = 7;
            this.lbl_EDate.Text = "Year";
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_Month.Font = new System.Drawing.Font("Elephant", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Month.Location = new System.Drawing.Point(101, 47);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(115, 38);
            this.lbl_Month.TabIndex = 6;
            this.lbl_Month.Text = "Month";
            // 
            // crpt_Monthly_Feed_Report
            // 
            this.crpt_Monthly_Feed_Report.ActiveViewIndex = -1;
            this.crpt_Monthly_Feed_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt_Monthly_Feed_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpt_Monthly_Feed_Report.DisplayStatusBar = false;
            this.crpt_Monthly_Feed_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crpt_Monthly_Feed_Report.Location = new System.Drawing.Point(0, 134);
            this.crpt_Monthly_Feed_Report.Name = "crpt_Monthly_Feed_Report";
            this.crpt_Monthly_Feed_Report.Size = new System.Drawing.Size(1183, 636);
            this.crpt_Monthly_Feed_Report.TabIndex = 11;
            this.crpt_Monthly_Feed_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cmb_Year
            // 
            this.cmb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cmb_Year.Location = new System.Drawing.Point(682, 47);
            this.cmb_Year.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(213, 41);
            this.cmb_Year.TabIndex = 13;
            this.cmb_Year.SelectedIndexChanged += new System.EventHandler(this.cmb_Year_SelectedIndexChanged);
            // 
            // cmb_Month
            // 
            this.cmb_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_Month.Location = new System.Drawing.Point(257, 44);
            this.cmb_Month.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(213, 41);
            this.cmb_Month.TabIndex = 12;
            this.cmb_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Month_SelectedIndexChanged);
            // 
            // frm_Monthly_Feed_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 770);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.crpt_Monthly_Feed_Report);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_EDate);
            this.Controls.Add(this.lbl_Month);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Monthly_Feed_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Feed Report";
            this.Load += new System.EventHandler(this.frm_Monthly_Feed_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_EDate;
        private System.Windows.Forms.Label lbl_Month;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt_Monthly_Feed_Report;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Month;
    }
}