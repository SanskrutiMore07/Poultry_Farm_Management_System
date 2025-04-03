
namespace Poultry_Farm_Manager_App.Staff
{
    partial class frm_Staff_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Staff_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Search_By_Designation = new System.Windows.Forms.Label();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Staff_List
            // 
            this.dgv_Staff_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 8.765217F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Staff_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Staff_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Staff_List.Location = new System.Drawing.Point(16, 136);
            this.dgv_Staff_List.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Staff_List.Name = "dgv_Staff_List";
            this.dgv_Staff_List.RowHeadersWidth = 51;
            this.dgv_Staff_List.Size = new System.Drawing.Size(1307, 491);
            this.dgv_Staff_List.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(914, 49);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(197, 60);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // lbl_Search_By_Designation
            // 
            this.lbl_Search_By_Designation.AutoSize = true;
            this.lbl_Search_By_Designation.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl_Search_By_Designation.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_By_Designation.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Search_By_Designation.Location = new System.Drawing.Point(175, 63);
            this.lbl_Search_By_Designation.Name = "lbl_Search_By_Designation";
            this.lbl_Search_By_Designation.Size = new System.Drawing.Size(309, 37);
            this.lbl_Search_By_Designation.TabIndex = 10;
            this.lbl_Search_By_Designation.Text = "Search By Designation";
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Designation.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Worker"});
            this.cmb_Designation.Location = new System.Drawing.Point(549, 68);
            this.cmb_Designation.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(264, 32);
            this.cmb_Designation.TabIndex = 11;
            this.cmb_Designation.SelectedIndexChanged += new System.EventHandler(this.cmb_Designation_SelectedIndexChanged);
            // 
            // frm_Staff_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.Controls.Add(this.cmb_Designation);
            this.Controls.Add(this.lbl_Search_By_Designation);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Staff_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Staff_List";
            this.Text = "STAFF LIST";
            this.Load += new System.EventHandler(this.frm_Staff_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Staff_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Search_By_Designation;
        private System.Windows.Forms.ComboBox cmb_Designation;
    }
}