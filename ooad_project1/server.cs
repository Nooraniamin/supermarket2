using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooad_project1
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string connection;
        string filepath = "supermarket.txt";
        private void saveConnection()
        {
            connection = "Data Source=" + txt_server.Text + ";Initial Catalog=" + txt_database.Text + ";Persist Security Info=True;User ID=" + txt_username.Text + ";Password=" + txt_password.Text;
            StreamWriter wr = new StreamWriter(filepath);
            wr.WriteLine(connection);
            wr.Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            saveConnection();
            Form1 IS = new Form1();
            MainClass.showWindow(IS, this, MDI.ActiveForm);
        }
    }
}
