
namespace Poultry_Farm_Manager_App.Heading
{
    partial class uc_Stock
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
            this.lbl_Stock_Details = new System.Windows.Forms.Label();
            this.btn_btn_Dispatch_Stock_List = new System.Windows.Forms.Button();
            this.btn_Dispatch_Stock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Stock_Details
            // 
            this.lbl_Stock_Details.AutoSize = true;
            this.lbl_Stock_Details.Font = new System.Drawing.Font("Baskerville Old Face", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Details.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Stock_Details.Location = new System.Drawing.Point(476, 14);
            this.lbl_Stock_Details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Stock_Details.Name = "lbl_Stock_Details";
            this.lbl_Stock_Details.Size = new System.Drawing.Size(367, 73);
            this.lbl_Stock_Details.TabIndex = 8;
            this.lbl_Stock_Details.Text = "Stock Details";
            // 
            // btn_btn_Dispatch_Stock_List
            // 
            this.btn_btn_Dispatch_Stock_List.BackColor = System.Drawing.Color.Teal;
            this.btn_btn_Dispatch_Stock_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_btn_Dispatch_Stock_List.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_btn_Dispatch_Stock_List.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_btn_Dispatch_Stock_List.Location = new System.Drawing.Point(880, 97);
            this.btn_btn_Dispatch_Stock_List.Margin = new System.Windows.Forms.Padding(4);
            this.btn_btn_Dispatch_Stock_List.Name = "btn_btn_Dispatch_Stock_List";
            this.btn_btn_Dispatch_Stock_List.Size = new System.Drawing.Size(332, 58);
            this.btn_btn_Dispatch_Stock_List.TabIndex = 11;
            this.btn_btn_Dispatch_Stock_List.Text = "Dispatch Stock List";
            this.btn_btn_Dispatch_Stock_List.UseVisualStyleBackColor = false;
            this.btn_btn_Dispatch_Stock_List.Click += new System.EventHandler(this.btn_btn_Dispatch_Stock_List_Click);
            // 
            // btn_Dispatch_Stock
            // 
            this.btn_Dispatch_Stock.BackColor = System.Drawing.Color.Teal;
            this.btn_Dispatch_Stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dispatch_Stock.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dispatch_Stock.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Dispatch_Stock.Location = new System.Drawing.Point(84, 97);
            this.btn_Dispatch_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Dispatch_Stock.Name = "btn_Dispatch_Stock";
            this.btn_Dispatch_Stock.Size = new System.Drawing.Size(356, 58);
            this.btn_Dispatch_Stock.TabIndex = 12;
            this.btn_Dispatch_Stock.Text = "Dispatch Stock";
            this.btn_Dispatch_Stock.UseVisualStyleBackColor = false;
            this.btn_Dispatch_Stock.Click += new System.EventHandler(this.btn_Dispatch_Stock_Click);
            // 
            // uc_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btn_Dispatch_Stock);
            this.Controls.Add(this.btn_btn_Dispatch_Stock_List);
            this.Controls.Add(this.lbl_Stock_Details);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_Stock";
            this.Size = new System.Drawing.Size(1339, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Stock_Details;
        private System.Windows.Forms.Button btn_btn_Dispatch_Stock_List;
        private System.Windows.Forms.Button btn_Dispatch_Stock;
    }
}
