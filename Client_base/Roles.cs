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
namespace Client_base
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }
        int a = Convert.ToInt32(Form2.id);
        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu asd = new Menu();
            Mainclass.showWindow(asd,this,MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAL.roles roles = new BAL.roles();
            roles.b_insert(textBox1.Text, a);
            Retrival.getRoles(dataGridView1, b_id, b_name, b_fid, b_fname);
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            lbl_cmp.Text = MDI.user;
            Retrival.getRoles(dataGridView1, b_id, b_name, b_fid, b_fname);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Retrival.getRoles(dataGridView1, b_id, b_name, b_fid, b_fname);
        }
        int id;
        private void button2_Click(object sender, EventArgs e)
        {
            BAL.roles r = new BAL.roles();
            r.b_delete(id);
            Retrival.getRoles(dataGridView1, b_id, b_name, b_fid, b_fname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BAL.roles r = new BAL.roles();
            r.b_update(id,textBox1.Text,a);
            Retrival.getRoles(dataGridView1, b_id, b_name, b_fid, b_fname);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string name;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["b_id"].Value.ToString());
                textBox1.Text = row.Cells["b_name"].Value.ToString();
                a = Convert.ToInt32(row.Cells["b_fid"].Value.ToString());
                name = row.Cells["b_fname"].Value.ToString();

            }
        }
    }
}
