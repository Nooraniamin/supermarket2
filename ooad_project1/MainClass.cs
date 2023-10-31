using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooad_project1
{
    internal class MainClass
    {
        private static string path = null;
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
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                if (res > 0)
                {
                    MessageBox.Show( "add successfully into the system");
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
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                if (res > 0)
                {
                    MessageBox.Show( "delete successfully into the system");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void update(int id, string name, string key)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", key);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                con.Close();
                if (res > 0)
                {
                    MessageBox.Show("update successfully into the system");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void getdata(DataGridView gv, DataGridViewColumn id, DataGridViewColumn name, DataGridViewColumn key)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getdata", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
