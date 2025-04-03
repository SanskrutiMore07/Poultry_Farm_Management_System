
namespace Poultry_Farm_Manager_App.Lot_Entry
{
    partial class frm_View_Lot_Entry
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
            this.dgv_Lot_Entry = new System.Windows.Forms.DataGridView();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Lot_Details = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lot_Entry)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Lot_Entry
            // 
            this.dgv_Lot_Entry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Lot_Entry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lot_Entry.Location = new System.Drawing.Point(3, 122);
            this.dgv_Lot_Entry.Name = "dgv_Lot_Entry";
            this.dgv_Lot_Entry.RowHeadersWidth = 51;
            this.dgv_Lot_Entry.RowTemplate.Height = 24;
            this.dgv_Lot_Entry.Size = new System.Drawing.Size(1332, 507);
            this.dgv_Lot_Entry.TabIndex = 0;
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
            this.cmb_Year.Location = new System.Drawing.Point(671, 49);
            this.cmb_Year.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(220, 41);
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
            this.cmb_Month.Location = new System.Drawing.Point(336, 49);
            this.cmb_Month.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(220, 41);
            this.cmb_Month.TabIndex = 1;
            this.cmb_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Month_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(945, 38);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(197, 62);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Lot_Details
            // 
            this.lbl_Lot_Details.AutoSize = true;
            this.lbl_Lot_Details.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Lot_Details.Font = new System.Drawing.Font("Mongolian Baiti", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lot_Details.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Lot_Details.Location = new System.Drawing.Point(109, 60);
            this.lbl_Lot_Details.Name = "lbl_Lot_Details";
            this.lbl_Lot_Details.Size = new System.Drawing.Size(149, 30);
            this.lbl_Lot_Details.TabIndex = 6;
            this.lbl_Lot_Details.Text = "Lot Details";
            // 
            // frm_View_Lot_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Lot_Details);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Lot_Entry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_View_Lot_Entry";
            this.Text = "frm_View_Lot_Entry";
            this.Load += new System.EventHandler(this.frm_View_Lot_Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lot_Entry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Lot_Entry;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Lot_Details;
    }
}