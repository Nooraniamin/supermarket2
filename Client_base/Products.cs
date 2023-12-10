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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            Mainclass.showWindow(m, this, MDI.ActiveForm);
        }

        private void Products_Load(object sender, EventArgs e)
        {
            lbl_cmp.Text = MDI.user;
            Retrival.getproduct(dataGridView1, id, name, c_id, c_name, amount, discount, a_discount, cmp_id, cmp_name);
            Retrival.loaditems("st_getCategories", cmb_category, "ID", "NAME");
            cmb_category.SelectedIndex = -1;
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAL.product p = new BAL.product();
            p.p_insert(txt_proname.Text,Convert.ToInt32(cmb_category.SelectedValue), Convert.ToDouble(txt_amount.Text), Convert.ToDouble(txt_discount.Text), Convert.ToDouble(txt_a_discount.Text));
            Retrival.getproduct(dataGridView1, id, name, c_id, c_name, amount, discount, a_discount, cmp_id, cmp_name);
            txt_proname.Text = "";
            cmb_category.SelectedIndex = -1;
            txt_amount.Text = "";
            txt_discount.Text = "";
            txt_a_discount.Text = "";
        }
        int p_id;
        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_discount_Leave(object sender, EventArgs e)
        {
            int originalPrice = 0;
            double discount, discountGiven, SalePrice;
            originalPrice = Convert.ToInt32(txt_amount.Text);
            discount = Convert.ToInt32(txt_discount.Text);
            discountGiven = originalPrice * (discount / 100);
            SalePrice = originalPrice - discountGiven;
            txt_a_discount.Text = SalePrice.ToString();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Retrival.getproduct(dataGridView1, id, name, c_id, c_name, amount, discount, a_discount, cmp_id, cmp_name);
            Retrival.loaditems("st_getCategories", cmb_category, "ID", "NAME");
            cmb_category.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAL.product p = new BAL.product();
            p.p_delete(p_id);
            Retrival.getproduct(dataGridView1, id, name, c_id, c_name, amount, discount, a_discount, cmp_id, cmp_name);
            txt_proname.Text = "";
            cmb_category.SelectedIndex = -1;
            txt_amount.Text = "";
            txt_discount.Text = "";
            txt_a_discount.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BAL.product p = new BAL.product();
            p.p_update(p_id,txt_proname.Text, Convert.ToInt32(cmb_category.SelectedValue), Convert.ToDouble(txt_amount.Text), Convert.ToDouble(txt_discount.Text), Convert.ToDouble(txt_a_discount.Text));
            Retrival.getproduct(dataGridView1, id, name, c_id, c_name, amount, discount, a_discount, cmp_id, cmp_name);
            txt_proname.Text = "";
            cmb_category.SelectedIndex = -1;
            txt_amount.Text = "";
            txt_discount.Text = "";
            txt_a_discount.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                p_id = Convert.ToInt32(row.Cells["c_id"].Value.ToString());
                txt_proname.Text = row.Cells["name"].Value.ToString();
                cmb_category.SelectedValue = row.Cells["c_id"].Value;
                txt_amount.Text= row.Cells["amount"].Value.ToString();
                txt_discount.Text = row.Cells["discount"].Value.ToString();
                txt_a_discount.Text = row.Cells["a_discount"].Value.ToString();

            }
        }
    }
}
