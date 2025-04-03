
namespace Poultry_Farm_Manager_App.User_Management
{
    partial class frm_Add_User
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
            this.gb_Add_New_User = new System.Windows.Forms.GroupBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.gb_Add_New_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add_New_User
            // 
            this.gb_Add_New_User.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Add_New_User.Controls.Add(this.tb_Username);
            this.gb_Add_New_User.Controls.Add(this.btn_Add);
            this.gb_Add_New_User.Controls.Add(this.cmb_User_Role);
            this.gb_Add_New_User.Controls.Add(this.tb_Confirm_Password);
            this.gb_Add_New_User.Controls.Add(this.tb_Password);
            this.gb_Add_New_User.Controls.Add(this.lbl_Confirm_Password);
            this.gb_Add_New_User.Controls.Add(this.lbl_Password);
            this.gb_Add_New_User.Controls.Add(this.lbl_Username);
            this.gb_Add_New_User.Controls.Add(this.lbl_User_Role);
            this.gb_Add_New_User.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Add_New_User.Location = new System.Drawing.Point(136, 39);
            this.gb_Add_New_User.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Add_New_User.Name = "gb_Add_New_User";
            this.gb_Add_New_User.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Add_New_User.Size = new System.Drawing.Size(1064, 562);
            this.gb_Add_New_User.TabIndex = 0;
            this.gb_Add_New_User.TabStop = false;
            this.gb_Add_New_User.Text = "Add New User";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(553, 144);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Username.MaxLength = 10;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(369, 35);
            this.tb_Username.TabIndex = 6;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Navy;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(429, 452);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(200, 68);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Location = new System.Drawing.Point(553, 60);
            this.cmb_User_Role.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_User_Role.MaxLength = 20;
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(369, 32);
            this.cmb_User_Role.TabIndex = 1;
            this.cmb_User_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_User_Role_SelectedIndexChanged);
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Confirm_Password.Location = new System.Drawing.Point(553, 353);
            this.tb_Confirm_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Confirm_Password.MaxLength = 10;
            this.tb_Confirm_Password.Name = "tb_Confirm_Password";
            this.tb_Confirm_Password.PasswordChar = '*';
            this.tb_Confirm_Password.Size = new System.Drawing.Size(369, 35);
            this.tb_Confirm_Password.TabIndex = 4;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(553, 245);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(369, 35);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Confirm_Password
            // 
            this.lbl_Confirm_Password.AutoSize = true;
            this.lbl_Confirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Password.ForeColor = System.Drawing.Color.Green;
            this.lbl_Confirm_Password.Location = new System.Drawing.Point(147, 347);
            this.lbl_Confirm_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Confirm_Password.Name = "lbl_Confirm_Password";
            this.lbl_Confirm_Password.Size = new System.Drawing.Size(266, 35);
            this.lbl_Confirm_Password.TabIndex = 3;
            this.lbl_Confirm_Password.Text = "Confirm Password";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Green;
            this.lbl_Password.Location = new System.Drawing.Point(147, 239);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(151, 35);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Green;
            this.lbl_Username.Location = new System.Drawing.Point(147, 138);
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
            this.lbl_User_Role.Location = new System.Drawing.Point(147, 54);
            this.lbl_User_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(151, 35);
            this.lbl_User_Role.TabIndex = 0;
            this.lbl_User_Role.Text = "User Role";
            // 
            // frm_Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.Controls.Add(this.gb_Add_New_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD USER";
            this.Load += new System.EventHandler(this.frm_Add_User_Load);
            this.gb_Add_New_User.ResumeLayout(false);
            this.gb_Add_New_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add_New_User;
        private System.Windows.Forms.Label lbl_Confirm_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Username;
    }
}