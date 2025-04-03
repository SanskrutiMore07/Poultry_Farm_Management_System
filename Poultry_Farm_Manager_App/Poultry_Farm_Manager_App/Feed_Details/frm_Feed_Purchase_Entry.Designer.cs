
namespace Poultry_Farm_Manager_App.Feed_Details
{
    partial class frm_Feed_Purchase_Entry
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
            this.lbl_Feed_Purchase_ID = new System.Windows.Forms.Label();
            this.gb_Purchase_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Sup_Name = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Feed_Purchase_ID = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Bag_Kg = new System.Windows.Forms.Label();
            this.cmb_Bag_Kg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Feed = new System.Windows.Forms.ComboBox();
            this.tb_Bag_Qty = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_Feed_Purchase_Entry = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feed_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bag_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Bill_Details = new System.Windows.Forms.GroupBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.gb_Purchase_Details.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Feed_Purchase_Entry)).BeginInit();
            this.gb_Bill_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Feed_Purchase_ID
            // 
            this.lbl_Feed_Purchase_ID.AutoSize = true;
            this.lbl_Feed_Purchase_ID.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feed_Purchase_ID.Location = new System.Drawing.Point(21, 38);
            this.lbl_Feed_Purchase_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Feed_Purchase_ID.Name = "lbl_Feed_Purchase_ID";
            this.lbl_Feed_Purchase_ID.Size = new System.Drawing.Size(252, 34);
            this.lbl_Feed_Purchase_ID.TabIndex = 2;
            this.lbl_Feed_Purchase_ID.Text = "Feed Purchase ID";
            // 
            // gb_Purchase_Details
            // 
            this.gb_Purchase_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Purchase_Details.Controls.Add(this.dtp_Date);
            this.gb_Purchase_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Purchase_Details.Controls.Add(this.tb_Sup_Name);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Supplier_Name);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Date);
            this.gb_Purchase_Details.Controls.Add(this.tb_Feed_Purchase_ID);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Feed_Purchase_ID);
            this.gb_Purchase_Details.Location = new System.Drawing.Point(11, 15);
            this.gb_Purchase_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Purchase_Details.Name = "gb_Purchase_Details";
            this.gb_Purchase_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Purchase_Details.Size = new System.Drawing.Size(613, 311);
            this.gb_Purchase_Details.TabIndex = 15;
            this.gb_Purchase_Details.TabStop = false;
            this.gb_Purchase_Details.Text = "Purchase Details";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(303, 110);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(265, 35);
            this.dtp_Date.TabIndex = 1;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(303, 250);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(265, 35);
            this.tb_Mobile_No.TabIndex = 3;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(21, 246);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(149, 34);
            this.lbl_Mobile_No.TabIndex = 21;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // tb_Sup_Name
            // 
            this.tb_Sup_Name.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sup_Name.Location = new System.Drawing.Point(303, 177);
            this.tb_Sup_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sup_Name.MaxLength = 15;
            this.tb_Sup_Name.Name = "tb_Sup_Name";
            this.tb_Sup_Name.Size = new System.Drawing.Size(265, 35);
            this.tb_Sup_Name.TabIndex = 2;
            this.tb_Sup_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OT);
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(21, 170);
            this.lbl_Supplier_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(210, 34);
            this.lbl_Supplier_Name.TabIndex = 19;
            this.lbl_Supplier_Name.Text = "Supplier Name";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(21, 103);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(76, 34);
            this.lbl_Date.TabIndex = 17;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Feed_Purchase_ID
            // 
            this.tb_Feed_Purchase_ID.Enabled = false;
            this.tb_Feed_Purchase_ID.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Feed_Purchase_ID.Location = new System.Drawing.Point(303, 38);
            this.tb_Feed_Purchase_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Feed_Purchase_ID.MaxLength = 10;
            this.tb_Feed_Purchase_ID.Name = "tb_Feed_Purchase_ID";
            this.tb_Feed_Purchase_ID.Size = new System.Drawing.Size(265, 35);
            this.tb_Feed_Purchase_ID.TabIndex = 1;
            this.tb_Feed_Purchase_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Navy;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(683, 556);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(245, 75);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.lbl_Bag_Kg);
            this.groupBox1.Controls.Add(this.cmb_Bag_Kg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_Feed);
            this.groupBox1.Controls.Add(this.tb_Bag_Qty);
            this.groupBox1.Controls.Add(this.tb_Price);
            this.groupBox1.Controls.Add(this.lbl_Price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(11, 338);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(613, 289);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed Purchase Entry";
            // 
            // lbl_Bag_Kg
            // 
            this.lbl_Bag_Kg.AutoSize = true;
            this.lbl_Bag_Kg.BackColor = System.Drawing.Color.Tan;
            this.lbl_Bag_Kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bag_Kg.Location = new System.Drawing.Point(516, 101);
            this.lbl_Bag_Kg.Name = "lbl_Bag_Kg";
            this.lbl_Bag_Kg.Size = new System.Drawing.Size(38, 25);
            this.lbl_Bag_Kg.TabIndex = 15;
            this.lbl_Bag_Kg.Text = "Kg";
            // 
            // cmb_Bag_Kg
            // 
            this.cmb_Bag_Kg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Bag_Kg.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Bag_Kg.FormattingEnabled = true;
            this.cmb_Bag_Kg.ItemHeight = 25;
            this.cmb_Bag_Kg.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "75",
            "80",
            "85"});
            this.cmb_Bag_Kg.Location = new System.Drawing.Point(283, 97);
            this.cmb_Bag_Kg.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Bag_Kg.Name = "cmb_Bag_Kg";
            this.cmb_Bag_Kg.Size = new System.Drawing.Size(225, 33);
            this.cmb_Bag_Kg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bag(KG)";
            // 
            // cmb_Feed
            // 
            this.cmb_Feed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Feed.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Feed.FormattingEnabled = true;
            this.cmb_Feed.ItemHeight = 25;
            this.cmb_Feed.Items.AddRange(new object[] {
            "Pre Starter",
            "Starter",
            "Grower",
            "Finisher"});
            this.cmb_Feed.Location = new System.Drawing.Point(283, 32);
            this.cmb_Feed.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Feed.Name = "cmb_Feed";
            this.cmb_Feed.Size = new System.Drawing.Size(285, 33);
            this.cmb_Feed.TabIndex = 4;
            this.cmb_Feed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OT);
            // 
            // tb_Bag_Qty
            // 
            this.tb_Bag_Qty.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bag_Qty.Location = new System.Drawing.Point(283, 219);
            this.tb_Bag_Qty.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Bag_Qty.MaxLength = 7;
            this.tb_Bag_Qty.Name = "tb_Bag_Qty";
            this.tb_Bag_Qty.Size = new System.Drawing.Size(285, 35);
            this.tb_Bag_Qty.TabIndex = 7;
            this.tb_Bag_Qty.TextChanged += new System.EventHandler(this.tb_Bag_Qty_TextChanged);
            this.tb_Bag_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(283, 154);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Price.MaxLength = 10;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(285, 35);
            this.tb_Price.TabIndex = 6;
            this.tb_Price.TextChanged += new System.EventHandler(this.tb_Price_TextChanged);
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(21, 151);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(85, 34);
            this.lbl_Price.TabIndex = 1;
            this.lbl_Price.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bag Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 34);
            this.label6.TabIndex = 3;
            this.label6.Text = "Feed";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1017, 556);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(245, 75);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_Feed_Purchase_Entry
            // 
            this.dgv_Feed_Purchase_Entry.AllowUserToAddRows = false;
            this.dgv_Feed_Purchase_Entry.AllowUserToDeleteRows = false;
            this.dgv_Feed_Purchase_Entry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Feed_Purchase_Entry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Feed_Name,
            this.Bag,
            this.Price,
            this.Bag_Qty,
            this.Total});
            this.dgv_Feed_Purchase_Entry.Location = new System.Drawing.Point(7, 127);
            this.dgv_Feed_Purchase_Entry.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Feed_Purchase_Entry.Name = "dgv_Feed_Purchase_Entry";
            this.dgv_Feed_Purchase_Entry.ReadOnly = true;
            this.dgv_Feed_Purchase_Entry.RowHeadersWidth = 51;
            this.dgv_Feed_Purchase_Entry.Size = new System.Drawing.Size(671, 316);
            this.dgv_Feed_Purchase_Entry.TabIndex = 18;
            // 
            // Sr_No
            // 
            this.Sr_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Sr_No.HeaderText = "Sr.No.";
            this.Sr_No.MinimumWidth = 6;
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
            this.Sr_No.Width = 77;
            // 
            // Feed_Name
            // 
            this.Feed_Name.HeaderText = "Feed Name";
            this.Feed_Name.MinimumWidth = 6;
            this.Feed_Name.Name = "Feed_Name";
            this.Feed_Name.ReadOnly = true;
            this.Feed_Name.Width = 120;
            // 
            // Bag
            // 
            this.Bag.HeaderText = "Bag(KG)";
            this.Bag.MinimumWidth = 6;
            this.Bag.Name = "Bag";
            this.Bag.ReadOnly = true;
            this.Bag.Width = 120;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 120;
            // 
            // Bag_Qty
            // 
            this.Bag_Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Bag_Qty.HeaderText = "Qty";
            this.Bag_Qty.MinimumWidth = 6;
            this.Bag_Qty.Name = "Bag_Qty";
            this.Bag_Qty.ReadOnly = true;
            this.Bag_Qty.Width = 59;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 120;
            // 
            // gb_Bill_Details
            // 
            this.gb_Bill_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Bill_Details.Controls.Add(this.tb_Total);
            this.gb_Bill_Details.Controls.Add(this.lbl_Total);
            this.gb_Bill_Details.Controls.Add(this.btn_Add);
            this.gb_Bill_Details.Controls.Add(this.tb_Total_Bill);
            this.gb_Bill_Details.Controls.Add(this.lbl_Total_Bill);
            this.gb_Bill_Details.Controls.Add(this.dgv_Feed_Purchase_Entry);
            this.gb_Bill_Details.Location = new System.Drawing.Point(641, 15);
            this.gb_Bill_Details.Name = "gb_Bill_Details";
            this.gb_Bill_Details.Size = new System.Drawing.Size(685, 532);
            this.gb_Bill_Details.TabIndex = 19;
            this.gb_Bill_Details.TabStop = false;
            this.gb_Bill_Details.Text = "Bill Details";
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.Location = new System.Drawing.Point(242, 58);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(225, 35);
            this.tb_Total.TabIndex = 8;
            this.tb_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(106, 51);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(98, 37);
            this.lbl_Total.TabIndex = 21;
            this.lbl_Total.Text = "Total ";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Palatino Linotype", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Location = new System.Drawing.Point(522, 38);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(125, 69);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Enabled = false;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(327, 472);
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(248, 35);
            this.tb_Total_Bill.TabIndex = 9;
            this.tb_Total_Bill.Text = "0";
            this.tb_Total_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON);
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.Location = new System.Drawing.Point(106, 465);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(140, 37);
            this.lbl_Total_Bill.TabIndex = 19;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // frm_Feed_Purchase_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1339, 641);
            this.Controls.Add(this.gb_Bill_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Purchase_Details);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Feed_Purchase_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEED PURCHASE ENTRY";
            this.Load += new System.EventHandler(this.frm_Feed_Purchase_Entry_Load);
            this.gb_Purchase_Details.ResumeLayout(false);
            this.gb_Purchase_Details.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Feed_Purchase_Entry)).EndInit();
            this.gb_Bill_Details.ResumeLayout(false);
            this.gb_Bill_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Feed_Purchase_ID;
        private System.Windows.Forms.GroupBox gb_Purchase_Details;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Feed_Purchase_ID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Bag_Kg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Feed;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Sup_Name;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Bag_Qty;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Feed_Purchase_Entry;
        private System.Windows.Forms.GroupBox gb_Bill_Details;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Bag_Kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feed_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bag_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DateTimePicker dtp_Date;
    }
}