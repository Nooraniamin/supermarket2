using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooad_project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string random(int length)
        {
            const string key = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(key, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void btn_GeneKey_Click(object sender, EventArgs e)
        {
            if (txt_cmpName.Text == "")
            {
                MessageBox.Show("Please Enter Your Company name");
            }
            else
            {
                txt_GenKey.Text = random(6);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            MainClass.insert(txt_cmpName.Text, txt_GenKey.Text);
            MainClass.getdata(dataGridView1, id, name, key);
            txt_cmpName.Text = "";
            txt_GenKey.Text = "";
        }
        private int Id;
        private void btn_delete_Click(object sender, EventArgs e)
        {
            MainClass.delete(Id);
            MainClass.getdata(dataGridView1, id, name, key);
            Id = 0;
            txt_cmpName.Text = "";
            txt_GenKey.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainClass.getdata(dataGridView1, id, name, key);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MainClass.update(Id, txt_cmpName.Text, txt_GenKey.Text);
            MainClass.getdata(dataGridView1, id, name, key);
            Id = 0;
            txt_cmpName.Text = "";
            txt_GenKey.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                txt_cmpName.Text = row.Cells["name"].Value.ToString();
                txt_GenKey.Text = row.Cells["key"].Value.ToString();
            }
        }
    }
}
