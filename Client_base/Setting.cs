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
using System.Xml;
using System.Configuration;

namespace Client_base
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        public void updateConfigFile(string con)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in xmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionString");
        }
        string connection;
        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\supermarket.txt";
        private void saveConnection()
        {
            connection = "Data Source=" + txt_server.Text + ";Initial Catalog=" + txt_database.Text + ";Persist Security Info=True;User ID=" + txt_username.Text + ";Password=" + txt_password.Text;
            StreamWriter wr = new StreamWriter(filepath);
            wr.WriteLine(connection);
            wr.Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            saveConnection();
            SignIn asd = new SignIn();
            Mainclass.showWindow(asd, this, MDI.ActiveForm);
            updateConfigFile(connection);
            DialogResult dr = MessageBox.Show("Setting saved successfully");
            ConfigurationManager.RefreshSection("connectionString");
        }
    }
}
