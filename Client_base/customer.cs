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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            lbl_cmp.Text = MDI.user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAL.customer c = new BAL.customer();
            c.cus_insert(textBox1.Text,textBox2.Text);
            this.Close();
        }
    }
}
