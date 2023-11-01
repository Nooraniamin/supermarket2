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
namespace Client_base
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BAL.BAL.isValidUser(txt_cmpName.Text, txt_password.Text);
                MessageBox.Show("Success");
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\save name and password.txt";
                StreamWriter wr = new StreamWriter(path);
                wr.WriteLine(txt_cmpName.Text);
                wr.Write(txt_password.Text);
                wr.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }
    }
}
