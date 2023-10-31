namespace ooad_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private static string random(int length)
        {
            const string key = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(key, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void btn_GenKey_Click(object sender, EventArgs e)
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
        }
        private int Id;
        private void Form1_Load(object sender, EventArgs e)
        {
            MainClass.getdata(dataGridView1, id, name, key);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MainClass.delete(Id);
            MainClass.getdata(dataGridView1, id, name, key);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MainClass.update(Id, txt_cmpName.Text, txt_GenKey.Text);
            MainClass.getdata(dataGridView1, id, name, key);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                txt_cmpName.Text = row.Cells["id"].Value.ToString();
                txt_GenKey.Text = row.Cells["id"].Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void txt_GenKey_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_cmpName_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmpName_lbl_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}