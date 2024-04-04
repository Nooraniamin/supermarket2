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
                return d;
            }
            private set
            {
                d = value;
            }
        }
        public static string id
        {
            get { return b; }
            private set { b = value; }
        }
        
        private void MDI_Load(object sender, EventArgs e)
        {
            try
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
                else if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\save name and password.txt"))
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\save name and password.txt";
                    StreamReader re = new StreamReader(path);
                    int count = 0;
                    while (!re.EndOfStream)
                    {
                        c = re.ReadLine();
                        if (count == 0)
                        {
                            user = c;

                        }
                        else if (count == 1)
                        {
                            id = c;
                        }
                        count++;
                    }
                    re.Close();
                    bool condition = Retrival.isValidUser(user, id);
                    if (condition == true)
                    {
                        if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\empid and pass.txt"))
                        {
                            Form2 form = new Form2();
                            Mainclass.showWindow(form, this);
                        }
                        else
                        {
                            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\empid and pass.txt";
                            StreamReader rea = new StreamReader(path1);
                            int count1 = 0;
                            while (!rea.EndOfStream)
                            {
                                c = rea.ReadLine();
                                if (count1 == 0)
                                {
                                    b = c;

                                }
                                else if (count1 == 1)
                                {
                                    ea = c;
                                }
                                count1++;
                            }
                            re.Close();
                            bool condition1 = Retrival.getemp(b, ea);
                            if (condition1 != true)
                            {
                                Form2 f = new Form2();
                                Mainclass.showWindow(f, this);
                            }
                            
                            
                        }
                    }
                    else
                    {
                        SignIn signIn = new SignIn();
                        Mainclass.showWindow(signIn, this);
                    }
                    
                    
                }
            }
            catch(Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
