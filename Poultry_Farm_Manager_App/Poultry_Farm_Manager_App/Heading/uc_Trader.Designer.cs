
namespace Poultry_Farm_Manager_App.Heading
{
    partial class uc_Trader
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
            this.btn_Trader_List = new System.Windows.Forms.Button();
            this.btn_Update_Trader = new System.Windows.Forms.Button();
            this.btn_Add_Trader = new System.Windows.Forms.Button();
            this.lbl_Trader_Details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Trader_List
            // 
            this.btn_Trader_List.BackColor = System.Drawing.Color.Teal;
            this.btn_Trader_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Trader_List.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trader_List.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Trader_List.Location = new System.Drawing.Point(741, 88);
            this.btn_Trader_List.Name = "btn_Trader_List";
            this.btn_Trader_List.Size = new System.Drawing.Size(184, 47);
            this.btn_Trader_List.TabIndex = 11;
            this.btn_Trader_List.Text = "Trader List";
            this.btn_Trader_List.UseVisualStyleBackColor = false;
            this.btn_Trader_List.Click += new System.EventHandler(this.btn_Trader_List_Click);
            // 
            // btn_Update_Trader
            // 
            this.btn_Update_Trader.BackColor = System.Drawing.Color.Teal;
            this.btn_Update_Trader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update_Trader.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Trader.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Update_Trader.Location = new System.Drawing.Point(392, 88);
            this.btn_Update_Trader.Name = "btn_Update_Trader";
            this.btn_Update_Trader.Size = new System.Drawing.Size(251, 47);
            this.btn_Update_Trader.TabIndex = 10;
            this.btn_Update_Trader.Text = "Update Trader";
            this.btn_Update_Trader.UseVisualStyleBackColor = false;
            this.btn_Update_Trader.Click += new System.EventHandler(this.btn_Update_Trader_Click);
            // 
            // btn_Add_Trader
            // 
            this.btn_Add_Trader.BackColor = System.Drawing.Color.Teal;
            this.btn_Add_Trader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_Trader.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Trader.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Add_Trader.Location = new System.Drawing.Point(79, 88);
            this.btn_Add_Trader.Name = "btn_Add_Trader";
            this.btn_Add_Trader.Size = new System.Drawing.Size(184, 47);
            this.btn_Add_Trader.TabIndex = 9;
            this.btn_Add_Trader.Text = "Add Trader";
            this.btn_Add_Trader.UseVisualStyleBackColor = false;
            this.btn_Add_Trader.Click += new System.EventHandler(this.btn_Add_Trader_Click);
            // 
            // lbl_Trader_Details
            // 
            this.lbl_Trader_Details.AutoSize = true;
            this.lbl_Trader_Details.Font = new System.Drawing.Font("Baskerville Old Face", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Trader_Details.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Trader_Details.Location = new System.Drawing.Point(326, 11);
            this.lbl_Trader_Details.Name = "lbl_Trader_Details";
            this.lbl_Trader_Details.Size = new System.Drawing.Size(339, 62);
            this.lbl_Trader_Details.TabIndex = 8;
            this.lbl_Trader_Details.Text = "Trader Details";
            // 
            // uc_Trader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btn_Trader_List);
            this.Controls.Add(this.btn_Update_Trader);
            this.Controls.Add(this.btn_Add_Trader);
            this.Controls.Add(this.lbl_Trader_Details);
            this.Name = "uc_Trader";
            this.Size = new System.Drawing.Size(1004, 147);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Trader_List;
        private System.Windows.Forms.Button btn_Update_Trader;
        private System.Windows.Forms.Button btn_Add_Trader;
        private System.Windows.Forms.Label lbl_Trader_Details;
    }
}
