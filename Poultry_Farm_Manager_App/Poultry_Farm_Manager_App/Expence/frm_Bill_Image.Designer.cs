
namespace Poultry_Farm_Manager_App.Expence
{
    partial class frm_Bill_Image
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
            this.dgv_Bill = new System.Windows.Forms.DataGridView();
            this.pb_Bill_Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Bill
            // 
            this.dgv_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill.Location = new System.Drawing.Point(118, 75);
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.RowHeadersWidth = 49;
            this.dgv_Bill.RowTemplate.Height = 24;
            this.dgv_Bill.Size = new System.Drawing.Size(511, 462);
            this.dgv_Bill.TabIndex = 0;
            this.dgv_Bill.SelectionChanged += new System.EventHandler(this.dgv_Bill_SelectionChanged);
            // 
            // pb_Bill_Img
            // 
            this.pb_Bill_Img.BackColor = System.Drawing.Color.MintCream;
            this.pb_Bill_Img.Location = new System.Drawing.Point(723, 75);
            this.pb_Bill_Img.Name = "pb_Bill_Img";
            this.pb_Bill_Img.Size = new System.Drawing.Size(486, 462);
            this.pb_Bill_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Bill_Img.TabIndex = 1;
            this.pb_Bill_Img.TabStop = false;
            // 
            // frm_Bill_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1321, 596);
            this.Controls.Add(this.pb_Bill_Img);
            this.Controls.Add(this.dgv_Bill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Bill_Image";
            this.Text = "frm_Bill_Image";
            this.Load += new System.EventHandler(this.frm_Bill_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Bill;
        private System.Windows.Forms.PictureBox pb_Bill_Img;
    }
}