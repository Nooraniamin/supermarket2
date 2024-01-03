namespace Client_base
{
    partial class Products
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_a_discount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cmp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_proname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productSettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1376, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productSettingToolStripMenuItem
            // 
            this.productSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem});
            this.productSettingToolStripMenuItem.Name = "productSettingToolStripMenuItem";
            this.productSettingToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.productSettingToolStripMenuItem.Text = "Product setting";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(118, 551);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 19;
            this.Refresh.Text = "&Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_a_discount
            // 
            this.txt_a_discount.Enabled = false;
            this.txt_a_discount.Location = new System.Drawing.Point(14, 459);
            this.txt_a_discount.Name = "txt_a_discount";
            this.txt_a_discount.Size = new System.Drawing.Size(275, 22);
            this.txt_a_discount.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "AFTER DISCOUNT";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(12, 308);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(275, 22);
            this.txt_amount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "AMOUNT";
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(12, 233);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(270, 24);
            this.cmb_category.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "CATEGORY";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(310, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 651);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.c_id,
            this.c_name,
            this.amount,
            this.discount,
            this.a_discount,
            this.cmp_id,
            this.cmp_name});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 651);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "PRODUCT NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // c_id
            // 
            this.c_id.HeaderText = "b_id";
            this.c_id.MinimumWidth = 6;
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Visible = false;
            this.c_id.Width = 125;
            // 
            // c_name
            // 
            this.c_name.HeaderText = "CATEGORY";
            this.c_name.MinimumWidth = 6;
            this.c_name.Name = "c_name";
            this.c_name.ReadOnly = true;
            this.c_name.Width = 250;
            // 
            // amount
            // 
            this.amount.HeaderText = "AMOUNT";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 250;
            // 
            // discount
            // 
            this.discount.HeaderText = "DISCOUNT";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 250;
            // 
            // a_discount
            // 
            this.a_discount.HeaderText = "AFTER DISCOUNT";
            this.a_discount.MinimumWidth = 6;
            this.a_discount.Name = "a_discount";
            this.a_discount.ReadOnly = true;
            this.a_discount.Width = 250;
            // 
            // cmp_id
            // 
            this.cmp_id.HeaderText = "cmp_id";
            this.cmp_id.MinimumWidth = 6;
            this.cmp_id.Name = "cmp_id";
            this.cmp_id.ReadOnly = true;
            this.cmp_id.Visible = false;
            this.cmp_id.Width = 125;
            // 
            // cmp_name
            // 
            this.cmp_name.HeaderText = "cmp_name";
            this.cmp_name.MinimumWidth = 6;
            this.cmp_name.Name = "cmp_name";
            this.cmp_name.ReadOnly = true;
            this.cmp_name.Visible = false;
            this.cmp_name.Width = 125;
            // 
            // lbl_cmp
            // 
            this.lbl_cmp.AutoSize = true;
            this.lbl_cmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cmp.Location = new System.Drawing.Point(457, 45);
            this.lbl_cmp.Name = "lbl_cmp";
            this.lbl_cmp.Size = new System.Drawing.Size(144, 51);
            this.lbl_cmp.TabIndex = 1;
            this.lbl_cmp.Text = "lable1";
            this.lbl_cmp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_cmp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(310, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 139);
            this.panel2.TabIndex = 4;
            // 
            // txt_proname
            // 
            this.txt_proname.Location = new System.Drawing.Point(12, 164);
            this.txt_proname.Name = "txt_proname";
            this.txt_proname.Size = new System.Drawing.Size(275, 22);
            this.txt_proname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCT NAME";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(135, 39);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_a_discount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_discount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_category);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_proname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 790);
            this.panel1.TabIndex = 3;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(14, 382);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(275, 22);
            this.txt_discount.TabIndex = 13;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            this.txt_discount.Leave += new System.EventHandler(this.txt_discount_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "DISCOUNT";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 820);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_a_discount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_cmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_proname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmp_name;
    }
}