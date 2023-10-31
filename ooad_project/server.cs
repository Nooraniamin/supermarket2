using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Configuration;

namespace ooad_project
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }
        string connection;
        string filepath = "C:\\Users\\aminm\\OneDrive\\Documents\\supermarket.txt";
        private void saveConnection()
        {
            connection = "Data Source="+txt_server.Text+";Initial Catalog="+txt_database.Text+";Persist Security Info=True;User ID="+txt_name.Text+";Password="+txt_password.Text;
            StreamWriter wr = new StreamWriter(filepath);
            wr.WriteLine(connection);
            wr.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveConnection();
            Form1 IS = new Form1();
            MainClass.showWindow(IS, this, MDI.ActiveForm);

        }

        private void server_Load(object sender, EventArgs e)
        {

        }
    }
}
