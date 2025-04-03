
namespace Poultry_Farm_Manager_App.Trader
{
    partial class frm_Add_Trader
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Account_No = new System.Windows.Forms.TextBox();
            this.lbl_Account_No = new System.Windows.Forms.Label();
            this.lbl_Bank_Detail = new System.Windows.Forms.Label();
            this.tb_Bank_Detail = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Bank_Details = new System.Windows.Forms.GroupBox();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.tb_Alternate_Mobile_No = new System.Windows.Forms.TextBox();
            this.gb_Personal_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Joining_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_PAN_No = new System.Windows.Forms.TextBox();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.tb_Trader_Name = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Alternate_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Trader_Name = new System.Windows.Forms.Label();
            this.lbl_Aadhaar_No = new System.Windows.Forms.Label();
            this.lbl_Trader_ID = new System.Windows.Forms.Label();
            this.tb_Trader_ID = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.gb_Bank_Details.SuspendLayout();
            this.gb_Personal_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Navy;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(303, 546);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(188, 64);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Account_No
            // 
            this.tb_Account_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_No.Location = new System.Drawing.Point(291, 105);
            this.tb_Account_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Account_No.MaxLength = 20;
            this.tb_Account_No.Name = "tb_Account_No";
            this.tb_Account_No.Size = new System.Drawing.Size(488, 33);
            this.tb_Account_No.TabIndex = 10;
            this.tb_Account_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AN);
            // 
            // lbl_Account_No
            // 
            this.lbl_Account_No.AutoSize = true;
            this.lbl_Account_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Account_No.Location = new System.Drawing.Point(63, 102);
            this.lbl_Account_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Account_No.Name = "lbl_Account_No";
            this.lbl_Account_No.Size = new System.Drawing.Size(128, 25);
            this.lbl_Account_No.TabIndex = 5;
            this.lbl_Account_No.Text = "Account No";
            // 
            // lbl_Bank_Detail
            // 
            this.lbl_Bank_Detail.AutoSize = true;
            this.lbl_Bank_Detail.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bank_Detail.ForeColor = System.Drawing.Color.Green;
            this.lbl_Bank_Detail.Location = new System.Drawing.Point(63, 37);
            this.lbl_Bank_Detail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bank_Detail.Name = "lbl_Bank_Detail";
            this.lbl_Bank_Detail.Size = new System.Drawing.Size(134, 25);
            this.lbl_Bank_Detail.TabIndex = 1;
            this.lbl_Bank_Detail.Text = "Bank Detail";
            // 
            // tb_Bank_Detail
            // 
            this.tb_Bank_Detail.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bank_Detail.Location = new System.Drawing.Point(291, 23);
            this.tb_Bank_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Bank_Detail.MaxLength = 50;
            this.tb_Bank_Detail.Multiline = true;
            this.tb_Bank_Detail.Name = "tb_Bank_Detail";
            this.tb_Bank_Detail.Size = new System.Drawing.Size(488, 57);
            this.tb_Bank_Detail.TabIndex = 9;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(833, 546);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(188, 64);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // gb_Bank_Details
            // 
            this.gb_Bank_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Bank_Details.Controls.Add(this.tb_Note);
            this.gb_Bank_Details.Controls.Add(this.tb_Account_No);
            this.gb_Bank_Details.Controls.Add(this.lbl_Account_No);
            this.gb_Bank_Details.Controls.Add(this.lbl_Note);
            this.gb_Bank_Details.Controls.Add(this.lbl_Bank_Detail);
            this.gb_Bank_Details.Controls.Add(this.tb_Bank_Detail);
            this.gb_Bank_Details.ForeColor = System.Drawing.Color.DarkBlue;
            this.gb_Bank_Details.Location = new System.Drawing.Point(12, 335);
            this.gb_Bank_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Bank_Details.Name = "gb_Bank_Details";
            this.gb_Bank_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Bank_Details.Size = new System.Drawing.Size(1315, 174);
            this.gb_Bank_Details.TabIndex = 27;
            this.gb_Bank_Details.TabStop = false;
            this.gb_Bank_Details.Text = "Bank Details";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(917, 23);
            this.tb_Note.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Note.MaxLength = 100;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(355, 129);
            this.tb_Note.TabIndex = 11;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Green;
            this.lbl_Note.Location = new System.Drawing.Point(831, 37);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(57, 25);
            this.lbl_Note.TabIndex = 9;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(916, 164);
            this.tb_Email_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Email_ID.MaxLength = 50;
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(355, 33);
            this.tb_Email_ID.TabIndex = 7;
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_No.Location = new System.Drawing.Point(916, 110);
            this.tb_Aadhar_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(355, 33);
            this.tb_Aadhar_No.TabIndex = 6;
            this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // tb_Alternate_Mobile_No
            // 
            this.tb_Alternate_Mobile_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternate_Mobile_No.Location = new System.Drawing.Point(315, 218);
            this.tb_Alternate_Mobile_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Alternate_Mobile_No.MaxLength = 10;
            this.tb_Alternate_Mobile_No.Name = "tb_Alternate_Mobile_No";
            this.tb_Alternate_Mobile_No.Size = new System.Drawing.Size(329, 33);
            this.tb_Alternate_Mobile_No.TabIndex = 4;
            this.tb_Alternate_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // gb_Personal_Details
            // 
            this.gb_Personal_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Personal_Details.Controls.Add(this.dtp_Joining_Date);
            this.gb_Personal_Details.Controls.Add(this.tb_PAN_No);
            this.gb_Personal_Details.Controls.Add(this.lbl_PAN_No);
            this.gb_Personal_Details.Controls.Add(this.tb_Email_ID);
            this.gb_Personal_Details.Controls.Add(this.tb_Aadhar_No);
            this.gb_Personal_Details.Controls.Add(this.lbl_Email_ID);
            this.gb_Personal_Details.Controls.Add(this.tb_Alternate_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.tb_Trader_Name);
            this.gb_Personal_Details.Controls.Add(this.lbl_Date);
            this.gb_Personal_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.lbl_Alternate_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.lbl_Trader_Name);
            this.gb_Personal_Details.Controls.Add(this.lbl_Aadhaar_No);
            this.gb_Personal_Details.Controls.Add(this.lbl_Trader_ID);
            this.gb_Personal_Details.Controls.Add(this.tb_Trader_ID);
            this.gb_Personal_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Personal_Details.ForeColor = System.Drawing.Color.DarkBlue;
            this.gb_Personal_Details.Location = new System.Drawing.Point(13, 30);
            this.gb_Personal_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Personal_Details.Name = "gb_Personal_Details";
            this.gb_Personal_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Personal_Details.Size = new System.Drawing.Size(1315, 298);
            this.gb_Personal_Details.TabIndex = 26;
            this.gb_Personal_Details.TabStop = false;
            this.gb_Personal_Details.Text = "Personal Details";
            // 
            // dtp_Joining_Date
            // 
            this.dtp_Joining_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.dtp_Joining_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Joining_Date.Location = new System.Drawing.Point(916, 52);
            this.dtp_Joining_Date.Name = "dtp_Joining_Date";
            this.dtp_Joining_Date.Size = new System.Drawing.Size(226, 33);
            this.dtp_Joining_Date.TabIndex = 13;
            // 
            // tb_PAN_No
            // 
            this.tb_PAN_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PAN_No.Location = new System.Drawing.Point(916, 226);
            this.tb_PAN_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PAN_No.MaxLength = 10;
            this.tb_PAN_No.Name = "tb_PAN_No";
            this.tb_PAN_No.Size = new System.Drawing.Size(355, 33);
            this.tb_PAN_No.TabIndex = 8;
            this.tb_PAN_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AN);
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAN_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_PAN_No.Location = new System.Drawing.Point(743, 223);
            this.lbl_PAN_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(97, 25);
            this.lbl_PAN_No.TabIndex = 12;
            this.lbl_PAN_No.Text = "PAN No";
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_ID.ForeColor = System.Drawing.Color.Green;
            this.lbl_Email_ID.Location = new System.Drawing.Point(743, 161);
            this.lbl_Email_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(108, 25);
            this.lbl_Email_ID.TabIndex = 10;
            this.lbl_Email_ID.Text = "Email ID";
            // 
            // tb_Trader_Name
            // 
            this.tb_Trader_Name.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Trader_Name.Location = new System.Drawing.Point(315, 110);
            this.tb_Trader_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Trader_Name.MaxLength = 40;
            this.tb_Trader_Name.Name = "tb_Trader_Name";
            this.tb_Trader_Name.Size = new System.Drawing.Size(329, 33);
            this.tb_Trader_Name.TabIndex = 2;
            this.tb_Trader_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OT);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Green;
            this.lbl_Date.Location = new System.Drawing.Point(743, 54);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(57, 25);
            this.lbl_Date.TabIndex = 5;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(315, 164);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(329, 33);
            this.tb_Mobile_No.TabIndex = 3;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Alternate_Mobile_No
            // 
            this.lbl_Alternate_Mobile_No.AutoSize = true;
            this.lbl_Alternate_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternate_Mobile_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Alternate_Mobile_No.Location = new System.Drawing.Point(57, 215);
            this.lbl_Alternate_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Alternate_Mobile_No.Name = "lbl_Alternate_Mobile_No";
            this.lbl_Alternate_Mobile_No.Size = new System.Drawing.Size(215, 25);
            this.lbl_Alternate_Mobile_No.TabIndex = 7;
            this.lbl_Alternate_Mobile_No.Text = "Alternate Mobile No";
            // 
            // lbl_Trader_Name
            // 
            this.lbl_Trader_Name.AutoSize = true;
            this.lbl_Trader_Name.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Trader_Name.ForeColor = System.Drawing.Color.Green;
            this.lbl_Trader_Name.Location = new System.Drawing.Point(57, 108);
            this.lbl_Trader_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Trader_Name.Name = "lbl_Trader_Name";
            this.lbl_Trader_Name.Size = new System.Drawing.Size(141, 25);
            this.lbl_Trader_Name.TabIndex = 2;
            this.lbl_Trader_Name.Text = "Trader Name";
            // 
            // lbl_Aadhaar_No
            // 
            this.lbl_Aadhaar_No.AutoSize = true;
            this.lbl_Aadhaar_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhaar_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Aadhaar_No.Location = new System.Drawing.Point(743, 107);
            this.lbl_Aadhaar_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Aadhaar_No.Name = "lbl_Aadhaar_No";
            this.lbl_Aadhaar_No.Size = new System.Drawing.Size(131, 25);
            this.lbl_Aadhaar_No.TabIndex = 8;
            this.lbl_Aadhaar_No.Text = "Aadhaar No";
            // 
            // lbl_Trader_ID
            // 
            this.lbl_Trader_ID.AutoSize = true;
            this.lbl_Trader_ID.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Trader_ID.ForeColor = System.Drawing.Color.Green;
            this.lbl_Trader_ID.Location = new System.Drawing.Point(57, 50);
            this.lbl_Trader_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Trader_ID.Name = "lbl_Trader_ID";
            this.lbl_Trader_ID.Size = new System.Drawing.Size(112, 25);
            this.lbl_Trader_ID.TabIndex = 1;
            this.lbl_Trader_ID.Text = "Trader ID";
            // 
            // tb_Trader_ID
            // 
            this.tb_Trader_ID.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Trader_ID.Location = new System.Drawing.Point(315, 49);
            this.tb_Trader_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Trader_ID.MaxLength = 4;
            this.tb_Trader_ID.Name = "tb_Trader_ID";
            this.tb_Trader_ID.Size = new System.Drawing.Size(329, 33);
            this.tb_Trader_ID.TabIndex = 1;
            this.tb_Trader_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(61, 161);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(116, 25);
            this.lbl_Mobile_No.TabIndex = 3;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // frm_Add_Trader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Bank_Details);
            this.Controls.Add(this.gb_Personal_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Add_Trader";
            this.Text = "ADD TRADER";
            this.Load += new System.EventHandler(this.frm_Add_Trader_Load);
            this.gb_Bank_Details.ResumeLayout(false);
            this.gb_Bank_Details.PerformLayout();
            this.gb_Personal_Details.ResumeLayout(false);
            this.gb_Personal_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Account_No;
        private System.Windows.Forms.Label lbl_Account_No;
        private System.Windows.Forms.Label lbl_Bank_Detail;
        private System.Windows.Forms.TextBox tb_Bank_Detail;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox gb_Bank_Details;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.TextBox tb_Alternate_Mobile_No;
        private System.Windows.Forms.GroupBox gb_Personal_Details;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.TextBox tb_Trader_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Alternate_Mobile_No;
        private System.Windows.Forms.Label lbl_Trader_Name;
        private System.Windows.Forms.Label lbl_Aadhaar_No;
        private System.Windows.Forms.Label lbl_Trader_ID;
        private System.Windows.Forms.TextBox tb_Trader_ID;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_PAN_No;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.DateTimePicker dtp_Joining_Date;
    }
}