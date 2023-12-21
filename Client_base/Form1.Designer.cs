namespace Client_base
{
    partial class Billing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_cmp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_branch = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_number = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.left_panel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_a_discount = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_product = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_g_amount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_finalamount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_r_amount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_payment = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(-1, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(135, 39);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_cmp
            // 
            this.lbl_cmp.AutoSize = true;
            this.lbl_cmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cmp.Location = new System.Drawing.Point(956, 9);
            this.lbl_cmp.Name = "lbl_cmp";
            this.lbl_cmp.Size = new System.Drawing.Size(144, 51);
            this.lbl_cmp.TabIndex = 3;
            this.lbl_cmp.Text = "lable1";
            this.lbl_cmp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_branch);
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Controls.Add(this.lbl_time);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lbl_cmp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1657, 130);
            this.panel2.TabIndex = 5;
            // 
            // lbl_branch
            // 
            this.lbl_branch.AutoSize = true;
            this.lbl_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_branch.Location = new System.Drawing.Point(970, 75);
            this.lbl_branch.Name = "lbl_branch";
            this.lbl_branch.Size = new System.Drawing.Size(83, 36);
            this.lbl_branch.TabIndex = 8;
            this.lbl_branch.Text = "labal";
            this.lbl_branch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(1524, 9);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(96, 32);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "USER";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(1524, 79);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(96, 32);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "USER";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(326, 79);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(126, 42);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "USER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_number);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 130);
            this.panel1.TabIndex = 4;
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(114, 96);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(101, 25);
            this.lbl_number.TabIndex = 10;
            this.lbl_number.Text = "BILL NO:";
            this.lbl_number.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "BILL NO:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.button4);
            this.left_panel.Controls.Add(this.button3);
            this.left_panel.Controls.Add(this.button2);
            this.left_panel.Controls.Add(this.button1);
            this.left_panel.Controls.Add(this.label7);
            this.left_panel.Controls.Add(this.txt_total);
            this.left_panel.Controls.Add(this.label6);
            this.left_panel.Controls.Add(this.txt_qty);
            this.left_panel.Controls.Add(this.label5);
            this.left_panel.Controls.Add(this.txt_a_discount);
            this.left_panel.Controls.Add(this.txt_discount);
            this.left_panel.Controls.Add(this.label4);
            this.left_panel.Controls.Add(this.txt_price);
            this.left_panel.Controls.Add(this.label3);
            this.left_panel.Controls.Add(this.cmb_product);
            this.left_panel.Controls.Add(this.label2);
            this.left_panel.Controls.Add(this.cmb_category);
            this.left_panel.Controls.Add(this.label1);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 130);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(317, 748);
            this.left_panel.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(117, 629);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Done";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 579);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "TOTAL PRICE";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(12, 528);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(278, 22);
            this.txt_total.TabIndex = 12;
            this.txt_total.Leave += new System.EventHandler(this.txt_total_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "QUANITITY";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(12, 456);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(278, 22);
            this.txt_qty.TabIndex = 10;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.Enter += new System.EventHandler(this.txt_qty_Enter);
            this.txt_qty.Leave += new System.EventHandler(this.txt_qty_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "AFTER DISCOUNT";
            // 
            // txt_a_discount
            // 
            this.txt_a_discount.Enabled = false;
            this.txt_a_discount.Location = new System.Drawing.Point(12, 383);
            this.txt_a_discount.Name = "txt_a_discount";
            this.txt_a_discount.Size = new System.Drawing.Size(278, 22);
            this.txt_a_discount.TabIndex = 8;
            // 
            // txt_discount
            // 
            this.txt_discount.Enabled = false;
            this.txt_discount.Location = new System.Drawing.Point(12, 305);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(278, 22);
            this.txt_discount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "DISCOUNT";
            // 
            // txt_price
            // 
            this.txt_price.Enabled = false;
            this.txt_price.Location = new System.Drawing.Point(17, 232);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(278, 22);
            this.txt_price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRICE";
            // 
            // cmb_product
            // 
            this.cmb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Location = new System.Drawing.Point(17, 155);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(278, 24);
            this.cmb_product.TabIndex = 3;
            this.cmb_product.SelectedIndexChanged += new System.EventHandler(this.cmb_product_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUCT";
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(17, 73);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(278, 24);
            this.cmb_category.TabIndex = 1;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIES";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.txt_g_amount);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.txt_finalamount);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txt_customer);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_r_amount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cmb_payment);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lbl_amount);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(317, 619);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1340, 259);
            this.panel3.TabIndex = 7;
            // 
            // txt_g_amount
            // 
            this.txt_g_amount.Enabled = false;
            this.txt_g_amount.Location = new System.Drawing.Point(948, 66);
            this.txt_g_amount.Name = "txt_g_amount";
            this.txt_g_amount.Size = new System.Drawing.Size(278, 22);
            this.txt_g_amount.TabIndex = 30;
            this.txt_g_amount.TextChanged += new System.EventHandler(this.txt_g_amount_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(737, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 29);
            this.label15.TabIndex = 31;
            this.label15.Text = "GIVING AMOUNT";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(905, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txt_finalamount
            // 
            this.txt_finalamount.Enabled = false;
            this.txt_finalamount.Location = new System.Drawing.Point(485, 209);
            this.txt_finalamount.Name = "txt_finalamount";
            this.txt_finalamount.Size = new System.Drawing.Size(278, 22);
            this.txt_finalamount.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(288, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "FINAL AMOUNT";
            // 
            // txt_customer
            // 
            this.txt_customer.Enabled = false;
            this.txt_customer.Location = new System.Drawing.Point(555, 161);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(278, 22);
            this.txt_customer.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(288, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "CUSTOMER NUMBER";
            // 
            // txt_r_amount
            // 
            this.txt_r_amount.Enabled = false;
            this.txt_r_amount.Location = new System.Drawing.Point(519, 112);
            this.txt_r_amount.Name = "txt_r_amount";
            this.txt_r_amount.Size = new System.Drawing.Size(278, 22);
            this.txt_r_amount.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(288, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 29);
            this.label11.TabIndex = 25;
            this.label11.Text = "RETURN AMOUNT";
            // 
            // cmb_payment
            // 
            this.cmb_payment.Enabled = false;
            this.cmb_payment.FormattingEnabled = true;
            this.cmb_payment.Items.AddRange(new object[] {
            "CASH",
            "CREDIT CARD"});
            this.cmb_payment.Location = new System.Drawing.Point(440, 67);
            this.cmb_payment.Name = "cmb_payment";
            this.cmb_payment.Size = new System.Drawing.Size(278, 24);
            this.cmb_payment.TabIndex = 23;
            this.cmb_payment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "PAYEMENT";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(507, 16);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(118, 29);
            this.lbl_amount.TabIndex = 23;
            this.lbl_amount.Text = "AMOUNT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "AMOUNT";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(317, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1340, 489);
            this.panel4.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.price,
            this.discount,
            this.a_discount,
            this.qty,
            this.total});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1340, 489);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // product
            // 
            this.product.HeaderText = "PRODUCT";
            this.product.MinimumWidth = 6;
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 200;
            // 
            // discount
            // 
            this.discount.HeaderText = "DISCOUNT";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 200;
            // 
            // a_discount
            // 
            this.a_discount.HeaderText = "AFTER DISCOUNT";
            this.a_discount.MinimumWidth = 6;
            this.a_discount.Name = "a_discount";
            this.a_discount.ReadOnly = true;
            this.a_discount.Width = 200;
            // 
            // qty
            // 
            this.qty.HeaderText = "QUAINTITY";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 200;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL PRICE";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 200;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1062, 209);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "PRINT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 878);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.panel2);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_cmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.ComboBox cmb_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_a_discount;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_r_amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_payment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_finalamount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_branch;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_g_amount;
        private System.Windows.Forms.Label label15;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button6;
    }
}