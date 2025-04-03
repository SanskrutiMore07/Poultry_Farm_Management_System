
namespace Poultry_Farm_Manager_App.Lot_Entry
{
    partial class frm_New_Lot_Entry
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
            this.gb_New_Lot_Entry = new System.Windows.Forms.GroupBox();
            this.dtp_Hach_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Supplier = new System.Windows.Forms.TextBox();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Lot_Number = new System.Windows.Forms.TextBox();
            this.lbl_Hach_Date = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Lot_Number = new System.Windows.Forms.Label();
            this.gb_Chicks_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Kg = new System.Windows.Forms.Label();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.tb_Chicks_Body_Weight = new System.Windows.Forms.TextBox();
            this.tb_No_Of_Chicks_Placed = new System.Windows.Forms.TextBox();
            this.tb_Chicks_Price = new System.Windows.Forms.TextBox();
            this.lbl_Chicks_Price = new System.Windows.Forms.Label();
            this.lbl_No_Of_Chicks_Placed = new System.Windows.Forms.Label();
            this.lbl_Chicks_Body_Weight = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_New_Lot_Entry.SuspendLayout();
            this.gb_Chicks_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_New_Lot_Entry
            // 
            this.gb_New_Lot_Entry.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_New_Lot_Entry.Controls.Add(this.dtp_Hach_Date);
            this.gb_New_Lot_Entry.Controls.Add(this.tb_Supplier);
            this.gb_New_Lot_Entry.Controls.Add(this.lbl_Supplier);
            this.gb_New_Lot_Entry.Controls.Add(this.tb_Mobile_No);
            this.gb_New_Lot_Entry.Controls.Add(this.tb_Lot_Number);
            this.gb_New_Lot_Entry.Controls.Add(this.lbl_Hach_Date);
            this.gb_New_Lot_Entry.Controls.Add(this.lbl_Mobile_No);
            this.gb_New_Lot_Entry.Controls.Add(this.lbl_Lot_Number);
            this.gb_New_Lot_Entry.ForeColor = System.Drawing.Color.Black;
            this.gb_New_Lot_Entry.Location = new System.Drawing.Point(31, 38);
            this.gb_New_Lot_Entry.Margin = new System.Windows.Forms.Padding(4);
            this.gb_New_Lot_Entry.Name = "gb_New_Lot_Entry";
            this.gb_New_Lot_Entry.Padding = new System.Windows.Forms.Padding(4);
            this.gb_New_Lot_Entry.Size = new System.Drawing.Size(1276, 191);
            this.gb_New_Lot_Entry.TabIndex = 11;
            this.gb_New_Lot_Entry.TabStop = false;
            this.gb_New_Lot_Entry.Text = "New Lot Entry";
            // 
            // dtp_Hach_Date
            // 
            this.dtp_Hach_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.dtp_Hach_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Hach_Date.Location = new System.Drawing.Point(917, 43);
            this.dtp_Hach_Date.Name = "dtp_Hach_Date";
            this.dtp_Hach_Date.Size = new System.Drawing.Size(227, 33);
            this.dtp_Hach_Date.TabIndex = 2;
            // 
            // tb_Supplier
            // 
            this.tb_Supplier.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.tb_Supplier.Location = new System.Drawing.Point(315, 105);
            this.tb_Supplier.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Supplier.MaxLength = 50;
            this.tb_Supplier.Name = "tb_Supplier";
            this.tb_Supplier.Size = new System.Drawing.Size(317, 33);
            this.tb_Supplier.TabIndex = 3;
            this.tb_Supplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OT);
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.ForeColor = System.Drawing.Color.Green;
            this.lbl_Supplier.Location = new System.Drawing.Point(44, 98);
            this.lbl_Supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(111, 30);
            this.lbl_Supplier.TabIndex = 12;
            this.lbl_Supplier.Text = "Supplier";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(917, 105);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(324, 33);
            this.tb_Mobile_No.TabIndex = 4;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // tb_Lot_Number
            // 
            this.tb_Lot_Number.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lot_Number.Location = new System.Drawing.Point(315, 43);
            this.tb_Lot_Number.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Lot_Number.MaxLength = 15;
            this.tb_Lot_Number.Name = "tb_Lot_Number";
            this.tb_Lot_Number.Size = new System.Drawing.Size(317, 33);
            this.tb_Lot_Number.TabIndex = 1;
            this.tb_Lot_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Hach_Date
            // 
            this.lbl_Hach_Date.AutoSize = true;
            this.lbl_Hach_Date.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hach_Date.ForeColor = System.Drawing.Color.Green;
            this.lbl_Hach_Date.Location = new System.Drawing.Point(741, 43);
            this.lbl_Hach_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Hach_Date.Name = "lbl_Hach_Date";
            this.lbl_Hach_Date.Size = new System.Drawing.Size(136, 30);
            this.lbl_Hach_Date.TabIndex = 8;
            this.lbl_Hach_Date.Text = "Hach Date";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(741, 108);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(131, 30);
            this.lbl_Mobile_No.TabIndex = 7;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Lot_Number
            // 
            this.lbl_Lot_Number.AutoSize = true;
            this.lbl_Lot_Number.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lot_Number.ForeColor = System.Drawing.Color.Green;
            this.lbl_Lot_Number.Location = new System.Drawing.Point(44, 43);
            this.lbl_Lot_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lot_Number.Name = "lbl_Lot_Number";
            this.lbl_Lot_Number.Size = new System.Drawing.Size(151, 30);
            this.lbl_Lot_Number.TabIndex = 3;
            this.lbl_Lot_Number.Text = "Lot Number";
            // 
            // gb_Chicks_Details
            // 
            this.gb_Chicks_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Chicks_Details.Controls.Add(this.lbl_Kg);
            this.gb_Chicks_Details.Controls.Add(this.tb_Total_Bill);
            this.gb_Chicks_Details.Controls.Add(this.lbl_Total_Bill);
            this.gb_Chicks_Details.Controls.Add(this.tb_Chicks_Body_Weight);
            this.gb_Chicks_Details.Controls.Add(this.tb_No_Of_Chicks_Placed);
            this.gb_Chicks_Details.Controls.Add(this.tb_Chicks_Price);
            this.gb_Chicks_Details.Controls.Add(this.lbl_Chicks_Price);
            this.gb_Chicks_Details.Controls.Add(this.lbl_No_Of_Chicks_Placed);
            this.gb_Chicks_Details.Controls.Add(this.lbl_Chicks_Body_Weight);
            this.gb_Chicks_Details.ForeColor = System.Drawing.Color.Black;
            this.gb_Chicks_Details.Location = new System.Drawing.Point(32, 261);
            this.gb_Chicks_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Chicks_Details.Name = "gb_Chicks_Details";
            this.gb_Chicks_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Chicks_Details.Size = new System.Drawing.Size(1276, 196);
            this.gb_Chicks_Details.TabIndex = 19;
            this.gb_Chicks_Details.TabStop = false;
            this.gb_Chicks_Details.Text = "Chick Details";
            // 
            // lbl_Kg
            // 
            this.lbl_Kg.AutoSize = true;
            this.lbl_Kg.BackColor = System.Drawing.Color.Silver;
            this.lbl_Kg.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kg.ForeColor = System.Drawing.Color.Black;
            this.lbl_Kg.Location = new System.Drawing.Point(473, 126);
            this.lbl_Kg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Kg.Name = "lbl_Kg";
            this.lbl_Kg.Size = new System.Drawing.Size(66, 25);
            this.lbl_Kg.TabIndex = 10;
            this.lbl_Kg.Text = "Gram";
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(923, 127);
            this.tb_Total_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Total_Bill.MaxLength = 7;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(317, 30);
            this.tb_Total_Bill.TabIndex = 8;
            this.tb_Total_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.Green;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(679, 122);
            this.lbl_Total_Bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(112, 25);
            this.lbl_Total_Bill.TabIndex = 9;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // tb_Chicks_Body_Weight
            // 
            this.tb_Chicks_Body_Weight.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Chicks_Body_Weight.Location = new System.Drawing.Point(313, 122);
            this.tb_Chicks_Body_Weight.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Chicks_Body_Weight.MaxLength = 6;
            this.tb_Chicks_Body_Weight.Name = "tb_Chicks_Body_Weight";
            this.tb_Chicks_Body_Weight.Size = new System.Drawing.Size(152, 30);
            this.tb_Chicks_Body_Weight.TabIndex = 7;
            this.tb_Chicks_Body_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ONF);
            // 
            // tb_No_Of_Chicks_Placed
            // 
            this.tb_No_Of_Chicks_Placed.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_No_Of_Chicks_Placed.Location = new System.Drawing.Point(923, 50);
            this.tb_No_Of_Chicks_Placed.Margin = new System.Windows.Forms.Padding(4);
            this.tb_No_Of_Chicks_Placed.MaxLength = 5;
            this.tb_No_Of_Chicks_Placed.Name = "tb_No_Of_Chicks_Placed";
            this.tb_No_Of_Chicks_Placed.Size = new System.Drawing.Size(317, 30);
            this.tb_No_Of_Chicks_Placed.TabIndex = 6;
            this.tb_No_Of_Chicks_Placed.TextChanged += new System.EventHandler(this.tb_No_Of_Chicks_Placed_TextChanged);
            this.tb_No_Of_Chicks_Placed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // tb_Chicks_Price
            // 
            this.tb_Chicks_Price.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Chicks_Price.Location = new System.Drawing.Point(313, 57);
            this.tb_Chicks_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Chicks_Price.MaxLength = 6;
            this.tb_Chicks_Price.Name = "tb_Chicks_Price";
            this.tb_Chicks_Price.Size = new System.Drawing.Size(317, 30);
            this.tb_Chicks_Price.TabIndex = 5;
            this.tb_Chicks_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Chicks_Price
            // 
            this.lbl_Chicks_Price.AutoSize = true;
            this.lbl_Chicks_Price.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Chicks_Price.ForeColor = System.Drawing.Color.Green;
            this.lbl_Chicks_Price.Location = new System.Drawing.Point(28, 54);
            this.lbl_Chicks_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Chicks_Price.Name = "lbl_Chicks_Price";
            this.lbl_Chicks_Price.Size = new System.Drawing.Size(137, 25);
            this.lbl_Chicks_Price.TabIndex = 5;
            this.lbl_Chicks_Price.Text = "Chicks Price";
            // 
            // lbl_No_Of_Chicks_Placed
            // 
            this.lbl_No_Of_Chicks_Placed.AutoSize = true;
            this.lbl_No_Of_Chicks_Placed.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_No_Of_Chicks_Placed.ForeColor = System.Drawing.Color.Green;
            this.lbl_No_Of_Chicks_Placed.Location = new System.Drawing.Point(679, 55);
            this.lbl_No_Of_Chicks_Placed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_No_Of_Chicks_Placed.Name = "lbl_No_Of_Chicks_Placed";
            this.lbl_No_Of_Chicks_Placed.Size = new System.Drawing.Size(216, 25);
            this.lbl_No_Of_Chicks_Placed.TabIndex = 4;
            this.lbl_No_Of_Chicks_Placed.Text = "No Of Chicks Placed";
            // 
            // lbl_Chicks_Body_Weight
            // 
            this.lbl_Chicks_Body_Weight.AutoSize = true;
            this.lbl_Chicks_Body_Weight.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Chicks_Body_Weight.ForeColor = System.Drawing.Color.Green;
            this.lbl_Chicks_Body_Weight.Location = new System.Drawing.Point(28, 122);
            this.lbl_Chicks_Body_Weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Chicks_Body_Weight.Name = "lbl_Chicks_Body_Weight";
            this.lbl_Chicks_Body_Weight.Size = new System.Drawing.Size(213, 25);
            this.lbl_Chicks_Body_Weight.TabIndex = 3;
            this.lbl_Chicks_Body_Weight.Text = "Chicks Body Weight";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Navy;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(368, 528);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(245, 75);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(702, 528);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(245, 75);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_New_Lot_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Chicks_Details);
            this.Controls.Add(this.gb_New_Lot_Entry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_New_Lot_Entry";
            this.Text = "New Lot Entry";
            this.Load += new System.EventHandler(this.frm_New_Lot_Entry_Load);
            this.gb_New_Lot_Entry.ResumeLayout(false);
            this.gb_New_Lot_Entry.PerformLayout();
            this.gb_Chicks_Details.ResumeLayout(false);
            this.gb_Chicks_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_New_Lot_Entry;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Lot_Number;
        private System.Windows.Forms.Label lbl_Hach_Date;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Lot_Number;
        private System.Windows.Forms.TextBox tb_Supplier;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.GroupBox gb_Chicks_Details;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.TextBox tb_Chicks_Body_Weight;
        private System.Windows.Forms.TextBox tb_No_Of_Chicks_Placed;
        private System.Windows.Forms.TextBox tb_Chicks_Price;
        private System.Windows.Forms.Label lbl_Chicks_Price;
        private System.Windows.Forms.Label lbl_No_Of_Chicks_Placed;
        private System.Windows.Forms.Label lbl_Chicks_Body_Weight;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Kg;
        private System.Windows.Forms.DateTimePicker dtp_Hach_Date;
    }
}