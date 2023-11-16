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
    }
}
