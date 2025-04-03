
namespace Poultry_Farm_Manager_App.Expence
{
    partial class frm_Expence_List
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
            this.dgv_Expence_List = new System.Windows.Forms.DataGridView();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Search_Expence = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Expence_List
            // 
            this.dgv_Expence_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Expence_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expence_List.Location = new System.Drawing.Point(16, 127);
            this.dgv_Expence_List.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Expence_List.Name = "dgv_Expence_List";
            this.dgv_Expence_List.RowHeadersWidth = 49;
            this.dgv_Expence_List.Size = new System.Drawing.Size(1307, 474);
            this.dgv_Expence_List.TabIndex = 9;
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
            this.cmb_Year.Location = new System.Drawing.Point(707, 46);
            this.cmb_Year.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(267, 41);
            this.cmb_Year.TabIndex = 2;
            this.cmb_Year.SelectedIndexChanged += new System.EventHandler(this.cmb_Year_SelectedIndexChanged);
            // 
            // cmb_Month
            // 
            this.cmb_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.IntegralHeight = false;
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
            this.cmb_Month.Location = new System.Drawing.Point(387, 46);
            this.cmb_Month.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(267, 41);
            this.cmb_Month.TabIndex = 1;
            this.cmb_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Month_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1045, 46);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(197, 49);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // lbl_Search_Expence
            // 
            this.lbl_Search_Expence.AutoSize = true;
            this.lbl_Search_Expence.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Search_Expence.Font = new System.Drawing.Font("Mongolian Baiti", 17F, System.Drawing.FontStyle.Bold);
            this.lbl_Search_Expence.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Search_Expence.Location = new System.Drawing.Point(55, 53);
            this.lbl_Search_Expence.Name = "lbl_Search_Expence";
            this.lbl_Search_Expence.Size = new System.Drawing.Size(298, 30);
            this.lbl_Search_Expence.TabIndex = 10;
            this.lbl_Search_Expence.Text = "Search Expence Details";
            // 
            // frm_Expence_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.Controls.Add(this.lbl_Search_Expence);
            this.Controls.Add(this.dgv_Expence_List);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.btn_Refresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Expence_List";
            this.Text = "frm_Expence_List";
            this.Load += new System.EventHandler(this.frm_Expence_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Expence_List;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Search_Expence;
    }
}