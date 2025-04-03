
namespace Poultry_Farm_Manager_App.Heading
{
    partial class uc_User_Management
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
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.btn_Update_User = new System.Windows.Forms.Button();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.lbl_User_Details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.BackColor = System.Drawing.Color.Teal;
            this.btn_Delete_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete_User.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Delete_User.Location = new System.Drawing.Point(741, 88);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(184, 47);
            this.btn_Delete_User.TabIndex = 11;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = false;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // btn_Update_User
            // 
            this.btn_Update_User.BackColor = System.Drawing.Color.Teal;
            this.btn_Update_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update_User.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_User.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Update_User.Location = new System.Drawing.Point(421, 88);
            this.btn_Update_User.Name = "btn_Update_User";
            this.btn_Update_User.Size = new System.Drawing.Size(184, 47);
            this.btn_Update_User.TabIndex = 10;
            this.btn_Update_User.Text = "Update User";
            this.btn_Update_User.UseVisualStyleBackColor = false;
            this.btn_Update_User.Click += new System.EventHandler(this.btn_Update_User_Click);
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.BackColor = System.Drawing.Color.Teal;
            this.btn_Add_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_User.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_User.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Add_User.Location = new System.Drawing.Point(79, 88);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(184, 47);
            this.btn_Add_User.TabIndex = 9;
            this.btn_Add_User.Text = "Add User";
            this.btn_Add_User.UseVisualStyleBackColor = false;
            this.btn_Add_User.Click += new System.EventHandler(this.btn_Add_User_Click);
            // 
            // lbl_User_Details
            // 
            this.lbl_User_Details.AutoSize = true;
            this.lbl_User_Details.Font = new System.Drawing.Font("Baskerville Old Face", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Details.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_User_Details.Location = new System.Drawing.Point(366, 11);
            this.lbl_User_Details.Name = "lbl_User_Details";
            this.lbl_User_Details.Size = new System.Drawing.Size(292, 62);
            this.lbl_User_Details.TabIndex = 8;
            this.lbl_User_Details.Text = "User Details";
            // 
            // uc_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btn_Delete_User);
            this.Controls.Add(this.btn_Update_User);
            this.Controls.Add(this.btn_Add_User);
            this.Controls.Add(this.lbl_User_Details);
            this.Name = "uc_User_Management";
            this.Size = new System.Drawing.Size(1004, 147);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.Button btn_Update_User;
        private System.Windows.Forms.Button btn_Add_User;
        private System.Windows.Forms.Label lbl_User_Details;
    }
}
