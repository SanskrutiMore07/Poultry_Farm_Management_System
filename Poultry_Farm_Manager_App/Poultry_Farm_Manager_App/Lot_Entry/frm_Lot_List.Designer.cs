
namespace Poultry_Farm_Manager_App.Lot_Entry
{
    partial class frm_Lot_List
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
            this.btn_Search_Lot = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.dgv_Lot_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lot_List)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search_Lot
            // 
            this.btn_Search_Lot.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Search_Lot.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Lot.Location = new System.Drawing.Point(50, 25);
            this.btn_Search_Lot.Name = "btn_Search_Lot";
            this.btn_Search_Lot.Size = new System.Drawing.Size(148, 49);
            this.btn_Search_Lot.TabIndex = 0;
            this.btn_Search_Lot.Text = "Search Lot";
            this.btn_Search_Lot.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(807, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cmb_Month
            // 
            this.cmb_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.IntegralHeight = false;
            this.cmb_Month.Location = new System.Drawing.Point(268, 29);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(201, 37);
            this.cmb_Month.TabIndex = 2;
            // 
            // cmb_Year
            // 
            this.cmb_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Location = new System.Drawing.Point(537, 31);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(201, 37);
            this.cmb_Year.TabIndex = 3;
            // 
            // dgv_Lot_List
            // 
            this.dgv_Lot_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lot_List.Location = new System.Drawing.Point(12, 96);
            this.dgv_Lot_List.Name = "dgv_Lot_List";
            this.dgv_Lot_List.Size = new System.Drawing.Size(980, 393);
            this.dgv_Lot_List.TabIndex = 4;
            // 
            // frm_Lot_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.dgv_Lot_List);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Search_Lot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Lot_List";
            this.Text = "frm_Lot_List";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lot_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search_Lot;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.DataGridView dgv_Lot_List;
    }
}