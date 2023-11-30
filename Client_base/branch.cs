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
    public partial class branch : Form
    {
        public branch()
        {
            InitializeComponent();
        }
        string id;
        private void branch_Load(object sender, EventArgs e)
        {
            lbl_cmp.Text = MDI.user;
            id = Form2.id;
            BAL.branch b  = new BAL.branch();
            Retrival.getbranch(dataGridView1, b_id, b_name, b_fid, b_fname);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            Mainclass.showWindow(m, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(id);
                BAL.branch b = new BAL.branch();
                b.b_insert(textBox1.Text, ID);
                MessageBox.Show("Insert Successfully Branch", "Success");
                Retrival.getbranch(dataGridView1, b_id, b_name, b_fid, b_fname);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"Error");
            }

        }
        private static int ad; 
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BAL.branch b = new BAL.branch();
                b.b_delete(ad);
                Retrival.getbranch(dataGridView1, b_id, b_name, b_fid, b_fname);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BAL.branch b = new BAL.branch();
            int ID = Convert.ToInt32(id);
            b.b_update(ad, textBox1.Text, ID);
            Retrival.getbranch(dataGridView1, b_id, b_name, b_fid, b_fname);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int ID;
                string name;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ad = Convert.ToInt32(row.Cells["b_id"].Value.ToString());
                textBox1.Text = row.Cells["b_name"].Value.ToString();
                ID = Convert.ToInt32(row.Cells["b_fid"].Value.ToString());
                name = row.Cells["b_fname"].Value.ToString();

            }
        }
    }
}
