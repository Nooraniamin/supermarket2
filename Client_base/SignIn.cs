using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BAL;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;

namespace Client_base
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        public void updateConfigFile(string name,string pass)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in xmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    xElement.FirstChild.Attributes[2].Value = name;
                    xElement.FirstChild.Attributes[3].Value = pass;
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionString");
        }
        public static string id;
        private void button1_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();

            Retrival.isValidUser(txt_cmpName.Text, txt_password.Text);
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            //StreamReader re = new StreamReader("supermarket.txt");
            //while (!re.EndOfStream)
            //{
            //    path1 = re.ReadLine();
           // }
            //re.Close();
        }
    }
}
