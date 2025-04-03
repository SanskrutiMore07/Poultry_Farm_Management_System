
namespace Poultry_Farm_Manager_App.Supplier
{
    partial class frm_Supplier_List
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
            this.dgv_Supplier_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Supplier_List
            // 
            this.dgv_Supplier_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supplier_List.Location = new System.Drawing.Point(12, 12);
            this.dgv_Supplier_List.Name = "dgv_Supplier_List";
            this.dgv_Supplier_List.Size = new System.Drawing.Size(980, 497);
            this.dgv_Supplier_List.TabIndex = 1;
            // 
            // frm_Supplier_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.dgv_Supplier_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Supplier_List";
            this.Text = "frm_Supplier_List";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Supplier_List;
    }
}