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
using System.Xml.Linq;
using BAL;
namespace Client_base
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        private static string a;
        private static string b;
        private static string c;
        private static string d;
        public static string ea;
        public static string user
        {
            get
            {
                return a;
            }
            private set
            {
                a = value;
            }
        }
        public static string id
        {
            get { return b; }
            private set { b = value; }
        }
        
        private void MDI_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\supermarket.txt"))
            {
                Setting sa = new Setting();
                Mainclass.showWindow(sa, this);
            }
            else if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\save name and password.txt"))
            {
                SignIn ia = new SignIn();
                Mainclass.showWindow(ia, this);
            }
            else
            {
                BAL.BAL.isValidUser(a, b);
                Form2 sa = new Form2();
                Mainclass.showWindow(sa, this);
            }
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\save name and password.txt";
            //StreamReader re = new StreamReader(path);
            //int count = 0;
            //while (!re.EndOfStream)
            //{
            //    c = re.ReadLine();
            //    if (count == 0)
            //    {
            //        d = c;

            //    }
            //    else if (count == 1)
            //    {
            //        a = c;
            //    }
            //    else
            //    {
            //        b = c;
            //    }
            //    count++;
            //}
            //re.Close();







        }
    }
}
