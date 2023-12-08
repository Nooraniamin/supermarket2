using BAL;
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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            lbl_cmp.Text = MDI.user;
            Retrival.loaditems("st_getroles", cmb_roles, "ID", "NAME");
            cmb_roles.SelectedIndex = -1;
            Retrival.loaditems("st_getbranch", cmb_branch, "ID", "NAME");
            cmb_branch.SelectedIndex = -1;
            Retrival.getuser(dataGridView1,id,name,cnic,g_salary,b_id,b_name,r_id,r_name,u_name,password,c_password,c_id,c_name);
        }
        int u_id;
        private void button1_Click(object sender, EventArgs e)
        {
            int branch = Convert.ToInt32(cmb_branch.SelectedValue.ToString());
            int role = Convert.ToInt32(cmb_roles.SelectedValue.ToString());
            int cnic1 = Convert.ToInt32(txt_cnic.Text.ToString());
            int salary = Convert.ToInt32(txt_salary.Text.ToString());
            BAL.user u = new BAL.user();
            if (lbl_x.Visible == true)
            {
                MessageBox.Show("Password doesn't match", "Error");
            }
            else
            {
                u.u_insert(txt_empname.Text, cnic1, salary, branch, role, txt_u_name.Text, txt_password.Text, txt_c_password.Text);
                txt_empname.Text = "";
                txt_cnic.Text = "";
                txt_salary.Text = "";
                cmb_branch.SelectedIndex = -1;
                cmb_roles.SelectedIndex = -1;
                txt_u_name.Text = "";
                txt_password.Text = "";
                txt_c_password.Text = "";
                Retrival.getuser(dataGridView1, id, name, cnic, g_salary, b_id, b_name, r_id, r_name, u_name, password, c_password, c_id, c_name);
            }

            
        }

        private void txt_c_password_TextChanged(object sender, EventArgs e)
        {
            if(txt_password.Text != txt_c_password.Text)
            {
                lbl_x.Visible = true;
            }
            else
            { 
                lbl_x.Visible = false; 
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            Mainclass.showWindow(a, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAL.user u = new BAL.user();
            u.u_delete(u_id);
            Retrival.getuser(dataGridView1, id, name, cnic, g_salary, b_id, b_name, r_id, r_name, u_name, password, c_password, c_id, c_name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int branch = Convert.ToInt32(cmb_branch.SelectedValue.ToString());
            int role = Convert.ToInt32(cmb_roles.SelectedValue.ToString());
            int cnic1 = Convert.ToInt32(txt_cnic.Text.ToString());
            int salary = Convert.ToInt32(txt_salary.Text.ToString());
            BAL.user u = new BAL.user();
            if (lbl_x.Visible == true)
            {
                MessageBox.Show("Password doesn't match", "Error");
            }
            else
            {
                u.u_update(u_id,txt_empname.Text, cnic1, salary, branch, role, txt_u_name.Text, txt_password.Text, txt_c_password.Text);
                txt_empname.Text = "";
                txt_cnic.Text = "";
                txt_salary.Text = "";
                cmb_branch.SelectedIndex = -1;
                cmb_roles.SelectedIndex = -1;
                txt_u_name.Text = "";
                txt_password.Text = "";
                txt_c_password.Text = "";
                Retrival.getuser(dataGridView1, id, name, cnic, g_salary, b_id, b_name, r_id, r_name, u_name, password, c_password, c_id, c_name);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                u_id = Convert.ToInt16(row.Cells["id"].Value.ToString());
                txt_empname.Text = row.Cells["name"].Value.ToString();
                txt_cnic.Text = row.Cells["cnic"].Value.ToString();
                txt_salary.Text = row.Cells["g_salary"].Value.ToString();
                cmb_branch.SelectedValue = row.Cells["b_id"].Value;
                cmb_roles.SelectedValue = row.Cells["r_id"].Value;
                txt_u_name.Text = row.Cells["u_name"].Value.ToString();
                txt_password.Text = row.Cells["password"].Value.ToString();
                txt_c_password.Text = row.Cells["c_password"].Value.ToString();
            }
        }

        private void lbl_cmp_Click(object sender, EventArgs e)
        {

        }
    }
}
