using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Form2_Load(object sender, EventArgs e)
        {
            
            lbl_username.Text = MDI.user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text != "Owner" || txt_password.Text != "owner")
                {
                    MessageBox.Show("Wrong, Please put right username and password", "Error");
                }
                else if (txt_name.Text == "" && txt_password.Text == "")
                {
                    MessageBox.Show("Please Fill all the entities", "Error");
                }
                else if (txt_name.Text == "Owner" && txt_password.Text == "owner")
                {
                    MessageBox.Show("You Successfully login", "Success");
                    Menu asd = new Menu();
                    Mainclass.showWindow(asd, this, MDI.ActiveForm);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
