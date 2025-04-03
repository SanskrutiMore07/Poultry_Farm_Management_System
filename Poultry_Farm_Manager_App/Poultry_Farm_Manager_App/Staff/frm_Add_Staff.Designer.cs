
namespace Poultry_Farm_Manager_App.Staff
{
    partial class frm_Add_Staff
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
            this.gb_Personal_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Joining_Date = new System.Windows.Forms.DateTimePicker();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.tb_Staff_Name = new System.Windows.Forms.TextBox();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.lbl_Staff_Name = new System.Windows.Forms.Label();
            this.lbl_Staff_ID = new System.Windows.Forms.Label();
            this.tb_Staff_ID = new System.Windows.Forms.TextBox();
            this.gb_More_Details = new System.Windows.Forms.GroupBox();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.tb_Alternate_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Aadhaar_No = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Alternate_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.gb_Bank_Details = new System.Windows.Forms.GroupBox();
            this.tb_Account_No = new System.Windows.Forms.TextBox();
            this.lbl_Account_No = new System.Windows.Forms.Label();
            this.lbl_Bank_Detail = new System.Windows.Forms.Label();
            this.tb_Bank_Detail = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Personal_Details.SuspendLayout();
            this.gb_More_Details.SuspendLayout();
            this.gb_Bank_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Personal_Details
            // 
            this.gb_Personal_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Personal_Details.Controls.Add(this.dtp_Joining_Date);
            this.gb_Personal_Details.Controls.Add(this.cmb_Designation);
            this.gb_Personal_Details.Controls.Add(this.tb_Staff_Name);
            this.gb_Personal_Details.Controls.Add(this.lbl_Joining_Date);
            this.gb_Personal_Details.Controls.Add(this.lbl_Designation);
            this.gb_Personal_Details.Controls.Add(this.lbl_Staff_Name);
            this.gb_Personal_Details.Controls.Add(this.lbl_Staff_ID);
            this.gb_Personal_Details.Controls.Add(this.tb_Staff_ID);
            this.gb_Personal_Details.ForeColor = System.Drawing.Color.DarkBlue;
            this.gb_Personal_Details.Location = new System.Drawing.Point(16, 15);
            this.gb_Personal_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Personal_Details.Name = "gb_Personal_Details";
            this.gb_Personal_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Personal_Details.Size = new System.Drawing.Size(1307, 148);
            this.gb_Personal_Details.TabIndex = 0;
            this.gb_Personal_Details.TabStop = false;
            this.gb_Personal_Details.Text = "Personal Details";
            // 
            // dtp_Joining_Date
            // 
            this.dtp_Joining_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.dtp_Joining_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Joining_Date.Location = new System.Drawing.Point(917, 41);
            this.dtp_Joining_Date.Name = "dtp_Joining_Date";
            this.dtp_Joining_Date.Size = new System.Drawing.Size(200, 33);
            this.dtp_Joining_Date.TabIndex = 2;
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Worker"});
            this.cmb_Designation.Location = new System.Drawing.Point(917, 101);
            this.cmb_Designation.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(264, 32);
            this.cmb_Designation.TabIndex = 4;
            // 
            // tb_Staff_Name
            // 
            this.tb_Staff_Name.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_Name.Location = new System.Drawing.Point(315, 101);
            this.tb_Staff_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Staff_Name.MaxLength = 40;
            this.tb_Staff_Name.Name = "tb_Staff_Name";
            this.tb_Staff_Name.Size = new System.Drawing.Size(329, 33);
            this.tb_Staff_Name.TabIndex = 3;
            this.tb_Staff_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OT);
            // 
            // lbl_Joining_Date
            // 
            this.lbl_Joining_Date.AutoSize = true;
            this.lbl_Joining_Date.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joining_Date.ForeColor = System.Drawing.Color.Green;
            this.lbl_Joining_Date.Location = new System.Drawing.Point(743, 39);
            this.lbl_Joining_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(138, 25);
            this.lbl_Joining_Date.TabIndex = 5;
            this.lbl_Joining_Date.Text = "Joining Date";
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.ForeColor = System.Drawing.Color.Green;
            this.lbl_Designation.Location = new System.Drawing.Point(743, 101);
            this.lbl_Designation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(128, 25);
            this.lbl_Designation.TabIndex = 4;
            this.lbl_Designation.Text = "Designation";
            // 
            // lbl_Staff_Name
            // 
            this.lbl_Staff_Name.AutoSize = true;
            this.lbl_Staff_Name.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Name.ForeColor = System.Drawing.Color.Green;
            this.lbl_Staff_Name.Location = new System.Drawing.Point(44, 100);
            this.lbl_Staff_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff_Name.Name = "lbl_Staff_Name";
            this.lbl_Staff_Name.Size = new System.Drawing.Size(122, 25);
            this.lbl_Staff_Name.TabIndex = 2;
            this.lbl_Staff_Name.Text = "Staff Name";
            // 
            // lbl_Staff_ID
            // 
            this.lbl_Staff_ID.AutoSize = true;
            this.lbl_Staff_ID.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_ID.ForeColor = System.Drawing.Color.Green;
            this.lbl_Staff_ID.Location = new System.Drawing.Point(44, 41);
            this.lbl_Staff_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff_ID.Name = "lbl_Staff_ID";
            this.lbl_Staff_ID.Size = new System.Drawing.Size(93, 25);
            this.lbl_Staff_ID.TabIndex = 1;
            this.lbl_Staff_ID.Text = "Staff ID";
            // 
            // tb_Staff_ID
            // 
            this.tb_Staff_ID.Enabled = false;
            this.tb_Staff_ID.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_ID.Location = new System.Drawing.Point(315, 39);
            this.tb_Staff_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Staff_ID.MaxLength = 4;
            this.tb_Staff_ID.Name = "tb_Staff_ID";
            this.tb_Staff_ID.Size = new System.Drawing.Size(329, 33);
            this.tb_Staff_ID.TabIndex = 1;
            this.tb_Staff_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // gb_More_Details
            // 
            this.gb_More_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_More_Details.Controls.Add(this.tb_Note);
            this.gb_More_Details.Controls.Add(this.tb_Aadhar_No);
            this.gb_More_Details.Controls.Add(this.tb_Salary);
            this.gb_More_Details.Controls.Add(this.tb_Alternate_Mobile_No);
            this.gb_More_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_More_Details.Controls.Add(this.lbl_Note);
            this.gb_More_Details.Controls.Add(this.lbl_Aadhaar_No);
            this.gb_More_Details.Controls.Add(this.lbl_Salary);
            this.gb_More_Details.Controls.Add(this.lbl_Alternate_Mobile_No);
            this.gb_More_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_More_Details.ForeColor = System.Drawing.Color.DarkBlue;
            this.gb_More_Details.Location = new System.Drawing.Point(16, 170);
            this.gb_More_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_More_Details.Name = "gb_More_Details";
            this.gb_More_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_More_Details.Size = new System.Drawing.Size(1307, 214);
            this.gb_More_Details.TabIndex = 1;
            this.gb_More_Details.TabStop = false;
            this.gb_More_Details.Text = "More Details";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.tb_Note.Location = new System.Drawing.Point(916, 110);
            this.tb_Note.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Note.MaxLength = 100;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(355, 85);
            this.tb_Note.TabIndex = 9;
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.tb_Aadhar_No.Location = new System.Drawing.Point(917, 43);
            this.tb_Aadhar_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Aadhar_No.MaxLength = 12;
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(355, 33);
            this.tb_Aadhar_No.TabIndex = 8;
            this.tb_Aadhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(315, 165);
            this.tb_Salary.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Salary.MaxLength = 5;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(329, 33);
            this.tb_Salary.TabIndex = 7;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // tb_Alternate_Mobile_No
            // 
            this.tb_Alternate_Mobile_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alternate_Mobile_No.Location = new System.Drawing.Point(315, 105);
            this.tb_Alternate_Mobile_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Alternate_Mobile_No.MaxLength = 10;
            this.tb_Alternate_Mobile_No.Name = "tb_Alternate_Mobile_No";
            this.tb_Alternate_Mobile_No.Size = new System.Drawing.Size(329, 33);
            this.tb_Alternate_Mobile_No.TabIndex = 6;
            this.tb_Alternate_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(315, 43);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(329, 33);
            this.tb_Mobile_No.TabIndex = 5;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Green;
            this.lbl_Note.Location = new System.Drawing.Point(745, 110);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(57, 25);
            this.lbl_Note.TabIndex = 9;
            this.lbl_Note.Text = "Note";
            // 
            // lbl_Aadhaar_No
            // 
            this.lbl_Aadhaar_No.AutoSize = true;
            this.lbl_Aadhaar_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhaar_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Aadhaar_No.Location = new System.Drawing.Point(741, 43);
            this.lbl_Aadhaar_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Aadhaar_No.Name = "lbl_Aadhaar_No";
            this.lbl_Aadhaar_No.Size = new System.Drawing.Size(131, 25);
            this.lbl_Aadhaar_No.TabIndex = 8;
            this.lbl_Aadhaar_No.Text = "Aadhaar No";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.Green;
            this.lbl_Salary.Location = new System.Drawing.Point(44, 160);
            this.lbl_Salary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(75, 25);
            this.lbl_Salary.TabIndex = 6;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_Alternate_Mobile_No
            // 
            this.lbl_Alternate_Mobile_No.AutoSize = true;
            this.lbl_Alternate_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternate_Mobile_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Alternate_Mobile_No.Location = new System.Drawing.Point(44, 100);
            this.lbl_Alternate_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Alternate_Mobile_No.Name = "lbl_Alternate_Mobile_No";
            this.lbl_Alternate_Mobile_No.Size = new System.Drawing.Size(215, 25);
            this.lbl_Alternate_Mobile_No.TabIndex = 7;
            this.lbl_Alternate_Mobile_No.Text = "Alternate Mobile No";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(44, 43);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(116, 25);
            this.lbl_Mobile_No.TabIndex = 3;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // gb_Bank_Details
            // 
            this.gb_Bank_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Bank_Details.Controls.Add(this.tb_Account_No);
            this.gb_Bank_Details.Controls.Add(this.lbl_Account_No);
            this.gb_Bank_Details.Controls.Add(this.lbl_Bank_Detail);
            this.gb_Bank_Details.Controls.Add(this.tb_Bank_Detail);
            this.gb_Bank_Details.ForeColor = System.Drawing.Color.DarkBlue;
            this.gb_Bank_Details.Location = new System.Drawing.Point(16, 391);
            this.gb_Bank_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Bank_Details.Name = "gb_Bank_Details";
            this.gb_Bank_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Bank_Details.Size = new System.Drawing.Size(1307, 146);
            this.gb_Bank_Details.TabIndex = 8;
            this.gb_Bank_Details.TabStop = false;
            this.gb_Bank_Details.Text = "Bank Details";
            // 
            // tb_Account_No
            // 
            this.tb_Account_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_No.Location = new System.Drawing.Point(315, 95);
            this.tb_Account_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Account_No.MaxLength = 20;
            this.tb_Account_No.Name = "tb_Account_No";
            this.tb_Account_No.Size = new System.Drawing.Size(488, 33);
            this.tb_Account_No.TabIndex = 11;
            this.tb_Account_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Account_No
            // 
            this.lbl_Account_No.AutoSize = true;
            this.lbl_Account_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Account_No.Location = new System.Drawing.Point(44, 95);
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
            this.lbl_Bank_Detail.Location = new System.Drawing.Point(44, 39);
            this.lbl_Bank_Detail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bank_Detail.Name = "lbl_Bank_Detail";
            this.lbl_Bank_Detail.Size = new System.Drawing.Size(134, 25);
            this.lbl_Bank_Detail.TabIndex = 1;
            this.lbl_Bank_Detail.Text = "Bank Detail";
            // 
            // tb_Bank_Detail
            // 
            this.tb_Bank_Detail.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bank_Detail.Location = new System.Drawing.Point(315, 23);
            this.tb_Bank_Detail.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Bank_Detail.MaxLength = 100;
            this.tb_Bank_Detail.Multiline = true;
            this.tb_Bank_Detail.Name = "tb_Bank_Detail";
            this.tb_Bank_Detail.Size = new System.Drawing.Size(488, 63);
            this.tb_Bank_Detail.TabIndex = 10;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(840, 562);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(188, 64);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Navy;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(301, 562);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(188, 64);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Bank_Details);
            this.Controls.Add(this.gb_More_Details);
            this.Controls.Add(this.gb_Personal_Details);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Add_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD STAF";
            this.Load += new System.EventHandler(this.frm_Add_Staff_Load);
            this.gb_Personal_Details.ResumeLayout(false);
            this.gb_Personal_Details.PerformLayout();
            this.gb_More_Details.ResumeLayout(false);
            this.gb_More_Details.PerformLayout();
            this.gb_Bank_Details.ResumeLayout(false);
            this.gb_Bank_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Personal_Details;
        private System.Windows.Forms.Label lbl_Joining_Date;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.Label lbl_Staff_Name;
        private System.Windows.Forms.Label lbl_Staff_ID;
        private System.Windows.Forms.TextBox tb_Staff_ID;
        private System.Windows.Forms.GroupBox gb_More_Details;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Alternate_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Aadhaar_No;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.TextBox tb_Staff_Name;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.TextBox tb_Alternate_Mobile_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.GroupBox gb_Bank_Details;
        private System.Windows.Forms.TextBox tb_Account_No;
        private System.Windows.Forms.Label lbl_Account_No;
        private System.Windows.Forms.Label lbl_Bank_Detail;
        private System.Windows.Forms.TextBox tb_Bank_Detail;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_Joining_Date;
    }
}