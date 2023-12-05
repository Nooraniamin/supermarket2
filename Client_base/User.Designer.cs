namespace Client_base
{
    partial class User
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_cmp = new System.Windows.Forms.Label();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cnic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_branch = new System.Windows.Forms.ComboBox();
            this.cmb_roles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_u_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_c_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_c_password);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_u_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_roles);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_branch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_cnic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_empname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 716);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_cmp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 140);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(310, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 576);
            this.panel3.TabIndex = 2;
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
            // txt_empname
            // 
            this.txt_empname.Location = new System.Drawing.Point(12, 164);
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(275, 22);
            this.txt_empname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPLOYEE NAME";
            // 
            // txt_cnic
            // 
            this.txt_cnic.Location = new System.Drawing.Point(12, 241);
            this.txt_cnic.MaxLength = 13;
            this.txt_cnic.Name = "txt_cnic";
            this.txt_cnic.Size = new System.Drawing.Size(275, 22);
            this.txt_cnic.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "BRANCH";
            // 
            // cmb_branch
            // 
            this.cmb_branch.FormattingEnabled = true;
            this.cmb_branch.Location = new System.Drawing.Point(12, 310);
            this.cmb_branch.Name = "cmb_branch";
            this.cmb_branch.Size = new System.Drawing.Size(270, 24);
            this.cmb_branch.TabIndex = 7;
            // 
            // cmb_roles
            // 
            this.cmb_roles.FormattingEnabled = true;
            this.cmb_roles.Location = new System.Drawing.Point(12, 384);
            this.cmb_roles.Name = "cmb_roles";
            this.cmb_roles.Size = new System.Drawing.Size(270, 24);
            this.cmb_roles.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "ROLES";
            // 
            // txt_u_name
            // 
            this.txt_u_name.Location = new System.Drawing.Point(12, 459);
            this.txt_u_name.Name = "txt_u_name";
            this.txt_u_name.Size = new System.Drawing.Size(275, 22);
            this.txt_u_name.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "UNIQUE NAME";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 525);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(275, 22);
            this.txt_password.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "PASSWORD";
            // 
            // txt_c_password
            // 
            this.txt_c_password.Location = new System.Drawing.Point(12, 593);
            this.txt_c_password.Name = "txt_c_password";
            this.txt_c_password.Size = new System.Drawing.Size(275, 22);
            this.txt_c_password.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "CONFIRM PASSWORD";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(116, 685);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 19;
            this.Refresh.Text = "&Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 621);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.cnic,
            this.b_id,
            this.b_name,
            this.r_id,
            this.r_name,
            this.u_name,
            this.password,
            this.c_password,
            this.c_id,
            this.c_name});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 576);
            this.dataGridView1.TabIndex = 0;
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
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // cnic
            // 
            this.cnic.HeaderText = "CNIC";
            this.cnic.MinimumWidth = 6;
            this.cnic.Name = "cnic";
            this.cnic.ReadOnly = true;
            this.cnic.Width = 200;
            // 
            // b_id
            // 
            this.b_id.HeaderText = "b_id";
            this.b_id.MinimumWidth = 6;
            this.b_id.Name = "b_id";
            this.b_id.ReadOnly = true;
            this.b_id.Visible = false;
            this.b_id.Width = 125;
            // 
            // b_name
            // 
            this.b_name.HeaderText = "BRANCH";
            this.b_name.MinimumWidth = 6;
            this.b_name.Name = "b_name";
            this.b_name.ReadOnly = true;
            this.b_name.Width = 200;
            // 
            // r_id
            // 
            this.r_id.HeaderText = "r_id";
            this.r_id.MinimumWidth = 6;
            this.r_id.Name = "r_id";
            this.r_id.ReadOnly = true;
            this.r_id.Visible = false;
            this.r_id.Width = 125;
            // 
            // r_name
            // 
            this.r_name.HeaderText = "ROLE";
            this.r_name.MinimumWidth = 6;
            this.r_name.Name = "r_name";
            this.r_name.ReadOnly = true;
            this.r_name.Width = 200;
            // 
            // u_name
            // 
            this.u_name.HeaderText = "UNIQUE NAME";
            this.u_name.MinimumWidth = 6;
            this.u_name.Name = "u_name";
            this.u_name.ReadOnly = true;
            this.u_name.Width = 200;
            // 
            // password
            // 
            this.password.HeaderText = "PASSWORD";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 200;
            // 
            // c_password
            // 
            this.c_password.HeaderText = "CONFIRM PASSWORD";
            this.c_password.MinimumWidth = 6;
            this.c_password.Name = "c_password";
            this.c_password.ReadOnly = true;
            this.c_password.Width = 200;
            // 
            // c_id
            // 
            this.c_id.HeaderText = "c_id";
            this.c_id.MinimumWidth = 6;
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Visible = false;
            this.c_id.Width = 125;
            // 
            // c_name
            // 
            this.c_name.HeaderText = "c_name";
            this.c_name.MinimumWidth = 6;
            this.c_name.Name = "c_name";
            this.c_name.ReadOnly = true;
            this.c_name.Visible = false;
            this.c_name.Width = 125;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 716);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_cmp;
        private System.Windows.Forms.TextBox txt_cnic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_c_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_u_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_roles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_branch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_name;
    }
}