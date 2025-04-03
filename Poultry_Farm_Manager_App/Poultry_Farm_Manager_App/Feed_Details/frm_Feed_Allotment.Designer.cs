
namespace Poultry_Farm_Manager_App.Feed_Details
{
    partial class frm_Feed_Allotment
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
            this.lbl_Feed_Allotment_ID = new System.Windows.Forms.Label();
            this.lbl_Allotment_Date = new System.Windows.Forms.Label();
            this.tb_Feed_Allotment_ID = new System.Windows.Forms.TextBox();
            this.gb_Feed_Allotment = new System.Windows.Forms.GroupBox();
            this.tb_Lot_Number = new System.Windows.Forms.TextBox();
            this.lbl_Lot_Number = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Staff = new System.Windows.Forms.ComboBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Feed = new System.Windows.Forms.Label();
            this.cmb_Feed = new System.Windows.Forms.ComboBox();
            this.lbl_Bag_KG = new System.Windows.Forms.Label();
            this.cmb_Bag_KG = new System.Windows.Forms.ComboBox();
            this.lbl_Bag_Quantity = new System.Windows.Forms.Label();
            this.lbl_Staff = new System.Windows.Forms.Label();
            this.tb_Bag_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Feed_Allotment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Feed_Allotment_ID
            // 
            this.lbl_Feed_Allotment_ID.AutoSize = true;
            this.lbl_Feed_Allotment_ID.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feed_Allotment_ID.ForeColor = System.Drawing.Color.Green;
            this.lbl_Feed_Allotment_ID.Location = new System.Drawing.Point(61, 53);
            this.lbl_Feed_Allotment_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Feed_Allotment_ID.Name = "lbl_Feed_Allotment_ID";
            this.lbl_Feed_Allotment_ID.Size = new System.Drawing.Size(253, 32);
            this.lbl_Feed_Allotment_ID.TabIndex = 74;
            this.lbl_Feed_Allotment_ID.Text = "Feed Allotment ID";
            // 
            // lbl_Allotment_Date
            // 
            this.lbl_Allotment_Date.AutoSize = true;
            this.lbl_Allotment_Date.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Allotment_Date.ForeColor = System.Drawing.Color.Green;
            this.lbl_Allotment_Date.Location = new System.Drawing.Point(644, 54);
            this.lbl_Allotment_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Allotment_Date.Name = "lbl_Allotment_Date";
            this.lbl_Allotment_Date.Size = new System.Drawing.Size(210, 32);
            this.lbl_Allotment_Date.TabIndex = 78;
            this.lbl_Allotment_Date.Text = "Allotment Date";
            // 
            // tb_Feed_Allotment_ID
            // 
            this.tb_Feed_Allotment_ID.Enabled = false;
            this.tb_Feed_Allotment_ID.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Feed_Allotment_ID.Location = new System.Drawing.Point(338, 54);
            this.tb_Feed_Allotment_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Feed_Allotment_ID.MaxLength = 7;
            this.tb_Feed_Allotment_ID.Name = "tb_Feed_Allotment_ID";
            this.tb_Feed_Allotment_ID.Size = new System.Drawing.Size(243, 33);
            this.tb_Feed_Allotment_ID.TabIndex = 1;
            this.tb_Feed_Allotment_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // gb_Feed_Allotment
            // 
            this.gb_Feed_Allotment.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Feed_Allotment.Controls.Add(this.tb_Lot_Number);
            this.gb_Feed_Allotment.Controls.Add(this.lbl_Lot_Number);
            this.gb_Feed_Allotment.Controls.Add(this.dtp_Date);
            this.gb_Feed_Allotment.Controls.Add(this.label1);
            this.gb_Feed_Allotment.Controls.Add(this.cmb_Staff);
            this.gb_Feed_Allotment.Controls.Add(this.lbl_Note);
            this.gb_Feed_Allotment.Controls.Add(this.tb_Note);
            this.gb_Feed_Allotment.Controls.Add(this.lbl_Feed_Allotment_ID);
            this.gb_Feed_Allotment.Controls.Add(this.lbl_Feed);
            this.gb_Feed_Allotment.Controls.Add(this.lbl_Allotment_Date);
            this.gb_Feed_Allotment.Controls.Add(this.cmb_Feed);
            this.gb_Feed_Allotment.Controls.Add(this.tb_Feed_Allotment_ID);
            this.gb_Feed_Allotment.Controls.Add(this.lbl_Bag_KG);
            this.gb_Feed_Allotment.Controls.Add(this.cmb_Bag_KG);
            this.gb_Feed_Allotment.Controls.Add(this.lbl_Bag_Quantity);
            this.gb_Feed_Allotment.Controls.Add(this.lbl_Staff);
            this.gb_Feed_Allotment.Controls.Add(this.tb_Bag_Quantity);
            this.gb_Feed_Allotment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Feed_Allotment.ForeColor = System.Drawing.Color.Black;
            this.gb_Feed_Allotment.Location = new System.Drawing.Point(15, 28);
            this.gb_Feed_Allotment.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Feed_Allotment.Name = "gb_Feed_Allotment";
            this.gb_Feed_Allotment.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Feed_Allotment.Size = new System.Drawing.Size(1307, 405);
            this.gb_Feed_Allotment.TabIndex = 82;
            this.gb_Feed_Allotment.TabStop = false;
            this.gb_Feed_Allotment.Text = "Feed Allotment";
            // 
            // tb_Lot_Number
            // 
            this.tb_Lot_Number.Enabled = false;
            this.tb_Lot_Number.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lot_Number.Location = new System.Drawing.Point(338, 118);
            this.tb_Lot_Number.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Lot_Number.MaxLength = 15;
            this.tb_Lot_Number.Name = "tb_Lot_Number";
            this.tb_Lot_Number.Size = new System.Drawing.Size(249, 33);
            this.tb_Lot_Number.TabIndex = 85;
            // 
            // lbl_Lot_Number
            // 
            this.lbl_Lot_Number.AutoSize = true;
            this.lbl_Lot_Number.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lot_Number.ForeColor = System.Drawing.Color.Green;
            this.lbl_Lot_Number.Location = new System.Drawing.Point(62, 118);
            this.lbl_Lot_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lot_Number.Name = "lbl_Lot_Number";
            this.lbl_Lot_Number.Size = new System.Drawing.Size(151, 30);
            this.lbl_Lot_Number.TabIndex = 86;
            this.lbl_Lot_Number.Text = "Lot Number";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(880, 55);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(219, 31);
            this.dtp_Date.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1115, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "Kg";
            // 
            // cmb_Staff
            // 
            this.cmb_Staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Staff.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Staff.FormattingEnabled = true;
            this.cmb_Staff.Items.AddRange(new object[] {
            "Pre Starter",
            "Starter",
            "Grower",
            "Finisher"});
            this.cmb_Staff.Location = new System.Drawing.Point(880, 122);
            this.cmb_Staff.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Staff.Name = "cmb_Staff";
            this.cmb_Staff.Size = new System.Drawing.Size(219, 32);
            this.cmb_Staff.TabIndex = 4;
            this.cmb_Staff.SelectedIndexChanged += new System.EventHandler(this.cmb_Staff_SelectedIndexChanged);
            this.cmb_Staff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OT);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Green;
            this.lbl_Note.Location = new System.Drawing.Point(644, 267);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(73, 32);
            this.lbl_Note.TabIndex = 81;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Note
            // 
            this.tb_Note.Location = new System.Drawing.Point(880, 267);
            this.tb_Note.MaxLength = 100;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(382, 99);
            this.tb_Note.TabIndex = 6;
            // 
            // lbl_Feed
            // 
            this.lbl_Feed.AutoSize = true;
            this.lbl_Feed.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feed.ForeColor = System.Drawing.Color.Green;
            this.lbl_Feed.Location = new System.Drawing.Point(61, 193);
            this.lbl_Feed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Feed.Name = "lbl_Feed";
            this.lbl_Feed.Size = new System.Drawing.Size(73, 32);
            this.lbl_Feed.TabIndex = 75;
            this.lbl_Feed.Text = "Feed";
            // 
            // cmb_Feed
            // 
            this.cmb_Feed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Feed.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Feed.FormattingEnabled = true;
            this.cmb_Feed.Items.AddRange(new object[] {
            "Pre Starter",
            "Starter",
            "Grower",
            "Finisher"});
            this.cmb_Feed.Location = new System.Drawing.Point(338, 196);
            this.cmb_Feed.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Feed.Name = "cmb_Feed";
            this.cmb_Feed.Size = new System.Drawing.Size(249, 32);
            this.cmb_Feed.TabIndex = 1;
            // 
            // lbl_Bag_KG
            // 
            this.lbl_Bag_KG.AutoSize = true;
            this.lbl_Bag_KG.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bag_KG.ForeColor = System.Drawing.Color.Green;
            this.lbl_Bag_KG.Location = new System.Drawing.Point(644, 193);
            this.lbl_Bag_KG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bag_KG.Name = "lbl_Bag_KG";
            this.lbl_Bag_KG.Size = new System.Drawing.Size(131, 32);
            this.lbl_Bag_KG.TabIndex = 73;
            this.lbl_Bag_KG.Text = "Bag(KG)";
            // 
            // cmb_Bag_KG
            // 
            this.cmb_Bag_KG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Bag_KG.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Bag_KG.FormattingEnabled = true;
            this.cmb_Bag_KG.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "75",
            "80",
            "85"});
            this.cmb_Bag_KG.Location = new System.Drawing.Point(880, 193);
            this.cmb_Bag_KG.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Bag_KG.Name = "cmb_Bag_KG";
            this.cmb_Bag_KG.Size = new System.Drawing.Size(219, 32);
            this.cmb_Bag_KG.TabIndex = 5;
            // 
            // lbl_Bag_Quantity
            // 
            this.lbl_Bag_Quantity.AutoSize = true;
            this.lbl_Bag_Quantity.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bag_Quantity.ForeColor = System.Drawing.Color.Green;
            this.lbl_Bag_Quantity.Location = new System.Drawing.Point(61, 269);
            this.lbl_Bag_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bag_Quantity.Name = "lbl_Bag_Quantity";
            this.lbl_Bag_Quantity.Size = new System.Drawing.Size(184, 32);
            this.lbl_Bag_Quantity.TabIndex = 72;
            this.lbl_Bag_Quantity.Text = "Bag Quantity";
            // 
            // lbl_Staff
            // 
            this.lbl_Staff.AutoSize = true;
            this.lbl_Staff.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff.ForeColor = System.Drawing.Color.Green;
            this.lbl_Staff.Location = new System.Drawing.Point(644, 118);
            this.lbl_Staff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff.Name = "lbl_Staff";
            this.lbl_Staff.Size = new System.Drawing.Size(77, 32);
            this.lbl_Staff.TabIndex = 71;
            this.lbl_Staff.Text = "Staff";
            // 
            // tb_Bag_Quantity
            // 
            this.tb_Bag_Quantity.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bag_Quantity.Location = new System.Drawing.Point(338, 269);
            this.tb_Bag_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Bag_Quantity.MaxLength = 7;
            this.tb_Bag_Quantity.Name = "tb_Bag_Quantity";
            this.tb_Bag_Quantity.Size = new System.Drawing.Size(249, 33);
            this.tb_Bag_Quantity.TabIndex = 2;
            this.tb_Bag_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(793, 504);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(203, 75);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Navy;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(353, 504);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(195, 75);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Feed_Allotment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Feed_Allotment);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Feed_Allotment";
            this.Text = "FEED ALLOTMENT";
            this.Load += new System.EventHandler(this.frm_Feed_Allotment_Load);
            this.gb_Feed_Allotment.ResumeLayout(false);
            this.gb_Feed_Allotment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Feed_Allotment_ID;
        private System.Windows.Forms.Label lbl_Allotment_Date;
        private System.Windows.Forms.TextBox tb_Feed_Allotment_ID;
        private System.Windows.Forms.GroupBox gb_Feed_Allotment;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Feed;
        private System.Windows.Forms.ComboBox cmb_Feed;
        private System.Windows.Forms.Label lbl_Bag_KG;
        private System.Windows.Forms.ComboBox cmb_Bag_KG;
        private System.Windows.Forms.Label lbl_Bag_Quantity;
        private System.Windows.Forms.Label lbl_Staff;
        private System.Windows.Forms.TextBox tb_Bag_Quantity;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Lot_Number;
        private System.Windows.Forms.Label lbl_Lot_Number;
    }
}