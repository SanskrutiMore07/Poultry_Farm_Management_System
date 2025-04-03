
namespace Poultry_Farm_Manager_App.Heading
{
    partial class uc_Summary
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
            this.lbl_Summary_Of_Lot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Summary_Of_Lot
            // 
            this.lbl_Summary_Of_Lot.AutoSize = true;
            this.lbl_Summary_Of_Lot.Font = new System.Drawing.Font("Baskerville Old Face", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Summary_Of_Lot.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Summary_Of_Lot.Location = new System.Drawing.Point(373, 47);
            this.lbl_Summary_Of_Lot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Summary_Of_Lot.Name = "lbl_Summary_Of_Lot";
            this.lbl_Summary_Of_Lot.Size = new System.Drawing.Size(574, 90);
            this.lbl_Summary_Of_Lot.TabIndex = 5;
            this.lbl_Summary_Of_Lot.Text = "Summary Of Lot";
            // 
            // uc_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.lbl_Summary_Of_Lot);
            this.Name = "uc_Summary";
            this.Size = new System.Drawing.Size(1339, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Summary_Of_Lot;
    }
}
