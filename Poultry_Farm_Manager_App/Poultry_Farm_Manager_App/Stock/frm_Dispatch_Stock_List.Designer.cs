
namespace Poultry_Farm_Manager_App.Stock
{
    partial class frm_Dispatch_Stock_List
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
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.dgv_Dispatch_Stock_List = new System.Windows.Forms.DataGridView();
            this.lbl_Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dispatch_Stock_List)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.btn_Refresh.Location = new System.Drawing.Point(840, 30);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(177, 66);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
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
            this.cmb_Year.Location = new System.Drawing.Point(572, 48);
            this.cmb_Year.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(213, 41);
            this.cmb_Year.TabIndex = 3;
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
            this.cmb_Month.Location = new System.Drawing.Point(309, 49);
            this.cmb_Month.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(213, 41);
            this.cmb_Month.TabIndex = 2;
            this.cmb_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Month_SelectedIndexChanged);
            // 
            // dgv_Dispatch_Stock_List
            // 
            this.dgv_Dispatch_Stock_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Dispatch_Stock_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dispatch_Stock_List.Location = new System.Drawing.Point(16, 126);
            this.dgv_Dispatch_Stock_List.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Dispatch_Stock_List.Name = "dgv_Dispatch_Stock_List";
            this.dgv_Dispatch_Stock_List.RowHeadersWidth = 51;
            this.dgv_Dispatch_Stock_List.Size = new System.Drawing.Size(1307, 487);
            this.dgv_Dispatch_Stock_List.TabIndex = 5;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 15.02609F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(213, 58);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(60, 26);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "Date";
            // 
            // frm_Dispatch_Stock_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.dgv_Dispatch_Stock_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Dispatch_Stock_List";
            this.Text = "DISPATCH STOCK LIST";
            this.Load += new System.EventHandler(this.frm_Dispatch_Stock_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dispatch_Stock_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.DataGridView dgv_Dispatch_Stock_List;
        private System.Windows.Forms.Label lbl_Date;
    }
}