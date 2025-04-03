
namespace Poultry_Farm_Manager_App.Feed_Details
{
    partial class frm_Feed_Purchase_List
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
            this.dgv_Feed_Purchase_list = new System.Windows.Forms.DataGridView();
            this.pnl_Feed_Details_List = new System.Windows.Forms.Panel();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Feed_Purchase_list)).BeginInit();
            this.pnl_Feed_Details_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Feed_Purchase_list
            // 
            this.dgv_Feed_Purchase_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Feed_Purchase_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Feed_Purchase_list.Location = new System.Drawing.Point(13, 141);
            this.dgv_Feed_Purchase_list.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Feed_Purchase_list.Name = "dgv_Feed_Purchase_list";
            this.dgv_Feed_Purchase_list.RowHeadersWidth = 51;
            this.dgv_Feed_Purchase_list.Size = new System.Drawing.Size(1313, 479);
            this.dgv_Feed_Purchase_list.TabIndex = 5;
            // 
            // pnl_Feed_Details_List
            // 
            this.pnl_Feed_Details_List.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnl_Feed_Details_List.Controls.Add(this.lbl_Month);
            this.pnl_Feed_Details_List.Controls.Add(this.lbl_Year);
            this.pnl_Feed_Details_List.Controls.Add(this.cmb_Year);
            this.pnl_Feed_Details_List.Controls.Add(this.cmb_Month);
            this.pnl_Feed_Details_List.Controls.Add(this.btn_Refresh);
            this.pnl_Feed_Details_List.Location = new System.Drawing.Point(13, 20);
            this.pnl_Feed_Details_List.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Feed_Details_List.Name = "pnl_Feed_Details_List";
            this.pnl_Feed_Details_List.Size = new System.Drawing.Size(1313, 113);
            this.pnl_Feed_Details_List.TabIndex = 4;
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Location = new System.Drawing.Point(372, 22);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(47, 17);
            this.lbl_Month.TabIndex = 8;
            this.lbl_Month.Text = "Month";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(658, 23);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(38, 17);
            this.lbl_Year.TabIndex = 7;
            this.lbl_Year.Text = "Year";
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
            this.cmb_Year.Location = new System.Drawing.Point(570, 44);
            this.cmb_Year.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(220, 41);
            this.cmb_Year.TabIndex = 3;
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
            this.cmb_Month.Location = new System.Drawing.Point(287, 43);
            this.cmb_Month.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(220, 41);
            this.cmb_Month.TabIndex = 2;
            this.cmb_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Month_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(912, 32);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(197, 62);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Feed_Purchase_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Feed_Purchase_list);
            this.Controls.Add(this.pnl_Feed_Details_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Feed_Purchase_List";
            this.Text = "Feed Purchase List";
            this.Load += new System.EventHandler(this.frm_Feed_Purchase_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Feed_Purchase_list)).EndInit();
            this.pnl_Feed_Details_List.ResumeLayout(false);
            this.pnl_Feed_Details_List.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Feed_Purchase_list;
        private System.Windows.Forms.Panel pnl_Feed_Details_List;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.Label lbl_Year;
    }
}