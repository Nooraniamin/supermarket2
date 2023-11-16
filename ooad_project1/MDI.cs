using ooad_project1.Properties;
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
using System.IO;
namespace ooad_project1
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            server sa = new server();
            MainClass.showWindow(sa, this);
        }
        private string path;
        private void MDI_Load(object sender, EventArgs e)
        {
            StreamReader re = new StreamReader("supermarket.txt");
            while (!re.EndOfStream)
            {
                path = re.ReadLine();
            }
            re.Close();
            if (path == null)
            {
                server obj = new server();
                MainClass.showWindow(obj, this);
            }
            else
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\save name and password.txt";
                StreamWriter wr = new StreamWriter(path);
                try
                {
                    Form1 Is = new Form1();
                    MainClass.showWindow(Is, this);
                }
                catch (Exception ex)
                {
                    wr.WriteLine("");
                    MessageBox.Show(ex.Message);
                    wr.Close();
                }

            }
        }
    }
}
