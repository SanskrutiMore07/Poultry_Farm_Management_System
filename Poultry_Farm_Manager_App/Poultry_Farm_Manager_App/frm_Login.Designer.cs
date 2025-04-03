
namespace Poultry_Farm_Manager_App
{
    partial class frm_Login
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
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.cmb_User_Name = new System.Windows.Forms.ComboBox();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.pnl_Welcome = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.pnl_Welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_login
            // 
            this.pb_login.BackColor = System.Drawing.Color.GhostWhite;
            this.pb_login.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_login.Image = global::Poultry_Farm_Manager_App.Properties.Resources.PoultryLogo1;
            this.pb_login.Location = new System.Drawing.Point(0, 0);
            this.pb_login.Margin = new System.Windows.Forms.Padding(4);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(629, 652);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login.TabIndex = 15;
            this.pb_login.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(911, 514);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(189, 74);
            this.btn_Login.TabIndex = 14;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tb_Password.Location = new System.Drawing.Point(1000, 394);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(356, 40);
            this.tb_Password.TabIndex = 13;
            // 
            // cmb_User_Name
            // 
            this.cmb_User_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmb_User_Name.FormattingEnabled = true;
            this.cmb_User_Name.Location = new System.Drawing.Point(1000, 288);
            this.cmb_User_Name.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_User_Name.Name = "cmb_User_Name";
            this.cmb_User_Name.Size = new System.Drawing.Size(356, 41);
            this.cmb_User_Name.TabIndex = 11;
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Worker"});
            this.cmb_User_Role.Location = new System.Drawing.Point(1000, 190);
            this.cmb_User_Role.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(356, 41);
            this.cmb_User_Role.TabIndex = 9;
            this.cmb_User_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_User_Role_SelectedIndexChanged);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Password.Location = new System.Drawing.Point(683, 386);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(161, 44);
            this.lbl_Password.TabIndex = 12;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_User_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_User_Name.Location = new System.Drawing.Point(683, 281);
            this.lbl_User_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(185, 44);
            this.lbl_User_Name.TabIndex = 10;
            this.lbl_User_Name.Text = "User Name";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_User_Role.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_User_Role.Location = new System.Drawing.Point(683, 182);
            this.lbl_User_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(162, 44);
            this.lbl_User_Role.TabIndex = 8;
            this.lbl_User_Role.Text = "User Role";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Californian FB", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Welcome.Location = new System.Drawing.Point(103, 27);
            this.lbl_Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(576, 74);
            this.lbl_Welcome.TabIndex = 16;
            this.lbl_Welcome.Text = "AgroBird EC House\r\n";
            // 
            // pnl_Welcome
            // 
            this.pnl_Welcome.BackColor = System.Drawing.Color.Teal;
            this.pnl_Welcome.Controls.Add(this.lbl_Welcome);
            this.pnl_Welcome.Location = new System.Drawing.Point(627, 0);
            this.pnl_Welcome.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Welcome.Name = "pnl_Welcome";
            this.pnl_Welcome.Size = new System.Drawing.Size(751, 123);
            this.pnl_Welcome.TabIndex = 17;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1376, 652);
            this.Controls.Add(this.pnl_Welcome);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.cmb_User_Name);
            this.Controls.Add(this.cmb_User_Role);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User_Name);
            this.Controls.Add(this.lbl_User_Role);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.pnl_Welcome.ResumeLayout(false);
            this.pnl_Welcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.ComboBox cmb_User_Name;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Panel pnl_Welcome;
    }
}

