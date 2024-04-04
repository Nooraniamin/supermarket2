using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_base
{
    public partial class Managermenu : Form
    {
        public Managermenu()
        {
            InitializeComponent();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            User u = new User();
            Mainclass.showWindow(u, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            Mainclass.showWindow(p, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Billing b = new Billing();
            Mainclass.showWindow(b, this, MDI.ActiveForm);
        }
    }
}
