using BAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client_base
{
    public partial class Counter : Form
    {
        public Counter()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            Mainclass.showWindow(m, this, MDI.ActiveForm);
        }
        private static string random(int length)
        {
            const string key = "0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(key, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        int a;
        int b;
        private void Counter_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Retrival.name;
            lbl_cmp.Text = MDI.user;
            a = Convert.ToInt32(Retrival.uid);
            lbl_branch.Text = Retrival.branch;
            b = Convert.ToInt32(Retrival.b_id);
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
            Retrival.loaditems("st_getproduct", cmb_product, "ID", "NAME");
            cmb_product.SelectedIndex = -1;
            lbl_number.Text = random(4);
            Retrival.getitems(Convert.ToInt32(lbl_number.Text), dataGridView1, id, p_id, product, price, discount, a_discount, qty, total);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        double am = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            BAL.item item = new BAL.item();
            item.i_insert(Convert.ToInt32(lbl_number.Text), Convert.ToInt32(cmb_product.SelectedValue), Convert.ToDouble(txt_price.Text), Convert.ToDouble(txt_discount.Text), Convert.ToDouble(txt_a_discount.Text), Convert.ToInt32(txt_qty.Text), Convert.ToInt32(txt_total.Text), b, a, lbl_date.Text);
            Retrival.getitems(Convert.ToInt32(lbl_number.Text), dataGridView1, id, p_id, product, price, discount, a_discount, qty, total);
            double to = Convert.ToDouble(txt_total.Text);
            am = am + to;
            lbl_amount.Text = am.ToString();
            cmb_product.SelectedIndex = -1;
            txt_price.Text = "";
            txt_discount.Text = "";
            txt_a_discount.Text = "";
            txt_qty.Text = "";
            txt_total.Text = "";

        }
        int i_id;
        private void button2_Click(object sender, EventArgs e)
        {
            BAL.item item = new BAL.item();
            item.i_delete(i_id);
            double to = Convert.ToDouble(txt_total.Text);
            Retrival.getitems(Convert.ToInt32(lbl_number.Text), dataGridView1, id, p_id, product, price, discount, a_discount, qty, total);
            am = am - to;
            lbl_amount.Text = am.ToString();
            cmb_product.SelectedIndex = -1;
            txt_price.Text = "";
            txt_discount.Text = "";
            txt_a_discount.Text = "";
            txt_qty.Text = "";
            txt_total.Text = "";
        }
        double temp;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BAL.item item = new BAL.item();
                item.i_update(i_id, Convert.ToInt32(lbl_number.Text), Convert.ToInt32(cmb_product.SelectedValue), Convert.ToDouble(txt_price.Text), Convert.ToDouble(txt_discount.Text), Convert.ToDouble(txt_a_discount.Text), Convert.ToInt32(txt_qty.Text), Convert.ToInt32(txt_total.Text), b, a, lbl_date.Text);
                double to = Convert.ToDouble(txt_total.Text);

                if (to > temp)
                {
                    am = am - to;
                }
                else
                {
                    am = am + to;
                }
                temp = to;
                Retrival.getitems(Convert.ToInt32(lbl_number.Text), dataGridView1, id, p_id, product, price, discount, a_discount, qty, total);
                lbl_amount.Text = am.ToString();
                cmb_product.SelectedIndex = -1;
                txt_price.Text = "";
                txt_discount.Text = "";
                txt_a_discount.Text = "";
                txt_qty.Text = "";
                txt_total.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                i_id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                cmb_product.SelectedValue = row.Cells["p_id"].Value.ToString();
                txt_price.Text = row.Cells["price"].Value.ToString();
                txt_discount.Text = row.Cells["discount"].Value.ToString();
                txt_a_discount.Text = row.Cells["a_discount"].Value.ToString();
                txt_qty.Text = row.Cells["qty"].Value.ToString();
                txt_total.Text = row.Cells["total"].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_customer.Enabled = true;
            cmb_payment.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment.Text == "CASH")
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
            try
            {
                double g_amount = Convert.ToDouble(txt_g_amount.Text);
                double r_amount = g_amount - am;
                txt_r_amount.Text = r_amount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("\t\t" + lbl_cmp.Text, new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(185, 10));
            e.Graphics.DrawString("Bill No: " + lbl_number.Text, new Font("Ariel", 16, FontStyle.Regular), Brushes.Black, new Point(50, 50));
            e.Graphics.DrawString("Cashier: " + lbl_username.Text, new Font("Ariel", 16, FontStyle.Regular), Brushes.Black, new Point(650, 50));
            e.Graphics.DrawString("Date: " + lbl_date.Text, new Font("Ariel", 16, FontStyle.Regular), Brushes.Black, new Point(50, 80));
            e.Graphics.DrawString("_________________________________________________________________________________________________________________________", new Font("Ariel", 12, FontStyle.Regular), Brushes.Black, new Point(0, 100));
            e.Graphics.DrawString("Product Name\tDiscount\tPrice\tqty\tTotal", new Font("Ariel", 16, FontStyle.Regular), Brushes.Black, new Point(0, 120));
            SqlCommand cmd = new SqlCommand("st_getitems", Retrival.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@billno", Convert.ToInt32(lbl_number.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Retrival.con.Open();
            try
            {
                string p = dt.Columns["Product"].ToString();
                string dis = dt.Columns["discount"].ToString();
                string pri = dt.Columns["after amount"].ToString();
                string q = dt.Columns["qty"].ToString();
                string tol = dt.Columns["total"].ToString();
                e.Graphics.DrawString(p + "\t" + dis + "\t" + pri + "\t" + q + "\t" + tol, new Font("Ariel", 12, FontStyle.Regular), Brushes.Black, new Point(0, 160));
                Retrival.con.Close();
            }
            catch (Exception ex)
            {
                Retrival.con.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        string cusname;
        int csid;
        private void txt_customer_Leave(object sender, EventArgs e)
        {
            if (Retrival.cus(txt_customer.Text) == true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("st_getcusWRTphone", Retrival.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@phone", txt_customer.Text);
                    Retrival.con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (txt_customer.Text == reader["phone"].ToString())
                            {

                                csid = Convert.ToInt32(reader["id"].ToString());
                                cusname = reader["name"].ToString();

                            }
                        }
                    }
                    reader.Close();
                    Retrival.con.Close();
                    MessageBox.Show(cusname);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    Retrival.con.Close();
                }
            }
            else
            {
                customer c = new customer();
                c.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cmb_payment.SelectedIndex == 1)
            {
                BAL.bill bill = new BAL.bill();
                bill.bill_insert(Convert.ToInt32(lbl_number.Text), cmb_payment.Text, Convert.ToDouble(lbl_amount.Text), csid, b);
                MessageBox.Show("SuccessFul");
            }
            else
            {
                BAL.bill bill = new BAL.bill();
                bill.bill_insert(Convert.ToInt32(lbl_number.Text), cmb_payment.Text, Convert.ToDouble(lbl_amount.Text), csid, b, Convert.ToDouble(txt_g_amount.Text), Convert.ToDouble(txt_r_amount.Text));
                MessageBox.Show("SuccessFul");
            }
            lbl_number.Text = random(4);
            txt_g_amount.Text = "";
            txt_r_amount.Text = "";
            cmb_payment.SelectedIndex = -1;
            txt_finalamount.Text = "";
            txt_customer.Text = "";
            Retrival.getitems(Convert.ToInt32(lbl_number.Text), dataGridView1, id, p_id, product, price, discount, a_discount, qty, total);
        }

        
    }
}
