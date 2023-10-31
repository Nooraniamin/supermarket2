namespace ooad_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            serverlbl = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_update = new Button();
            btn_delete = new Button();
            btn_insert = new Button();
            btn_GenKey = new Button();
            label1 = new Label();
            txt_GenKey = new TextBox();
            txt_cmpName = new TextBox();
            cmpName_lbl = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            key = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // serverlbl
            // 
            serverlbl.AutoSize = true;
            serverlbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            serverlbl.Location = new Point(424, 29);
            serverlbl.Name = "serverlbl";
            serverlbl.Size = new Size(511, 60);
            serverlbl.TabIndex = 0;
            serverlbl.Text = "SUPERMARKET SERVER";
            serverlbl.TextAlign = ContentAlignment.TopCenter;
            serverlbl.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(serverlbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1329, 151);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_insert);
            panel2.Controls.Add(btn_GenKey);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_GenKey);
            panel2.Controls.Add(txt_cmpName);
            panel2.Controls.Add(cmpName_lbl);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 391);
            panel2.Name = "panel2";
            panel2.Size = new Size(1329, 175);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(614, 131);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(485, 131);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(343, 131);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(94, 29);
            btn_insert.TabIndex = 5;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_GenKey
            // 
            btn_GenKey.Location = new Point(691, 101);
            btn_GenKey.Name = "btn_GenKey";
            btn_GenKey.Size = new Size(94, 29);
            btn_GenKey.TabIndex = 4;
            btn_GenKey.Text = "Generate";
            btn_GenKey.UseVisualStyleBackColor = true;
            btn_GenKey.Click += btn_GenKey_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 56);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 3;
            label1.Text = "Generate Key";
            label1.Click += label1_Click_1;
            // 
            // txt_GenKey
            // 
            txt_GenKey.Location = new Point(424, 63);
            txt_GenKey.Name = "txt_GenKey";
            txt_GenKey.Size = new Size(311, 27);
            txt_GenKey.TabIndex = 2;
            txt_GenKey.TextChanged += txt_GenKey_TextChanged;
            // 
            // txt_cmpName
            // 
            txt_cmpName.Location = new Point(424, 20);
            txt_cmpName.Name = "txt_cmpName";
            txt_cmpName.Size = new Size(311, 27);
            txt_cmpName.TabIndex = 1;
            txt_cmpName.TextChanged += txt_cmpName_TextChanged;
            // 
            // cmpName_lbl
            // 
            cmpName_lbl.AutoSize = true;
            cmpName_lbl.Location = new Point(266, 23);
            cmpName_lbl.Name = "cmpName_lbl";
            cmpName_lbl.Size = new Size(116, 20);
            cmpName_lbl.TabIndex = 0;
            cmpName_lbl.Text = "Company Name";
            cmpName_lbl.Click += cmpName_lbl_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(1329, 240);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, key });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1329, 240);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 450;
            // 
            // name
            // 
            name.HeaderText = "NAME";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 450;
            // 
            // key
            // 
            key.HeaderText = "KEY";
            key.MinimumWidth = 6;
            key.Name = "key";
            key.Width = 450;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 566);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server_form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label serverlbl;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txt_GenKey;
        private TextBox txt_cmpName;
        private Label cmpName_lbl;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_insert;
        private Button btn_GenKey;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn key;
    }
}