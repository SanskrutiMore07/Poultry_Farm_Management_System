
namespace Poultry_Farm_Manager_App.Poultry_Details
{
    partial class frm_View_Farm_Details
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
            this.dgv_Farm_Details = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Farm_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Farm_Details
            // 
            this.dgv_Farm_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 8.765217F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Farm_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Farm_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Farm_Details.Location = new System.Drawing.Point(16, 15);
            this.dgv_Farm_Details.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Farm_Details.Name = "dgv_Farm_Details";
            this.dgv_Farm_Details.RowHeadersWidth = 49;
            this.dgv_Farm_Details.Size = new System.Drawing.Size(1307, 612);
            this.dgv_Farm_Details.TabIndex = 0;
            // 
            // frm_View_Farm_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.Controls.Add(this.dgv_Farm_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Farm_Details";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "VIEW FARM DETAILS";
            this.Load += new System.EventHandler(this.frm_View_Farm_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Farm_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Farm_Details;
    }
}