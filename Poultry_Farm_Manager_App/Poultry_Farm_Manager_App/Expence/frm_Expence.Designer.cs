
namespace Poultry_Farm_Manager_App.Expence
{
    partial class frm_Expence
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
            this.gb_Expence_ID_And_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Expence_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Expence_Id = new System.Windows.Forms.TextBox();
            this.lbl_Expence_Date = new System.Windows.Forms.Label();
            this.lbl_Expence_Id = new System.Windows.Forms.Label();
            this.btn_Browse_Bill_Image = new System.Windows.Forms.Button();
            this.pb_Bill_Image = new System.Windows.Forms.PictureBox();
            this.tb_Paid_By = new System.Windows.Forms.TextBox();
            this.tb_Expence_Details = new System.Windows.Forms.TextBox();
            this.tb_Amount_Paid = new System.Windows.Forms.TextBox();
            this.lbl_Paid_By = new System.Windows.Forms.Label();
            this.lbl_Bill_Image = new System.Windows.Forms.Label();
            this.lbl_Amount_Paid = new System.Windows.Forms.Label();
            this.lbl_Expence_Details = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Expence_Details = new System.Windows.Forms.GroupBox();
            this.gb_Payment_Details = new System.Windows.Forms.GroupBox();
            this.gb_Expence_ID_And_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).BeginInit();
            this.gb_Expence_Details.SuspendLayout();
            this.gb_Payment_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Expence_ID_And_Details
            // 
            this.gb_Expence_ID_And_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Expence_ID_And_Details.Controls.Add(this.dtp_Expence_Date);
            this.gb_Expence_ID_And_Details.Controls.Add(this.tb_Expence_Id);
            this.gb_Expence_ID_And_Details.Controls.Add(this.lbl_Expence_Date);
            this.gb_Expence_ID_And_Details.Controls.Add(this.lbl_Expence_Id);
            this.gb_Expence_ID_And_Details.Location = new System.Drawing.Point(25, 15);
            this.gb_Expence_ID_And_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Expence_ID_And_Details.Name = "gb_Expence_ID_And_Details";
            this.gb_Expence_ID_And_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Expence_ID_And_Details.Size = new System.Drawing.Size(1287, 149);
            this.gb_Expence_ID_And_Details.TabIndex = 0;
            this.gb_Expence_ID_And_Details.TabStop = false;
            this.gb_Expence_ID_And_Details.Text = "Expence ID And Details";
            // 
            // dtp_Expence_Date
            // 
            this.dtp_Expence_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.dtp_Expence_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Expence_Date.Location = new System.Drawing.Point(928, 70);
            this.dtp_Expence_Date.Name = "dtp_Expence_Date";
            this.dtp_Expence_Date.Size = new System.Drawing.Size(213, 33);
            this.dtp_Expence_Date.TabIndex = 1;
            // 
            // tb_Expence_Id
            // 
            this.tb_Expence_Id.Enabled = false;
            this.tb_Expence_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expence_Id.Location = new System.Drawing.Point(296, 74);
            this.tb_Expence_Id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Expence_Id.Name = "tb_Expence_Id";
            this.tb_Expence_Id.Size = new System.Drawing.Size(303, 33);
            this.tb_Expence_Id.TabIndex = 1;
            this.tb_Expence_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Expence_Date
            // 
            this.lbl_Expence_Date.AutoSize = true;
            this.lbl_Expence_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Date.Location = new System.Drawing.Point(726, 72);
            this.lbl_Expence_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Expence_Date.Name = "lbl_Expence_Date";
            this.lbl_Expence_Date.Size = new System.Drawing.Size(163, 29);
            this.lbl_Expence_Date.TabIndex = 4;
            this.lbl_Expence_Date.Text = "Expence Date";
            // 
            // lbl_Expence_Id
            // 
            this.lbl_Expence_Id.AutoSize = true;
            this.lbl_Expence_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Id.Location = new System.Drawing.Point(54, 74);
            this.lbl_Expence_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Expence_Id.Name = "lbl_Expence_Id";
            this.lbl_Expence_Id.Size = new System.Drawing.Size(133, 29);
            this.lbl_Expence_Id.TabIndex = 0;
            this.lbl_Expence_Id.Text = "Expence Id";
            // 
            // btn_Browse_Bill_Image
            // 
            this.btn_Browse_Bill_Image.BackColor = System.Drawing.Color.Khaki;
            this.btn_Browse_Bill_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse_Bill_Image.Location = new System.Drawing.Point(991, 222);
            this.btn_Browse_Bill_Image.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Browse_Bill_Image.Name = "btn_Browse_Bill_Image";
            this.btn_Browse_Bill_Image.Size = new System.Drawing.Size(168, 47);
            this.btn_Browse_Bill_Image.TabIndex = 3;
            this.btn_Browse_Bill_Image.Text = "Browse Bill Image";
            this.btn_Browse_Bill_Image.UseVisualStyleBackColor = false;
            this.btn_Browse_Bill_Image.Click += new System.EventHandler(this.btn_Browse_Bill_Image_Click);
            // 
            // pb_Bill_Image
            // 
            this.pb_Bill_Image.BackColor = System.Drawing.Color.GhostWhite;
            this.pb_Bill_Image.Location = new System.Drawing.Point(872, 14);
            this.pb_Bill_Image.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Bill_Image.Name = "pb_Bill_Image";
            this.pb_Bill_Image.Size = new System.Drawing.Size(389, 200);
            this.pb_Bill_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Bill_Image.TabIndex = 11;
            this.pb_Bill_Image.TabStop = false;
            // 
            // tb_Paid_By
            // 
            this.tb_Paid_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid_By.Location = new System.Drawing.Point(885, 50);
            this.tb_Paid_By.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Paid_By.Name = "tb_Paid_By";
            this.tb_Paid_By.Size = new System.Drawing.Size(303, 33);
            this.tb_Paid_By.TabIndex = 5;
            this.tb_Paid_By.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OT);
            // 
            // tb_Expence_Details
            // 
            this.tb_Expence_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expence_Details.Location = new System.Drawing.Point(296, 70);
            this.tb_Expence_Details.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Expence_Details.Multiline = true;
            this.tb_Expence_Details.Name = "tb_Expence_Details";
            this.tb_Expence_Details.Size = new System.Drawing.Size(385, 144);
            this.tb_Expence_Details.TabIndex = 2;
            // 
            // tb_Amount_Paid
            // 
            this.tb_Amount_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount_Paid.Location = new System.Drawing.Point(259, 51);
            this.tb_Amount_Paid.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Amount_Paid.Name = "tb_Amount_Paid";
            this.tb_Amount_Paid.Size = new System.Drawing.Size(303, 33);
            this.tb_Amount_Paid.TabIndex = 4;
            this.tb_Amount_Paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Paid_By
            // 
            this.lbl_Paid_By.AutoSize = true;
            this.lbl_Paid_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_By.Location = new System.Drawing.Point(726, 54);
            this.lbl_Paid_By.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Paid_By.Name = "lbl_Paid_By";
            this.lbl_Paid_By.Size = new System.Drawing.Size(95, 29);
            this.lbl_Paid_By.TabIndex = 5;
            this.lbl_Paid_By.Text = "Paid By";
            // 
            // lbl_Bill_Image
            // 
            this.lbl_Bill_Image.AutoSize = true;
            this.lbl_Bill_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Image.Location = new System.Drawing.Point(726, 119);
            this.lbl_Bill_Image.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bill_Image.Name = "lbl_Bill_Image";
            this.lbl_Bill_Image.Size = new System.Drawing.Size(120, 29);
            this.lbl_Bill_Image.TabIndex = 3;
            this.lbl_Bill_Image.Text = "Bill Image";
            // 
            // lbl_Amount_Paid
            // 
            this.lbl_Amount_Paid.AutoSize = true;
            this.lbl_Amount_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount_Paid.Location = new System.Drawing.Point(54, 55);
            this.lbl_Amount_Paid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Amount_Paid.Name = "lbl_Amount_Paid";
            this.lbl_Amount_Paid.Size = new System.Drawing.Size(149, 29);
            this.lbl_Amount_Paid.TabIndex = 2;
            this.lbl_Amount_Paid.Text = "Amount Paid";
            // 
            // lbl_Expence_Details
            // 
            this.lbl_Expence_Details.AutoSize = true;
            this.lbl_Expence_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_Details.Location = new System.Drawing.Point(54, 136);
            this.lbl_Expence_Details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Expence_Details.Name = "lbl_Expence_Details";
            this.lbl_Expence_Details.Size = new System.Drawing.Size(187, 29);
            this.lbl_Expence_Details.TabIndex = 1;
            this.lbl_Expence_Details.Text = "Expence Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(868, 572);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(200, 66);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Navy;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(462, 572);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(200, 66);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb_Expence_Details
            // 
            this.gb_Expence_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Expence_Details.Controls.Add(this.pb_Bill_Image);
            this.gb_Expence_Details.Controls.Add(this.lbl_Expence_Details);
            this.gb_Expence_Details.Controls.Add(this.tb_Expence_Details);
            this.gb_Expence_Details.Controls.Add(this.btn_Browse_Bill_Image);
            this.gb_Expence_Details.Controls.Add(this.lbl_Bill_Image);
            this.gb_Expence_Details.Location = new System.Drawing.Point(25, 172);
            this.gb_Expence_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Expence_Details.Name = "gb_Expence_Details";
            this.gb_Expence_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Expence_Details.Size = new System.Drawing.Size(1287, 277);
            this.gb_Expence_Details.TabIndex = 14;
            this.gb_Expence_Details.TabStop = false;
            this.gb_Expence_Details.Text = "Expence Details";
            // 
            // gb_Payment_Details
            // 
            this.gb_Payment_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Payment_Details.Controls.Add(this.lbl_Amount_Paid);
            this.gb_Payment_Details.Controls.Add(this.tb_Amount_Paid);
            this.gb_Payment_Details.Controls.Add(this.lbl_Paid_By);
            this.gb_Payment_Details.Controls.Add(this.tb_Paid_By);
            this.gb_Payment_Details.Location = new System.Drawing.Point(25, 455);
            this.gb_Payment_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Payment_Details.Name = "gb_Payment_Details";
            this.gb_Payment_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Payment_Details.Size = new System.Drawing.Size(1287, 111);
            this.gb_Payment_Details.TabIndex = 14;
            this.gb_Payment_Details.TabStop = false;
            this.gb_Payment_Details.Text = "Payment_Details";
            // 
            // frm_Expence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.Controls.Add(this.gb_Payment_Details);
            this.Controls.Add(this.gb_Expence_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Expence_ID_And_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Expence";
            this.Text = "EXPENCE";
            this.Load += new System.EventHandler(this.frm_Expence_Load);
            this.gb_Expence_ID_And_Details.ResumeLayout(false);
            this.gb_Expence_ID_And_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).EndInit();
            this.gb_Expence_Details.ResumeLayout(false);
            this.gb_Expence_Details.PerformLayout();
            this.gb_Payment_Details.ResumeLayout(false);
            this.gb_Payment_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Expence_ID_And_Details;
        private System.Windows.Forms.TextBox tb_Paid_By;
        private System.Windows.Forms.TextBox tb_Expence_Details;
        private System.Windows.Forms.TextBox tb_Amount_Paid;
        private System.Windows.Forms.TextBox tb_Expence_Id;
        private System.Windows.Forms.Label lbl_Paid_By;
        private System.Windows.Forms.Label lbl_Expence_Date;
        private System.Windows.Forms.Label lbl_Bill_Image;
        private System.Windows.Forms.Label lbl_Amount_Paid;
        private System.Windows.Forms.Label lbl_Expence_Details;
        private System.Windows.Forms.Label lbl_Expence_Id;
        private System.Windows.Forms.Button btn_Browse_Bill_Image;
        private System.Windows.Forms.PictureBox pb_Bill_Image;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_Expence_Date;
        private System.Windows.Forms.GroupBox gb_Expence_Details;
        private System.Windows.Forms.GroupBox gb_Payment_Details;
    }
}