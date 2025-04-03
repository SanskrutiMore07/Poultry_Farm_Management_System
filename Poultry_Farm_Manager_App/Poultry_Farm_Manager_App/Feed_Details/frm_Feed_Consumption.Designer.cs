
namespace Poultry_Farm_Manager_App.Feed_Details
{
    partial class frm_Feed_Consumption
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
            this.gb_Feed_Consumption = new System.Windows.Forms.GroupBox();
            this.lbl_Bag_Kg = new System.Windows.Forms.Label();
            this.cmb_Fc_Bag_Kg = new System.Windows.Forms.ComboBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Feed = new System.Windows.Forms.Label();
            this.cmb_Feed = new System.Windows.Forms.ComboBox();
            this.lbl_Feed_Consumption_In_KG = new System.Windows.Forms.Label();
            this.lbl_lbl_Feed_Consumption_In_Bags = new System.Windows.Forms.Label();
            this.tb_Feed_Consumption_In_Bags = new System.Windows.Forms.TextBox();
            this.lbl_Total_Feed_Consumption = new System.Windows.Forms.Label();
            this.tb_Running_FCR = new System.Windows.Forms.TextBox();
            this.lbl_Running_FCR = new System.Windows.Forms.Label();
            this.tb_Total_Feed_Consumption = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Lot_No = new System.Windows.Forms.Label();
            this.tb_Lot_Number = new System.Windows.Forms.TextBox();
            this.lbl_FC_ID = new System.Windows.Forms.Label();
            this.gb_Feed_Consumption_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Consumption_Date = new System.Windows.Forms.DateTimePicker();
            this.cmb_Staff = new System.Windows.Forms.ComboBox();
            this.lbl_Staff = new System.Windows.Forms.Label();
            this.lbl_Consumption_Date = new System.Windows.Forms.Label();
            this.tb_FC_ID = new System.Windows.Forms.TextBox();
            this.gb_Feed_Consumption.SuspendLayout();
            this.gb_Feed_Consumption_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Feed_Consumption
            // 
            this.gb_Feed_Consumption.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Feed_Consumption.Controls.Add(this.lbl_Bag_Kg);
            this.gb_Feed_Consumption.Controls.Add(this.cmb_Fc_Bag_Kg);
            this.gb_Feed_Consumption.Controls.Add(this.lbl_Note);
            this.gb_Feed_Consumption.Controls.Add(this.tb_Note);
            this.gb_Feed_Consumption.Controls.Add(this.lbl_Feed);
            this.gb_Feed_Consumption.Controls.Add(this.cmb_Feed);
            this.gb_Feed_Consumption.Controls.Add(this.lbl_Feed_Consumption_In_KG);
            this.gb_Feed_Consumption.Controls.Add(this.lbl_lbl_Feed_Consumption_In_Bags);
            this.gb_Feed_Consumption.Controls.Add(this.tb_Feed_Consumption_In_Bags);
            this.gb_Feed_Consumption.Controls.Add(this.lbl_Total_Feed_Consumption);
            this.gb_Feed_Consumption.Controls.Add(this.tb_Running_FCR);
            this.gb_Feed_Consumption.Controls.Add(this.lbl_Running_FCR);
            this.gb_Feed_Consumption.Controls.Add(this.tb_Total_Feed_Consumption);
            this.gb_Feed_Consumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Feed_Consumption.ForeColor = System.Drawing.Color.Black;
            this.gb_Feed_Consumption.Location = new System.Drawing.Point(56, 192);
            this.gb_Feed_Consumption.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Feed_Consumption.Name = "gb_Feed_Consumption";
            this.gb_Feed_Consumption.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Feed_Consumption.Size = new System.Drawing.Size(1233, 291);
            this.gb_Feed_Consumption.TabIndex = 82;
            this.gb_Feed_Consumption.TabStop = false;
            this.gb_Feed_Consumption.Text = "Feed Consumption";
            // 
            // lbl_Bag_Kg
            // 
            this.lbl_Bag_Kg.AutoSize = true;
            this.lbl_Bag_Kg.BackColor = System.Drawing.Color.Tan;
            this.lbl_Bag_Kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bag_Kg.Location = new System.Drawing.Point(538, 108);
            this.lbl_Bag_Kg.Name = "lbl_Bag_Kg";
            this.lbl_Bag_Kg.Size = new System.Drawing.Size(38, 25);
            this.lbl_Bag_Kg.TabIndex = 85;
            this.lbl_Bag_Kg.Text = "Kg";
            // 
            // cmb_Fc_Bag_Kg
            // 
            this.cmb_Fc_Bag_Kg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Fc_Bag_Kg.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Fc_Bag_Kg.FormattingEnabled = true;
            this.cmb_Fc_Bag_Kg.ItemHeight = 25;
            this.cmb_Fc_Bag_Kg.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "75",
            "80",
            "85"});
            this.cmb_Fc_Bag_Kg.Location = new System.Drawing.Point(305, 104);
            this.cmb_Fc_Bag_Kg.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Fc_Bag_Kg.Name = "cmb_Fc_Bag_Kg";
            this.cmb_Fc_Bag_Kg.Size = new System.Drawing.Size(225, 33);
            this.cmb_Fc_Bag_Kg.TabIndex = 4;
            this.cmb_Fc_Bag_Kg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Green;
            this.lbl_Note.Location = new System.Drawing.Point(610, 168);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(73, 32);
            this.lbl_Note.TabIndex = 83;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Note
            // 
            this.tb_Note.Location = new System.Drawing.Point(873, 182);
            this.tb_Note.MaxLength = 100;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(332, 85);
            this.tb_Note.TabIndex = 8;
            // 
            // lbl_Feed
            // 
            this.lbl_Feed.AutoSize = true;
            this.lbl_Feed.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feed.ForeColor = System.Drawing.Color.Green;
            this.lbl_Feed.Location = new System.Drawing.Point(16, 30);
            this.lbl_Feed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Feed.Name = "lbl_Feed";
            this.lbl_Feed.Size = new System.Drawing.Size(73, 32);
            this.lbl_Feed.TabIndex = 81;
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
            this.cmb_Feed.Location = new System.Drawing.Point(308, 33);
            this.cmb_Feed.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Feed.Name = "cmb_Feed";
            this.cmb_Feed.Size = new System.Drawing.Size(222, 32);
            this.cmb_Feed.TabIndex = 3;
            this.cmb_Feed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OT);
            // 
            // lbl_Feed_Consumption_In_KG
            // 
            this.lbl_Feed_Consumption_In_KG.AutoSize = true;
            this.lbl_Feed_Consumption_In_KG.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feed_Consumption_In_KG.ForeColor = System.Drawing.Color.Green;
            this.lbl_Feed_Consumption_In_KG.Location = new System.Drawing.Point(14, 104);
            this.lbl_Feed_Consumption_In_KG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Feed_Consumption_In_KG.Name = "lbl_Feed_Consumption_In_KG";
            this.lbl_Feed_Consumption_In_KG.Size = new System.Drawing.Size(297, 27);
            this.lbl_Feed_Consumption_In_KG.TabIndex = 76;
            this.lbl_Feed_Consumption_In_KG.Text = "Feed Consumption In (KG)";
            // 
            // lbl_lbl_Feed_Consumption_In_Bags
            // 
            this.lbl_lbl_Feed_Consumption_In_Bags.AutoSize = true;
            this.lbl_lbl_Feed_Consumption_In_Bags.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lbl_Feed_Consumption_In_Bags.ForeColor = System.Drawing.Color.Green;
            this.lbl_lbl_Feed_Consumption_In_Bags.Location = new System.Drawing.Point(609, 29);
            this.lbl_lbl_Feed_Consumption_In_Bags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lbl_Feed_Consumption_In_Bags.Name = "lbl_lbl_Feed_Consumption_In_Bags";
            this.lbl_lbl_Feed_Consumption_In_Bags.Size = new System.Drawing.Size(318, 30);
            this.lbl_lbl_Feed_Consumption_In_Bags.TabIndex = 75;
            this.lbl_lbl_Feed_Consumption_In_Bags.Text = "Feed Consumption In Bags";
            // 
            // tb_Feed_Consumption_In_Bags
            // 
            this.tb_Feed_Consumption_In_Bags.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Feed_Consumption_In_Bags.Location = new System.Drawing.Point(925, 30);
            this.tb_Feed_Consumption_In_Bags.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Feed_Consumption_In_Bags.MaxLength = 7;
            this.tb_Feed_Consumption_In_Bags.Name = "tb_Feed_Consumption_In_Bags";
            this.tb_Feed_Consumption_In_Bags.Size = new System.Drawing.Size(280, 33);
            this.tb_Feed_Consumption_In_Bags.TabIndex = 5;
            this.tb_Feed_Consumption_In_Bags.TextChanged += new System.EventHandler(this.tb_Feed_Consumption_In_Bags_TextChanged);
            this.tb_Feed_Consumption_In_Bags.DoubleClick += new System.EventHandler(this.tb_Feed_Consumption_In_Bags_DoubleClick);
            this.tb_Feed_Consumption_In_Bags.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Total_Feed_Consumption
            // 
            this.lbl_Total_Feed_Consumption.AutoSize = true;
            this.lbl_Total_Feed_Consumption.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Feed_Consumption.ForeColor = System.Drawing.Color.Green;
            this.lbl_Total_Feed_Consumption.Location = new System.Drawing.Point(609, 107);
            this.lbl_Total_Feed_Consumption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total_Feed_Consumption.Name = "lbl_Total_Feed_Consumption";
            this.lbl_Total_Feed_Consumption.Size = new System.Drawing.Size(297, 30);
            this.lbl_Total_Feed_Consumption.TabIndex = 77;
            this.lbl_Total_Feed_Consumption.Text = "Total Feed Consumption ";
            // 
            // tb_Running_FCR
            // 
            this.tb_Running_FCR.Enabled = false;
            this.tb_Running_FCR.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Running_FCR.Location = new System.Drawing.Point(306, 169);
            this.tb_Running_FCR.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Running_FCR.MaxLength = 7;
            this.tb_Running_FCR.Name = "tb_Running_FCR";
            this.tb_Running_FCR.Size = new System.Drawing.Size(224, 33);
            this.tb_Running_FCR.TabIndex = 7;
            this.tb_Running_FCR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Running_FCR
            // 
            this.lbl_Running_FCR.AutoSize = true;
            this.lbl_Running_FCR.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Running_FCR.ForeColor = System.Drawing.Color.Green;
            this.lbl_Running_FCR.Location = new System.Drawing.Point(16, 168);
            this.lbl_Running_FCR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Running_FCR.Name = "lbl_Running_FCR";
            this.lbl_Running_FCR.Size = new System.Drawing.Size(171, 30);
            this.lbl_Running_FCR.TabIndex = 73;
            this.lbl_Running_FCR.Text = "Running FCR";
            // 
            // tb_Total_Feed_Consumption
            // 
            this.tb_Total_Feed_Consumption.Enabled = false;
            this.tb_Total_Feed_Consumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Feed_Consumption.Location = new System.Drawing.Point(925, 104);
            this.tb_Total_Feed_Consumption.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Total_Feed_Consumption.MaxLength = 7;
            this.tb_Total_Feed_Consumption.Name = "tb_Total_Feed_Consumption";
            this.tb_Total_Feed_Consumption.Size = new System.Drawing.Size(280, 33);
            this.tb_Total_Feed_Consumption.TabIndex = 6;
            this.tb_Total_Feed_Consumption.TextChanged += new System.EventHandler(this.tb_Total_Feed_Consumption_TextChanged);
            this.tb_Total_Feed_Consumption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Navy;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(373, 511);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(195, 75);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(780, 511);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(203, 75);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Lot_No
            // 
            this.lbl_Lot_No.AutoSize = true;
            this.lbl_Lot_No.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lot_No.ForeColor = System.Drawing.Color.Green;
            this.lbl_Lot_No.Location = new System.Drawing.Point(51, 96);
            this.lbl_Lot_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lot_No.Name = "lbl_Lot_No";
            this.lbl_Lot_No.Size = new System.Drawing.Size(104, 32);
            this.lbl_Lot_No.TabIndex = 83;
            this.lbl_Lot_No.Text = "Lot No";
            // 
            // tb_Lot_Number
            // 
            this.tb_Lot_Number.Enabled = false;
            this.tb_Lot_Number.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lot_Number.Location = new System.Drawing.Point(228, 87);
            this.tb_Lot_Number.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Lot_Number.MaxLength = 15;
            this.tb_Lot_Number.Name = "tb_Lot_Number";
            this.tb_Lot_Number.Size = new System.Drawing.Size(270, 33);
            this.tb_Lot_Number.TabIndex = 2;
            this.tb_Lot_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_FC_ID
            // 
            this.lbl_FC_ID.AutoSize = true;
            this.lbl_FC_ID.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FC_ID.ForeColor = System.Drawing.Color.Green;
            this.lbl_FC_ID.Location = new System.Drawing.Point(51, 40);
            this.lbl_FC_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FC_ID.Name = "lbl_FC_ID";
            this.lbl_FC_ID.Size = new System.Drawing.Size(95, 32);
            this.lbl_FC_ID.TabIndex = 84;
            this.lbl_FC_ID.Text = "FC ID";
            // 
            // gb_Feed_Consumption_Details
            // 
            this.gb_Feed_Consumption_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Feed_Consumption_Details.Controls.Add(this.dtp_Consumption_Date);
            this.gb_Feed_Consumption_Details.Controls.Add(this.cmb_Staff);
            this.gb_Feed_Consumption_Details.Controls.Add(this.lbl_Staff);
            this.gb_Feed_Consumption_Details.Controls.Add(this.lbl_Consumption_Date);
            this.gb_Feed_Consumption_Details.Controls.Add(this.tb_FC_ID);
            this.gb_Feed_Consumption_Details.Controls.Add(this.tb_Lot_Number);
            this.gb_Feed_Consumption_Details.Controls.Add(this.lbl_Lot_No);
            this.gb_Feed_Consumption_Details.Controls.Add(this.lbl_FC_ID);
            this.gb_Feed_Consumption_Details.Location = new System.Drawing.Point(55, 44);
            this.gb_Feed_Consumption_Details.Name = "gb_Feed_Consumption_Details";
            this.gb_Feed_Consumption_Details.Size = new System.Drawing.Size(1233, 140);
            this.gb_Feed_Consumption_Details.TabIndex = 83;
            this.gb_Feed_Consumption_Details.TabStop = false;
            this.gb_Feed_Consumption_Details.Text = "Feed Consumption Details";
            // 
            // dtp_Consumption_Date
            // 
            this.dtp_Consumption_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Consumption_Date.Location = new System.Drawing.Point(928, 39);
            this.dtp_Consumption_Date.Name = "dtp_Consumption_Date";
            this.dtp_Consumption_Date.Size = new System.Drawing.Size(272, 31);
            this.dtp_Consumption_Date.TabIndex = 1;
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
            this.cmb_Staff.Location = new System.Drawing.Point(928, 90);
            this.cmb_Staff.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Staff.Name = "cmb_Staff";
            this.cmb_Staff.Size = new System.Drawing.Size(272, 32);
            this.cmb_Staff.TabIndex = 2;
            this.cmb_Staff.SelectedIndexChanged += new System.EventHandler(this.cmb_Staff_SelectedIndexChanged);
            this.cmb_Staff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OT);
            // 
            // lbl_Staff
            // 
            this.lbl_Staff.AutoSize = true;
            this.lbl_Staff.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff.ForeColor = System.Drawing.Color.Green;
            this.lbl_Staff.Location = new System.Drawing.Point(598, 92);
            this.lbl_Staff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff.Name = "lbl_Staff";
            this.lbl_Staff.Size = new System.Drawing.Size(77, 32);
            this.lbl_Staff.TabIndex = 89;
            this.lbl_Staff.Text = "Staff";
            // 
            // lbl_Consumption_Date
            // 
            this.lbl_Consumption_Date.AutoSize = true;
            this.lbl_Consumption_Date.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consumption_Date.ForeColor = System.Drawing.Color.Green;
            this.lbl_Consumption_Date.Location = new System.Drawing.Point(598, 31);
            this.lbl_Consumption_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Consumption_Date.Name = "lbl_Consumption_Date";
            this.lbl_Consumption_Date.Size = new System.Drawing.Size(247, 32);
            this.lbl_Consumption_Date.TabIndex = 87;
            this.lbl_Consumption_Date.Text = "Consumption Date";
            // 
            // tb_FC_ID
            // 
            this.tb_FC_ID.Enabled = false;
            this.tb_FC_ID.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FC_ID.Location = new System.Drawing.Point(228, 31);
            this.tb_FC_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_FC_ID.MaxLength = 10;
            this.tb_FC_ID.Name = "tb_FC_ID";
            this.tb_FC_ID.Size = new System.Drawing.Size(270, 33);
            this.tb_FC_ID.TabIndex = 1;
            this.tb_FC_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // frm_Feed_Consumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Feed_Consumption_Details);
            this.Controls.Add(this.gb_Feed_Consumption);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Feed_Consumption";
            this.Text = "frm_Feed_Consumption";
            this.Load += new System.EventHandler(this.frm_Feed_Consumption_Load);
            this.gb_Feed_Consumption.ResumeLayout(false);
            this.gb_Feed_Consumption.PerformLayout();
            this.gb_Feed_Consumption_Details.ResumeLayout(false);
            this.gb_Feed_Consumption_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Feed_Consumption;
        private System.Windows.Forms.Label lbl_Feed_Consumption_In_KG;
        private System.Windows.Forms.Label lbl_lbl_Feed_Consumption_In_Bags;
        private System.Windows.Forms.TextBox tb_Feed_Consumption_In_Bags;
        private System.Windows.Forms.Label lbl_Total_Feed_Consumption;
        private System.Windows.Forms.TextBox tb_Total_Feed_Consumption;
        private System.Windows.Forms.Label lbl_Lot_No;
        private System.Windows.Forms.TextBox tb_Lot_Number;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_FC_ID;
        private System.Windows.Forms.GroupBox gb_Feed_Consumption_Details;
        private System.Windows.Forms.TextBox tb_FC_ID;
        private System.Windows.Forms.Label lbl_Consumption_Date;
        private System.Windows.Forms.ComboBox cmb_Staff;
        private System.Windows.Forms.Label lbl_Staff;
        private System.Windows.Forms.Label lbl_Feed;
        private System.Windows.Forms.ComboBox cmb_Feed;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.TextBox tb_Running_FCR;
        private System.Windows.Forms.Label lbl_Running_FCR;
        private System.Windows.Forms.DateTimePicker dtp_Consumption_Date;
        private System.Windows.Forms.Label lbl_Bag_Kg;
        private System.Windows.Forms.ComboBox cmb_Fc_Bag_Kg;
    }
}