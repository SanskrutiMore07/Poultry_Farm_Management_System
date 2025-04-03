
namespace Poultry_Farm_Manager_App.Heading
{
    partial class uc_Lot_Details
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
            this.lbl_Lot_Details = new System.Windows.Forms.Label();
            this.btn_New_Lot_Entry = new System.Windows.Forms.Button();
            this.btn_Current_Lot_Entry = new System.Windows.Forms.Button();
            this.btn_View_Lot_Entry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Lot_Details
            // 
            this.lbl_Lot_Details.AutoSize = true;
            this.lbl_Lot_Details.Font = new System.Drawing.Font("Baskerville Old Face", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lot_Details.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Lot_Details.Location = new System.Drawing.Point(500, 15);
            this.lbl_Lot_Details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lot_Details.Name = "lbl_Lot_Details";
            this.lbl_Lot_Details.Size = new System.Drawing.Size(327, 76);
            this.lbl_Lot_Details.TabIndex = 0;
            this.lbl_Lot_Details.Text = "Lot Details";
            // 
            // btn_New_Lot_Entry
            // 
            this.btn_New_Lot_Entry.BackColor = System.Drawing.Color.Teal;
            this.btn_New_Lot_Entry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New_Lot_Entry.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New_Lot_Entry.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_New_Lot_Entry.Location = new System.Drawing.Point(513, 107);
            this.btn_New_Lot_Entry.Margin = new System.Windows.Forms.Padding(4);
            this.btn_New_Lot_Entry.Name = "btn_New_Lot_Entry";
            this.btn_New_Lot_Entry.Size = new System.Drawing.Size(292, 58);
            this.btn_New_Lot_Entry.TabIndex = 2;
            this.btn_New_Lot_Entry.Text = "New Lot Entry";
            this.btn_New_Lot_Entry.UseVisualStyleBackColor = false;
            this.btn_New_Lot_Entry.Click += new System.EventHandler(this.btn_New_Lot_Entry_Click);
            // 
            // btn_Current_Lot_Entry
            // 
            this.btn_Current_Lot_Entry.BackColor = System.Drawing.Color.Teal;
            this.btn_Current_Lot_Entry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Current_Lot_Entry.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Current_Lot_Entry.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Current_Lot_Entry.Location = new System.Drawing.Point(77, 107);
            this.btn_Current_Lot_Entry.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Current_Lot_Entry.Name = "btn_Current_Lot_Entry";
            this.btn_Current_Lot_Entry.Size = new System.Drawing.Size(328, 58);
            this.btn_Current_Lot_Entry.TabIndex = 1;
            this.btn_Current_Lot_Entry.Text = "Current Lot Entry ";
            this.btn_Current_Lot_Entry.UseVisualStyleBackColor = false;
            this.btn_Current_Lot_Entry.Click += new System.EventHandler(this.btn_Current_Lot_Entry_Click);
            // 
            // btn_View_Lot_Entry
            // 
            this.btn_View_Lot_Entry.BackColor = System.Drawing.Color.Teal;
            this.btn_View_Lot_Entry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_Lot_Entry.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Lot_Entry.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_View_Lot_Entry.Location = new System.Drawing.Point(937, 107);
            this.btn_View_Lot_Entry.Margin = new System.Windows.Forms.Padding(4);
            this.btn_View_Lot_Entry.Name = "btn_View_Lot_Entry";
            this.btn_View_Lot_Entry.Size = new System.Drawing.Size(292, 58);
            this.btn_View_Lot_Entry.TabIndex = 4;
            this.btn_View_Lot_Entry.Text = "View Lot Entry";
            this.btn_View_Lot_Entry.UseVisualStyleBackColor = false;
            this.btn_View_Lot_Entry.Click += new System.EventHandler(this.btn_View_Lot_Entry_Click);
            // 
            // uc_Lot_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btn_View_Lot_Entry);
            this.Controls.Add(this.btn_Current_Lot_Entry);
            this.Controls.Add(this.btn_New_Lot_Entry);
            this.Controls.Add(this.lbl_Lot_Details);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_Lot_Details";
            this.Size = new System.Drawing.Size(1339, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lot_Details;
        private System.Windows.Forms.Button btn_New_Lot_Entry;
        private System.Windows.Forms.Button btn_Current_Lot_Entry;
        private System.Windows.Forms.Button btn_View_Lot_Entry;
    }
}
