
namespace Poultry_Farm_Manager_App.Feed_Details
{
    partial class frm_Feed_Transfer
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
            this.lbl_Feed_Transfer_ID = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Staff = new System.Windows.Forms.ComboBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Feed = new System.Windows.Forms.Label();
            this.lbl_Transfer_Date = new System.Windows.Forms.Label();
            this.cmb_Feed = new System.Windows.Forms.ComboBox();
            this.tb_Feed_Transfer_ID = new System.Windows.Forms.TextBox();
            this.dtp_Transfer_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Bag_KG = new System.Windows.Forms.Label();
            this.cmb_Bag_KG = new System.Windows.Forms.ComboBox();
            this.lbl_Bag_Quantity = new System.Windows.Forms.Label();
            this.lbl_Staff = new System.Windows.Forms.Label();
            this.tb_Bag_Quantity = new System.Windows.Forms.TextBox();
            this.gb_Feed_Transfer = new System.Windows.Forms.GroupBox();
            this.tb_Total_Feed_Transfer = new System.Windows.Forms.TextBox();
            this.lbl_Total_Feed_Transfer = new System.Windows.Forms.Label();
            this.gb_Feed_Transfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Navy;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(327, 542);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(195, 75);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Feed_Transfer_ID
            // 
            this.lbl_Feed_Transfer_ID.AutoSize = true;
            this.lbl_Feed_Transfer_ID.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feed_Transfer_ID.ForeColor = System.Drawing.Color.Green;
            this.lbl_Feed_Transfer_ID.Location = new System.Drawing.Point(61, 53);
            this.lbl_Feed_Transfer_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Feed_Transfer_ID.Name = "lbl_Feed_Transfer_ID";
            this.lbl_Feed_Transfer_ID.Size = new System.Drawing.Size(233, 32);
            this.lbl_Feed_Transfer_ID.TabIndex = 74;
            this.lbl_Feed_Transfer_ID.Text = "Feed Transfer ID";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(807, 542);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(203, 75);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // cmb_Staff
            // 
            this.cmb_Staff.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Staff.FormattingEnabled = true;
            this.cmb_Staff.Items.AddRange(new object[] {
            "Pre Starter",
            "Starter",
            "Grower",
            "Finisher"});
            this.cmb_Staff.Location = new System.Drawing.Point(949, 164);
            this.cmb_Staff.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Staff.Name = "cmb_Staff";
            this.cmb_Staff.Size = new System.Drawing.Size(249, 32);
            this.cmb_Staff.TabIndex = 6;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Green;
            this.lbl_Note.Location = new System.Drawing.Point(644, 361);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(73, 32);
            this.lbl_Note.TabIndex = 81;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Note
            // 
            this.tb_Note.Location = new System.Drawing.Point(880, 364);
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(382, 90);
            this.tb_Note.TabIndex = 8;
            // 
            // lbl_Feed
            // 
            this.lbl_Feed.AutoSize = true;
            this.lbl_Feed.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feed.ForeColor = System.Drawing.Color.Green;
            this.lbl_Feed.Location = new System.Drawing.Point(61, 164);
            this.lbl_Feed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Feed.Name = "lbl_Feed";
            this.lbl_Feed.Size = new System.Drawing.Size(73, 32);
            this.lbl_Feed.TabIndex = 75;
            this.lbl_Feed.Text = "Feed";
            // 
            // lbl_Transfer_Date
            // 
            this.lbl_Transfer_Date.AutoSize = true;
            this.lbl_Transfer_Date.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transfer_Date.ForeColor = System.Drawing.Color.Green;
            this.lbl_Transfer_Date.Location = new System.Drawing.Point(644, 54);
            this.lbl_Transfer_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Transfer_Date.Name = "lbl_Transfer_Date";
            this.lbl_Transfer_Date.Size = new System.Drawing.Size(190, 32);
            this.lbl_Transfer_Date.TabIndex = 78;
            this.lbl_Transfer_Date.Text = "Transfer Date";
            // 
            // cmb_Feed
            // 
            this.cmb_Feed.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Feed.FormattingEnabled = true;
            this.cmb_Feed.Items.AddRange(new object[] {
            "Pre Starter",
            "Starter",
            "Grower",
            "Finisher"});
            this.cmb_Feed.Location = new System.Drawing.Point(338, 169);
            this.cmb_Feed.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Feed.Name = "cmb_Feed";
            this.cmb_Feed.Size = new System.Drawing.Size(249, 32);
            this.cmb_Feed.TabIndex = 3;
            // 
            // tb_Feed_Transfer_ID
            // 
            this.tb_Feed_Transfer_ID.Enabled = false;
            this.tb_Feed_Transfer_ID.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Feed_Transfer_ID.Location = new System.Drawing.Point(344, 53);
            this.tb_Feed_Transfer_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Feed_Transfer_ID.MaxLength = 15;
            this.tb_Feed_Transfer_ID.Name = "tb_Feed_Transfer_ID";
            this.tb_Feed_Transfer_ID.Size = new System.Drawing.Size(243, 33);
            this.tb_Feed_Transfer_ID.TabIndex = 1;
            // 
            // dtp_Transfer_Date
            // 
            this.dtp_Transfer_Date.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Transfer_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Transfer_Date.Location = new System.Drawing.Point(949, 49);
            this.dtp_Transfer_Date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Transfer_Date.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtp_Transfer_Date.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_Transfer_Date.Name = "dtp_Transfer_Date";
            this.dtp_Transfer_Date.Size = new System.Drawing.Size(243, 33);
            this.dtp_Transfer_Date.TabIndex = 2;
            this.dtp_Transfer_Date.Value = new System.DateTime(2024, 7, 27, 0, 0, 0, 0);
            // 
            // lbl_Bag_KG
            // 
            this.lbl_Bag_KG.AutoSize = true;
            this.lbl_Bag_KG.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bag_KG.ForeColor = System.Drawing.Color.Green;
            this.lbl_Bag_KG.Location = new System.Drawing.Point(61, 261);
            this.lbl_Bag_KG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bag_KG.Name = "lbl_Bag_KG";
            this.lbl_Bag_KG.Size = new System.Drawing.Size(131, 32);
            this.lbl_Bag_KG.TabIndex = 73;
            this.lbl_Bag_KG.Text = "Bag(KG)";
            // 
            // cmb_Bag_KG
            // 
            this.cmb_Bag_KG.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Bag_KG.FormattingEnabled = true;
            this.cmb_Bag_KG.Items.AddRange(new object[] {
            "50kg",
            "60kg",
            "70kg",
            "75kg"});
            this.cmb_Bag_KG.Location = new System.Drawing.Point(338, 272);
            this.cmb_Bag_KG.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Bag_KG.Name = "cmb_Bag_KG";
            this.cmb_Bag_KG.Size = new System.Drawing.Size(249, 32);
            this.cmb_Bag_KG.TabIndex = 4;
            // 
            // lbl_Bag_Quantity
            // 
            this.lbl_Bag_Quantity.AutoSize = true;
            this.lbl_Bag_Quantity.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bag_Quantity.ForeColor = System.Drawing.Color.Green;
            this.lbl_Bag_Quantity.Location = new System.Drawing.Point(61, 356);
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
            this.lbl_Staff.Location = new System.Drawing.Point(644, 164);
            this.lbl_Staff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff.Name = "lbl_Staff";
            this.lbl_Staff.Size = new System.Drawing.Size(77, 32);
            this.lbl_Staff.TabIndex = 71;
            this.lbl_Staff.Text = "Staff";
            // 
            // tb_Bag_Quantity
            // 
            this.tb_Bag_Quantity.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bag_Quantity.Location = new System.Drawing.Point(338, 361);
            this.tb_Bag_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Bag_Quantity.MaxLength = 5;
            this.tb_Bag_Quantity.Name = "tb_Bag_Quantity";
            this.tb_Bag_Quantity.Size = new System.Drawing.Size(249, 33);
            this.tb_Bag_Quantity.TabIndex = 5;
            // 
            // gb_Feed_Transfer
            // 
            this.gb_Feed_Transfer.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Feed_Transfer.Controls.Add(this.tb_Total_Feed_Transfer);
            this.gb_Feed_Transfer.Controls.Add(this.lbl_Total_Feed_Transfer);
            this.gb_Feed_Transfer.Controls.Add(this.cmb_Staff);
            this.gb_Feed_Transfer.Controls.Add(this.lbl_Note);
            this.gb_Feed_Transfer.Controls.Add(this.tb_Note);
            this.gb_Feed_Transfer.Controls.Add(this.lbl_Feed_Transfer_ID);
            this.gb_Feed_Transfer.Controls.Add(this.lbl_Feed);
            this.gb_Feed_Transfer.Controls.Add(this.lbl_Transfer_Date);
            this.gb_Feed_Transfer.Controls.Add(this.cmb_Feed);
            this.gb_Feed_Transfer.Controls.Add(this.tb_Feed_Transfer_ID);
            this.gb_Feed_Transfer.Controls.Add(this.dtp_Transfer_Date);
            this.gb_Feed_Transfer.Controls.Add(this.lbl_Bag_KG);
            this.gb_Feed_Transfer.Controls.Add(this.cmb_Bag_KG);
            this.gb_Feed_Transfer.Controls.Add(this.lbl_Bag_Quantity);
            this.gb_Feed_Transfer.Controls.Add(this.lbl_Staff);
            this.gb_Feed_Transfer.Controls.Add(this.tb_Bag_Quantity);
            this.gb_Feed_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Feed_Transfer.ForeColor = System.Drawing.Color.Black;
            this.gb_Feed_Transfer.Location = new System.Drawing.Point(16, 24);
            this.gb_Feed_Transfer.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Feed_Transfer.Name = "gb_Feed_Transfer";
            this.gb_Feed_Transfer.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Feed_Transfer.Size = new System.Drawing.Size(1307, 478);
            this.gb_Feed_Transfer.TabIndex = 85;
            this.gb_Feed_Transfer.TabStop = false;
            this.gb_Feed_Transfer.Text = "Feed Transfer";
            // 
            // tb_Total_Feed_Transfer
            // 
            this.tb_Total_Feed_Transfer.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Feed_Transfer.Location = new System.Drawing.Point(949, 275);
            this.tb_Total_Feed_Transfer.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Total_Feed_Transfer.MaxLength = 5;
            this.tb_Total_Feed_Transfer.Name = "tb_Total_Feed_Transfer";
            this.tb_Total_Feed_Transfer.Size = new System.Drawing.Size(243, 33);
            this.tb_Total_Feed_Transfer.TabIndex = 7;
            // 
            // lbl_Total_Feed_Transfer
            // 
            this.lbl_Total_Feed_Transfer.AutoSize = true;
            this.lbl_Total_Feed_Transfer.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Feed_Transfer.ForeColor = System.Drawing.Color.Green;
            this.lbl_Total_Feed_Transfer.Location = new System.Drawing.Point(644, 270);
            this.lbl_Total_Feed_Transfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total_Feed_Transfer.Name = "lbl_Total_Feed_Transfer";
            this.lbl_Total_Feed_Transfer.Size = new System.Drawing.Size(264, 32);
            this.lbl_Total_Feed_Transfer.TabIndex = 83;
            this.lbl_Total_Feed_Transfer.Text = "Total Feed Transfer";
            // 
            // frm_Feed_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Feed_Transfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Feed_Transfer";
            this.Text = "Feed Transfer";
            this.Load += new System.EventHandler(this.frm_Feed_Transfer_Load);
            this.gb_Feed_Transfer.ResumeLayout(false);
            this.gb_Feed_Transfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Feed_Transfer_ID;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Staff;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Feed;
        private System.Windows.Forms.Label lbl_Transfer_Date;
        private System.Windows.Forms.ComboBox cmb_Feed;
        private System.Windows.Forms.TextBox tb_Feed_Transfer_ID;
        private System.Windows.Forms.DateTimePicker dtp_Transfer_Date;
        private System.Windows.Forms.Label lbl_Bag_KG;
        private System.Windows.Forms.ComboBox cmb_Bag_KG;
        private System.Windows.Forms.Label lbl_Bag_Quantity;
        private System.Windows.Forms.Label lbl_Staff;
        private System.Windows.Forms.TextBox tb_Bag_Quantity;
        private System.Windows.Forms.GroupBox gb_Feed_Transfer;
        private System.Windows.Forms.TextBox tb_Total_Feed_Transfer;
        private System.Windows.Forms.Label lbl_Total_Feed_Transfer;
    }
}