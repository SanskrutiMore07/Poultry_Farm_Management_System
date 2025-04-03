
namespace Poultry_Farm_Manager_App.User_Management
{
    partial class frm_Delete_User
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
            this.gb_Delete_User = new System.Windows.Forms.GroupBox();
            this.tb_User_Role = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.tb_Admin_Password = new System.Windows.Forms.TextBox();
            this.lbl_Admin_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.dgv_User_Details = new System.Windows.Forms.DataGridView();
            this.gb_Delete_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Delete_User
            // 
            this.gb_Delete_User.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Delete_User.Controls.Add(this.tb_User_Role);
            this.gb_Delete_User.Controls.Add(this.tb_Username);
            this.gb_Delete_User.Controls.Add(this.btn_Delete_User);
            this.gb_Delete_User.Controls.Add(this.tb_Admin_Password);
            this.gb_Delete_User.Controls.Add(this.lbl_Admin_Password);
            this.gb_Delete_User.Controls.Add(this.lbl_Username);
            this.gb_Delete_User.Controls.Add(this.lbl_User_Role);
            this.gb_Delete_User.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Delete_User.Location = new System.Drawing.Point(37, 39);
            this.gb_Delete_User.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Delete_User.Name = "gb_Delete_User";
            this.gb_Delete_User.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Delete_User.Size = new System.Drawing.Size(671, 562);
            this.gb_Delete_User.TabIndex = 2;
            this.gb_Delete_User.TabStop = false;
            this.gb_Delete_User.Text = "Delete User";
            // 
            // tb_User_Role
            // 
            this.tb_User_Role.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User_Role.Location = new System.Drawing.Point(312, 90);
            this.tb_User_Role.Margin = new System.Windows.Forms.Padding(4);
            this.tb_User_Role.MaxLength = 10;
            this.tb_User_Role.Name = "tb_User_Role";
            this.tb_User_Role.Size = new System.Drawing.Size(336, 35);
            this.tb_User_Role.TabIndex = 7;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(312, 185);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Username.MaxLength = 10;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(336, 35);
            this.tb_Username.TabIndex = 6;
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.BackColor = System.Drawing.Color.Navy;
            this.btn_Delete_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete_User.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.btn_Delete_User.ForeColor = System.Drawing.Color.White;
            this.btn_Delete_User.Location = new System.Drawing.Point(182, 388);
            this.btn_Delete_User.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(296, 75);
            this.btn_Delete_User.TabIndex = 5;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = false;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // tb_Admin_Password
            // 
            this.tb_Admin_Password.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Admin_Password.Location = new System.Drawing.Point(312, 271);
            this.tb_Admin_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Admin_Password.MaxLength = 10;
            this.tb_Admin_Password.Name = "tb_Admin_Password";
            this.tb_Admin_Password.Size = new System.Drawing.Size(336, 35);
            this.tb_Admin_Password.TabIndex = 3;
            this.tb_Admin_Password.TextChanged += new System.EventHandler(this.tb_Admin_Password_TextChanged);
            // 
            // lbl_Admin_Password
            // 
            this.lbl_Admin_Password.AutoSize = true;
            this.lbl_Admin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin_Password.ForeColor = System.Drawing.Color.Green;
            this.lbl_Admin_Password.Location = new System.Drawing.Point(36, 268);
            this.lbl_Admin_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Admin_Password.Name = "lbl_Admin_Password";
            this.lbl_Admin_Password.Size = new System.Drawing.Size(246, 35);
            this.lbl_Admin_Password.TabIndex = 2;
            this.lbl_Admin_Password.Text = "Admin Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Green;
            this.lbl_Username.Location = new System.Drawing.Point(36, 178);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(156, 35);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.ForeColor = System.Drawing.Color.Green;
            this.lbl_User_Role.Location = new System.Drawing.Point(36, 83);
            this.lbl_User_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(151, 35);
            this.lbl_User_Role.TabIndex = 0;
            this.lbl_User_Role.Text = "User Role";
            // 
            // dgv_User_Details
            // 
            this.dgv_User_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_User_Details.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgv_User_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User_Details.Location = new System.Drawing.Point(747, 39);
            this.dgv_User_Details.Name = "dgv_User_Details";
            this.dgv_User_Details.RowHeadersWidth = 49;
            this.dgv_User_Details.RowTemplate.Height = 24;
            this.dgv_User_Details.Size = new System.Drawing.Size(552, 562);
            this.dgv_User_Details.TabIndex = 3;
            this.dgv_User_Details.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_User_Details_CellDoubleClick);
            // 
            // frm_Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.Controls.Add(this.dgv_User_Details);
            this.Controls.Add(this.gb_Delete_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Delete_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DELETE USER";
            this.Load += new System.EventHandler(this.frm_Delete_User_Load);
            this.gb_Delete_User.ResumeLayout(false);
            this.gb_Delete_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Delete_User;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.TextBox tb_Admin_Password;
        private System.Windows.Forms.Label lbl_Admin_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.DataGridView dgv_User_Details;
        private System.Windows.Forms.TextBox tb_User_Role;
        private System.Windows.Forms.TextBox tb_Username;
    }
}