namespace ooad_project
{
    partial class server
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
            panel1 = new Panel();
            serverlbl = new Label();
            lbl_server = new Label();
            lbl_database = new Label();
            txt_server = new TextBox();
            txt_database = new TextBox();
            lbl_name = new Label();
            lbl_password = new Label();
            txt_name = new TextBox();
            txt_password = new TextBox();
            btn_save = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(serverlbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 125);
            panel1.TabIndex = 0;
            // 
            // serverlbl
            // 
            serverlbl.AutoSize = true;
            serverlbl.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            serverlbl.Location = new Point(151, 32);
            serverlbl.Name = "serverlbl";
            serverlbl.Size = new Size(511, 60);
            serverlbl.TabIndex = 1;
            serverlbl.Text = "SUPERMARKET SERVER";
            serverlbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_server
            // 
            lbl_server.AutoSize = true;
            lbl_server.Location = new Point(88, 152);
            lbl_server.Name = "lbl_server";
            lbl_server.Size = new Size(94, 20);
            lbl_server.TabIndex = 1;
            lbl_server.Text = "Server Name";
            // 
            // lbl_database
            // 
            lbl_database.AutoSize = true;
            lbl_database.Location = new Point(97, 207);
            lbl_database.Name = "lbl_database";
            lbl_database.Size = new Size(72, 20);
            lbl_database.TabIndex = 2;
            lbl_database.Text = "Database";
            // 
            // txt_server
            // 
            txt_server.Location = new Point(210, 145);
            txt_server.Name = "txt_server";
            txt_server.Size = new Size(136, 27);
            txt_server.TabIndex = 3;
            // 
            // txt_database
            // 
            txt_database.Location = new Point(210, 200);
            txt_database.Name = "txt_database";
            txt_database.Size = new Size(136, 27);
            txt_database.TabIndex = 4;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(420, 152);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(75, 20);
            lbl_name.TabIndex = 5;
            lbl_name.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(425, 207);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(70, 20);
            lbl_password.TabIndex = 6;
            lbl_password.Text = "Password";
            lbl_password.Click += label4_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(523, 149);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(139, 27);
            txt_name.TabIndex = 7;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(523, 200);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(139, 27);
            txt_password.TabIndex = 8;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(291, 283);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(186, 41);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 399);
            Controls.Add(btn_save);
            Controls.Add(txt_password);
            Controls.Add(txt_name);
            Controls.Add(lbl_password);
            Controls.Add(lbl_name);
            Controls.Add(txt_database);
            Controls.Add(txt_server);
            Controls.Add(lbl_database);
            Controls.Add(lbl_server);
            Controls.Add(panel1);
            Name = "server";
            Text = "server";
            Load += server_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label serverlbl;
        private Label lbl_server;
        private Label lbl_database;
        private TextBox txt_server;
        private TextBox txt_database;
        private Label lbl_name;
        private Label lbl_password;
        private TextBox txt_name;
        private TextBox txt_password;
        private Button btn_save;
    }
}