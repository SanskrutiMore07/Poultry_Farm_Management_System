
namespace Poultry_Farm_Manager_App.Heading
{
    partial class uc_Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Report_Details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Report_Details
            // 
            this.lbl_Report_Details.AutoSize = true;
            this.lbl_Report_Details.Font = new System.Drawing.Font("Baskerville Old Face", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Report_Details.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Report_Details.Location = new System.Drawing.Point(291, 46);
            this.lbl_Report_Details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Report_Details.Name = "lbl_Report_Details";
            this.lbl_Report_Details.Size = new System.Drawing.Size(673, 82);
            this.lbl_Report_Details.TabIndex = 8;
            this.lbl_Report_Details.Text = "Poultry Report Details";
            // 
            // uc_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.lbl_Report_Details);
            this.Name = "uc_Report";
            this.Size = new System.Drawing.Size(1339, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Report_Details;
    }
}
