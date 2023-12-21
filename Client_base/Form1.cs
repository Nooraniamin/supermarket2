using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_base
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            Mainclass.showWindow(m, this, MDI.ActiveForm);
        }
        private static string random(int length)
        {
            const string key = "0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(key, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void Billing_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Retrival.name;
            lbl_cmp.Text = MDI.user;
            int a = Convert.ToInt32(Retrival.id);
            lbl_branch.Text = Retrival.branch;
            int b = Convert.ToInt32(Retrival.b_id);
            Timer timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += timer1_Tick;
            timer.Start();
            Retrival.loaditems("st_getCategories", cmb_category, "ID", "NAME");
            cmb_category.SelectedIndex = -1;
            lbl_number.Text = random(4);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cmb_product_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                Retrival.con.Open();
                SqlCommand cmd = new SqlCommand("st_getpriceWRTproduct", Retrival.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(cmb_product.SelectedValue));
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    
                    txt_price.Text = reader["Price"].ToString();
                    txt_discount.Text = reader["Discount"].ToString();
                    txt_a_discount.Text = reader["After discount"].ToString();
                }

                reader.Close();
                Retrival.con.Close();
            }
            catch (Exception ex)
            {
                Retrival.con.Close();
                MessageBox.Show(ex.Message, "Error");
            }



        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

            Retrival.loaditems("st_getMenu", cmb_product, Convert.ToInt32(cmb_category.SelectedValue), "ID", "NAME");
            cmb_product.SelectedIndex = -1;
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_qty_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_total_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_qty_Leave(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txt_a_discount.Text);
                double q = Convert.ToDouble(txt_qty.Text);
                double c = a * q;
                txt_total.Text = c.ToString();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }
        double am = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(cmb_product.Text,txt_price.Text,txt_discount.Text,txt_a_discount.Text,txt_qty.Text,txt_total.Text);
            double to = Convert.ToDouble(txt_total.Text);
            am = am + to;
            lbl_amount.Text = am.ToString();
            cmb_category.SelectedIndex = -1;
            cmb_product.SelectedIndex = -1;
            txt_price.Text = "";
            txt_discount.Text = "";
            txt_a_discount.Text = "";
            txt_qty.Text = "";
            txt_total.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            double to = Convert.ToDouble(txt_total.Text);
            am = am - to;
            lbl_amount.Text = am.ToString();
            cmb_category.SelectedIndex = -1;
            cmb_product.SelectedIndex = -1;
            txt_price.Text = "";
            txt_discount.Text = "";
            txt_a_discount.Text = "";
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["product"].Value = cmb_product.Text;
                selectedRow.Cells["price"].Value = txt_price.Text;
                selectedRow.Cells["discount"].Value = txt_discount.Text;
                selectedRow.Cells["a_discount"].Value = txt_a_discount.Text;
                selectedRow.Cells["qty"].Value = txt_qty.Text;
                selectedRow.Cells["total"].Value = txt_total.Text;
            }
            double to = Convert.ToDouble(txt_total.Text);
            
            am = am + to;
            lbl_amount.Text = am.ToString();
            cmb_category.SelectedIndex = -1;
            cmb_product.SelectedIndex = -1;
            txt_price.Text = "";
            txt_discount.Text = "";
            txt_a_discount.Text = "";
            txt_qty.Text = "";
            txt_total.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                cmb_product.Text = selectedRow.Cells["product"].Value.ToString();
                txt_price.Text = selectedRow.Cells["price"].Value.ToString();
                txt_discount.Text = selectedRow.Cells["discount"].Value.ToString();
                txt_a_discount.Text = selectedRow.Cells["a_discount"].Value.ToString();
                txt_qty.Text = selectedRow.Cells["qty"].Value.ToString();
                txt_total.Text = selectedRow.Cells["total"].Value.ToString();

                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_customer.Enabled = true;
            cmb_payment.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_payment.Text == "CASH")
            {
                txt_g_amount.Enabled = true;
                txt_finalamount.Text = am.ToString();
            }
            else 
            {
                txt_g_amount.Enabled = false;
                txt_finalamount.Text = am.ToString();
            }
        }

        private void txt_g_amount_TextChanged(object sender, EventArgs e)
        {
            double g_amount = Convert.ToDouble(txt_g_amount.Text);
            double r_amount = g_amount - am;
            txt_r_amount.Text = r_amount.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("\t\t" + lbl_cmp.Text, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(185, 10));
            e.Graphics.DrawString("Bill No: " + lbl_number.Text, new Font("Ariel", 16, FontStyle.Regular), Brushes.Black, new Point(50,50));
            e.Graphics.DrawString("_________________________________________________________________________________________________________________________", new Font("Ariel", 12, FontStyle.Regular), Brushes.Black, new Point(0, 60));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
