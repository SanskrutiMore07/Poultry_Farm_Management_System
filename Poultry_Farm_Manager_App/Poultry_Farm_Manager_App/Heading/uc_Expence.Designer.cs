
namespace Poultry_Farm_Manager_App.Heading
{
    partial class uc_Expence
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
            this.btn_Expence_List = new System.Windows.Forms.Button();
            this.btn_Add_Expence = new System.Windows.Forms.Button();
            this.lbl_Expence_Details = new System.Windows.Forms.Label();
            this.btn_Payment_Receipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Expence_List
            // 
            this.btn_Expence_List.BackColor = System.Drawing.Color.Teal;
            this.btn_Expence_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Expence_List.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Expence_List.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Expence_List.Location = new System.Drawing.Point(960, 108);
            this.btn_Expence_List.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Expence_List.Name = "btn_Expence_List";
            this.btn_Expence_List.Size = new System.Drawing.Size(245, 58);
            this.btn_Expence_List.TabIndex = 2;
            this.btn_Expence_List.Text = "Expence List";
            this.btn_Expence_List.UseVisualStyleBackColor = false;
            this.btn_Expence_List.Click += new System.EventHandler(this.btn_Expence_List_Click);
            // 
            // btn_Add_Expence
            // 
            this.btn_Add_Expence.BackColor = System.Drawing.Color.Teal;
            this.btn_Add_Expence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_Expence.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Expence.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Add_Expence.Location = new System.Drawing.Point(139, 108);
            this.btn_Add_Expence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add_Expence.Name = "btn_Add_Expence";
            this.btn_Add_Expence.Size = new System.Drawing.Size(245, 58);
            this.btn_Add_Expence.TabIndex = 1;
            this.btn_Add_Expence.Text = "Add Expence";
            this.btn_Add_Expence.UseVisualStyleBackColor = false;
            this.btn_Add_Expence.Click += new System.EventHandler(this.btn_Add_Expence_Click);
            // 
            // lbl_Expence_Details
            // 
            this.lbl_Expence_Details.AutoSize = true;
            this.lbl_Expence_Details.BackColor = System.Drawing.Color.Teal;
            this.lbl_Expence_Details.Font = new System.Drawing.Font("Baskerville Old Face", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Details.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Expence_Details.Location = new System.Drawing.Point(467, 17);
            this.lbl_Expence_Details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Expence_Details.Name = "lbl_Expence_Details";
            this.lbl_Expence_Details.Size = new System.Drawing.Size(446, 73);
            this.lbl_Expence_Details.TabIndex = 12;
            this.lbl_Expence_Details.Text = "Expence Details";
            // 
            // btn_Payment_Receipt
            // 
            this.btn_Payment_Receipt.BackColor = System.Drawing.Color.Teal;
            this.btn_Payment_Receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Payment_Receipt.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payment_Receipt.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Payment_Receipt.Location = new System.Drawing.Point(508, 108);
            this.btn_Payment_Receipt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Payment_Receipt.Name = "btn_Payment_Receipt";
            this.btn_Payment_Receipt.Size = new System.Drawing.Size(343, 58);
            this.btn_Payment_Receipt.TabIndex = 13;
            this.btn_Payment_Receipt.Text = "Payment Receipt";
            this.btn_Payment_Receipt.UseVisualStyleBackColor = false;
            this.btn_Payment_Receipt.Click += new System.EventHandler(this.btn_Payment_Receipt_Click);
            // 
            // uc_Expence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btn_Payment_Receipt);
            this.Controls.Add(this.btn_Expence_List);
            this.Controls.Add(this.btn_Add_Expence);
            this.Controls.Add(this.lbl_Expence_Details);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_Expence";
            this.Size = new System.Drawing.Size(1339, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Expence_List;
        private System.Windows.Forms.Button btn_Add_Expence;
        private System.Windows.Forms.Label lbl_Expence_Details;
        private System.Windows.Forms.Button btn_Payment_Receipt;
    }
}
