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
using BAL;
namespace Client_base
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string id = "1";
        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_id.Text = id;
            lbl_username.Text = MDI.user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool condition = Retrival.getemp(txt_name.Text, txt_password.Text);
            try
            {
                string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\empid and pass.txt";
                if (condition == true)
                {
                    MessageBox.Show("You Successfully login", "Success");
                    StreamWriter w = new StreamWriter(path1);
                    w.WriteLine(txt_name.Text);
                    w.WriteLine(txt_password.Text);
                    w.Close();
                    Menu asd = new Menu();
                    Mainclass.showWindow(asd, this, MDI.ActiveForm);
                }
                else
                {
                    MessageBox.Show("Invalid User and Password ", "Error");
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }
    }
}
