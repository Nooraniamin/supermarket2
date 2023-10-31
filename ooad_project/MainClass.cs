using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace ooad_project
{
    internal class MainClass
    {
        private static string path;
        private static string connection()
        {
            StreamReader re = new StreamReader("C:\\Users\\aminm\\OneDrive\\Documents\\supermarket.txt");
            while (!re.EndOfStream)
            {
                path = re.ReadLine();
            }
            re.Close();
            return path;
        }
        public static SqlConnection con = new SqlConnection(path);
        public static void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void showWindow(Form openWin, Form MDI)
        {
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void insert(string name, string password)
        {
            try 
            {
                SqlCommand cmd = new SqlCommand("st_insert", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                if (res > 0)
                {
                    MessageBox.Show("item" + "add successfully into the system", "success");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void delete(int id) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_delete", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                if (res > 0)
                {
                    MessageBox.Show("item" + "add successfully into the system", "success");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void update(int id, string name, string key)
        {
            try 
            {
                SqlCommand cmd = new SqlCommand("st_insert", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", key);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                if (res > 0)
                {
                    MessageBox.Show("item" + "add successfully into the system", "success");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public static void getdata(DataGridView gv,DataGridViewColumn id, DataGridViewColumn name, DataGridViewColumn key)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getdata", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                id.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["Name"].ToString();
                key.DataPropertyName = dt.Columns["Key"].ToString();
                gv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }

}
