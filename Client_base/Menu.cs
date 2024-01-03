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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_branch_Click(object sender, EventArgs e)
        {
            branch b = new branch();
            Mainclass.showWindow(b, this, MDI.ActiveForm);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_roles_Click(object sender, EventArgs e)
        {
            Roles roles = new Roles();
            Mainclass.showWindow(roles, this, MDI.ActiveForm);
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            User asd = new User();
            Mainclass.showWindow(asd,this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            Mainclass.showWindow(p, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Billing b = new Billing();
            Mainclass.showWindow(b,this, MDI.ActiveForm);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\empid and pass.txt";
            StreamWriter w = new StreamWriter(path);
            w.WriteLine("");
            w.WriteLine("");
            w.Close();
            Form2 f = new Form2();
            Mainclass.showWindow(f,this,MDI.ActiveForm);
        }
    }
}
