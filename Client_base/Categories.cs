using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client_base
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        int a = Convert.ToInt32(Form2.id);
        private void button1_Click(object sender, EventArgs e)
        {
            BAL.categories c = new BAL.categories();
            c.b_insert(txt_proname.Text, a);
            txt_proname.Text = "";
            Retrival.getcategory(dataGridView1, c_id, name, cmp_id, cmp_name);
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            Retrival.getcategory(dataGridView1, c_id, name, cmp_id, cmp_name);
        }
        int id;
        private void button2_Click(object sender, EventArgs e)
        {
            BAL.categories c = new BAL.categories();
            c.b_delete(id);
            Retrival.getcategory(dataGridView1, c_id, name, cmp_id, cmp_name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BAL.categories c = new BAL.categories();
            c.b_update(id,txt_proname.Text,a);
            Retrival.getcategory(dataGridView1, c_id, name, cmp_id, cmp_name);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Retrival.getcategory(dataGridView1, c_id, name, cmp_id, cmp_name);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string name;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["c_id"].Value.ToString());
                txt_proname.Text = row.Cells["name"].Value.ToString();
                a = Convert.ToInt32(row.Cells["cmp_id"].Value.ToString());
                name = row.Cells["cmp_name"].Value.ToString();

            }
        }
    }
}
