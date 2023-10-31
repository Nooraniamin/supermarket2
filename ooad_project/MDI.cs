using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooad_project
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            StreamReader re = new StreamReader("C:\\Users\\aminm\\OneDrive\\Documents\\supermarket.txt");
            string count = null;
            while(!re.EndOfStream)
            {
                count = re.ReadLine();
            }
            re.Close();
            if (count == null)
            {
                server obj = new server();
                MainClass.showWindow(obj, this);
            }
            else
            {
                try
                {
                    Form1 Is = new Form1();
                    MainClass.showWindow(Is, this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
