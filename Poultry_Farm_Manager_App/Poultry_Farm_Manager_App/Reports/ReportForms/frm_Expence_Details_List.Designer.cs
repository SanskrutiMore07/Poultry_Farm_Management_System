
namespace Poultry_Farm_Manager_App.Reports.ReportForms
{
    partial class frm_Expence_Details_List
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
            this.crpt_Expence_List = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbl_SDate = new System.Windows.Forms.Label();
            this.lbl_EDate = new System.Windows.Forms.Label();
            this.dtp_From_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_To_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crpt_Expence_List
            // 
            this.crpt_Expence_List.ActiveViewIndex = -1;
            this.crpt_Expence_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt_Expence_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpt_Expence_List.DisplayStatusBar = false;
            this.crpt_Expence_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crpt_Expence_List.Location = new System.Drawing.Point(0, 144);
            this.crpt_Expence_List.Name = "crpt_Expence_List";
            this.crpt_Expence_List.Size = new System.Drawing.Size(1187, 591);
            this.crpt_Expence_List.TabIndex = 0;
            this.crpt_Expence_List.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lbl_SDate
            // 
            this.lbl_SDate.AutoSize = true;
            this.lbl_SDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_SDate.Font = new System.Drawing.Font("Elephant", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDate.Location = new System.Drawing.Point(58, 59);
            this.lbl_SDate.Name = "lbl_SDate";
            this.lbl_SDate.Size = new System.Drawing.Size(181, 38);
            this.lbl_SDate.TabIndex = 1;
            this.lbl_SDate.Text = "From Date";
            // 
            // lbl_EDate
            // 
            this.lbl_EDate.AutoSize = true;
            this.lbl_EDate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_EDate.Font = new System.Drawing.Font("Elephant", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EDate.Location = new System.Drawing.Point(571, 59);
            this.lbl_EDate.Name = "lbl_EDate";
            this.lbl_EDate.Size = new System.Drawing.Size(138, 38);
            this.lbl_EDate.TabIndex = 2;
            this.lbl_EDate.Text = "To Date";
            // 
            // dtp_From_Date
            // 
            this.dtp_From_Date.CalendarFont = new System.Drawing.Font("Mongolian Baiti", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From_Date.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From_Date.Location = new System.Drawing.Point(276, 65);
            this.dtp_From_Date.Name = "dtp_From_Date";
            this.dtp_From_Date.Size = new System.Drawing.Size(200, 30);
            this.dtp_From_Date.TabIndex = 3;
            // 
            // dtp_To_Date
            // 
            this.dtp_To_Date.CalendarFont = new System.Drawing.Font("Mongolian Baiti", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To_Date.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To_Date.Location = new System.Drawing.Point(749, 65);
            this.dtp_To_Date.Name = "dtp_To_Date";
            this.dtp_To_Date.Size = new System.Drawing.Size(200, 30);
            this.dtp_To_Date.TabIndex = 4;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Palatino Linotype", 15.02609F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1001, 59);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(147, 54);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Expence_Details_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 735);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_To_Date);
            this.Controls.Add(this.dtp_From_Date);
            this.Controls.Add(this.lbl_EDate);
            this.Controls.Add(this.lbl_SDate);
            this.Controls.Add(this.crpt_Expence_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Expence_Details_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Expence_Details_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt_Expence_List;
        private System.Windows.Forms.Label lbl_SDate;
        private System.Windows.Forms.Label lbl_EDate;
        private System.Windows.Forms.DateTimePicker dtp_From_Date;
        private System.Windows.Forms.DateTimePicker dtp_To_Date;
        private System.Windows.Forms.Button btn_Search;
    }
}