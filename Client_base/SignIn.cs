using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BAL;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;

namespace Client_base
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\save name and password.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            Retrival.isValidUser(txt_cmpName.Text, txt_password.Text);
            StreamWriter wr = new StreamWriter(path);
            wr.WriteLine(txt_cmpName.Text);
            wr.WriteLine(txt_password.Text);
            wr.Close();
            
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            //StreamReader re = new StreamReader("supermarket.txt");
            //while (!re.EndOfStream)
            //{
            //    path1 = re.ReadLine();
           // }
            //re.Close();
        }
    }
}
