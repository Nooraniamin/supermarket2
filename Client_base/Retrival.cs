using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BAL;
using System.Xml.Linq;

namespace Client_base
{
    internal class Retrival
    {
        private static string id;
        public static string uid;
        public static string cmp_id 
        {
            get 
            {
                return id;
            }
            private set 
            {
                id = value;
            }
        }
        public static string path;
        private static string connection()
        {
            StreamReader re = new StreamReader("supermarket.txt");
            while (!re.EndOfStream)
            {
                path = re.ReadLine();
            }
            re.Close();
            return path;
        }
        public static SqlConnection con = new SqlConnection(connection());
        public static void getbranch(DataGridView gv, DataGridViewColumn IDGV, DataGridViewColumn NameGV,DataGridViewColumn ID,DataGridViewColumn NAME)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("st_getbranch", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                IDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["NAME"].ToString();
                ID.DataPropertyName = dt.Columns["BRANCH ID"].ToString();
                NAME.DataPropertyName = dt.Columns["BRNCH NAME"].ToString();
                gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public static void getRoles(DataGridView gv, DataGridViewColumn IDGV, DataGridViewColumn NameGV, DataGridViewColumn ID, DataGridViewColumn NAME)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("st_getroles", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                IDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["NAME"].ToString();
                ID.DataPropertyName = dt.Columns["COMPANY ID"].ToString();
                NAME.DataPropertyName = dt.Columns["COMPANY NAME"].ToString();
                gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public static void getuser(DataGridView gv,DataGridViewColumn ID,DataGridViewColumn name,DataGridViewColumn cnic,DataGridViewColumn salary,DataGridViewColumn b_id,DataGridViewColumn branch, DataGridViewColumn r_id, DataGridViewColumn role,DataGridViewColumn u_name,DataGridViewColumn pass, DataGridViewColumn c_pass,DataGridViewColumn c_id, DataGridViewColumn c_name)
        {
            try
            {
                int cmp = 1;
                con.Open();
                SqlCommand cmd = new SqlCommand("st_getusers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cmp);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ID.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["NAME"].ToString();
                cnic.DataPropertyName = dt.Columns["CNIC"].ToString();
                salary.DataPropertyName = dt.Columns["SALARY"].ToString();
                b_id.DataPropertyName = dt.Columns["B_ID"].ToString();
                branch.DataPropertyName = dt.Columns["BRANCH"].ToString();
                r_id.DataPropertyName = dt.Columns["R_ID"].ToString();
                role.DataPropertyName = dt.Columns["ROLES"].ToString();
                u_name.DataPropertyName = dt.Columns["U_NAME"].ToString();
                pass.DataPropertyName = dt.Columns["PASSWORD"].ToString();
                c_pass.DataPropertyName = dt.Columns["C_PASSWORD"].ToString();
                c_id.DataPropertyName = dt.Columns["C_ID"].ToString();
                c_name.DataPropertyName = dt.Columns["COMPANY NAME"].ToString();
                gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public static bool isValidUser(string user, string pass)
        {
            bool status = false;
            try
            {

                SqlCommand cmd = new SqlCommand("st_getcompany", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (user == reader["Name"].ToString() && pass == reader["Key"].ToString())
                        {
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\save name and password.txt";
                            id = reader["ID"].ToString();
                            MessageBox.Show("SuccessFully");
                            status = true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid User and Password ", "Error");
                            status = false;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User and Password ", "Error");
                    status = false;

                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                con.Close();
            }
            return status;
        }
        public static string name;
        public static string branch;
        public static string b_id;
        public static bool getemp(string user, string pass)
        {
            bool status = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getlogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Parameters.AddWithValue("@name", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (user == reader["NAME"].ToString() && pass == reader["PASSWORD"].ToString())
                        {
                            
                            uid = reader["ID"].ToString();
                            string role = reader["ROLES"].ToString();
                            name = reader["NAME"].ToString();
                            branch = reader["BRANCH"].ToString();
                            b_id = reader["B_ID"].ToString();
                            status = true;
                            if(role == "Owner")
                            {
                                Menu m = new Menu();
                                Mainclass.showWindow(m, MDI.ActiveForm);
                                
                            }
                            else if(role == "Manager")
                            {
                                Managermenu m = new Managermenu();
                                Mainclass.showWindow(m,MDI.ActiveForm);
                                
                            }
                            else if (role =="Seller")
                            {
                                Counter c = new Counter();
                                Mainclass.showWindow(c, MDI.ActiveForm);
                                
                            }
                            
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }
                else
                {
                    status = false;
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                
                con.Close();
            }
            return status;
        }
        public static void loaditems(string proc, ComboBox cb, string vMember, string dMember)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void loaditems(string proc, ComboBox cb,int a ,string vMember, string dMember)
        
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", a);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;
                con.Close ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void getcategory(DataGridView gv, DataGridViewColumn IDGV, DataGridViewColumn NameGV, DataGridViewColumn ID, DataGridViewColumn NAME)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("st_getCategories", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", 1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                IDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["NAME"].ToString();
                ID.DataPropertyName = dt.Columns["COMPANY ID"].ToString();
                NAME.DataPropertyName = dt.Columns["COMPANY NAME"].ToString();
                gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public static void getproduct(DataGridView gv, DataGridViewColumn ID, DataGridViewColumn name, DataGridViewColumn cnic, DataGridViewColumn salary, DataGridViewColumn b_id, DataGridViewColumn branch, DataGridViewColumn r_id, DataGridViewColumn role, DataGridViewColumn u_name)
        {
            try
            {
                int cmp = 1;
                con.Open();
                SqlCommand cmd = new SqlCommand("st_getproduct", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cmp);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ID.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["NAME"].ToString();
                cnic.DataPropertyName = dt.Columns["C_ID"].ToString();
                salary.DataPropertyName = dt.Columns["C_NAME"].ToString();
                b_id.DataPropertyName = dt.Columns["AMOUNT"].ToString();
                branch.DataPropertyName = dt.Columns["DISCOUNT"].ToString();
                r_id.DataPropertyName = dt.Columns["A_DISCOUNT"].ToString();
                role.DataPropertyName = dt.Columns["CMP_ID"].ToString();
                u_name.DataPropertyName = dt.Columns["CMP_NAME"].ToString();
                gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public static void getitems(int billno,DataGridView gv, DataGridViewColumn id, DataGridViewColumn p_id, DataGridViewColumn product, DataGridViewColumn price, DataGridViewColumn discount, DataGridViewColumn a_amount, DataGridViewColumn qty, DataGridViewColumn total)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("st_getitems", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@billno", billno);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                id.DataPropertyName = dt.Columns["id"].ToString();
                p_id.DataPropertyName = dt.Columns["p_id"].ToString();
                product.DataPropertyName = dt.Columns["Product"].ToString();
                price.DataPropertyName = dt.Columns["Price"].ToString();
                discount.DataPropertyName = dt.Columns["discount"].ToString();
                a_amount.DataPropertyName = dt.Columns["after amount"].ToString();
                qty.DataPropertyName = dt.Columns["qty"].ToString();
                total.DataPropertyName = dt.Columns["total"].ToString();
                gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) 
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error");
                
            }
            
        }
        public static int cusid;
        public static string cusname;
        public static bool cus(string number)
        {
            bool status = false;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getcusWRTphone", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@phone", number);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (number == reader["phone"].ToString())
                        {

                            cusid = Convert.ToInt32(reader["id"].ToString());
                            cusname = reader["name"].ToString();
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                    }
                }
                else
                {
                    status = false;
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                con.Close();
            }
            return status;
        }


    }

}
